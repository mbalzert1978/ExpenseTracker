namespace ET.Tracking.UseCases;

public sealed record Currency(string Value) {
    public static Currency Create(string value) => new(value);
}
