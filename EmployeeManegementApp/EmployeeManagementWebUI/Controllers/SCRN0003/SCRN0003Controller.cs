using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebUI.Controllers.SCRN0003
{
    /// <summary>
    /// 社員照会・更新画面　コントローラー
    /// </summary>
    /// <remarks>
    /// 社員照会・更新画面　コントローラー
    /// </remarks>
    [Route("/employee/update")]
    public class SCRN0003Controller : Controller
    {
        #region === コンストラクタ ===

        public SCRN0003Controller()
        {
        }

        #endregion

        #region === 初期表示 ===

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <remarks>
        /// イベント社員照会・更新画面初期表示：
        /// </remarks>
        /// <returns>ActionResult</returns>
        [Route("")]
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region === 更新処理 ===

        #endregion

        #region === 削除処理 ===

        #endregion

        #region === 戻る処理 ===

        #endregion
    }
}
