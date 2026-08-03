using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicator for the length of time since this payment method was added to this shopper's account.
/// Allowed values:
/// * notApplicable
/// * thisTransaction
/// * lessThan30Days
/// * from30To60Days
/// * moreThan60Days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentAccountIndicator>))]
public sealed record PaymentAccountIndicator : StringEnum<PaymentAccountIndicator>
{
    private PaymentAccountIndicator(string value) : base(value)
    {
    }

    public static readonly PaymentAccountIndicator NotApplicable = new("notApplicable");

    public static readonly PaymentAccountIndicator ThisTransaction = new("thisTransaction");

    public static readonly PaymentAccountIndicator LessThan30Days = new("lessThan30Days");

    public static readonly PaymentAccountIndicator From30To60Days = new("from30To60Days");

    public static readonly PaymentAccountIndicator MoreThan60Days = new("moreThan60Days");

    public static PaymentAccountIndicator FromValue(string value) => FromValueCore(value);
}
