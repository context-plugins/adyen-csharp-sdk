using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CampaignStatusTransition>))]
public sealed record CampaignStatusTransition : OpenStringEnum<CampaignStatusTransition>
{
    private CampaignStatusTransition(string value) : base(value)
    {
    }

    public static readonly CampaignStatusTransition Activate = new("activate");

    public static readonly CampaignStatusTransition End = new("end");

    public TResult Match<TResult>(Func<TResult> onActivate, Func<TResult> onEnd, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Activate => onActivate(),
            _ when this == End => onEnd(),
            _ => otherwise(Value)
        };

    public void Match(Action onActivate, Action onEnd, Action<string> otherwise)
    {
        if (this == Activate) onActivate();
        else if (this == End) onEnd();
        else otherwise(Value);
    }
}
