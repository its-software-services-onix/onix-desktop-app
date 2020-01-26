using System;
using Its.Onix.Api.Client.Commons;

namespace Its.Onix.Api.Client.Commons
{
    public interface IOperation
    {
        string BaseUrl { get; set; }

        QueryResponseParam<T> Apply<T>(QueryRequestParam param);

        T Apply<T>(T data) where T:BaseModel;
    }
}
