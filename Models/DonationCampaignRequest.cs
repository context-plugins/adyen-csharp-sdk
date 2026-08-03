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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inPerson")]
    public InPersonDonationSettings? InPerson { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("online")]
    public OnlineDonationSettings? Online { get; init; }
}
