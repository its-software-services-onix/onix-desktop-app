using System;
using System.Collections.Generic;
using System.Reflection;
using Its.Onix.Api.Client.Commons;

namespace Its.Onix.Api.Client.Factories
{
    public static class FactoryOperation
    {
        private static string baseUrl;
        private static readonly Dictionary<string, string> classMaps = new Dictionary<string, string>();

        static FactoryOperation()
        {
            AddClassConfig("GetCompanyProfileList", "Its.Onix.Api.Client.Operations.CompanyProfiles.GetCompanyProfileList");
            AddClassConfig("GetCompanyProfileInfo", "Its.Onix.Api.Client.Operations.CompanyProfiles.GetCompanyProfileInfo");
            AddClassConfig("DeleteCompanyProfile", "Its.Onix.Api.Client.Operations.CompanyProfiles.DeleteCompanyProfile");

            AddClassConfig("GetMasterList", "Its.Onix.Api.Client.Operations.Masters.GetMasterList");
            AddClassConfig("GetMasterInfo", "Its.Onix.Api.Client.Operations.Masters.GetMasterInfo");
            AddClassConfig("DeleteMaster", "Its.Onix.Api.Client.Operations.Masters.DeleteMaster");
        }

        private static void AddClassConfig(string apiName, string fqdn)
        {
            classMaps.Add(apiName, fqdn);
        }

        public static void SetBaseUrl(string url)
        {
            baseUrl = url;
        }


        public static IOperation CreateOperationObject(string name)
        {
            if (!classMaps.ContainsKey(name))
            {
                throw new ArgumentNullException(String.Format("Operation not found [{0}]", name));
            }

            string fqdn = classMaps[name];

            Assembly asm = Assembly.GetExecutingAssembly();
            IOperation obj = (IOperation)asm.CreateInstance(fqdn);

            obj.BaseUrl = baseUrl;
            return obj;
        }
    }
}
