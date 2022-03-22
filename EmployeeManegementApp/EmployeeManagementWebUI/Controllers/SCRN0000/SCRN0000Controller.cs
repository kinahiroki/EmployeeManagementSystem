using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementWebUI.Controllers.SCRN0000
{
    /// <summary>
    /// 社員管理システムTOP コントローラ
    /// </summary>
    /// <remarks>
    /// 社員管理システムTOP コントローラ
    /// </remarks>
    public class SCRN0000Controller : EmployeeWebControllerBase
    {
        #region === 初期表示 ===

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <remarks>
        /// イベント名：社員管理システムTOP画面初期表示
        /// </remarks>
        /// <returns>ActionResult</returns>
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        #endregion
    }
}
