using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Dtos.InsuranceDtos
{
    public class InsuranceListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }= string.Empty;
        public required int AgencyCode { get; set; }
    }
}