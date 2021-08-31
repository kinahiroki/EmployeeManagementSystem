using EmployeeManagementWebUI.Common.Dto;
using EmployeeManagementWebUI.Common.Validate;
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
            viewModelDto.DepartmentPullDownList = new List<PulldownListForItemDTO>()
            {
                new PulldownListForItemDTO(){ ItemNameForDisplay = "総務", ItemValue = "01" },
                new PulldownListForItemDTO(){ ItemNameForDisplay = "人事", ItemValue = "02" },
            };

            // TODO 役職プルダウンリスト作成

            // TODO 性別ラジオボタン作成

            return viewModelDto;
        }

        /// <summary>
        /// 社員管理登録画面　登録処理
        /// </summary>
        /// <remarks>
        /// 画面で入力された社員データの登録前処理を行う。
        /// </remarks>
        /// <param name="request">画面入力値</param>
        /// <returns>処理結果</returns>
        public SCRN0002ViewModelDTO Entry(SCRN0002Request request)
        {
            (var checkResult, var errorMessageList) = IsInputValueCheck(request);
            if (!checkResult)
            {
                return new SCRN0002ViewModelDTO()
                {
                    ErrorMessageList = errorMessageList,
                };
            }

            return new SCRN0002ViewModelDTO();
        }

        private (bool, List<DisplayMessageDTO>) IsInputValueCheck(SCRN0002Request request)
        {
            var checkResult = true;
            var errorMessageList = new List<DisplayMessageDTO>();

            // 社員IDの入力値チェック
            if (!ValidateUtility.IsRequiredCheck(request.EmployeeID))
            {
                checkResult = false;
                errorMessageList.Add(
                    new DisplayMessageDTO()
                    {
                        MessageID = "ERR001",
                        DisplayForMessage = "必須",
                    });
            }

            return (checkResult, errorMessageList);
        }

    }
}
