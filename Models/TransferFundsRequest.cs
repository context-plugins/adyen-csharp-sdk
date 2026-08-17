using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransferFundsRequest
{
    /// <summary>
    /// The amount to be transferred.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount Amount { get; init; }

    /// <summary>
    /// The code of the account to which the funds are to be credited.
    /// &gt;The state of the Account Holder of this account must be Active.
    /// </summary>
    [JsonPropertyName("destinationAccountCode")]
    public required string DestinationAccountCode { get; init; }

    /// <summary>
    /// A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    /// <summary>
    /// The code of the account from which the funds are to be debited.
    /// &gt;The state of the Account Holder of this account must be Active and allow payouts.
    /// </summary>
    [JsonPropertyName("sourceAccountCode")]
    public required string SourceAccountCode { get; init; }

    /// <summary>
    /// The code related to the type of transfer being performed.
    /// &gt;The permitted codes differ for each platform account and are defined in their service level agreement.
    /// </summary>
    [JsonPropertyName("transferCode")]
    public required string TransferCode { get; init; }
}
