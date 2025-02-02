namespace EP.Tracking.UseCases;

internal sealed record Expense(Guid Id, string Description, Amount Amount, DateTime OccurredAt);