using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record OnlineDonationSettings
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultAmount")]
    public DonationAmount? DefaultAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("donationType")]
    public DonationType1? DonationType { get; init; }

    /// <summary>
    /// The merchant accounts for this sales channel that are associated with the donation campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccounts")]
    public IReadOnlyList<string>? MerchantAccounts { get; init; }

    /// <summary>
    /// The Adyen-generated unique identifiers of stores for this sales channel that are associated with the donation campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeIds")]
    public IReadOnlyList<string>? StoreIds { get; init; }
}
