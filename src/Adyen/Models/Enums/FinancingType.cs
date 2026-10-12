using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FinancingType>))]
public sealed record FinancingType : OpenStringEnum<FinancingType>
{
    private FinancingType(string value) : base(value)
    {
    }

    public static readonly FinancingType HardwareFinancing = new("hardwareFinancing");

    public static readonly FinancingType BusinessFinancing = new("businessFinancing");

    public TResult Match<TResult>(Func<TResult> onHardwareFinancing,
        Func<TResult> onBusinessFinancing,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == HardwareFinancing => onHardwareFinancing(),
            _ when this == BusinessFinancing => onBusinessFinancing(),
            _ => otherwise(Value)
        };

    public void Match(Action onHardwareFinancing, Action onBusinessFinancing, Action<string> otherwise)
    {
        if (this == HardwareFinancing) onHardwareFinancing();
        else if (this == BusinessFinancing) onBusinessFinancing();
        else otherwise(Value);
    }
}
