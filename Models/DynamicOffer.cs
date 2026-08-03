using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record DynamicOffer
{
    /// <summary>
    /// The unique identifier of the account holder that the dynamic offer is for.
    /// </summary>
    [JsonPropertyName("accountHolderId")]
    public required string AccountHolderId { get; init; }

    [JsonPropertyName("contractType")]
    public required ContractType ContractType { get; init; }

    /// <summary>
    /// The expiration date and time of the offer validity period.
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public required DateTimeOffset ExpiresAt { get; init; }

    [JsonPropertyName("financingType")]
    public required FinancingType2 FinancingType { get; init; }

    /// <summary>
    /// The unique identifier of the dynamic offer.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("maximumAmount")]
    public required MaximumAmount MaximumAmount { get; init; }

    [JsonPropertyName("minimumAmount")]
    public required MinimumAmount MinimumAmount { get; init; }

    [JsonPropertyName("repayment")]
    public required DynamicOfferRepayment Repayment { get; init; }

    /// <summary>
    /// The starting date and time of the offer validity period.
    /// </summary>
    [JsonPropertyName("startsAt")]
    public required DateTimeOffset StartsAt { get; init; }
}
