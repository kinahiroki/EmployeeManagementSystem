using EmployeeManagementWebUI.Common.Dto;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementWebUI.Utility
{
    /// <summary>
    /// 画面用Utilityクラス
    /// </summary>
    /// <remarks>
    /// 画面表示の際に必要な書式変換、エラーメッセージの編集などの処理を格納する。
    /// </remarks>
    public class ScreenUtility
    {
        #region === 表示用メッセージ生成処理 ===

        /// <summary>
        /// 表示用エラーメッセージ生成
        /// </summary>
        /// <remarks>
        /// 表示用エラーメッセージ生成
        /// </remarks>
        /// <param name="modelStateDictionary">モデルステータス</param>
        /// <returns>生成した表示用エラーメッセージ</returns>
        public static IEnumerable<DisplayMessageDTO> CreateErrorMessageForDisplay(ModelStateDictionary modelStateDictionary)
        {
            return modelStateDictionary.Values
                .SelectMany(validInfo => validInfo.Errors
                .Select(errInfo => new DisplayMessageDTO()
                {
                    DisplayForMessage = errInfo.ErrorMessage,
                }))
                .ToList();
        }

        #endregion
    }
}
