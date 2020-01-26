using System.Windows;
using Newtonsoft.Json;

using Its.Onix.Api.Client.Commons;
using Its.Onix.Api.Client.Models;
using Its.Onix.Api.Client.Factories;

namespace Its.Onix.Api.Client.Demo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
            InitializeComponent();
            FactoryOperation.SetBaseUrl("https://onix-web-api-dev-phjesaf3ha-an.a.run.app/api/");
        }

        private IOperation GetOperationObject(string name)
        {
            var obj = FactoryOperation.CreateOperationObject(name);
            return obj;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            QueryRequestParam qrp = new QueryRequestParam();
            var opr = GetOperationObject("GetMasterList");
            var resp = opr.Apply<MMaster>(qrp);

            txtOutput.Text = resp.ToJSON();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            QueryRequestParam qrp = new QueryRequestParam();
            var opr = GetOperationObject("GetCompanyProfileList");
            var resp = opr.Apply<MCompanyProfile>(qrp);

            txtOutput.Text = resp.ToJSON();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var opr = GetOperationObject("GetMasterInfo");
            MMaster data = new MMaster() { MasterId = 8 };
            data = opr.Apply(data);

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            txtOutput.Text = json;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var opr = GetOperationObject("GetCompanyProfileInfo");
            MCompanyProfile data = new MCompanyProfile() { CompanyProfileId = 10 };
            data = opr.Apply(data);

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            txtOutput.Text = json;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var opr = GetOperationObject("DeleteMaster");
            MMaster data = new MMaster() { MasterId = 129 };
            data = opr.Apply(data);

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            txtOutput.Text = json;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var opr = GetOperationObject("DeleteCompanyProfile");
            MCompanyProfile data = new MCompanyProfile() { CompanyProfileId = 1 };
            data = opr.Apply(data);

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            txtOutput.Text = json;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var opr = GetOperationObject("SaveMaster");
            MMaster data = new MMaster() 
            { 
                MasterId = 8, 
                Code = "---NewCode33--", 
                Name = "NewName",
                ShortDescription = "NewShortDescription",
                Type = 1,
                Key = "This is new key",
                Tag = "ทดสอบแท็ก"
            };

            data = opr.Apply(data);

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            txtOutput.Text = json;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var opr = GetOperationObject("SaveCompanyProfile");
            MCompanyProfile data = new MCompanyProfile()
            {
                CompanyProfileId = null,
                Code = "WTT004",
                CompanyNameThai = "บริษัท 1234 test [" + txtDummy.Text + "]",
                CompanyNameEng = "1234 Company XXXX",
                CompanyPrefix = new MMaster() { MasterId = 11 }
            };

            data = opr.Apply(data);

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            txtOutput.Text = json;
        }
    }
}
