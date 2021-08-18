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
    public class SCRN0002Controller : Controller
    {
        /// <summary>コントローラ名：社員管理システムメニュー</summary>
        /// <remarks>コントローラ名：社員管理システムメニュー</remarks>
        private const string CONTROLLER_NAME_MANU = "SCRN0001";

        /// <summary>アクション名：社員管理システムメニュー_初期表示</summary>
        /// <remarks>アクション名：社員管理システムメニュー_初期表示</remarks>
        private const string ACTION_NAME_INDEX = "Index";

        private readonly IEV0002Helper _ev0002Helper = null;

        public SCRN0002Controller(IEV0002Helper ev0002Helper)
        {
            _ev0002Helper = ev0002Helper;
        }

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
            var viewModelDto = _ev0002Helper.Init();
            return View(viewModelDto);
        }

        /// <summary>
        /// 新規登録
        /// </summary>
        /// <remarks>
        /// イベント名：新規登録ボタン押下
        /// </remarks>
        /// <param name="request">request</param>
        /// <returns>ActionResult</returns>
        [Route("/entry/execute")]
        [HttpPost]
        public IActionResult Execute(SCRN0002Request request)
        {
            var viewModelDto = _ev0002Helper.Entry(request);
            if (viewModelDto.ErrorMessageList.Any())
            {
                return View("Index", viewModelDto);
            }

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
