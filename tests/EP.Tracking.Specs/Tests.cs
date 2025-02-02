using EP.Tracking.TestApi;

namespace EP.Tracking.Specs;

public class Tests
{
    [Fact]
    public async Task GetExpensesAsyncWhenUserIdFoundShouldReturnExpensesVM()
    {
        ExpenseTestApi testApi = new();

        Adapters.ExpensesVM expenses = await testApi.GetExpensesAsync(ExpenseTestApi.Existing);

        Assert.NotNull(expenses);
    }
}
