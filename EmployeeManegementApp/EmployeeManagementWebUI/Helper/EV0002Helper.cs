﻿using EmployeeManagementWebUI.BusinessLogic;
using EmployeeManagementWebUI.Common.Dto;
using EmployeeManagementWebUI.Common.Session;
using EmployeeManagementWebUI.Common.Validate;
using EmployeeManagementWebUI.DataAccess;
using EmployeeManagementWebUI.ViewModel.SCRN0002;
using Microsoft.AspNetCore.Http;
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
        #region === フィールド ===

        /// <summary>所属管理Logic</summary>
        /// <remarks>所属管理Logic</remarks>
        private readonly IEV8002Logic _affiliationLogic = null;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// コンストラクタ
        /// </remarks>
        /// <param name="affiliationLogic"></param>
        public EV0002Helper(IEV8002Logic affiliationLogic)
        {
            _affiliationLogic = affiliationLogic;
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

            // 所属管理データの取得
            //var affiliationList = _affiliationLogic.FindAllForAffiliation();

            // 所属部署プルダウンリスト作成
            //viewModelDto.DepartmentPullDownList = affiliationList.Select(x =>
            //    new PulldownListForItemDTO()
            //    {
            //        ItemNameForDisplay = x.AffiliationNm,
            //        ItemValue = x.AffiliationCD,
            //    })
            //    .ToList();

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
            return new SCRN0002ViewModelDTO();
        }
    }
}
