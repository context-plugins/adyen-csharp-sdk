using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record InPersonDonationSettings
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultAmount")]
    public DonationAmount? DefaultAmount { get; init; }

    [JsonPropertyName("displayTextField")]
    public required DisplayTextField2 DisplayTextField { get; init; }

    [JsonPropertyName("donationFlow")]
    public required DonationFlow1 DonationFlow { get; init; }

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
    /// Required if <c>donationFlow</c> is set to <b>twoStep</b>. The time, in milliseconds, that the terminal waits for the shopper to present their card. Defaults to <b>10000</b> (10 seconds). Range: 5000 to 15000.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("presentCardTimeoutMs")]
    public long? PresentCardTimeoutMs { get; init; }

    /// <summary>
    /// The time, in milliseconds, that the terminal waits for the shopper to make a selection on the donation screen. Defaults to <b>10000</b> (10 seconds). Range: 5000 to 15000.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("promptTimeoutMs")]
    public long? PromptTimeoutMs { get; init; }

    /// <summary>
    /// The Adyen-generated unique identifiers of stores for this sales channel that are associated with the donation campaign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeIds")]
    public IReadOnlyList<string>? StoreIds { get; init; }
}
