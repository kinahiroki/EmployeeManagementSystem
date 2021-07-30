using EmployeeManagementWebUI.ViewModel.SCRN0001;

namespace EmployeeManagementWebUI.Helper
{
    /// <summary>
    /// メニュー画面ヘルパー　実装クラス
    /// </summary>
    /// <remarks>
    /// メニュー画面ヘルパー　実装クラス
    /// </remarks>
    public class EV0001Helper : IEV0001Helper
    {
        /// <summary>
        /// メニュー画面　初期表示処理
        /// </summary>
        /// <remarks>
        /// メニュー画面の初期表示時の処理を実施
        /// </remarks>
        /// <returns>表示情報</returns>
        public SCRN0001ViewModelDTO Init()
        {
            return new SCRN0001ViewModelDTO();
        }
    }
}
