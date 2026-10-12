using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CapitalGrantAccount
{
    /// <summary>
    /// The balances of the grant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balances")]
    public IReadOnlyList<CapitalBalance>? Balances { get; init; }

    /// <summary>
    /// The unique identifier of the balance account used to fund the grant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingBalanceAccountId")]
    public string? FundingBalanceAccountId { get; init; }

    /// <summary>
    /// The identifier of the grant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The limits of the grant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limits")]
    public IReadOnlyList<GrantLimit>? Limits { get; init; }
}
