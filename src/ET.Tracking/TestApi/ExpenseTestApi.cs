using ET.Tracking.Adapters;
using ET.Tracking.UseCases;

namespace ET.Tracking.TestApi;

public sealed class ExpenseTestApi {
    private readonly TrackingController _trackingController;

    public ExpenseTestApi() =>
        _trackingController = new TrackingController(
            new TrackingInteractor(
                new FakeExpenseRepository(
                    [Expense.Create(Guid.Empty, "Test expense 1", "100", "USD", DateTime.UtcNow)]
                )
            )
        );

    public enum UserIds {
        Exists = 0,
        NotFound = 1,
    }

    public static UserIds Existing => UserIds.Exists;
    public static UserIds NotFound => UserIds.NotFound;

    public async Task<ExpensesVM> GetExpensesAsync(UserIds userId) =>
        userId switch {
            UserIds.Exists => await _trackingController
                .GetExpensesAsync(Guid.Empty.ToString())
                .ConfigureAwait(false),
            UserIds.NotFound => await _trackingController
                .GetExpensesAsync(Guid.NewGuid().ToString())
                .ConfigureAwait(false),
            _ => ExpensesVM.Empty,
        };
}
