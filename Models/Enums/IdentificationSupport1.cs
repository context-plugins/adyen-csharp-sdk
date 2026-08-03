using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Support of the loyalty account identification. Allows knowing where and how you have found the loyalty account identification.
/// Possible values:
/// * <b>HybridCard</b>
/// * <b>LinkedCard</b>
/// * <b>LoyaltyCard</b>
/// * <b>NoCard</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentificationSupport1>))]
public sealed record IdentificationSupport1 : StringEnum<IdentificationSupport1>
{
    private IdentificationSupport1(string value) : base(value)
    {
    }

    public static readonly IdentificationSupport1 NoCard = new("NoCard");

    public static readonly IdentificationSupport1 LoyaltyCard = new("LoyaltyCard");

    public static readonly IdentificationSupport1 HybridCard = new("HybridCard");

    public static readonly IdentificationSupport1 LinkedCard = new("LinkedCard");

    public static IdentificationSupport1 FromValue(string value) => FromValueCore(value);
}
