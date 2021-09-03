using EmployeeManagementWebUI.BusinessLogicDto;
using EmployeeManagementWebUI.DataAccess;
using System.Collections.Generic;

namespace EmployeeManagementWebUI.BusinessLogic
{
    /// <summary>
    /// 部署情報取得（全件） 実装クラス
    /// </summary>
    /// <remarks>
    /// 部署情報取得（全件） 実装クラス
    /// </remarks>
    public class EV8002Logic : IEV8002Logic
    {
        #region === 部署情報取得 ===

        /// <summary>
        /// 部署情報取得
        /// </summary>
        /// <remarks>
        /// 部署情報取得
        /// </remarks>
        /// <returns>全件取得結果</returns>
        public IEnumerable<AffiliationDAO> FindAllForAffiliation()
        {
            using var repository = new EmployeeSystemRepository();

            repository.Open();

            var selectResultList = new List<AffiliationDAO>();

            // SQL実行
            var selectQuery = "SELECT * FROM employee_db.m_affiliation";

            // 実行結果の取得
            var selectResult = repository.ExcuteQuery(selectQuery);
            while (selectResult.Read())
            {
                var resultItem = new AffiliationDAO()
                {
                    AffiliationCD = selectResult[0].ToString(),
                    ManagementCD = selectResult[1].ToString(),
                    BrunchCD = selectResult[2].ToString(),
                    GroupCD = selectResult[3].ToString(),
                    ManagementNm = selectResult[4].ToString(),
                    BrunchNm = selectResult[5].ToString(),
                    GroupNm = selectResult[6].ToString(),
                    ManagementEmployeeID = selectResult[7].ToString(),
                };
                selectResultList.Add(resultItem);
            }
            selectResult.Close();
            repository.Close();

            // 所属名称の設定
            selectResultList.ForEach(x => x.AffiliationNm = GetAffiliationName(x));

            return selectResultList;
        }

        #endregion

        #region === 所属名称の設定 ===

        /// <summary>
        /// 所属名称の設定
        /// </summary>
        /// <remarks>
        /// 所属名称の設定
        /// </remarks>
        /// <param name="resultItem">検索結果要素</param>
        /// <returns>設定後の要素</returns>
        private string GetAffiliationName(AffiliationDAO resultItem)
        {
            const string NO_GROUP_CD = "00";
            const string NO_BRUNCH_CD = "00";

            string affoliationName;
            if (resultItem.GroupCD != NO_GROUP_CD)
            {
                affoliationName = resultItem.GroupNm;
            }
            else if (resultItem.BrunchCD != NO_BRUNCH_CD)
            {
                affoliationName = resultItem.BrunchNm;
            }
            else
            {
                affoliationName = resultItem.ManagementNm;
            }

            return affoliationName;
        }

        #endregion
    }
}
