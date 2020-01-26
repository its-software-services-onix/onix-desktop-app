using System;
using System.IO;
using System.Text;
using System.Net;
using Newtonsoft.Json;

namespace Its.Onix.Api.Client.Commons
{
    public abstract class OperationQueryBase : IOperation
    {
        public string BaseUrl { get; set; }

        protected virtual string GetRestPath()
        {
            return "";
        }

        protected virtual string GetRestPath<BaseModel>(BaseModel data)
        {
            return "";
        }

        protected virtual string GetHttpMethod()
        {
            return "GET";
        }

        protected T SubmitOperation<T>(string method, string restPath)
        {
            string url = string.Format("{0}{1}", BaseUrl, restPath);

            var httpReq = WebRequest.Create(url);
            httpReq.Method = method;

            var response = httpReq.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var qrp = JsonConvert.DeserializeObject<T>(responseString);

            return qrp;
        }

        protected QueryResponseParam<T> SubmitPostOperation<T>(string restPath, QueryRequestParam param)
        {
            string payload = JsonConvert.SerializeObject(param);
            string url = string.Format("{0}{1}", BaseUrl, restPath);

            string postData = string.Format("JsonContent={0}", payload);
            byte[] data = Encoding.ASCII.GetBytes(postData);


            var httpReq = WebRequest.Create(url);
            httpReq.Method = "POST";
            httpReq.ContentType = "application/x-www-form-urlencoded";
            httpReq.ContentLength = data.Length;

            var sr = httpReq.GetRequestStream();

            sr.Write(data, 0, data.Length);

            var response = httpReq.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            var qrp = JsonConvert.DeserializeObject<QueryResponseParam<T>>(responseString);

            return qrp;
        }

        public QueryResponseParam<T> Apply<T>(QueryRequestParam param)
        {
            string path = GetRestPath();
            var qrp = SubmitPostOperation<T>(path, param);
            return qrp;
        }

        public T Apply<T>(T data) where T:BaseModel
        {
            string path = GetRestPath<T>(data);
            string method = GetHttpMethod();

            T qrp = default(T);

            if (path.Contains("Delete"))
            {
                method = "DELETE";
            }

            try
            {
                qrp = SubmitOperation<T>(method, path);
            }
            catch
            { 
            }

            return qrp;
        }
    }
}
