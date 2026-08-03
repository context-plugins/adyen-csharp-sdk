using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CapitalGrant
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount5? Amount { get; init; }

    [JsonPropertyName("balances")]
    public required Balances Balances { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty")]
    public Counterparty10? Counterparty { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fee")]
    public Fee2? Fee { get; init; }

    /// <summary>
    /// The identifier of the grant account used for the grant.
    /// </summary>
    [JsonPropertyName("grantAccountId")]
    public required string GrantAccountId { get; init; }

    /// <summary>
    /// The identifier of the grant offer that has been selected and from which the grant details will be used.
    /// </summary>
    [JsonPropertyName("grantOfferId")]
    public required string GrantOfferId { get; init; }

    /// <summary>
    /// The identifier of the grant reference.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("repayment")]
    public Repayment8? Repayment { get; init; }

    [JsonPropertyName("status")]
    public required Status18 Status { get; init; }
}
