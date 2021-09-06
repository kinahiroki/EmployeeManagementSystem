using System.Runtime.Serialization;

namespace EmployeeManagementWebUI.Common.Session
{
    /// <summary>
    /// セッション用役職情報
    /// </summary>
    /// <remarks>
    /// セッション用役職情報
    /// </remarks>
    [DataContract]
    public class PositionInfo
    {
        /// <summary>役職コード</summary>
        /// <remarks>役職コード</remarks>
        /// <value>役職コード</value>
        [DataMember]
        public string PositionCD { get; set; }

        /// <summary>役職コード</summary>
        /// <remarks>役職コード</remarks>
        /// <value>役職コード</value>
        [DataMember]
        public string PositionNm { get; set; }
    }
}
