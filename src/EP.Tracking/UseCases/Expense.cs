namespace EP.Tracking.UseCases;

internal sealed record Expense(Guid Id, string Description, Amount Amount, DateTime OccurredAt)
{
    internal static Expense Create(
        Guid id,
        string description,
        string amount,
        string currency,
        DateTime occurredAt
    )
    {
        if (string.IsNullOrWhiteSpace(currency))
        {
            throw new ArgumentException("Currency must be provided");
        }

        if (!uint.TryParse(amount, out uint amountValue))
        {
            throw new ArgumentException("Amount must be a valid number");
        }

        Currency currencyObj = Currency.Create(currency);
        Amount amountObj = Amount.Create(amountValue, currencyObj);
        return new(id, description, amountObj, occurredAt);
    }
};