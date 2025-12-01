using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Dtos.InsuranceDtos
{
    public class InsuranceResponseDto
    {
        public required string Token { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public City City { get; set; }
        public required int AgencyCode { get; set; }

    
    }
}