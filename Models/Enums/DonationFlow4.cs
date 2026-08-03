using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The interaction flow for in-person donations: complete payment for the purchase and the donation in one go, or separately.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DonationFlow4>))]
public sealed record DonationFlow4 : StringEnum<DonationFlow4>
{
    private DonationFlow4(string value) : base(value)
    {
    }

    public static readonly DonationFlow4 OneStep = new("oneStep");

    public static readonly DonationFlow4 TwoStep = new("twoStep");

    public static DonationFlow4 FromValue(string value) => FromValueCore(value);
}
