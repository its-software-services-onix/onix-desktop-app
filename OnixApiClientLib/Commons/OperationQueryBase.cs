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

        protected T SubmitOperationWithNoContent<T>(string method, string restPath)
        {
            string url = string.Format("{0}{1}", BaseUrl, restPath);

            var httpReq = WebRequest.Create(url);
            httpReq.Method = method;

            var response = httpReq.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var qrp = JsonConvert.DeserializeObject<T>(responseString);

            return qrp;
        }

        private string SubmitData(string method, string restPath, object dat)
        {
            string payload = JsonConvert.SerializeObject(dat);
            string url = string.Format("{0}{1}", BaseUrl, restPath);

            string postData = string.Format("JsonContent={0}", payload);
            byte[] data = Encoding.UTF8.GetBytes(postData);

            var httpReq = WebRequest.Create(url);
            httpReq.Method = method;
            httpReq.ContentType = "application/x-www-form-urlencoded";
            httpReq.ContentLength = data.Length;

            var sr = httpReq.GetRequestStream();

            sr.Write(data, 0, data.Length);

            var response = httpReq.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        protected QueryResponseParam<T> SubmitPostOperationForQuery<T>(string restPath, QueryRequestParam param)
        {
            string responseString = SubmitData("POST", restPath, param);
            var qrp = JsonConvert.DeserializeObject<QueryResponseParam<T>>(responseString);
            return qrp;
        }

        protected T SubmitOperationWithContent<T>(string method, string restPath, T dat)
        {
            string responseString = SubmitData(method, restPath, dat);
            var resp = JsonConvert.DeserializeObject<T>(responseString);
            return resp;
        }

        public QueryResponseParam<T> Apply<T>(QueryRequestParam param)
        {
            string path = GetRestPath();
            var qrp = SubmitPostOperationForQuery<T>(path, param);
            return qrp;
        }

        public T Apply<T>(T data) where T:BaseModel
        {
            string path = GetRestPath<T>(data);
            string method = "GET";

            T res = default(T);

            if (path.Contains("Delete"))
            {
                method = "DELETE";
                res = SubmitOperationWithNoContent<T>(method, path);
            }
            else if (path.Contains("Save"))
            {
                string[] parts = path.Split('/');
                int size = parts.Length;

                if (size == 2)
                {
                    method = "POST";
                }
                else
                {
                    method = "PUT";
                }

                res = SubmitOperationWithContent(method, path, data);
            }
            else
            {
                //GET - GetInfo() function
                res = SubmitOperationWithNoContent<T>(method, path);
            }

            return res;
        }
    }
}
