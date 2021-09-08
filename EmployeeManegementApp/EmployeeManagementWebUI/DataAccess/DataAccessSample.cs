using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebUI.DataAccess
{
    /// <summary>
    /// DB接続のサンプル
    /// </summary>
    public class DataAccessSample
    {
        /// <summary>
        /// SQLパラメータありのコードサンプル
        /// </summary>
        public void SelectSampleWithParam()
        {
            using var repository = new EmployeeSystemRepository();
            repository.Open();

            // ①引数ありのSQLを実行する場合
            var selectQueryWithParam = "SELECT * FROM table_name WHERE target_column_name = @variableName";

            // ②引数のパラメータ名と値をDictionaryに格納する。
            var parametorNameAndValueDic = new Dictionary<string, object>()
            {
                // { SQLに指定した変数名, 変数に入れたい値 }
                { "@variableName",  string.Empty }
            };

            // ③SQLの実行
            var selectResult = repository.ExcuteQuery(selectQueryWithParam, parametorNameAndValueDic);
            while (selectResult.Read())
            {
            }
            selectResult.Close();

            repository.Close();
        }

        /// <summary>
        /// SQLパラメータなしのコードサンプル
        /// </summary>
        public void SelectSampleNoParam()
        {
            using var repository = new EmployeeSystemRepository();
            repository.Open();

            // ①引数ありのSQLを実行する場合
            var selectQueryWithParam = "SELECT * FROM table_name WHERE target_column_name";

            // ②SQLの実行
            var selectResult = repository.ExcuteQuery(selectQueryWithParam);
            while (selectResult.Read())
            {
            }
            selectResult.Close();

            repository.Close();
        }

        public void InsertSample()
        {
            using var repository = new EmployeeSystemRepository();
            repository.Open();

            // ①SQLの生成
            var insertQuery = "INSERT INTO table_name { column_1, culumn_2, culumn_3, …, culumn_N }"
                + " VALUES (@value_1, @value_2, @value_3, …, @value_N) ";

            // ②パラメータ生成
            var parametorNameAndValueDic = new Dictionary<string, object>()
            {
                // { SQLに指定した変数名, 変数に入れたい値 }
                { "@value_1", string.Empty },
            };

            // ③SQLの実行
            repository.ExcuteNonQuery(insertQuery, parametorNameAndValueDic);

            repository.Close();
        }
    }
}
