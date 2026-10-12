using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DisplayTextField>))]
public sealed record DisplayTextField : OpenStringEnum<DisplayTextField>
{
    private DisplayTextField(string value) : base(value)
    {
    }

    public static readonly DisplayTextField CauseName = new("causeName");

    public static readonly DisplayTextField NonprofitName = new("nonprofitName");

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
