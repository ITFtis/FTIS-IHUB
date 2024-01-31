using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iHub
{
    public class MisClass
    {
    }

    public class MisPjClass
    {
        /// <summary>
        /// 部門簡稱
        /// </summary>
        public string dname { get; set; }

        /// <summary>
        /// 計畫名稱
        /// </summary>
        public string pjds1 { get; set; }

        /// <summary>
        /// 工作項目(主項)
        /// </summary>
        public string pjds2 { get; set; }

        /// <summary>
        /// 工作項目(細項)
        /// </summary>
        public string pjds2b { get; set; }

        /// <summary>
        /// 合約規範日期
        /// </summary>
        public string date3 { get; set; }

        /// <summary>
        /// 合約規範日期 與當日差異天數
        /// </summary>
        public int? date3_diffday { get; set; }

        /// <summary>
        /// 完成與否
        /// </summary>
        public string fnh { get; set; }

        /// <summary>
        /// 結案與否
        /// </summary>
        public string cls { get; set; }

        /// <summary>
        /// 部門代碼
        /// </summary>
        public string dcode { get; set; }

        /// <summary>
        /// 預定完成日
        /// </summary>
        public string date4 { get; set; }

        /// <summary>
        /// 預定完成日 與當日差異天數
        /// </summary>
        public int? date4_diffday { get; set; }

        /// <summary>
        /// 員編
        /// </summary>
        public string mno { get; set; }

        /// <summary>
        /// 員工姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 員工Email
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 通知狀態 代碼
        /// </summary>
        public string alertState { get; set; }

        /// <summary>
        /// 通知狀態 名稱
        /// </summary>
        public string alertStateName { get; set; }
    }

    //public class MisPjGroupClass
    //{
    //    /// <summary>
    //    /// 部門簡稱
    //    /// </summary>
    //    public string dname { get; set; }

    //    /// <summary>
    //    /// 員編
    //    /// </summary>
    //    public string mno { get; set; }

    //    /// <summary>
    //    /// 員工姓名
    //    /// </summary>
    //    public string name { get; set; }

    //    /// <summary>
    //    /// 員工Email
    //    /// </summary>
    //    public string email { get; set; }

    //    /// <summary>
    //    /// 計畫名稱
    //    /// </summary>
    //    public string pjds1 { get; set; }

    //    /// <summary>
    //    /// 工作項目(主項)
    //    /// </summary>
    //    public string pjds2 { get; set; }

    //    /// <summary>
    //    /// 合約規範日期
    //    /// </summary>
    //    public string date3 { get; set; }

    //    /// <summary>
    //    /// 結案與否
    //    /// </summary>
    //    public string cls { get; set; }

    //    /// <summary>
    //    /// 數量
    //    /// </summary>
    //    public int Counts { get; set; }
    //}
}