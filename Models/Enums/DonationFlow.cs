using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DonationFlow>))]
public sealed record DonationFlow : StringEnum<DonationFlow>
{
    private DonationFlow(string value) : base(value)
    {
    }

    public static readonly DonationFlow OneStep = new("oneStep");

    public static readonly DonationFlow TwoStep = new("twoStep");

    public static DonationFlow FromValue(string value) => FromValueCore(value);
}
