using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CalculatedGrantOffer
{
    /// <summary>
    /// The unique identifier of the account holder that the dynamic offer is for.
    /// </summary>
    [JsonPropertyName("accountHolderId")]
    public required string AccountHolderId { get; init; }

    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }

    [JsonPropertyName("contractType")]
    public required ContractType ContractType { get; init; }

    /// <summary>
    /// The expiration date and time of the offer validity period.
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public required DateTimeOffset ExpiresAt { get; init; }

    [JsonPropertyName("fee")]
    public required GrantOfferFee Fee { get; init; }

    [JsonPropertyName("repayment")]
    public required Repayment1 Repayment { get; init; }

    /// <summary>
    /// The starting date and time of the offer validity period.
    /// </summary>
    [JsonPropertyName("startsAt")]
    public required DateTimeOffset StartsAt { get; init; }
}
