using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of Loyalty processing requested by the Sale System. An way to specify what the POI has to handle concerning the loyalty.
/// Possible values:
/// * <b>Allowed</b>
/// * <b>Forbidden</b>
/// * <b>Processed</b>
/// * <b>Proposed</b>
/// * <b>Required</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyHandling2>))]
public sealed record LoyaltyHandling2 : StringEnum<LoyaltyHandling2>
{
    private LoyaltyHandling2(string value) : base(value)
    {
    }

    public static readonly LoyaltyHandling2 Forbidden = new("Forbidden");

    public static readonly LoyaltyHandling2 Processed = new("Processed");

    public static readonly LoyaltyHandling2 Allowed = new("Allowed");

    public static readonly LoyaltyHandling2 Proposed = new("Proposed");

    public static readonly LoyaltyHandling2 Required = new("Required");

    public static LoyaltyHandling2 FromValue(string value) => FromValueCore(value);
}
