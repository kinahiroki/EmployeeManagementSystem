using EmployeeManagementWebUI.ViewModel.SCRN0002;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebUI.Helper
{
    /// <summary>
    /// 社員登録画面ヘルパー　実装クラス
    /// </summary>
    /// <remarks>
    /// 社員登録画面ヘルパー　実装クラス
    /// </remarks>
    public class EV0002Helper : IEV0002Helper
    {
        public EV0002Helper()
        {
        }

        /// <summary>
        /// 社員管理登録画面　初期表示処理
        /// </summary>
        /// <remarks>
        /// 社員管理登録画面の初期表示時に必要な情報の取得を行う。
        /// </remarks>
        /// <returns>表示情報</returns>
        public SCRN0002ViewModelDTO Init()
        {
            var viewModelDto = new SCRN0002ViewModelDTO();
            
            // TODO 所属部署プルダウンリスト作成

            // TODO 役職プルダウンリスト作成

            // TODO 性別ラジオボタン作成

            return viewModelDto;
        }
    }
}
