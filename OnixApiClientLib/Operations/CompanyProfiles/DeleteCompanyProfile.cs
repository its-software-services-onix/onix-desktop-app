using Its.Onix.Api.Client.Commons;
using Its.Onix.Api.Client.Models;

namespace Its.Onix.Api.Client.Operations.CompanyProfiles
{
    public class DeleteCompanyProfile : OperationQueryBase
    {
        protected override string GetRestPath<BaseModel>(BaseModel data)
        {
            MCompanyProfile m = data as MCompanyProfile;
            return string.Format("CompanyProfile/DeleteCompanyProfile/{0}", m.CompanyProfileId);
        }
    }
}
