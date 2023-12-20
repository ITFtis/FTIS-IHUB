using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace iHub.Models
{
    /// <summary>
    /// 跑馬燈
    /// </summary>
    [Table("cmmMrq")]
    public class cmmMrq
    {
        [Key]        
        [StringLength(1)]
        public string mrqno { get; set; }

        [StringLength(1)]
        public string mrquse { get; set; }

        [Display(Name = "色碼")]
        [StringLength(6)]
        public string mrqcolor { get; set; }

        [Display(Name = "內容")]
        [StringLength(100)]
        public string mrqtxt { get; set; }
    }
}