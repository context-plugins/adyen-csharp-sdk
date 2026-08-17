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

    /// <summary>
    /// Contains the information required to store a payment method.
    /// </summary>
    [JsonPropertyName("paymentMethod")]
    public required PaymentMethodToStore1 PaymentMethod { get; init; }

    /// <summary>
    /// Defines a recurring payment type. Required when creating a token to store payment details.
    /// Allowed values:
    /// * <c>Subscription</c> – A transaction for a fixed or variable amount, which follows a fixed schedule.
    /// * <c>CardOnFile</c> – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.
    /// * <c>UnscheduledCardOnFile</c> – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount.
    /// </summary>
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
