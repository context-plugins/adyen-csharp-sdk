using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicator when the shopper has changed their password.
/// Allowed values:
/// * notApplicable
/// * thisTransaction
/// * lessThan30Days
/// * from30To60Days
/// * moreThan60Days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PasswordChangeIndicator>))]
public sealed record PasswordChangeIndicator : StringEnum<PasswordChangeIndicator>
{
    private PasswordChangeIndicator(string value) : base(value)
    {
    }

    public static readonly PasswordChangeIndicator NotApplicable = new("notApplicable");

    public static readonly PasswordChangeIndicator ThisTransaction = new("thisTransaction");

    public static readonly PasswordChangeIndicator LessThan30Days = new("lessThan30Days");

    public static readonly PasswordChangeIndicator From30To60Days = new("from30To60Days");

    public static readonly PasswordChangeIndicator MoreThan60Days = new("moreThan60Days");

    public static PasswordChangeIndicator FromValue(string value) => FromValueCore(value);
}
