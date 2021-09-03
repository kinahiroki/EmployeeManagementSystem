using EmployeeManagementWebUI.BusinessLogicDto;
using System.Collections.Generic;

namespace EmployeeManagementWebUI.BusinessLogic
{
    /// <summary>
    /// 部署情報取得（全件） インターフェース
    /// </summary>
    /// <remarks>
    /// 部署情報取得（全件） インターフェース
    /// </remarks>
    public interface IEV8002Logic
    {
        /// <summary>
        /// 部署情報取得
        /// </summary>
        /// <remarks>
        /// 部署情報取得
        /// </remarks>
        /// <returns>全件取得結果</returns>
        IEnumerable<AffiliationDAO> FindAllForAffiliation();
    }
}
