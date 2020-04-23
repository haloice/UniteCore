using System;
using System.Collections.Generic;

namespace UniteCore
{
    /// <summary>
    /// 中心的なファンクション
    /// </summary>
    public static class Uni
    {
        #region "Range"
        /// <summary>
        /// １...[引数:intEnd]間の整数Listを返す
        /// foreach分で任意回数繰り返し処理を実施できる
        /// （PythonのRange関数よりインスパイア）
        /// </summary>
        /// <param name="intEnd"></param>
        /// <returns></returns>
        public static List<int> Range(int intEnd)
        {
            var intsRtn = new List<int>();

            for (int i = 1; i < intEnd + 1; i++)
                intsRtn.Add(i);

            return intsRtn;
        }

        /// <summary>
        /// 上記メソッド＋開始値を設定可能
        /// </summary>
        /// <param name="intStart"></param>
        /// <param name="intEnd"></param>
        /// <returns></returns>
        public static List<int> Range(int intStart, int intEnd)
        {
            var intsRtn = new List<int>();

            for (int i = intStart; i < intEnd + 1; i++)
                intsRtn.Add(i);

            return intsRtn;
        }
        #endregion
    }
}
