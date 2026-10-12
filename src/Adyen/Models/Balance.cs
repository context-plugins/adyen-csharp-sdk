using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Balance
{
    /// <summary>
    /// The balance available for use.
    /// </summary>
    [JsonPropertyName("available")]
    public required long Available { get; init; }

    /// <summary>
    /// The sum of the transactions that have already been settled.
    /// </summary>
    [JsonPropertyName("balance")]
    public required long BalanceValue { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see> of the balance.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// The sum of the transactions that will be settled in the future.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pending")]
    public long? Pending { get; init; }

    /// <summary>
    /// The balance that will become the available balance after the pending balance is settled.
    /// <para>
    /// The pending available balance is equal to the lower of the following:
    /// - The <c>pending</c> balance
    /// - The <c>pending</c> balance plus the <c>available</c> balance.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pendingAvailable")]
    public long? PendingAvailable { get; init; }

    /// <summary>
    /// The balance currently held in reserve.
    /// </summary>
    [JsonPropertyName("reserved")]
    public required long Reserved { get; init; }
}
