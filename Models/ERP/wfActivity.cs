using Dou.Misc.Attr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Util;

namespace iHub.Models
{
    /// <summary>
    /// 單據審批環節資訊
    /// </summary>
    [Table("wfActivity")]
    public class wfActivity
    {
        [Key]
        [Display(Name = "事務編號")]
        [ColumnDef(Visible = false)]
        [Column(Order = 1)]
        public long TransactionId { get; set; }

        [Key]
        [Display(Name = "層級號")]
        [ColumnDef(Visible = false)]
        [Column(Order = 2)]
        public int LevelNO { get; set; }

        [Key]
        [Display(Name = "預計辦理人")]
        [ColumnDef(Visible = false)]
        [Column(Order = 3, TypeName = "varchar")]        
        [StringLength(20)]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "環節類別")]
        public int kind { get; set; }

        [Required]
        [Display(Name = "狀態值")]
        public int State { get; set; }
    }
}