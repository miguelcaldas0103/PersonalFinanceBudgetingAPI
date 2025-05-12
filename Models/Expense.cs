using FinanceTrackingAPI.Enums;

namespace FinanceTrackingAPI.Models
{
    public class Expense
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public string Title { get; set; }
        public TypeOfExpenseEnum TypeOfExpense { get; set; }
        public DateTime DateOfExpense { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}