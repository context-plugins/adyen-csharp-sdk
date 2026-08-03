using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DisableRequest
{
    /// <summary>
    /// Specify the contract if you only want to disable a specific use.
    /// <para>
    /// This field can be set to one of the following values, or to their combination (comma-separated):
    /// * ONECLICK
    /// * RECURRING
    /// * PAYOUT
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contract")]
    public string? Contract { get; init; }

    /// <summary>
    /// The merchant account identifier with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The ID that uniquely identifies the recurring detail reference.
    /// <para>
    /// If it is not provided, the whole recurring contract of the <c>shopperReference</c> will be disabled, which includes all recurring details.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringDetailReference")]
    public string? RecurringDetailReference { get; init; }

    /// <summary>
    /// The ID that uniquely identifies the shopper.
    /// <para>
    /// This <c>shopperReference</c> must be the same as the <c>shopperReference</c> used in the initial payment.
    /// </para>
    /// </summary>
    [JsonPropertyName("shopperReference")]
    public required string ShopperReference { get; init; }
}
