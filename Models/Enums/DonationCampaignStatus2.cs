using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The current status of the donation campaign.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DonationCampaignStatus2>))]
public sealed record DonationCampaignStatus2 : StringEnum<DonationCampaignStatus2>
{
    private DonationCampaignStatus2(string value) : base(value)
    {
    }

    public static readonly DonationCampaignStatus2 Active = new("active");

    public static readonly DonationCampaignStatus2 Inactive = new("inactive");

    public static readonly DonationCampaignStatus2 Ended = new("ended");

    public static DonationCampaignStatus2 FromValue(string value) => FromValueCore(value);
}
