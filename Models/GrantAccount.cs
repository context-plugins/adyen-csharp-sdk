using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GrantAccount
{
    /// <summary>
    /// Contains the sum of the balances of all grants tracked by this grant account. The balances are separated by currency.
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
    /// The unique identifier of the grant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Contains the maximum amount of funds that you can disburse for grants.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limits")]
    public IReadOnlyList<GrantLimit>? Limits { get; init; }
}
