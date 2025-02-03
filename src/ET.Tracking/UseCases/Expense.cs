namespace ET.Tracking.UseCases;

public sealed record Expense(Guid Id, string Description, Amount Amount, DateTime OccurredAt) {
    public static Expense Create(
        Guid id,
        string description,
        string amount,
        string currency,
        DateTime occurredAt
    ) {
        if (string.IsNullOrWhiteSpace(currency)) {
            throw new ArgumentException("Currency must be provided");
        }

        if (!uint.TryParse(amount, out var amountValue)) {
            throw new ArgumentException("Amount must be a valid number");
        }

        var currencyObj = Currency.Create(currency);
        var amountObj = Amount.Create(amountValue, currencyObj);
        return new(id, description, amountObj, occurredAt);
    }
}
