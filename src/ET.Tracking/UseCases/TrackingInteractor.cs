namespace ET.Tracking.UseCases;

public sealed class TrackingInteractor(IExpenseRepository expenseRepository) {
    private readonly IExpenseRepository _expenseRepository = expenseRepository;

    public async Task<ExpensesResponse> GetExpensesAsync(GetExpensesRequest request) {
        ArgumentNullException.ThrowIfNull(request, nameof(request));
        var expenses = await _expenseRepository
            .GetExpenseAsync(request.UserId)
            .ConfigureAwait(false);
        return new ExpensesResponse(
            expenses,
            (uint)expenses.Count,
            (uint)expenses.Sum(e => e.Amount.Value)
        );
    }
}
