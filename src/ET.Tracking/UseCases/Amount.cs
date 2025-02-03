namespace ET.Tracking.UseCases;

public sealed record Amount(uint Value, Currency Currency) {
    public static Amount Create(uint value, Currency currency) => new(value, currency);
}
