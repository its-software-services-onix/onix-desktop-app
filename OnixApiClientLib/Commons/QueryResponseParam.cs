using System.Collections.Generic;
using Newtonsoft.Json;

namespace Its.Onix.Api.Client.Commons
{
    public class QueryResponseParam<T>
    {
        public int TotalRecord { get; set; }

        public int TotalPage { get; set; }

        public int RecordCount { get; set; }

        public int PageNo { get; set; }

        public List<T> Results { get; set; }

        public string ToJSON()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            return json;
        }
    }
}
