namespace InsuranceAPI.Dtos.DamagedPartDtos
{
    public class DamagePartResponse
    {
        public string? PartName { get; set; }="Unknown part";
        public decimal PartPrice { get; set; }
        public int Reduction { get; set; }
    }
}