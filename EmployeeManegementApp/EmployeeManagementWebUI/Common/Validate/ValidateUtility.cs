using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebUI.Common.Validate
{
    /// <summary>
    /// 検証共通クラス
    /// </summary>
    /// <remarks>
    /// 共通のチェック処理を定義するクラス
    /// </remarks>
    public class ValidateUtility
    {
        /// <summary>
        /// 必須チェック
        /// </summary>
        /// <remarks>
        /// 必須チェック
        /// </remarks>
        /// <param name="targetValue">チェック対象の値</param>
        /// <returns>チェック結果</returns>
        public static bool IsRequiredCheck(string targetValue)
        {
            return !string.IsNullOrEmpty(targetValue);
        }

        /// <summary>
        /// 数値チェック
        /// </summary>
        /// <remarks>
        /// 数値チェック
        /// </remarks>
        /// <param name="targetValue">チェック対象の値</param>
        /// <returns></returns>
        public static bool IsNumber(string targetValue)
        {
            return int.TryParse(targetValue, out _);
        }
    }
}
