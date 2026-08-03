using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates whether the rental rate is daily or weekly.
/// * <b>additionalData key:</b> <c>carRental.rateIndicator</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RateType>))]
public sealed record RateType : StringEnum<RateType>
{
    private RateType(string value) : base(value)
    {
    }

    public static readonly RateType Daily = new("daily");

    public static readonly RateType Weekly = new("weekly");

    public static RateType FromValue(string value) => FromValueCore(value);
}
