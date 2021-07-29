using EmployeeManagementWebUI.ViewModel.SCRN0002;

namespace EmployeeManagementWebUI.Helper
{
    /// <summary>
    /// 社員登録画面ヘルパー　インターフェース
    /// </summary>
    /// <remarks>
    /// 社員登録画面ヘルパー　インターフェース
    /// </remarks>
    public interface IEV0002Helper
    {
        /// <summary>
        /// 社員管理登録画面　初期表示処理
        /// </summary>
        /// <remarks>
        /// 社員管理登録画面の初期表示時に必要な情報の取得を行う。
        /// </remarks>
        /// <returns>表示情報</returns>
        public SCRN0002ViewModelDTO Init();
    }
}
