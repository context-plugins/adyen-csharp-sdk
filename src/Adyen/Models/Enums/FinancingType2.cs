using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of financing that the offer is for.
/// <para>
/// Possible values: <b>businessFinancing</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FinancingType2>))]
public sealed record FinancingType2 : OpenStringEnum<FinancingType2>
{
    private FinancingType2(string value) : base(value)
    {
    }

    public static readonly FinancingType2 HardwareFinancing = new("hardwareFinancing");

    public static readonly FinancingType2 BusinessFinancing = new("businessFinancing");

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
