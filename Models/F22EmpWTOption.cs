using Dou.Misc.Attr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace iHub.Models
{
    /// <summary>
    /// 員工─班表&差勤選擇記錄表
    /// </summary>
    [Table("F22EmpWTOption")]
    public class F22EmpWTOption
    {
        [Key]
        [Display(Name = "員工編號")]
        [Column(Order = 0, TypeName = "varchar")]
        [ColumnDef(Display = "員工編號", EditType = EditType.TextList, SelectItemsClassNamespace = "FtisHelperV2.DB.FnoSelectItemsClassImp, FtisHelperV2", Filter = true, FilterAssign = FilterAssignType.Contains, Sortable = true)]
        [StringLength(6)]
        public virtual string Fno { get; set; }

        [Key]
        [Display(Name = "差勤年份")]
        [Column(Order = 1)]
        [ColumnDef(Filter = true)]
        public virtual int Wyear { get; set; }

        [Key]
        [Display(Name = "工作季別")]
        [ColumnDef(Filter = true)]
        [Column(Order = 2)]
        public virtual System.Byte Qno { get; set; }

        [Key]
        [Display(Name = "班表選次")]
        [ColumnDef(VisibleEdit = true, EditType = EditType.Select, SelectItemsClassNamespace = iHub.Models.F22EmpWTOptionSelectItemsSelectNo.AssemblyQualifiedName)]
        [Column(Order = 3)]
        public virtual System.Byte SelectNo { get; set; }

        [Display(Name = "所選班表代號")]
        [ColumnDef(VisibleEdit = true, EditType = EditType.Select, SelectItemsClassNamespace = iHub.Models.F22EmpWTOptionSelectItemsClassID.AssemblyQualifiedName)]
        [Required]
        public virtual System.Byte ClassID { get; set; }

        [Display(Name = "所選出勤時段代號")]
        [ColumnDef(VisibleEdit = true, EditType = EditType.Select, SelectItemsClassNamespace = iHub.Models.F22EmpWTOptionSelectItemsWTID.AssemblyQualifiedName)]
        [Required]
        public virtual System.Byte WTID { get; set; }
        [Required]

        [Display(Name = "所選該次班表起始日")]
        [Column(TypeName = "date")]
        [ColumnDef(EditType = EditType.Date)]
        public virtual DateTime Cstartdate { get; set; }

        [Display(Name = "所選該次班表結束日")]
        [Column(TypeName = "date")]
        [ColumnDef(EditType = EditType.Date)]
        public virtual DateTime Cenddate { get; set; }

        [Display(Name = "異動時間")]
        [ColumnDef(VisibleEdit = false)]
        public virtual DateTime UpdateTime { get; set; }

        [Display(Name = "備註說明")]
        [Column(TypeName = "nvarchar")]
        [ColumnDef(EditType = EditType.TextArea)]
        [StringLength(500)]
        public virtual string Remark { get; set; }
    }

    public class F22EmpWTOptionSelectItemsSelectNo : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "iHub.Models.F22EmpWTOptionSelectItemsSelectNo, iHub";

        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return iHub.Code.GetSelectNo();
        }
    }

    public class F22EmpWTOptionSelectItemsClassID : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "iHub.Models.F22EmpWTOptionSelectItemsClassID, iHub";

        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return iHub.Code.GetClassID();
        }
    }

    public class F22EmpWTOptionSelectItemsWTID : SelectItemsClass
    {
        public const string AssemblyQualifiedName = "iHub.Models.F22EmpWTOptionSelectItemsWTID, iHub";

        public override IEnumerable<KeyValuePair<string, object>> GetSelectItems()
        {
            return iHub.Code.GetWTID();
        }
    }
}