using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace ConvertHagakiDesignKitToEpsonPhotoPlas.Models {
    internal class EpsonData {
        [Name("姓")]
        public string FamilyName { get; set; } = string.Empty;
        [Name("名")]
        public string GivenName { get; set; } = string.Empty;
        [Name("フリガナ")]
        public string Furigana { get; set; } = string.Empty;
        [Name("敬称")]
        public string TitleOfHonor { get; set; } = string.Empty;
        [Name("自宅 7桁〒")]
        public string PostalCode { get; set; } = string.Empty;
        [Name("住所１")]
        public string Address1 { get; set; } = string.Empty;
        [Name("住所２")]
        public string Address2 { get; set; } = string.Empty;
        [Name("会社名_カラリオ")]
        public string CompanyName { get; set; } = string.Empty;
        [Name("部署名_カラリオ")]
        public string DepartmentName { get; set; } = string.Empty;
        [Name("役職名_カラリオ")]
        public string JobTitle { get; set; } = string.Empty;
        [Name("連姓1")]
        public string JointFamilyName1 { get; set; } = string.Empty;
        [Name("連姓2")]
        public string JointFamilyName2 { get; set; } = string.Empty;
        [Name("連姓3")]
        public string JointFamilyName3 { get; set; } = string.Empty;
        [Name("連姓4")]
        public string JointFamilyName4 { get; set; } = string.Empty;
        [Name("連姓5")]
        public string JointFamilyName5 { get; set; } = string.Empty;
        [Name("連名1")]
        public string JointGivenName1 { get; set; } = string.Empty;
        [Name("連名2")]
        public string JointGivenName2 { get; set; } = string.Empty;
        [Name("連名3")]
        public string JointGivenName3 { get; set; } = string.Empty;
        [Name("連名4")]
        public string JointGivenName4 { get; set; } = string.Empty;
        [Name("連名5")]
        public string JointGivenName5 { get; set; } = string.Empty;
        [Name("敬称(連名１)")]
        public string JointTitleOfHonor1 { get; set; } = string.Empty;
        [Name("敬称(連名２)")]
        public string JointTitleOfHonor2 { get; set; } = string.Empty;
        [Name("敬称(連名３)")]
        public string JointTitleOfHonor3 { get; set; } = string.Empty;
        [Name("敬称(連名４)")]
        public string JointTitleOfHonor4 { get; set; } = string.Empty;
        [Name("敬称(連名５)")]
        public string JointTitleOfHonor5 { get; set; } = string.Empty;
    }
}
