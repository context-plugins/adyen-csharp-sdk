using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The text shown on the payment terminal, asking the shopper for a donation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisplayTextField1>))]
public sealed record DisplayTextField1 : OpenStringEnum<DisplayTextField1>
{
    private DisplayTextField1(string value) : base(value)
    {
    }

    public static readonly DisplayTextField1 CauseName = new("causeName");

    public static readonly DisplayTextField1 NonprofitName = new("nonprofitName");

    public TResult Match<TResult>(Func<TResult> onCauseName,
        Func<TResult> onNonprofitName,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CauseName => onCauseName(),
            _ when this == NonprofitName => onNonprofitName(),
            _ => otherwise(Value)
        };

    public void Match(Action onCauseName, Action onNonprofitName, Action<string> otherwise)
    {
        if (this == CauseName) onCauseName();
        else if (this == NonprofitName) onNonprofitName();
        else otherwise(Value);
    }
}
