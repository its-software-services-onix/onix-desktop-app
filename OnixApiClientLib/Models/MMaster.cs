using Its.Onix.Api.Client.Commons;

namespace Its.Onix.Api.Client.Models
{
    public class MMaster : BaseModel
    {
        public int? MasterId { get; set; }
        
        public string Code { get; set; }

        public string Name { get; set; }

        public string LongDescription { get; set; }

        public string ShortDescription { get; set; }

        public int Type { get; set; }
    }
}
