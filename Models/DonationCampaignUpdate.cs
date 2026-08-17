using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.AnyOf;

namespace Adyen.Models;

public record DonationCampaignUpdate
{
    /// <summary>
    /// The unique identifiers of the account holders associated with the donation campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderIds")]
    public IReadOnlyList<string?>? AccountHolderIds { get; init; }

    /// <summary>
    /// The settings for in-person donations collected as part of the campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inPerson")]
    public InPerson? InPerson { get; init; }

    /// <summary>
    /// The name of the donation campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MinLength(1)]
    public string? Name { get; init; }

    /// <summary>
    /// The settings for online donations collected as part of the campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("online")]
    public Online? Online { get; init; }
}
