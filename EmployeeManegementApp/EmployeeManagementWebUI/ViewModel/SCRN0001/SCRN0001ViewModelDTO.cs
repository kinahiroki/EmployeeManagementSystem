using EmployeeManagementWebUI.Common.Dto;
using System;
using System.Collections.Generic;

namespace EmployeeManagementWebUI.ViewModel.SCRN0001
{
    /// <summary>
    /// 社員管理メニュー用ViewModelDTO
    /// </summary>
    /// <remarks>
    /// 社員管理メニュー画面で表示する各項目の値を保持するDTO
    /// </remarks>
    public class SCRN0001ViewModelDTO
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// 各プロパティの初期値を設定する。
        /// </remarks>
        public SCRN0001ViewModelDTO()
        {
            ErrorMessageList = new List<DisplayMessageDTO>();
            EmployeeID = string.Empty;
        }

        /// <summary>エラーメッセージリストの取得と設定</summary>
        /// <remarks>エラーメッセージリストの取得と設定</remarks>
        /// <value>エラーメッセージリスト</value>
        public IList<DisplayMessageDTO> ErrorMessageList { get; set; }

        /// <summary>社員IDの取得と設定</summary>
        /// <remarks>社員IDの取得と設定</remarks>
        /// <value>社員ID</value>
        public string EmployeeID { get; set; }
    }
}
