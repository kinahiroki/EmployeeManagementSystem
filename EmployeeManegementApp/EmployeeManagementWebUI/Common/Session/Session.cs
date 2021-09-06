namespace EmployeeManagementWebUI.Common.Session
{
    /// <summary>
    /// 各セッション情報の格納
    /// </summary>
    public class Session
    {
        /// <summary>マスタ情報</summary>
        /// <remarks>マスタ情報</remarks>
        /// <value>マスタ情報</value>
        public MasterInfoForSession MasterInfo { get; set; }

        /// <summary>更新社員ID</summary>
        /// <remarks>更新社員ID</remarks>
        /// <value>更新社員ID</value>
        public string UpdateEmployeeID { get; set; }
    }
}
