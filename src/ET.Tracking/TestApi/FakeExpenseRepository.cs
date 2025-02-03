using ET.Tracking.UseCases;

namespace ET.Tracking.TestApi;

public sealed class FakeExpenseRepository(ICollection<Expense> expenses) : IExpenseRepository {
    public Task<IReadOnlyCollection<Expense>> GetExpenseAsync(Guid userId) => Task.FromResult<IReadOnlyCollection<Expense>>(
            [.. expenses.Where(e => e.Id == userId)]
        );
}
