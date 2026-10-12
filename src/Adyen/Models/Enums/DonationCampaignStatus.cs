using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DonationCampaignStatus>))]
public sealed record DonationCampaignStatus : OpenStringEnum<DonationCampaignStatus>
{
    private DonationCampaignStatus(string value) : base(value)
    {
    }

    public static readonly DonationCampaignStatus Active = new("active");

    public static readonly DonationCampaignStatus Inactive = new("inactive");

    public static readonly DonationCampaignStatus Ended = new("ended");

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
