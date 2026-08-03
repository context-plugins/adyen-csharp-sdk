using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of instalment transaction.
/// Possible values:
/// * <b>Daily</b>
/// * <b>Weekly</b>
/// * <b>Monthly</b>
/// * <b>Annual</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PeriodUnit>))]
public sealed record PeriodUnit : StringEnum<PeriodUnit>
{
    private PeriodUnit(string value) : base(value)
    {
    }

    public static readonly PeriodUnit Daily = new("Daily");

    public static readonly PeriodUnit Weekly = new("Weekly");

    public static readonly PeriodUnit Monthly = new("Monthly");

    public static readonly PeriodUnit Annual = new("Annual");

    public static PeriodUnit FromValue(string value) => FromValueCore(value);
}
