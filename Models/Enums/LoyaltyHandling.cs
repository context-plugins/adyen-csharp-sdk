using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Forbidden</b>
/// * <b>Processed</b>
/// * <b>Allowed</b>
/// * <b>Proposed</b>
/// * <b>Required</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyHandling>))]
public sealed record LoyaltyHandling : StringEnum<LoyaltyHandling>
{
    private LoyaltyHandling(string value) : base(value)
    {
    }

    public static readonly LoyaltyHandling Forbidden = new("Forbidden");

    public static readonly LoyaltyHandling Processed = new("Processed");

    public static readonly LoyaltyHandling Allowed = new("Allowed");

    public static readonly LoyaltyHandling Proposed = new("Proposed");

    public static readonly LoyaltyHandling Required = new("Required");

    public static LoyaltyHandling FromValue(string value) => FromValueCore(value);
}
