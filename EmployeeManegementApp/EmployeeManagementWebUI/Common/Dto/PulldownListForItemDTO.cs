namespace EmployeeManagementWebUI.Common.Dto
{
    /// <summary>
    /// プルダウンリスト用DTO
    /// </summary>
    /// <remarks>
    /// プルダウンリストの表示用名称と値を格納するDTO
    /// </remarks>
    public class PulldownListForItemDTO
    {
        /// <summary>表示用項目名称の取得と設定</summary>
        /// <remarks>表示用項目名称の取得と設定</remarks>
        /// <value>表示用項目名称</value>
        public string ItemNameForDisplay { get; set; }

        /// <summary>項目値の取得と設定</summary>
        /// <remarks>項目値の取得と設定</remarks>
        /// <value>項目値</value>
        public string ItemValue { get; set; }
    }
}
