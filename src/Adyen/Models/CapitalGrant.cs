using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CapitalGrant
{
    /// <summary>
    /// An object containing the amount of the grant, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount17? Amount { get; init; }

    /// <summary>
    /// An object containing the details of the existing grant.
    /// </summary>
    [JsonPropertyName("balances")]
    public required CapitalBalance Balances { get; init; }

    /// <summary>
    /// An object containing the details of the receiving party of the grant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty")]
    public GrantCounterparty2? Counterparty { get; init; }

    /// <summary>
    /// An object containing the fee currency and value, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fee")]
    public Fee4? Fee { get; init; }

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

    /// <summary>
    /// An object containing the details of the 30-day repayment threshold.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("repayment")]
    public Repayment? Repayment { get; init; }

    /// <summary>
    /// The current status of the grant. Possible values: <b>Pending</b>, <b>Active</b>, <b>Repaid</b>, <b>WrittenOff</b>, <b>Failed</b>, <b>Revoked</b>.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status14 Status { get; init; }
}
