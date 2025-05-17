namespace SalaryCalculatorApi.Models
{
    public class SalaryRequest
    {
        public int JobPercentage { get; set; } 
        public string ProfessionalLevel { get; set; } = string.Empty; 
        public int ManagementLevel { get; set; } 
        public int YearsOfSeniority { get; set; }
        public bool EligibleByLaw { get; set; }
        public string? LawGroup { get; set; } 

    }
}
