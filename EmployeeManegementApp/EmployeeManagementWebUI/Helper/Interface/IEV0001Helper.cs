using EmployeeManagementWebUI.ViewModel.SCRN0001;

namespace EmployeeManagementWebUI.Helper
{
    /// <summary>
    /// メニュー画面ヘルパー　インターフェース
    /// </summary>
    /// <remarks>
    /// メニュー画面ヘルパー　インターフェース
    /// </remarks>
    public interface IEV0001Helper
    {
        /// <summary>
        /// メニュー画面　初期表示処理
        /// </summary>
        /// <remarks>
        /// メニュー画面の初期表示時の処理を実施
        /// </remarks>
        /// <returns>表示情報</returns>
        SCRN0001ViewModelDTO Init();
    }
}
