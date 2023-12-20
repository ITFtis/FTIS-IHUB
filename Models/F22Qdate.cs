using Dou.Misc.Attr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace iHub.Models
{
    /// <summary>
    /// 年度季別區間表
    /// </summary>
    [Table("F22Qdate")]
    public class F22Qdate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnDef(Visible = false)]
        public virtual int Id { get; set; }

        [Display(Name = "差勤年份")]
        [Required]
        public virtual int Wyear { get; set; }

        [Display(Name = "季別")]
        [Required]
        public virtual System.Byte Qno { get; set; }

        [Display(Name = "該季起始日期")]
        [Required]
        [Column(TypeName = "date")]
        [ColumnDef(EditType = EditType.Date)]
        public virtual DateTime Startdate { get; set; }

        [Display(Name = "該季結束日期")]
        [Required]
        [Column(TypeName = "date")]
        [ColumnDef(EditType = EditType.Date)]
        public virtual DateTime Enddate { get; set; }

        [Display(Name = "是否已匯入")]
        [ColumnDef(Visible = false, VisibleEdit = false)]
        public virtual bool IsImport { get; set; }
    }

    public class F22QdateFun
    {
        /// <summary>
        /// 是否挑選員工班表
        /// </summary>
        /// <param name="Fno"></param>
        /// <returns></returns>
        public static bool IsEmpWTOption(string Fno)
        {
            bool result = false;

            try
            {
                SysParam ps = GetEmpWTOption();

                if (ps.IsBlock == "Y")
                {
                    //////判斷員工是否已新增班表
                    System.Data.Entity.DbContext dbContext = new T8ModelContext();
                    Dou.Models.DB.IModelEntity<F22EmpWTOption> wt = new Dou.Models.DB.ModelEntity<F22EmpWTOption>(dbContext);

                    var u = wt.Get(a => a.Fno == Fno && a.Wyear == ps.Wyear && a.Qno == ps.Qno);
                    if (u == null)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            return result;
        }

        /// <summary>
        /// 是否挑選員工班表
        /// </summary>
        /// <param name="Fno"></param>
        /// <returns></returns>
        public static SysParam GetEmpWTOption()
        {
            SysParam result = null;

            try
            {
                XDocument doc = XDocument.Load(System.Web.Hosting.HostingEnvironment.MapPath("~/Config/SysParam.xml"));

                ArrayOfSysParam pss = iHub.XmlHelper.Deserialize<ArrayOfSysParam>(doc);
                result = pss.SysParam.Where(a => a.Key == "EmpWTOption").First();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            return result;
        }
    }

    /// <summary>
    /// 年度：已執行匯入班表範例
    /// </summary>
    public class F22QdateSelectItemsWyearImport : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "iHub.Models.F22QdateSelectItemsWyearImport, iHub";

        static IEnumerable<F22Qdate> _qdates;
        static IEnumerable<F22Qdate> Qdates
        {
            get
            {
                if (_qdates == null || _qdates.Count() == 0)
                {
                    using (var db = new iHub.Models.T8ModelContext())
                    {
                        _qdates = db.F22Qdate.Where(a => a.IsImport).ToArray();
                    }
                }
                return _qdates;
            }
        }


        public static void Reset()
        {
            _qdates = null;
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return Qdates.Select(s => new KeyValuePair<string, object>(s.Wyear + "", s.Wyear));
        }
    }

    /// <summary>
    /// 季別：已執行匯入班表範例
    /// </summary>
    public class F22QdateSelectItemsQnoImport : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "iHub.Models.F22QdateSelectItemsQnoImport, iHub";

        static IEnumerable<F22Qdate> _qdates;
        static IEnumerable<F22Qdate> Qdates
        {
            get
            {
                if (_qdates == null || _qdates.Count() == 0)
                {
                    using (var db = new iHub.Models.T8ModelContext())
                    {
                        _qdates = db.F22Qdate.Where(a => a.IsImport).ToArray();
                    }
                }
                return _qdates;
            }
        }


        public static void Reset()
        {
            _qdates = null;
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            //return Qdates.Select(s => new KeyValuePair<string, object>(s.Qno + "", s.Qno));

            //(連動下拉)不同年度，有相同季別(2023,1)(2022,1)，故value要唯一key值(年度_季別)
            return Qdates.Select(s => new KeyValuePair<string, object>(s.Wyear.ToString() + "_" + s.Qno.ToString(), "{\"v\":\"" + s.Qno.ToString() + "\",\"Wyear\":\"" + s.Wyear + "\"}"));
        }
    }
}