﻿using Dou.Misc.Attr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iHub.Models
{
    /// <summary>
    /// 單據審批資訊
    /// </summary>
    [Table("wfBill")]
    public class wfBill
    {
        [Key]
        [Display(Name = "事務編號")]
        [ColumnDef(Visible = false)]
        public long TransactionId { get; set; }

        [Required]
        [Display(Name = "單據類型")]
        [ColumnDef(EditType = EditType.Select, SelectItemsClassNamespace = iHub.Models.capCommBillTypeSelectItems.AssemblyQualifiedName)]
        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string TypeId { get; set; }

        [Required]
        [Display(Name = "流程狀態")]
        public int BillState { get; set; }
        
        [Required]
        [Display(Name = "最後辦理時間")]
        public long UpdateTime { get; set; }
    }
}