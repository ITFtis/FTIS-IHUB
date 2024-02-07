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
    /// 超鏈接控管
    /// </summary>
    [Table("webUrlAccess")]
    public class webUrlAccess
    {
        [Key]
        [Display(Name = "編號")]        
        [Column(TypeName = "varchar")]
        [StringLength(40)]
        public string Id { get; set; }

        [Display(Name = "用戶編號")]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string UserId { get; set; }

        [Display(Name = "功能")]
        public int SourceTag { get; set; }

        [Display(Name = "主鍵")]
        [Column(TypeName = "nvarchar")]
        [StringLength(128)]
        public string PKValues { get; set; }
    }
}