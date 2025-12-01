namespace InsuranceAPI.Dtos.ExpertDtos
{
    public class ExpertJoinResponse
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Address { get; set; }= string.Empty;
        public required string PhoneNumber { get; set; }
    }
}