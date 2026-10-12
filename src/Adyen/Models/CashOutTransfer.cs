using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CashOutTransfer
{
    /// <summary>
    /// The amount of the cashout instruction transaction, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// The reference of the cashout transfer.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The type of the cashout transfer.
    /// <para>
    /// Possible values:
    /// - <b>cashoutRepayment</b>: Corresponds to the transfer created to deduct the cashout amount after settlement.
    /// - <b>cashoutFee</b>: Corresponds to the transfer created to debit the cashout fee form the user's balance account.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type121 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
