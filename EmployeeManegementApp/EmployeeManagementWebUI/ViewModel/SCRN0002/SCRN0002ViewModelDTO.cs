using EmployeeManagementWebUI.Common.Dto;
using System.Collections.Generic;

namespace EmployeeManagementWebUI.ViewModel.SCRN0002
{
    /// <summary>
    /// 社員登録画面用ViewModelDTO
    /// </summary>
    /// <remarks>
    /// 社員登録画面で表示する各項目の値を保持するDTO
    /// </remarks>
    public class SCRN0002ViewModelDTO
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// 各プロパティの初期値を設定する。
        /// </remarks>
        public SCRN0002ViewModelDTO()
        {
            ErrorMessageList = new List<DisplayMessageDTO>();
            EmployeeID = string.Empty;
            DepartmentPullDownList = new List<PulldownListForItemDTO>();
            SelectedDepartmentCD = string.Empty;
            PositionPullDownList = new List<PulldownListForItemDTO>();
            SelectedPositionCD = string.Empty;
            EmployeeName = string.Empty;
            GenderRadioButtonItems = new List<RadioButtonForItemDTO>();
            SelectedGenderCD = string.Empty;
            IsForeignNationality = false;
            Birthday = string.Empty;
            BaseSalary = string.Empty;
            Memo = string.Empty;
        }

        /// <summary>エラーメッセージリストの取得と設定</summary>
        /// <remarks>エラーメッセージリストの取得と設定</remarks>
        /// <value>エラーメッセージリスト</value>
        public IList<DisplayMessageDTO> ErrorMessageList { get; set; }

        public string EmployeeID { get; set; }

        public IList<PulldownListForItemDTO> DepartmentPullDownList { get; set; }

        public string SelectedDepartmentCD { get; set; }

        public IList<PulldownListForItemDTO> PositionPullDownList { get; set; }

        public string SelectedPositionCD { get; set; }

        public string EmployeeName { get; set; }

        public IList<RadioButtonForItemDTO> GenderRadioButtonItems { get; set; }

        public string SelectedGenderCD { get; set; }

        public bool IsForeignNationality { get; set; }

        public string Birthday { get; set; }

        public string BaseSalary { get; set; }

        public string Memo { get; set; }
    }
}
