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

    /// <summary>
    /// The financing amount that would be paid out to your user.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// The contract type of the offer.
    /// <para>
    /// Possible values:
    /// * <b>loan</b>
    /// * <b>cashAdvance</b>
    /// </para>
    /// </summary>
    [JsonPropertyName("contractType")]
    public required ContractType ContractType { get; init; }

    /// <summary>
    /// The expiration date and time of the offer validity period.
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public required DateTimeOffset ExpiresAt { get; init; }

    /// <summary>
    /// Contains information about the fee that your user would pay for the grant.
    /// </summary>
    [JsonPropertyName("fee")]
    public required GrantOfferFee1 Fee { get; init; }

    /// <summary>
    /// Contains information about the repayment configuration of the grant.
    /// </summary>
    [JsonPropertyName("repayment")]
    public required Repayment11 Repayment { get; init; }

    /// <summary>
    /// The starting date and time of the offer validity period.
    /// </summary>
    [JsonPropertyName("startsAt")]
    public required DateTimeOffset StartsAt { get; init; }
}
