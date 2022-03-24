using EmployeeManagementWebUI.Helper;
using EmployeeManagementWebUI.ViewModel.SCRN0002;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EmployeeManagementWebUI.Controllers.SCRN0002
{
    /// <summary>
    /// 社員登録画面　コントローラー
    /// </summary>
    /// <remarks>
    /// 社員登録画面　コントローラー
    /// </remarks>
    [Route("/employee/entry")]
    public class SCRN0002Controller : Controller
    {
        #region === 定数 ===

        /// <summary>コントローラ名：社員管理システムメニュー</summary>
        /// <remarks>コントローラ名：社員管理システムメニュー</remarks>
        private const string CONTROLLER_NAME_MENU = "SCRN0001";

        /// <summary>コントローラ名：社員管理完了</summary>
        /// <remarks>コントローラ名：社員管理完了</remarks>
        private const string CONTROLLER_NAME_CONFIRM = "SCRN0004";

        /// <summary>アクション名：初期表示</summary>
        /// <remarks>アクション名：初期表示</remarks>
        private const string ACTION_NAME_INDEX = "Index";

        #endregion

        #region === フィールド ===

        /// <summary>社員登録Helper</summary>
        /// <remarks>社員登録Helper</remarks>
        private readonly IEV0002Helper _ev0002Helper = null;

        #endregion

        #region === コンストラクタ ===

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// DIコンテナからインスタンスの取得
        /// </remarks>
        /// <param name="ev0002Helper">EV0002Helper</param>
        public SCRN0002Controller(IEV0002Helper ev0002Helper)
        {
            _ev0002Helper = ev0002Helper;
        }

        #endregion

        #region === 初期表示 ===

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <remarks>
        /// イベント名：社員登録画面初期表示
        /// </remarks>
        /// <returns>ActionResult</returns>
        [Route("")]
        [HttpPost]
        public IActionResult Index()
        {
            var viewModelDto = _ev0002Helper.Init();
            return View(viewModelDto);
        }

        #endregion

        #region === 新規登録 ===

        /// <summary>
        /// 新規登録
        /// </summary>
        /// <remarks>
        /// イベント名：新規登録ボタン押下
        /// </remarks>
        /// <param name="request">request</param>
        /// <returns>ActionResult</returns>
        [Route("execute")]
        [HttpPost]
        public IActionResult Execute(SCRN0002Request request)
        {
            // ModelStateを格納
            request.ModelStateDictionary = ModelState;

            var viewModelDto = _ev0002Helper.Entry(request);
            if (viewModelDto.ErrorMessageList.Any())
            {
                return View(ACTION_NAME_INDEX, viewModelDto);
            }

            return View(ACTION_NAME_INDEX, CONTROLLER_NAME_CONFIRM);
        }

        #endregion

        #region === 戻る処理 ===

        /// <summary>
        /// 戻る処理
        /// </summary>
        /// <remarks>
        /// イベント名：戻るボタン押下
        /// </remarks>
        /// <returns></returns>
        [Route("back")]
        [HttpGet]
        public IActionResult Back()
        {
            return RedirectToAction(ACTION_NAME_INDEX, CONTROLLER_NAME_MENU);
        }

        #endregion
    }
}
