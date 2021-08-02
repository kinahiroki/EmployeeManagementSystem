using EmployeeManagementWebUI.Helper;
using EmployeeManagementWebUI.ViewModel.SCRN0001;

namespace EmployeeManagementWebUITest.ControllerTest.Mock
{
    /// <summary>
    /// EV0001Helper Mockクラス
    /// </summary>
    /// <remarks>
    /// EV0001Helper Mockクラス
    /// </remarks>
    class EV0001HelperMock : IEV0001Helper
    {
        /// <summary>テスト用ViewModel</summary>
        /// <remarks>テスト用ViewModel</remarks>
        public SCRN0001ViewModelDTO SCRN0001ViewModel { get; set; }

        /// <summary>
        /// 初期表示処理
        /// </summary>
        /// <remarks>
        /// テスト用のViewModelDTOを返す。
        /// </remarks>
        /// <returns>テスト用ViewModel</returns>
        public SCRN0001ViewModelDTO Init()
        {
            return SCRN0001ViewModel;
        }
    }
}
