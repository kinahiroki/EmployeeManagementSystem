using EmployeeManagementWebUI.Helper;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementWebUI.Controllers.SCRN0001
{
    /// <summary>
    /// 社員管理システムメニュー　コントローラー
    /// </summary>
    /// <remarks>
    /// 社員管理システムメニュー　コントローラー
    /// </remarks>
    public class SCRN0001Controller : Controller
    {
        /// <summary></summary>
        /// <remarks></remarks>
        private readonly IEV0001Helper _ev0001Helper = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// DIの実施
        /// </remarks>
        public SCRN0001Controller(IEV0001Helper ev0001Helper)
        {
            _ev0001Helper = ev0001Helper;
        }

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <remarks>
        /// イベント名：社員管理システムメニュー画面初期表示
        /// </remarks>
        /// <returns>ActionResult</returns>
        [Route("/employee/menu")]
        [HttpGet]
        public IActionResult Index()
        {
            // 初期化
            var viewModelDto = _ev0001Helper.Init();
            return View(viewModelDto);
        }
    }
}
