using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iHub.Models
{
    /// <summary>
    /// 單據類型代碼
    /// </summary>
    [Table("capCommBillType")]
    public class capCommBillType
    {
        [Key]
        [Display(Name = "來源標籤")]
        [Column(Order = 1)]        
        public int SourceTag { get; set; }

        [Key]
        [Display(Name = "單據類型")]
        [Column(Order = 2, TypeName = "varchar")]
        [StringLength(15)]
        public string TypeId { get; set; }

        [Required]
        [Display(Name = "類型名稱")]
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string TypeName { get; set; }

        static object lockGetAllDatas = new object();
        public static IEnumerable<capCommBillType> GetAllDatas(int cachetimer = 0)
        {
            if (cachetimer == 0) cachetimer = Constant.cacheTime;

            string key = "iHub.Models.capCommBillType";
            var allData = DouHelper.Misc.GetCache<IEnumerable<capCommBillType>>(cachetimer, key);
            lock (lockGetAllDatas)
            {
                if (allData == null)
                {
                    Dou.Models.DB.IModelEntity<capCommBillType> modle = new Dou.Models.DB.ModelEntity<capCommBillType>(new T8ERPModelContext());
                    allData = modle.GetAll().ToArray();

                    DouHelper.Misc.AddCache(allData, key);
                }
            }

            return allData;
        }
    }

    public class capCommBillTypeSelectItems : Dou.Misc.Attr.SelectItemsClass
    {        
        public const string AssemblyQualifiedName = "iHub.Models.capCommBillTypeSelectItems, iHub";

        protected static IEnumerable<capCommBillType> _capCommBillTypes;
        internal static IEnumerable<capCommBillType> CapCommBillTypes
        {
            get
            {
                if (_capCommBillTypes == null)
                {
                    Dou.Models.DB.IModelEntity<capCommBillType> model = new Dou.Models.DB.ModelEntity<capCommBillType>(new iHubModelContextExt());
                    _capCommBillTypes = model.GetAll().ToArray();
                }
                return _capCommBillTypes;
            }
        }


        public static void Reset()
        {
            _capCommBillTypes = null;
        }
        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return CapCommBillTypes.Select(s => new KeyValuePair<string, object>(s.TypeId, s.TypeName));
        }
    }
}