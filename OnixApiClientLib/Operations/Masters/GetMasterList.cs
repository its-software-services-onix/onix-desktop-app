using Its.Onix.Api.Client.Commons;

namespace Its.Onix.Api.Client.Operations.Masters
{
    public class GetMasterList : OperationQueryBase
    {
        protected override string GetRestPath()
        {
            return "Master/GetMasterList";
        }
    }
}
