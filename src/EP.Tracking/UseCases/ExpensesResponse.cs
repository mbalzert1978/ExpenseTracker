namespace EP.Tracking.UseCases;

internal sealed record ExpensesResponse(
    IEnumerable<Expense> Expenses,
    uint TotalCount,
    uint TotalAmount
);