using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The text shown on the payment terminal, either the name or the cause of the nonprofit organization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisplayTextField2>))]
public sealed record DisplayTextField2 : OpenStringEnum<DisplayTextField2>
{
    private DisplayTextField2(string value) : base(value)
    {
    }

    public static readonly DisplayTextField2 CauseName = new("causeName");

    public static readonly DisplayTextField2 NonprofitName = new("nonprofitName");

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
