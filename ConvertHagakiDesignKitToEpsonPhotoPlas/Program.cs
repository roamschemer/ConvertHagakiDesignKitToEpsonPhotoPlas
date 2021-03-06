using ConvertHagakiDesignKitToEpsonPhotoPlas.Models;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

if (args.Length == 0) {
    Console.WriteLine("エラー：はがきデザインキットから出力した住所録のCSVファイルを.exeファイルに直接ドラッグ＆ドロップしてください。");
    Console.WriteLine("任意のキーを押して終了します。");
    Console.ReadKey();
    return 1;
}
var importFilePath = args[0];
Console.WriteLine($"Start Convert");
Console.WriteLine($"{importFilePath} のコンバートを実行します。");
try {
    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    List<HagakiDesignKitData> hagakiDesignKitDatas;
    var configuration = new CsvConfiguration(CultureInfo.InvariantCulture) {
        HeaderValidated = null,
        MissingFieldFound = null,
    };
    using (var reader = new StreamReader(new FileStream(importFilePath, FileMode.Open), Encoding.GetEncoding("shift-jis")))
    using (var csv = new CsvReader(reader, configuration)) {
        hagakiDesignKitDatas = csv.GetRecords<HagakiDesignKitData>().ToList();
    }
    var epsonDatas = hagakiDesignKitDatas.Select(x => {
        Console.WriteLine($"{x.FamilyName} {x.GivenName} reading");
        return new EpsonData() {
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
        };
    });
    if (!epsonDatas.Any())
        throw new Exception("読み込むことができませんでした。もう一度はがきデザインキットから出力したCSVファイルでお試しください。");
    var exportFilePath = $"epson_photo_plas_address_list_{DateTime.Now.ToString("yyyyMMdd_HHmmssfff")}.csv";
    using (var writer = new StreamWriter(exportFilePath, false, Encoding.GetEncoding("shift_jis")))
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)) {
        csv.WriteRecords(epsonDatas);
    }
    Console.WriteLine($"Finish Convert");
    Console.WriteLine($"{exportFilePath} が出力されました。");
    Console.WriteLine("この CSV ファイルは Epson Photo+ で読込可能です。");
} catch (Exception e) {
    Console.WriteLine($"System Error");
    Console.WriteLine(e.Message);
    Console.WriteLine("任意のキーを押して終了します。");
    Console.ReadKey();
    return 1;
}
Console.WriteLine("任意のキーを押して終了します。");
Console.ReadKey();
return 0;
