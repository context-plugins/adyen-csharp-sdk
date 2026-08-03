using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of instalment transaction.
/// Possible values:
/// * <b>Annual</b>
/// * <b>Daily</b>
/// * <b>Monthly</b>
/// * <b>Weekly</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PeriodUnit1>))]
public sealed record PeriodUnit1 : StringEnum<PeriodUnit1>
{
    private PeriodUnit1(string value) : base(value)
    {
    }

    public static readonly PeriodUnit1 Daily = new("Daily");

    public static readonly PeriodUnit1 Weekly = new("Weekly");

    public static readonly PeriodUnit1 Monthly = new("Monthly");

    public static readonly PeriodUnit1 Annual = new("Annual");

    public static PeriodUnit1 FromValue(string value) => FromValueCore(value);
}
