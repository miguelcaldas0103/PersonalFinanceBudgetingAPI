using FinanceTrackingAPI.Enums;

namespace FinanceTrackingAPI.Models
{
    public class Income
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public string Title { get; set; }
        public TypeOfIncomeEnum TypeOfIncome { get; set; }
        public DateTime DateOfIncome { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
