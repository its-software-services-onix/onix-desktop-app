using Its.Onix.Api.Client.Commons;
using Its.Onix.Api.Client.Models;

namespace Its.Onix.Api.Client.Operations.CompanyProfiles
{
    public class SaveCompanyProfile : OperationQueryBase
    {
        protected override string GetRestPath<BaseModel>(BaseModel data)
        {
            string path = "CompanyProfile/SaveCompanyProfile";

            MCompanyProfile m = data as MCompanyProfile;
            if (m.CompanyProfileId != null)
            {
                path = string.Format("{0}/{1}", path, m.CompanyProfileId);
            }

            return path;
        }
    }
}
