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
    }
}