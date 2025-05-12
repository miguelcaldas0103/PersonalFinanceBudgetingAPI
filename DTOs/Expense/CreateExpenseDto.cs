using FinanceTrackingAPI.Enums;

namespace FinanceTrackingAPI.DTOs.Expense
{
    public class CreateExpenseDto
    {
        public double Amount { get; set; }
        public string Title { get; set; }
        public TypeOfExpenseEnum TypeOfExpense { get; set; }
        public DateTime DateOfExpense { get; set; }
    }
}
