using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record StoredPaymentMethodRequest
{
    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    [JsonPropertyName("paymentMethod")]
    public required PaymentMethodToStore PaymentMethod { get; init; }

    [JsonPropertyName("recurringProcessingModel")]
    public required RecurringProcessingModel1 RecurringProcessingModel { get; init; }

    /// <summary>
    /// The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    public string? ShopperEmail { get; init; }

    /// <summary>
    /// The IP address of a shopper.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperIP")]
    public string? ShopperIp { get; init; }

    /// <summary>
    /// A unique identifier for the shopper (for example, user ID or account ID).
    /// </summary>
    [JsonPropertyName("shopperReference")]
    public required string ShopperReference { get; init; }
}
