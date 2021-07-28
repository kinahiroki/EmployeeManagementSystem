﻿using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}