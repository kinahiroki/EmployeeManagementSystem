using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebUI.DataAccess
{
    /// <summary>
    /// Sample DataAccess
    /// </summary>
    public class SampleDataAccess
    {
        public void SampleSelect()
        {
            using var repository = new EmployeeSystemRepository();

            // ①DB接続の開始
            repository.Open();

            // ②SQLの生成
            var selectQuery = "SELECT * FROM employee_db.m_affiliation";

            // ③SQLのパラメータ設定
            // var selectCommand = new SqlCommand(selectQuery);

            // ④SQLの実行
            // (1) SELECT文の場合
            var selectResult = repository.ExcuteQuery(selectQuery);
            while (selectResult.Read())
            {
            }
            selectResult.Close();

            // (2) INSERT, UPDATE, DALETE の場合
            var updateQuery = "UPDATE employee_db.m_affiliation SET management_cd = @managementCD";
            var parametarNameAndVakue = new Dictionary<string, object>()
            {
                { "@managementCD", "02" },
            };
            repository.ExcuteNonQuery(updateQuery, parametarNameAndVakue);

            // ⑤SQL結果の取得

            // ⑥DB接続の終了
            repository.Clone();
        }
    }
}
