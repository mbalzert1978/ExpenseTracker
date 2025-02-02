namespace EP.Tracking.Adapters;

public sealed record ExpensesVM(
    IReadOnlyCollection<ExpenseVM> Expenses,
    string TotalExpenses,
    string TotalAmount
)
{
    public static ExpensesVM Empty => new([], "0", "0");
};
