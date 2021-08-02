using EmployeeManagementWebUI.Helper;
using NUnit.Framework;

namespace EmployeeManagementWebUITest.HelperTest
{
    /// <summary>
    /// メニュー画面ヘルパーテストクラス
    /// </summary>
    /// <remarks>
    /// メニュー画面ヘルパーテストクラス
    /// </remarks>
    [TestFixture]
    public class EV0001HelperTest
    {
        /// <summary>
        /// 初期表示処理　正常テスト
        /// </summary>
        /// <remarks>
        /// 初期表示時の正常時テストを行う。
        /// 実施結果が以下の通りになることを検証する。
        /// ①ViewModelDTOの各項目が初期値で格納されていること
        /// 　社員ID                ：空文字
        /// 　エラーメッセージリスト：0件
        /// </remarks>
        [Test]
        public void InitNormalTest()
        {
            // Arrange
            // なし

            // Act
            var target = new EV0001Helper();
            var actualResult = target.Init();

            // Assert
            Assert.AreEqual(string.Empty, actualResult.EmployeeID);
            CollectionAssert.IsEmpty(actualResult.ErrorMessageList);
        }
    }
}
