using InsuranceAPI.Dtos.DamagedPartDtos;
using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Dtos.ExpertiseReportDtos
{
    public class ExpertiseReportResponse
    {
        public int Id { get; set; }
        public required string Reference { get; set; }
        public required ExpertiseReportState State { get; set; }= ExpertiseReportState.Waiting_Appeal;
        public required string Incident { get; set; }
        public DateTime IncidentDate { get; set; }
        public required string VehicleConditionBeforeIncident { get; set; }
        public required string ImpactPoint { get; set; }
        public required string DamagedPoint { get; set; }
        public int PaintAndAdditions { get; set; }
        public required string LaborDescription { get; set; }
        public decimal LaborCost { get; set; }
        public required decimal DamagePartTotalCostBeforeReduction { get; set; }
        public required decimal DamagePartTotalPercentage { get; set; }
        public required decimal DamagePartTotalReductionCost { get; set; }
        public required decimal DamagePartTotalCostAfterReduction { get; set; }
        public required decimal Total { get; set; }

        public List<DamagePartResponse> DamagedParts { get; set; }= new List<DamagePartResponse>();
    }
}