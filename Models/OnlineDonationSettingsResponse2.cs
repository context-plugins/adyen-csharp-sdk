using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The settings for online donations collected as part of the campaign.
/// </summary>
public record OnlineDonationSettingsResponse2
{
    /// <summary>
    /// The currency and fixed amounts for donations. We automatically add calculated amounts in other currencies for participating stores that use a different currency than the default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amounts")]
    public IReadOnlyList<DonationAmount>? Amounts { get; init; }

    /// <summary>
    /// The currency that was used in the request to set fixed donation amounts. Format: three-character <see href="https://docs.adyen.com/development-resources/currency-codes#currency-codes">ISO currency code</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultCurrency")]
    public string? DefaultCurrency { get; init; }

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
