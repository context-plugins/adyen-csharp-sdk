using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DonationCampaignStatus>))]
public sealed record DonationCampaignStatus : StringEnum<DonationCampaignStatus>
{
    private DonationCampaignStatus(string value) : base(value)
    {
    }

    public static readonly DonationCampaignStatus Active = new("active");

    public static readonly DonationCampaignStatus Inactive = new("inactive");

    public static readonly DonationCampaignStatus Ended = new("ended");

    public static DonationCampaignStatus FromValue(string value) => FromValueCore(value);
}
