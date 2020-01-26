using System;

namespace Its.Onix.Api.Client.Commons
{
    public class BaseModel
    {
        public BaseModel()
        { 
        }

        public string Key { get; set; }

        public DateTime LastMaintDate { get; set; }

        public string Tag { get; set; }

        public int OperatorId { get; set; }
    }
}