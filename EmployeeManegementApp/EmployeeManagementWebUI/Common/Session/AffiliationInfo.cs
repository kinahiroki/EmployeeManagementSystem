using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebUI.Common.Session
{
    /// <summary>
    /// セッション用部署情報
    /// </summary>
    /// <remarks>
    /// セッション用部署情報
    /// </remarks>
    public class AffiliationInfo
    {
        /// <summary>部署コード</summary>
        /// <remarks>部署コード</remarks>
        /// <value>部署コード</value>
        public string AffiliationCD { get; set; }

        /// <summary>部署名称</summary>
        /// <remarks>部署名称</remarks>
        /// <value>部署名称</value>
        public string AffiliationNm { get; set;
        }
    }
}
