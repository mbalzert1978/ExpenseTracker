namespace ET.Tracking.UseCases;

public sealed record ExpensesResponse(
    IEnumerable<Expense> Expenses,
    uint TotalCount,
    uint TotalAmount
);
