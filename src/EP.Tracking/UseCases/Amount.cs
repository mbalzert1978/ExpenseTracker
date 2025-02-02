namespace EP.Tracking.UseCases;

internal sealed record Amount(uint Value, Currency Currency)
{
    internal static Amount Create(uint value, Currency currency)
    {
        return new(value, currency);
    }
};