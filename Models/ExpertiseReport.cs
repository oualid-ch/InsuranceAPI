using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Models
{
    public class ExpertiseReport
    {
        public int Id { get; set; }
        public required string Reference { get; set; }
        public required string Incident { get; set; }
        public DateTime IncidentDate { get; set; }
        public required string VehicleConditionBeforeIncident { get; set; }
        public required string ImpactPoint { get; set; }
        public required string DamagedPoint { get; set; }
        public int PaintAndAdditions { get; set; }
        public ExpertiseReportState State { get; set; }= ExpertiseReportState.Waiting;
        public required string LaborDescription { get; set; }
        public decimal LaborCost { get; set; }
        public int? ServiceOrderId { get; set; }
        public ServiceOrder? ServiceOrder { get; set; }
        public List<DamagedPart> DamagedParts { get; set; }= new List<DamagedPart>();
    }
}