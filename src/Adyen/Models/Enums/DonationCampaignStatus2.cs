using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The current status of the donation campaign.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DonationCampaignStatus2>))]
public sealed record DonationCampaignStatus2 : OpenStringEnum<DonationCampaignStatus2>
{
    private DonationCampaignStatus2(string value) : base(value)
    {
    }

    public static readonly DonationCampaignStatus2 Active = new("active");

    public static readonly DonationCampaignStatus2 Inactive = new("inactive");

    public static readonly DonationCampaignStatus2 Ended = new("ended");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onInactive,
        Func<TResult> onEnded,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Inactive => onInactive(),
            _ when this == Ended => onEnded(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onInactive, Action onEnded, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Inactive) onInactive();
        else if (this == Ended) onEnded();
        else otherwise(Value);
    }
}
