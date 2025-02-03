using ET.Tracking.TestApi;

namespace ET.Tracking.Specs;

public class TrackingTests {
    [Fact]
    public async Task GetExpensesAsyncWhenUserIdFoundShouldReturnExpensesVM() {
        ExpenseTestApi testApi = new();

        var expenses = await testApi.GetExpensesAsync(ExpenseTestApi.Existing);

        Assert.NotNull(expenses);
    }
}
