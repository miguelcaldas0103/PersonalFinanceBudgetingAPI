using FinanceTrackingAPI.Enums;

namespace FinanceTrackingAPI.DTOs.Expense
{
    public class GetExpenseDto
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public string Title { get; set; }
        public TypeOfExpenseEnum TypeOfExpense { get; set; }
        public DateTime DateOfExpense { get; set; }
    }
}
