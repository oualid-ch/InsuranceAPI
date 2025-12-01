namespace InsuranceAPI.Dtos.InsuranceDtos
{
    public class InsuranceLoginRequestDto
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }

    }
}