using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of Loyalty processing requested by the Sale System.
/// Possible values:
/// * <b>Allowed</b>
/// * <b>Forbidden</b>
/// * <b>Processed</b>
/// * <b>Proposed</b>
/// * <b>Required</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyHandling1>))]
public sealed record LoyaltyHandling1 : StringEnum<LoyaltyHandling1>
{
    private LoyaltyHandling1(string value) : base(value)
    {
    }

    public static readonly LoyaltyHandling1 Forbidden = new("Forbidden");

    public static readonly LoyaltyHandling1 Processed = new("Processed");

    public static readonly LoyaltyHandling1 Allowed = new("Allowed");

    public static readonly LoyaltyHandling1 Proposed = new("Proposed");

    public static readonly LoyaltyHandling1 Required = new("Required");

    public static LoyaltyHandling1 FromValue(string value) => FromValueCore(value);
}
