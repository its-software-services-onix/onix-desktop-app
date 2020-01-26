using Its.Onix.Api.Client.Commons;

namespace Its.Onix.Api.Client.Models
{
    public class MCompanyProfile : BaseModel
    {
        public int? CompanyProfileId { get; set; }

        public string Code { get; set; }

        public string CompanyNameThai { get; set; }

        public string CompanyNameEng { get; set; }

        public string OperatorNameThai { get; set; }

        public string OperatorNameEng { get; set; }

        public string AddressThai { get; set; }

        public string AddressEng { get; set; }

        public string Telephone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string WebSite { get; set; }

        public string Logo { get; set; }

        public string TaxNo { get; set; }

        public string RegistrationName { get; set; }

        public string RegistrationAddress { get; set; }

        public string BuildingName { get; set; }

        public string RoomNo { get; set; }

        public string FloorNo { get; set; }

        public string VillageName { get; set; }

        public string HomeNo { get; set; }

        public string Moo { get; set; }

        public string Soi { get; set; }

        public string Road { get; set; }

        public string District { get; set; }

        public string Town { get; set; }

        public string Province { get; set; }

        public string Zip { get; set; }

        public MMaster CompanyPrefix { get; set; }
    }
}
