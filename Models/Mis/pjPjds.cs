﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace iHub.Models.Mis
{
    /// <summary>
    /// 專案履約追蹤資料表
    /// </summary>
    [Table("pjPjds")]
    public class pjPjds
    {
        [Key]
        [Display(Name = "序號")]
        [Column(Order = 1)]
        public string sno { get; set; }

        [Key]
        [Display(Name = "序號2")]
        [Column(Order = 2)]
        public string sno2 { get; set; }

        [Display(Name = "部門簡稱")]
        public string dname { get; set; }

        [Display(Name = "計畫名稱")]
        public string pjds1 { get; set; }

        [Display(Name = "工作項目(主項)")]
        public string pjds2 { get; set; }

        [Display(Name = "工作項目(細項)")]
        public string pjds2b { get; set; }

        [Display(Name = "合約規範日期")]
        public string date3 { get; set; }

        [Display(Name = "部門代碼")]
        public string dcode { get; set; }

        [Display(Name = "預定完成日")]
        public string date4 { get; set; }

        [Display(Name = "完成與否")]
        public string fnh { get; set; }

        [Display(Name = "結案與否")]
        public string cls { get; set; }       
    }
}