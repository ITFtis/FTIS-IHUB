using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace iHub.Models.Mis
{
    /// <summary>
    /// 部門
    /// </summary>
    [Table("cmmDep")]
    public class cmmDep
    {
        [Key]
        [Display(Name = "部門代碼")]
        public string dcode { get; set; }

        [Display(Name = "員編")]
        public string dckno { get; set; }          
    }
}