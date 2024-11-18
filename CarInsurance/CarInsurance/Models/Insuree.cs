namespace CarInsurance.Models
{
    public class Insuree
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string EmailAddress { get; set; }
        public required string DateOfBirth { get; set; }
        public string? CarYear { get; set; }
        public  string?  CarMake { get; set; }
        public string? CarModel { get; set; }
        public int DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public string? CoverageType { get; set; }
        public int Qoute { get; set; }

    }
}
