using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Dtos.ExpertDtos
{
    public class ExpertListResponse
    {
        public int Id { get; set; }
        public required string? FirstName { get; set; }
        public required string? LastName { get; set; }
        public required string? Address { get; set; }= string.Empty;
        public required string? PhoneNumber { get; set; }
        public required City City { get; set; }
    }
}