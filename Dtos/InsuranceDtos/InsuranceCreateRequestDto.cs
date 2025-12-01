using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Dtos.InsuranceDtos
{
    public class InsuranceCreateRequestDto
    {
        public string Name { get; set; }= string.Empty;
        public string Address { get; set; }= string.Empty;
        public City City { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required int AgencyCode { get; set; }
    }
}