using Dou.Misc.Attr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace iHub.Models.ERP
{
    /// <summary>
    /// 加班申請單表身
    /// </summary>
    [Table("hrmOTApplyTime")]
    public class hrmOTApplyTime
    {
        [Key]
        [Display(Name = "單據編號")]
        [ColumnDef(Visible = false)]
        [Column(Order = 1)]
        public string BillNo { get; set; }

        [Key]
        [Display(Name = "標識號")]
        [ColumnDef(Visible = false)]
        [Column(Order = 2)]
        public int RowCode { get; set; }

        [Display(Name = "加班開始日期")]
        [ColumnDef(Visible = false)]
        public int BeginDate { get; set; }
    }
}