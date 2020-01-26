using Its.Onix.Api.Client.Commons;

namespace Its.Onix.Api.Client.Operations.CompanyProfiles
{
    public class GetCompanyProfileList : OperationQueryBase
    {
        protected override string GetRestPath()
        {
            return "CompanyProfile/GetCompanyProfileList";
        }
    }
}
