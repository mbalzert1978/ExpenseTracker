namespace EP.Tracking.UseCases;

internal interface IExpenseRepository
{
    Task<IReadOnlyCollection<Expense>> GetExpenseAsync(Guid userId);
}
