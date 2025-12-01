using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Dtos.ExpertDtos
{
    public class ExpertCreateRequest
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }= string.Empty;

        public required City City { get; set; }
    }
}