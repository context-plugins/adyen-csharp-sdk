using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record GrantOffer1
{
    /// <summary>
    /// The unique identifier of the account holder to which the grant is offered.
    /// </summary>
    [JsonPropertyName("accountHolderId")]
    public required string AccountHolderId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount5? Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contractType")]
    public ContractType? ContractType { get; init; }

    /// <summary>
    /// The expiration date and time of the offer validity period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiresAt")]
    public DateTimeOffset? ExpiresAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fee")]
    public GrantOfferFee? Fee { get; init; }

    /// <summary>
    /// The unique identifier of the offer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("repayment")]
    public Repayment1? Repayment { get; init; }

    /// <summary>
    /// The starting date and time of the offer validity period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startsAt")]
    public DateTimeOffset? StartsAt { get; init; }
}
