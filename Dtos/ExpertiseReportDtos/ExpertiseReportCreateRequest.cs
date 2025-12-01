using InsuranceAPI.Dtos.DamagedPartDtos;
using InsuranceAPI.Models;

namespace InsuranceAPI.Dtos.ExpertiseReportDtos
{
    public class ExpertiseReportCreateRequest
    {
        public string ExpertToken { get; set; } = string.Empty;
        public required string Reference { get; set; }
        public required string Incident { get; set; }
        public DateTime IncidentDate { get; set; }
        public required string VehicleConditionBeforeIncident { get; set; }
        public required string ImpactPoint { get; set; }
        public required string DamagedPoint { get; set; }
        public int PaintAndAdditions { get; set; }
        public required string LaborDescription { get; set; }
        public decimal LaborCost { get; set; }
        public int? ServiceOrderId { get; set; }
        public List<DamagedPartCreateRequest> DamagedParts { get; set; }= new List<DamagedPartCreateRequest>();
    }
}