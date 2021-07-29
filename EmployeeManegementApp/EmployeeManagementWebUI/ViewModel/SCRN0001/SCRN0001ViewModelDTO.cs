using EmployeeManagementWebUI.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        /// <summary>エラーメッセージリスト</summary>
        /// <remarks>エラーメッセージリスト</remarks>
        /// <value>エラーメッセージリスト</value>
        public IList<DisplayMessage> ErrorMessageList { get; set; }

        /// <summary>社員ID</summary>
        /// <remarks>社員ID</remarks>
        /// <value>社員ID</value>
        public string EmployeeID { get; set; }
    }
}
