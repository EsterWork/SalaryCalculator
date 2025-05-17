namespace SalaryCalculatorApi.Models
{
    public class SalaryResult
    {
        public double BaseSalary { get; set; }
        public double SeniorityBonusPercent { get; set; }
        public double SeniorityBonusAmount { get; set; }
        public double LawBonusAmount { get; set; }
        public double SalaryBeforeRaise { get; set; }
        public double RaisePercent { get; set; }
        public double RaiseAmount { get; set; }
        public double NewBaseSalary { get; set; }
    }
}
