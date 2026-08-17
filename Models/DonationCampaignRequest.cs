using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DonationCampaignRequest
{
    /// <summary>
    /// The unique identifiers of the account holders associated with the donation campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderIds")]
    public IReadOnlyList<string>? AccountHolderIds { get; init; }

    /// <summary>
    /// The settings for in-person donations collected as part of the campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inPerson")]
    public InPersonDonationSettings2? InPerson { get; init; }

    /// <summary>
    /// The name of the donation campaign.
    /// </summary>
    [JsonPropertyName("name")]
    [MinLength(1)]
    public required string Name { get; init; }

    /// <summary>
    /// The unique identifier of the nonprofit cause that the campaign supports.
    /// </summary>
    [JsonPropertyName("nonprofitCauseId")]
    [MinLength(1)]
    public required string NonprofitCauseId { get; init; }

    /// <summary>
    /// The settings for online donations collected as part of the campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("online")]
    public OnlineDonationSettings2? Online { get; init; }
}
