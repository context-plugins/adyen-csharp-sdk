using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record StoredValueLoadRequest
{
    /// <summary>
    /// The amount information for the transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount Amount { get; init; }

    /// <summary>
    /// The type of load you are trying to do, when absent we default to 'load'
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loadType")]
    public LoadType? LoadType { get; init; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The collection that contains the type of the payment method and its specific information if available
    /// </summary>
    [JsonPropertyName("paymentMethod")]
    public required IReadOnlyDictionary<string, string> PaymentMethod { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringDetailReference")]
    public string? RecurringDetailReference { get; init; }

    /// <summary>
    /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement.
    /// If you need to provide multiple references for a transaction, separate them with hyphens ("-").
    /// Maximum length: 80 characters.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    /// <summary>
    /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer.
    /// For the web service API, Adyen assumes Ecommerce shopper interaction by default.
    /// <para>
    /// This field has the following possible values:
    /// * <c>Ecommerce</c> - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request.
    /// * <c>ContAuth</c> - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment).
    /// * <c>Moto</c> - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone.
    /// * <c>POS</c> - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public ShopperInteraction? ShopperInteraction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    public string? ShopperReference { get; init; }

    /// <summary>
    /// The physical store, for which this payment is processed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    [StringLength(16, MinimumLength = 1)]
    public string? Store { get; init; }
}
