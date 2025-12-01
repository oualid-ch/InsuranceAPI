using InsuranceAPI.Dtos.ExpertDtos;
using InsuranceAPI.Dtos.ExpertiseReportDtos;
using InsuranceAPI.Dtos.InsuranceDtos;
using InsuranceAPI.Models;
using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Dtos.ServiceOrderDtos
{
    public class ServiceOrderResponse
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; } = DateTime.Now;
        public required string VictimFullName { get; set; }
        public required string VictimPolicyNumber { get; set; }
        public City VictimCity { get; set; }
        public required InsuranceJoinResponse? VictimInsurance { get; set; }
        public required string VehicleMakerAndModel { get; set; }
        public required string VehicleLicensePlate { get; set; }
        public required string VehicleType { get; set; }
        public required string VehicleSeriesNumber { get; set; }
        public required string VehicleGenre { get; set; }
        public required int VehicleWeight { get; set; }
        public string? AtFaultFullName { get; set; }
        public string? AtFaultPolicyNumber { get; set; }
        public City? AtFaultCity { get; set; }
        public InsuranceJoinResponse? AtFaultInsurance { get; set; }
        public required ExpertJoinResponse? AssociatedExpert { get; set; }
        public ExpertiseReportResponse? ExpertiseReport { get; set; }
    }
}