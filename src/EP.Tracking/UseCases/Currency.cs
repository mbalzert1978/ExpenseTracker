namespace EP.Tracking.UseCases;

internal sealed record Currency(string Value)
{
    internal static Currency Create(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(value));
        return new(value);
    }
};