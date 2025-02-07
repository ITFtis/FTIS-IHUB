using Dou.Misc.Attr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHub.Models
{
	[Table("POST")]
	public partial class POST
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[ColumnDef(Visible = false, VisibleView =false)]
		public int PostId { get; set; }

		[StringLength(255)]
		[ColumnDef(Display = "新聞名稱", Filter = true, FilterAssign = FilterAssignType.Contains, Index = 2)]
		public string Title { get; set; }

		[StringLength(255)]
		[ColumnDef(Visible = false, VisibleView = false)]
		public string Summary { get; set; }

		[ColumnDef(Display = "新聞內容",Visible = false)]
		public string HtmlContent { get; set; }

		[StringLength(255)]
		[ColumnDef(Visible = false, VisibleView = false)]
		public string KeyWord { get; set; }

		[ColumnDef(Visible = false, VisibleView = false)]
		public int? NodeId { get; set; }

		[ColumnDef(Visible = false, VisibleView = false)]
		public int? SortNo { get; set; }

		[ColumnDef(Visible = false, VisibleView = false)]
		public int? Flag { get; set; }

		[StringLength(255)]
		[ColumnDef(Visible = false, VisibleView = false)]
		public string PicFileName { get; set; }

		[StringLength(255)]
		[ColumnDef(Visible = false, VisibleView = false)]
		public string DocFileName { get; set; }

		[StringLength(255)]
		[ColumnDef(Visible = false, VisibleView = false)]
		public string StoreName { get; set; }

		[StringLength(255)]
		[ColumnDef(Visible = false, VisibleView = false)]
		public string Phone { get; set; }

		[StringLength(255)]
		[ColumnDef(Visible = false, VisibleView = false)]
		public string Fax { get; set; }

		[StringLength(255)]
		[ColumnDef(Visible = false, VisibleView = false)]
		public string Address { get; set; }

		[StringLength(255)]
		[ColumnDef(Visible = false, VisibleView = false)]
		public string GoogleMap { get; set; }

		[StringLength(255)]
		[ColumnDef(Visible = false, VisibleView = false)]
		public string CreatedBy { get; set; }

		[StringLength(255)]
		[ColumnDef(Visible = false, VisibleView = false)]
		public string UpdatedBy { get; set; }

		[ColumnDef(Visible = false, VisibleView = false)]
		public DateTime? UpdatedDate { get; set; }

		[ColumnDef(Visible = false, VisibleView = false)]
		public DateTime? CreatedDate { get; set; }

		[ColumnDef(Display = "日期",Visible = false, VisibleView = false)]
		public DateTime? ShowDate { get; set; }

		[ColumnDef(Display = "日期", Index = 1)]
		public string Date
		{
			get
			{
				return ShowDate != null ? ShowDate.Value.ToString("yyyy/MM/dd") : "";
			}
		}

		[ColumnDef(Visible = false, VisibleView = false)]
		public int? Type { get; set; }

		[StringLength(255)]
		[ColumnDef(Display ="相關連結",Visible = false)]
		public string LinkUrl { get; set; }

		[ColumnDef(Visible = false, VisibleView = false)]
		public string HtmlContent2 { get; set; }

		[ColumnDef(Visible = false, VisibleView = false)]
		public string HtmlContent3 { get; set; }

		[ColumnDef(Visible = false, VisibleView = false)]
		public string HtmlContent4 { get; set; }

		[Required]
		[Display(Name = "不顯示iHub")]        
        [ColumnDef(Visible = false, VisibleEdit = false,
			EditType = EditType.Radio,
            SelectItemsClassNamespace = iHub.GetYNSelectItems.AssemblyQualifiedName)]
        public string IsClosedIHub { get; set; }
    }

	/// <summary>
	/// (官網轉入暫存表)會內公告
	/// </summary>
    [Table("tmp_POST")]
    public partial class tmp_POST
    {
        [Key]
        public int PostId { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string HtmlContent { get; set; }

        public string KeyWord { get; set; }

        public int? NodeId { get; set; }

        public int? SortNo { get; set; }

        public int? Flag { get; set; }

        public string PicFileName { get; set; }

        public string DocFileName { get; set; }

        public string StoreName { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Address { get; set; }

        public string GoogleMap { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ShowDate { get; set; }

        public int? Type { get; set; }

        public string LinkUrl { get; set; }

        public string HtmlContent2 { get; set; }

        public string HtmlContent3 { get; set; }

        public string HtmlContent4 { get; set; }
    }
}
