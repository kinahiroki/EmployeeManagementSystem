using EmployeeManagementWebUI.Common.Dto;
using EmployeeManagementWebUI.Controllers.SCRN0001;
using EmployeeManagementWebUI.ViewModel.SCRN0001;
using EmployeeManagementWebUITest.ControllerTest.Mock;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementWebUITest.ControllerTest
{
    /// <summary>
    /// 社員管理システムメニュー　コントローラーテスト
    /// </summary>
    /// <remarks>
    /// 社員管理システムメニュー　コントローラーテスト
    /// </remarks>
    [TestFixture]
    public class SCRN0001ControllerTest
    {
        /// <summary>
        /// 初期表示　正常テスト
        /// </summary>
        /// <remarks>
        /// 初期表示処理時のテストを実施
        /// </remarks>
        [Test]
        public void IndexNormalTest()
        {
            // Arrange
            // テスト対象の呼び出しに必要な処理を実施
            var mockHelper = new EV0001HelperMock
            {
                SCRN0001ViewModel = new SCRN0001ViewModelDTO()
                {
                    EmployeeID = string.Empty,
                    ErrorMessageList = new List<DisplayMessageDTO>(),
                }
            };

            // Act
            // テスト対象の呼出
            var target = new SCRN0001Controller(mockHelper);
            var actualResult = target.Index();

            // Assert
            // テスト結果の検証
            // Controllerクラスの「return View()」に設定されている値を確認する。

            // ViewModelDTOの検証
            var actualResultViewModel = (ViewResult)actualResult;

            // (1) ViewModelDTOの型が期待通りの型か？
            Assert.IsAssignableFrom<SCRN0001ViewModelDTO>(actualResultViewModel.ViewData.Model);

            // (2) ViewNameが設定されていないか？（デフォルトのままか）
            Assert.AreEqual(null, actualResultViewModel.ViewName);

            // (3) ViewModelの各項目の値が期待値通りか？
            var actualResultModel = (SCRN0001ViewModelDTO)actualResultViewModel.ViewData.Model;
            Assert.AreEqual(string.Empty, actualResultModel.EmployeeID);
            CollectionAssert.IsEmpty(actualResultModel.ErrorMessageList);
        }
    }
}
