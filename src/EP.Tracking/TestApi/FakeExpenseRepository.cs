using EP.Tracking.UseCases;

namespace EP.Tracking.TestApi;

internal sealed class FakeExpenseRepository(ICollection<Expense> expenses) : IExpenseRepository
{
    public Task<IReadOnlyCollection<Expense>> GetExpenseAsync(Guid userId)
    {
        return Task.FromResult<IReadOnlyCollection<Expense>>(
            [.. expenses.Where(e => e.Id == userId)]
        );
    }
}