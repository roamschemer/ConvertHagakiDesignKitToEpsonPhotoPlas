using CsvHelper.Configuration.Attributes;

namespace ConvertHagakiDesignKitToEpsonPhotoPlas.Models {
    internal class HagakiDesignKitData {
        [Name("氏名(姓)")]
        public string FamilyName { get; set; } = string.Empty;
        [Name("氏名(名)")]
        public string GivenName { get; set; } = string.Empty;
        [Name("フリガナ(姓)")]
        public string Furigana1 { get; set; } = string.Empty;
        [Name("フリガナ(名)")]
        public string Furigana2 { get; set; } = string.Empty;
        [Name("敬称")]
        public string TitleOfHonor { get; set; } = string.Empty;
        [Name("郵便番号(自宅欄)")]
        public string PostalCode { get; set; } = string.Empty;
        [Name("自宅住所(都道府県)")]
        public string Address1 { get; set; } = string.Empty;
        [Name("自宅住所(市区町村)")]
        public string Address2 { get; set; } = string.Empty;
        [Name("自宅住所(番地等)")]
        public string Address3 { get; set; } = string.Empty;
        [Name("自宅住所(建物名)")]
        public string Address4 { get; set; } = string.Empty;
        [Name("会社名(会社欄)")]
        public string CompanyName { get; set; } = string.Empty;
        [Name("部署名(会社欄)")]
        public string DepartmentName { get; set; } = string.Empty;
        [Name("役職(会社欄)")]
        public string JobTitle { get; set; } = string.Empty;
        [Name("連名1(姓:自宅欄)")]
        public string JointFamilyName1 { get; set; } = string.Empty;
        [Name("連名2(姓:自宅欄)")]
        public string JointFamilyName2 { get; set; } = string.Empty;
        [Name("連名3(姓:自宅欄)")]
        public string JointFamilyName3 { get; set; } = string.Empty;
        [Name("連名4(姓:自宅欄)")]
        public string JointFamilyName4 { get; set; } = string.Empty;
        [Name("連名5(姓:自宅欄)")]
        public string JointFamilyName5 { get; set; } = string.Empty;
        [Name("連名1(名:自宅欄)")]
        public string JointGivenName1 { get; set; } = string.Empty;
        [Name("連名2(名:自宅欄)")]
        public string JointGivenName2 { get; set; } = string.Empty;
        [Name("連名3(名:自宅欄)")]
        public string JointGivenName3 { get; set; } = string.Empty;
        [Name("連名4(名:自宅欄)")]
        public string JointGivenName4 { get; set; } = string.Empty;
        [Name("連名5(名:自宅欄)")]
        public string JointGivenName5 { get; set; } = string.Empty;
        [Name("連名1(敬称:自宅欄)")]
        public string JointTitleOfHonor1 { get; set; } = string.Empty;
        [Name("連名2(敬称:自宅欄)")]
        public string JointTitleOfHonor2 { get; set; } = string.Empty;
        [Name("連名3(敬称:自宅欄)")]
        public string JointTitleOfHonor3 { get; set; } = string.Empty;
        [Name("連名4(敬称:自宅欄)")]
        public string JointTitleOfHonor4 { get; set; } = string.Empty;
        [Name("連名5(敬称:自宅欄)")]
        public string JointTitleOfHonor5 { get; set; } = string.Empty;
    }
}
