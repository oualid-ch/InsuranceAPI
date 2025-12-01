using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Models
{
    public class ServiceOrder
    {
        public int Id { get; set; }
        public string IssueDate { get; set; } = DateTime.Now.ToString();
        public required string VictimFullName { get; set; }
        public required string VictimPolicyNumber { get; set; }
        public required int VictimInsuranceID { get; set; }
        public required Insurance? VictimInsurance { get; set; }
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
        public int? AtFaultInsuranceID { get; set; }
        public Insurance? AtFaultInsurance { get; set; }
        public required int AssociatedExpertID { get; set; }
        public required Expert? AssociatedExpert { get; set; }
        public ExpertiseReport? ExpertiseReport { get; set; }
    }
}