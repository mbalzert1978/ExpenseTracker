namespace EP.Tracking.Adapters;

internal sealed record ExpensesVM(
    IReadOnlyCollection<ExpenseVM> Expenses,
    string TotalExpenses,
    string TotalAmount
)
{
    internal static ExpensesVM Empty => new([], "0", "0");
};
