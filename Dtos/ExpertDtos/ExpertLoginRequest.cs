namespace InsuranceAPI.Dtos.ExpertDtos
{
    public class ExpertLoginRequest
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }
}