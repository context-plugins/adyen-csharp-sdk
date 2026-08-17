using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicator for the length of time since this shopper account was created in the merchant's environment.
/// Allowed values:
/// * notApplicable
/// * thisTransaction
/// * lessThan30Days
/// * from30To60Days
/// * moreThan60Days, Indicator when the shopper has changed their password.
/// Allowed values:
/// * notApplicable
/// * thisTransaction
/// * lessThan30Days
/// * from30To60Days
/// * moreThan60Days, Indicator for the length of time since this payment method was added to this shopper's account.
/// Allowed values:
/// * notApplicable
/// * thisTransaction
/// * lessThan30Days
/// * from30To60Days
/// * moreThan60Days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountAgeIndicator>))]
public sealed record AccountAgeIndicator : StringEnum<AccountAgeIndicator>
{
    private AccountAgeIndicator(string value) : base(value)
    {
    }

    public static readonly AccountAgeIndicator NotApplicable = new("notApplicable");

    public static readonly AccountAgeIndicator ThisTransaction = new("thisTransaction");

    public static readonly AccountAgeIndicator LessThan30Days = new("lessThan30Days");

    public static readonly AccountAgeIndicator From30To60Days = new("from30To60Days");

    public static readonly AccountAgeIndicator MoreThan60Days = new("moreThan60Days");

    public static AccountAgeIndicator FromValue(string value) => FromValueCore(value);
}
