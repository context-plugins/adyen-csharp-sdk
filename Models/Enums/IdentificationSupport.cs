using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Support of the loyalty account identification. Allows knowing where and how you have found the loyalty account identification.
/// Possible values:
/// * <b>NoCard</b>
/// * <b>LoyaltyCard</b>
/// * <b>HybridCard</b>
/// * <b>LinkedCard</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentificationSupport>))]
public sealed record IdentificationSupport : StringEnum<IdentificationSupport>
{
    private IdentificationSupport(string value) : base(value)
    {
    }

    public static readonly IdentificationSupport NoCard = new("NoCard");

    public static readonly IdentificationSupport LoyaltyCard = new("LoyaltyCard");

    public static readonly IdentificationSupport HybridCard = new("HybridCard");

    public static readonly IdentificationSupport LinkedCard = new("LinkedCard");

    public static IdentificationSupport FromValue(string value) => FromValueCore(value);
}
