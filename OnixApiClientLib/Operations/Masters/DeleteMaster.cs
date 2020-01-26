using Its.Onix.Api.Client.Commons;
using Its.Onix.Api.Client.Models;

namespace Its.Onix.Api.Client.Operations.Masters
{
    public class DeleteMaster : OperationQueryBase
    {
        protected override string GetRestPath<BaseModel>(BaseModel data)
        {
            MMaster m = data as MMaster;
            return string.Format("Master/DeleteMaster/{0}", m.MasterId);
        }
    }
}
