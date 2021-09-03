using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebUI.ViewModel.SCRN0002
{
    /// <summary>
    /// 社員登録画面用Request
    /// </summary>
    /// <remarks>
    /// 社員登録画面からの入力値を格納
    /// </remarks>
    public class SCRN0002Request
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// 各プロパティの初期値を設定する。
        /// </remarks>
        public SCRN0002Request()
        {
            EmployeeID = string.Empty;
            SelectedDepartmentCD = string.Empty;
            SelectedPositionCD = string.Empty;
            EmployeeName = string.Empty;
            SelectedGenderCD = string.Empty;
            IsForeignNationality = false;
            Birthday = string.Empty;
            BaseSalary = string.Empty;
            Memo = string.Empty;
        }

        [Required]
        public string EmployeeID { get; set; }

        public string SelectedDepartmentCD { get; set; }

        public string SelectedPositionCD { get; set; }

        public string EmployeeName { get; set; }

        public string SelectedGenderCD { get; set; }

        public bool IsForeignNationality { get; set; }

        public string Birthday { get; set; }

        public string BaseSalary { get; set; }

        public string Memo { get; set; }
    }
}
