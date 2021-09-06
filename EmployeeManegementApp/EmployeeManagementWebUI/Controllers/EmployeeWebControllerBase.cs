using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebUI.Controllers
{
    /// <summary>
    /// 社員管理システムWebController基底クラス
    /// </summary>
    /// <remarks>
    /// 社員管理システムWebController基底クラス
    /// </remarks>
    public class EmployeeWebControllerBase : Controller
    {
        #region === フィールド ===

        /// <summary>セッション情報</summary>
        /// <remarks>セッション情報</remarks>
        public readonly ISession _session = null;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// コンストラクタ
        /// </remarks>
        public EmployeeWebControllerBase(HttpContext httpContext)
        {
            _session = httpContext.Session;
        }
    }
}
