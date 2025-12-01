using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Dtos.ServiceOrderDtos
{
    public class ServiceOrderUdateRequest
    {
        public required int Id { get; set; }
        public required string VictimFullName { get; set; }
        public required string VictimPolicyNumber { get; set; }
        public City VictimCity { get; set; }
        public required string VehicleMakerAndModel { get; set; }
        public required string VehicleLicensePlate { get; set; }
        public required string VehicleType { get; set; }
        public required string VehicleSeriesNumber { get; set; }
        public required string VehicleGenre { get; set; }
        public required int VehicleWeight { get; set; }
        public string? AtFaultFullName { get; set; }
        public string? AtFaultPolicyNumber { get; set; }
        public City? AtFaultCity { get; set; }
        public required int AssociatedExpertID { get; set; }
        public required string VictimInsuranceToken { get; set; }
        public int? AtFaultInsuranceID { get; set; }
    }
}