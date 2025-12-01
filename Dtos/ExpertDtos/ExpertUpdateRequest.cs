namespace InsuranceAPI.Dtos.ExpertDtos
{
    public class ExpertUpdateRequest
    {
        public string Token { get; set; }= string.Empty;
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Address { get; set; }= string.Empty;
        public required string PhoneNumber { get; set; }
        public required string CurrentPassword { get; set; }
        public required string NewPassword { get; set; }
    }
}