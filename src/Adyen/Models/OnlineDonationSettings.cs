using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record OnlineDonationSettings
{
    /// <summary>
    /// The default amount for donations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultAmount")]
    public DonationAmount1? DefaultAmount { get; init; }

    /// <summary>
    /// The type of donation to collect from the shopper. Possible values:
    /// <list type="bullet">
    ///   <item><description><b>roundup</b>: Round up the transaction amount.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>fixedAmounts</b>: Choose a fixed amount.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>fixedAmountsRoundup</b>: Round up, or choose a fixed amount.</description></item>
    /// </list>
    /// </summary>
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
