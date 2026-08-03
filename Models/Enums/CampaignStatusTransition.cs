using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CampaignStatusTransition>))]
public sealed record CampaignStatusTransition : StringEnum<CampaignStatusTransition>
{
    private CampaignStatusTransition(string value) : base(value)
    {
    }

    public static readonly CampaignStatusTransition Activate = new("activate");

    public static readonly CampaignStatusTransition End = new("end");

    public static CampaignStatusTransition FromValue(string value) => FromValueCore(value);
}
