using Dou.Misc.Attr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace iHub.Models.Mis
{
    /// <summary>
    /// 員工基本資料
    /// </summary>
    [Table("cmmEmp")]
    public class cmmEmp
    {
        [Key]
        [Display(Name = "員編")]
        public string mno { get; set; }

        [Display(Name = "姓名")]        
        public string name { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }
    }
}