using InsuranceAPI.Models.Enums;

namespace InsuranceAPI.Models
{
    public class Expert
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }= string.Empty;
        public required City City { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public List<ServiceOrder> ServiceOrders { get; set; }= new List<ServiceOrder>();
    }
}