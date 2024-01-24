using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iHub
{
    public class ERPClass
    {
    }

    public class ErpCheckClass
    {
        /// <summary>
        /// 事務編號
        /// </summary>
        public long TransactionId { get; set; }

        /// <summary>
        /// 層級號
        /// </summary>
        public int LevelNO { get; set; }

        /// <summary>
        /// 預計辦理人
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 環節類別
        /// </summary>
        public int kind { get; set; }

        /// <summary>
        /// 狀態值
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 單據類型
        /// </summary>
        public string TypeId { get; set; }

        /// <summary>
        /// 流程狀態
        /// </summary>
        public int BillState { get; set; }

        /// <summary>
        /// 最後辦理時間
        /// </summary>
        public long UpdateTime { get; set; }

        /// <summary>
        /// 人員姓名
        /// </summary>
        public string PersonName { get; set; }

        /// <summary>
        /// EMail
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// 單據類型名稱
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 送審人姓名
        /// </summary>
        public string MakerName { get; set; }

        /// <summary>
        /// 送審時間
        /// </summary>
        public long MakeTime { get; set; }
    }

    public class ErpCheckGroupClass
    {
        /// <summary>
        /// 預計辦理人
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 人員姓名
        /// </summary>
        public string PersonName { get; set; }

        /// <summary>
        /// EMail
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// 單據類型
        /// </summary>
        public string TypeId { get; set; }

        /// <summary>
        /// 單據類型名稱
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 數量
        /// </summary>
        public int Counts { get; set; }
    }
}