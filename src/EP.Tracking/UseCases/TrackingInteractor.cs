namespace EP.Tracking.UseCases;

internal sealed class TrackingInteractor(IExpenseRepository expenseRepository)
{
    private readonly IExpenseRepository _expenseRepository = expenseRepository;

    internal async Task<ExpensesResponse> GetExpensesAsync(GetExpensesRequest request)
    {
        IReadOnlyCollection<Expense> expenses = await _expenseRepository.GetExpenseAsync(request.UserId).ConfigureAwait(false);

        return new ExpensesResponse(
            expenses,
            (uint)expenses.Count,
            (uint)expenses.Sum(e => e.Amount.Value)
        );

    }
}
