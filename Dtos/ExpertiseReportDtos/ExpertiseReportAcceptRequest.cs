namespace InsuranceAPI.Dtos.ExpertiseReportDtos
{
    public class ExpertiseReportAcceptRequest
    {
        public required string InsuranceToken { get; set; } = string.Empty;
        public required int ExpertiseReportID { get; set; }
    }
}