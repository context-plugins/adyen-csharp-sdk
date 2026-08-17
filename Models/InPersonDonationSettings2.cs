using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The settings for in-person donations collected as part of the campaign.
/// </summary>
public record InPersonDonationSettings2
{
    /// <summary>
    /// The default amount for donations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultAmount")]
    public DonationAmount1? DefaultAmount { get; init; }

    /// <summary>
    /// The text shown on the payment terminal, either the name or the cause of the nonprofit organization.
    /// </summary>
    [JsonPropertyName("displayTextField")]
    public required DisplayTextField2 DisplayTextField { get; init; }

    /// <summary>
    /// The interaction flow for in-person donations. Possible values:
    /// <list type="bullet">
    ///   <item><description><b>oneStep</b>: The shopper presents their payment method for the payment and the donation in one go, after the donation.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>twoStep</b>: The shopper presents their payment method twice: after the payment and after the donation.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("donationFlow")]
    public required DonationFlow1 DonationFlow { get; init; }

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
