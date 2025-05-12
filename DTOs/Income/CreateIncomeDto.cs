using FinanceTrackingAPI.Enums;

namespace FinanceTrackingAPI.DTOs.Income
{
    public class CreateIncomeDto
    {
        public double Amount { get; set; }
        public string Title { get; set; }
        public TypeOfIncomeEnum TypeOfIncome { get; set; }
        public DateTime DateOfIncome { get; set; }
    }
}
