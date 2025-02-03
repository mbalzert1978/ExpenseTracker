namespace ET.Tracking.UseCases;

public interface IExpenseRepository {
    public Task<IReadOnlyCollection<Expense>> GetExpenseAsync(Guid userId);
}
