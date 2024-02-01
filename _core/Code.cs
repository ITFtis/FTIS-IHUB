using iHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iHub
{
    /// <summary>
    /// 靜態代碼
    /// </summary>
    public class Code
    {
        /// <summary>
        /// 班表代號
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<string, object>> GetSelectNo()
        {
            IEnumerable<KeyValuePair<string, object>> result = new List<KeyValuePair<string, object>>();

            result = result.Append(new KeyValuePair<string, object>("1", "1"));
            result = result.Append(new KeyValuePair<string, object>("2", "2"));
            result = result.Append(new KeyValuePair<string, object>("3", "3"));
            result = result.Append(new KeyValuePair<string, object>("4", "4"));
            result = result.Append(new KeyValuePair<string, object>("5", "5"));
            result = result.Append(new KeyValuePair<string, object>("6", "6"));
            result = result.Append(new KeyValuePair<string, object>("7", "7"));
            result = result.Append(new KeyValuePair<string, object>("8", "8"));
            result = result.Append(new KeyValuePair<string, object>("9", "9"));

            return result;
        }

        /// <summary>
        /// 班表代號
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<string, object>> GetClassID()
        {
            IEnumerable<KeyValuePair<string, object>> result = new List<KeyValuePair<string, object>>();

            result = result.Append(new KeyValuePair<string, object>("1", "班表一"));
            result = result.Append(new KeyValuePair<string, object>("2", "班表二"));
            result = result.Append(new KeyValuePair<string, object>("3", "班表三"));
            result = result.Append(new KeyValuePair<string, object>("9", "特殊班表"));

            return result;
        }

        /// <summary>
        /// 出勤時段代號
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<string, object>> GetWTID()
        {
            IEnumerable<KeyValuePair<string, object>> result = new List<KeyValuePair<string, object>>();

            result = result.Append(new KeyValuePair<string, object>("1", "08:00"));
            result = result.Append(new KeyValuePair<string, object>("2", "08:30"));
            result = result.Append(new KeyValuePair<string, object>("3", "09:00"));

            return result;
        }

        #region  MisModelContext  員工管理系統

        /// <summary>
        /// 履約通知狀態
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<string, object>> GetAlertState()
        {
            IEnumerable<KeyValuePair<string, object>> result = new List<KeyValuePair<string, object>>();

            result = result.Append(new KeyValuePair<string, object>("0", "無"));
            result = result.Append(new KeyValuePair<string, object>("1", "通知"));
            result = result.Append(new KeyValuePair<string, object>("2", "鎖住"));

            return result;
        }

        /// <summary>
        /// (換算)履約通知狀態
        /// </summary>
        /// <param name="date4_diffday">預定完成日 與當日差異天數</param>
        /// <param name="date3_diffday">合約規範日期 與當日差異天數</param>
        /// <returns></returns>
        public static string ToAlertState(int date4_diffday, int date3_diffday)
        {
            int defDay1 = 15;   //預定完成日(date4) 15天內「通知」
            int defDay2 = 3;    //合約規範日期(date3) 3天內「鎖住」  

            string state = "0";
            if (date3_diffday <= defDay2)
            {
                state = "2";
            }
            else if (date4_diffday <= defDay1)
            {
                state = "1";
            }

            return state;
        }

        /// <summary>
        /// (舊)員工系統編號5碼
        /// </summary>
        /// <param name="mno"></param>
        /// <returns></returns>
        public static string ToMno5(string mno)
        {
            if (mno.Length < 6)
                return mno;

            return mno.Substring(1, 5);            
        }

        #endregion

        #region  T8ERP

        /// <summary>
        /// 單據審批資訊 流程狀態
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<string, object>> GetBillState()
        {
            IEnumerable<KeyValuePair<string, object>> result = new List<KeyValuePair<string, object>>();

            result = result.Append(new KeyValuePair<string, object>("0", "無"));
            result = result.Append(new KeyValuePair<string, object>("1", "未送審"));
            result = result.Append(new KeyValuePair<string, object>("2", "審批中"));
            result = result.Append(new KeyValuePair<string, object>("3", "已審批"));
            result = result.Append(new KeyValuePair<string, object>("4", "被否決"));
            result = result.Append(new KeyValuePair<string, object>("5", "申請撤回中"));

            return result;
        }

        /// <summary>
        /// 單據審批環節資訊 環節類別
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<string, object>> GetBillActivityKind()
        {
            IEnumerable<KeyValuePair<string, object>> result = new List<KeyValuePair<string, object>>();
            
            result = result.Append(new KeyValuePair<string, object>("0", "副本"));
            result = result.Append(new KeyValuePair<string, object>("1", "審批"));
            result = result.Append(new KeyValuePair<string, object>("2", "委託審批"));
            result = result.Append(new KeyValuePair<string, object>("3", "委託提供意見"));
            result = result.Append(new KeyValuePair<string, object>("13", "加簽審批"));
            result = result.Append(new KeyValuePair<string, object>("14", "加簽副本"));
            result = result.Append(new KeyValuePair<string, object>("4", "判斷"));
            result = result.Append(new KeyValuePair<string, object>("5", "分支開始"));
            result = result.Append(new KeyValuePair<string, object>("10", "分支"));
            result = result.Append(new KeyValuePair<string, object>("6", "分支結束"));
            result = result.Append(new KeyValuePair<string, object>("7", "組織開始"));
            result = result.Append(new KeyValuePair<string, object>("8", "組織結束"));
            result = result.Append(new KeyValuePair<string, object>("11", "會簽開始"));
            result = result.Append(new KeyValuePair<string, object>("12", "會簽結束"));
            result = result.Append(new KeyValuePair<string, object>("9", "結束"));            

            return result;
        }

        /// <summary>
        /// 單據審批環節資訊 狀態值
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<string, object>> GetBillActivityState()
        {
            IEnumerable<KeyValuePair<string, object>> result = new List<KeyValuePair<string, object>>();            

            result = result.Append(new KeyValuePair<string, object>("3", "已簽核"));

            result = result.Append(new KeyValuePair<string, object>("0", "未處理"));
            result = result.Append(new KeyValuePair<string, object>("1", "已簽收"));
            result = result.Append(new KeyValuePair<string, object>("2", "已審批"));
            result = result.Append(new KeyValuePair<string, object>("4", "已退回"));
            result = result.Append(new KeyValuePair<string, object>("8", "已否決"));
            result = result.Append(new KeyValuePair<string, object>("16", "被退回"));
            result = result.Append(new KeyValuePair<string, object>("32", "被否決"));
            result = result.Append(new KeyValuePair<string, object>("64", "原單已異動"));
            result = result.Append(new KeyValuePair<string, object>("128", "被催辦"));
            result = result.Append(new KeyValuePair<string, object>("256", "委託審批"));
            result = result.Append(new KeyValuePair<string, object>("512", "委託提供意見"));            

            return result;
        }

        /// <summary>
        /// iHub 申請單轉換(OA加班單,LN請假單,MS調班單)
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<capCommBillType> GetIHubBillType()
        {
            List<capCommBillType> list = capCommBillType.GetAllDatas().ToList();

            list.Where(a => a.TypeId == "OA").FirstOrDefault().TypeName = "加班單";
            list.Where(a => a.TypeId == "LN").FirstOrDefault().TypeName = "請假單";
            list.Where(a => a.TypeId == "MS").FirstOrDefault().TypeName = "調班單";

            return list;
        }

        #endregion
    }
}