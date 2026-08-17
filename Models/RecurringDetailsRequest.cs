using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RecurringDetailsRequest
{
    /// <summary>
    /// The merchant account identifier you want to process the (transaction) request with.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// A container for the type of a recurring contract to be retrieved.
    /// <para>
    /// The contract value needs to match the contract value submitted in the payment transaction used to create a recurring contract.
    /// However, if <c>ONECLICK,RECURRING</c> is the original contract definition in the initial payment, then <c>contract</c> should take either <c>ONECLICK</c> or <c>RECURRING</c>, depending on whether or not you want the shopper to enter their card's security code when they finalize their purchase.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring")]
    public Recurring? Recurring { get; init; }

    /// <summary>
    /// The reference you use to uniquely identify the shopper (e.g. user ID or account ID).
    /// </summary>
    [JsonPropertyName("shopperReference")]
    public required string ShopperReference { get; init; }
}
