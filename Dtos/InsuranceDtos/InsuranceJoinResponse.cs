namespace InsuranceAPI.Dtos.InsuranceDtos
{
    public class InsuranceJoinResponse
    {
        public string Name { get; set; }= string.Empty;
        public required int AgencyCode { get; set; }
    }
}