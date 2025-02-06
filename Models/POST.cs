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
	}
}
