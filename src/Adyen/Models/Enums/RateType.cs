using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates whether the rental rate is daily or weekly.
/// * <b>additionalData key:</b> <c>carRental.rateIndicator</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RateType>))]
public sealed record RateType : OpenStringEnum<RateType>
{
    private RateType(string value) : base(value)
    {
    }

    public static readonly RateType Daily = new("daily");

    public static readonly RateType Weekly = new("weekly");

    public TResult Match<TResult>(Func<TResult> onDaily, Func<TResult> onWeekly, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Daily => onDaily(),
            _ when this == Weekly => onWeekly(),
            _ => otherwise(Value)
        };

    public void Match(Action onDaily, Action onWeekly, Action<string> otherwise)
    {
        if (this == Daily) onDaily();
        else if (this == Weekly) onWeekly();
        else otherwise(Value);
    }
}
