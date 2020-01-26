using Its.Onix.Api.Client.Commons;
using Its.Onix.Api.Client.Models;

namespace Its.Onix.Api.Client.Operations.Masters
{
    public class SaveMaster : OperationQueryBase
    {
        protected override string GetRestPath<BaseModel>(BaseModel data)
        {
            string path = "Master/SaveMaster";

            MMaster m = data as MMaster;
            if (m.MasterId != null)
            {
                path = string.Format("{0}/{1}", path, m.MasterId);
            }

            return path;
        }
    }
}
