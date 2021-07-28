using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementWebUI.Controllers.SCRN0002
{
    /// <summary>
    /// 社員登録画面　コントローラー
    /// </summary>
    /// <remarks>
    /// 社員登録画面　コントローラー
    /// </remarks>
    public class SCRN0002Controller : Controller
    {
        /// <summary>コントローラ名：社員管理システムメニュー</summary>
        /// <remarks>コントローラ名：社員管理システムメニュー</remarks>
        private const string CONTROLLER_NAME_MANU = "SCRN0001";

        /// <summary>アクション名：社員管理システムメニュー_初期表示</summary>
        /// <remarks>アクション名：社員管理システムメニュー_初期表示</remarks>
        private const string ACTION_NAME_INDEX = "Index";

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <remarks>
        /// イベント名：社員登録画面初期表示
        /// </remarks>
        /// <returns>ActionResult</returns>
        [Route("/entry")]
        [HttpGet]
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 新規登録
        /// </summary>
        /// <remarks>
        /// イベント名：新規登録ボタン押下
        /// </remarks>
        /// <returns>ActionResult</returns>
        [Route("/entry/execute")]
        [HttpPost]
        public IActionResult Execute()
        {
            return View();
        }

        /// <summary>
        /// 戻る処理
        /// </summary>
        /// <remarks>
        /// イベント名：戻るボタン押下
        /// </remarks>
        /// <returns></returns>
        [Route("/back")]
        [HttpGet]
        public IActionResult Back()
        {
            return RedirectToAction(ACTION_NAME_INDEX, CONTROLLER_NAME_MANU);
        }
    }
}
