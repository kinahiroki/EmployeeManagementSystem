using System;
using System.Collections.Generic;
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

            // ③SQLのパラメータ設定

            // ④SQLの実行

            // ⑤SQL結果の取得

            // ⑥DB接続の終了
            repository.Clone();
        }
    }
}
