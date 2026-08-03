using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicator for the length of time since the shopper's account was last updated.
/// Allowed values:
/// * thisTransaction
/// * lessThan30Days
/// * from30To60Days
/// * moreThan60Days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountChangeIndicator>))]
public sealed record AccountChangeIndicator : StringEnum<AccountChangeIndicator>
{
    private AccountChangeIndicator(string value) : base(value)
    {
    }

    public static readonly AccountChangeIndicator ThisTransaction = new("thisTransaction");

    public static readonly AccountChangeIndicator LessThan30Days = new("lessThan30Days");

    public static readonly AccountChangeIndicator From30To60Days = new("from30To60Days");

    public static readonly AccountChangeIndicator MoreThan60Days = new("moreThan60Days");

    public static AccountChangeIndicator FromValue(string value) => FromValueCore(value);
}
