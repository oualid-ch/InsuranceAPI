using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Dtos.InsuranceDtos
{
    public class InsuranceUpdateRequestDto
    {
        public required string Token { get; set; }
        public string Name { get; set; }= string.Empty;
        public string Address { get; set; }= string.Empty;
        public required City City { get; set; }
        public required int AgencyCode { get; set; }
        public required string CurrentPassword { get; set; }
        public string NewPassword { get; set; } = string.Empty;

    }
}