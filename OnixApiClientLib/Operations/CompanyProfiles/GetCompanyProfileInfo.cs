using Its.Onix.Api.Client.Commons;
using Its.Onix.Api.Client.Models;

namespace Its.Onix.Api.Client.Operations.CompanyProfiles
{
    public class GetCompanyProfileInfo : OperationQueryBase
    {
        protected override string GetRestPath<BaseModel>(BaseModel data)
        {
            MCompanyProfile m = data as MCompanyProfile;
            return string.Format("CompanyProfile/GetCompanyProfileInfo/{0}", m.CompanyProfileId);
        }
    }
}
