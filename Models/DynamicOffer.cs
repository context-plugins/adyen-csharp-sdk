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
    /// The type of financing that the offer is for.
    /// <para>
    /// Possible values: <b>businessFinancing</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("financingType")]
    public required FinancingType2 FinancingType { get; init; }

    /// <summary>
    /// The unique identifier of the dynamic offer.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The maximum financing amount available to the account holder under this offer.
    /// </summary>
    [JsonPropertyName("maximumAmount")]
    public required Amount17 MaximumAmount { get; init; }

    /// <summary>
    /// The minimum financing amount available to the account holder under this offer.
    /// </summary>
    [JsonPropertyName("minimumAmount")]
    public required Amount17 MinimumAmount { get; init; }

    /// <summary>
    /// Contains information about the repayment configuration of the grant.
    /// </summary>
    [JsonPropertyName("repayment")]
    public required DynamicOfferRepayment2 Repayment { get; init; }

    /// <summary>
    /// The starting date and time of the offer validity period.
    /// </summary>
    [JsonPropertyName("startsAt")]
    public required DateTimeOffset StartsAt { get; init; }
}
