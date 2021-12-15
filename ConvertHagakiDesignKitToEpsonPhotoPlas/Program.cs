using ConvertHagakiDesignKitToEpsonPhotoPlas.Models;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

Console.WriteLine("Hello, ConvertHagakiDesignKitToEpsonPhotoPlas!");
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
List<HagakiDesignKitData> hagakiDesignKitDatas;
var importFilePath = "import\\address_list.csv";
var configuration = new CsvConfiguration(CultureInfo.InvariantCulture) {
    HeaderValidated = null,
    MissingFieldFound = null,
};
using (var reader = new StreamReader(new FileStream(importFilePath, FileMode.Open), Encoding.GetEncoding("shift-jis")))
using (var csv = new CsvReader(reader, configuration)) {
    hagakiDesignKitDatas = csv.GetRecords<HagakiDesignKitData>().ToList();
}
var epsonDatas = hagakiDesignKitDatas.Select(x => new EpsonData() {
    FamilyName = x.FamilyName,
    GivenName = x.GivenName,
    Furigana = x.Furigana1 + x.Furigana2,
    TitleOfHonor = x.TitleOfHonor,
    PostalCode = x.PostalCode,
    Address1 = x.Address1 + x.Address2 + x.Address3,
    Address2 = x.Address4,
    CompanyName = x.CompanyName,
    DepartmentName = x.DepartmentName,
    JobTitle = x.JobTitle,
    JointFamilyName1 = x.JointFamilyName1,
    JointFamilyName2 = x.JointFamilyName2,
    JointFamilyName3 = x.JointFamilyName3,
    JointFamilyName4 = x.JointFamilyName4,
    JointFamilyName5 = x.JointFamilyName5,
    JointGivenName1 = x.JointGivenName1,
    JointGivenName2 = x.JointGivenName2,
    JointGivenName3 = x.JointGivenName3,
    JointGivenName4 = x.JointGivenName4,
    JointGivenName5 = x.JointGivenName5,
    JointTitleOfHonor1 = x.JointTitleOfHonor1,
    JointTitleOfHonor2 = x.JointTitleOfHonor2,
    JointTitleOfHonor3 = x.JointTitleOfHonor3,
    JointTitleOfHonor4 = x.JointTitleOfHonor4,
    JointTitleOfHonor5 = x.JointTitleOfHonor5,
});
var exportFilePath = "export\\address_list.csv";
using (var writer = new StreamWriter(exportFilePath, false, Encoding.GetEncoding("shift_jis")))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)) {
    csv.WriteRecords(epsonDatas);
}