using System.Globalization;

using EP.Tracking.UseCases;

namespace EP.Tracking.Adapters;

internal sealed class TrackingController(TrackingInteractor trackingInteractor)
{
    private readonly TrackingInteractor _trackingInteractor = trackingInteractor;

    internal async Task<ExpensesVM> GetExpensesAsync(string userId)
    {
        if (!Guid.TryParse(userId, out Guid userIdGuid))
        {
            return ExpensesVM.Empty;
        }

        ExpensesResponse response = await _trackingInteractor
            .GetExpensesAsync(new(userIdGuid))
            .ConfigureAwait(false);
        return new ExpensesVM(
            [
                .. response.Expenses.Select(expense => new ExpenseVM(
                    expense.Id.ToString(),
                    expense.Amount.ToString(),
                    expense.Description,
                    expense.OccurredAt
                )),
            ],
            response.TotalCount.ToString(CultureInfo.InvariantCulture),
            response.TotalAmount.ToString(CultureInfo.InvariantCulture)
        );
    }
}
