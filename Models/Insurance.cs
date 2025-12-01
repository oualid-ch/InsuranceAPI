using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string Name { get; set; }= string.Empty;
        public string Address { get; set; }= string.Empty;
        public City City { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required int AgencyCode { get; set; }
        public List<ServiceOrder> ServiceOrdersVictim { get; set; }= new List<ServiceOrder>();
        public List<ServiceOrder> ServiceOrdersAtFault { get; set; }= new List<ServiceOrder>();

    }
}