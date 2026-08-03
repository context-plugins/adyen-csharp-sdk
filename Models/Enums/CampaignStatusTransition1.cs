using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The desired status change. Possible values: <b>activate</b> or <b>end</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CampaignStatusTransition1>))]
public sealed record CampaignStatusTransition1 : StringEnum<CampaignStatusTransition1>
{
    private CampaignStatusTransition1(string value) : base(value)
    {
    }

    public static readonly CampaignStatusTransition1 Activate = new("activate");

    public static readonly CampaignStatusTransition1 End = new("end");

    public static CampaignStatusTransition1 FromValue(string value) => FromValueCore(value);
}
