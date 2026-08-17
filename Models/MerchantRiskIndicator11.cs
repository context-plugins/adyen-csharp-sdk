using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Additional risk fields for 3D Secure 2.
/// &gt; For 3D Secure 2 transactions, we recommend that you include this object to increase the chances of achieving a frictionless flow.
/// </summary>
public record MerchantRiskIndicator11
{
    /// <summary>
    /// Whether the chosen delivery address is identical to the billing address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addressMatch")]
    public bool? AddressMatch { get; init; }

    /// <summary>
    /// Indicator regarding the delivery address.
    /// Allowed values:
    /// * <c>shipToBillingAddress</c>
    /// * <c>shipToVerifiedAddress</c>
    /// * <c>shipToNewAddress</c>
    /// * <c>shipToStore</c>
    /// * <c>digitalGoods</c>
    /// * <c>goodsNotShipped</c>
    /// * <c>other</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryAddressIndicator")]
    public DeliveryAddressIndicator? DeliveryAddressIndicator { get; init; }

    /// <summary>
    /// The delivery email address (for digital goods).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryEmail")]
    public string? DeliveryEmail { get; init; }

    /// <summary>
    /// For Electronic delivery, the email address to which the merchandise was delivered. Maximum length: 254 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryEmailAddress")]
    [MaxLength(254)]
    public string? DeliveryEmailAddress { get; init; }

    /// <summary>
    /// The estimated delivery time for the shopper to receive the goods.
    /// Allowed values:
    /// * <c>electronicDelivery</c>
    /// * <c>sameDayShipping</c>
    /// * <c>overnightShipping</c>
    /// * <c>twoOrMoreDaysShipping</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveryTimeframe")]
    public DeliveryTimeframe? DeliveryTimeframe { get; init; }

    /// <summary>
    /// For prepaid or gift card purchase, the purchase amount total of prepaid or gift card(s).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("giftCardAmount")]
    public Amount? GiftCardAmount { get; init; }

    /// <summary>
    /// For prepaid or gift card purchase, total count of individual prepaid or gift cards/codes purchased.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("giftCardCount")]
    public int? GiftCardCount { get; init; }

    /// <summary>
    /// For prepaid or gift card purchase, <see href="https://www.iso.org/iso-4217-currency-codes.html">ISO 4217</see> three-digit currency code of the gift card, other than those listed in Table A.5 of the EMVCo 3D Secure Protocol and Core Functions Specification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("giftCardCurr")]
    public string? GiftCardCurr { get; init; }

    /// <summary>
    /// For pre-order purchases, the expected date this product will be available to the shopper.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preOrderDate")]
    public DateTimeOffset? PreOrderDate { get; init; }

    /// <summary>
    /// Indicator for whether this transaction is for pre-ordering a product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preOrderPurchase")]
    public bool? PreOrderPurchase { get; init; }

    /// <summary>
    /// Indicates whether Cardholder is placing an order for merchandise with a future availability or release date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preOrderPurchaseInd")]
    public string? PreOrderPurchaseInd { get; init; }

    /// <summary>
    /// Indicator for whether the shopper has already purchased the same items in the past.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reorderItems")]
    public bool? ReorderItems { get; init; }

    /// <summary>
    /// Indicates whether the cardholder is reordering previously purchased merchandise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reorderItemsInd")]
    public string? ReorderItemsInd { get; init; }

    /// <summary>
    /// Indicates shipping method chosen for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipIndicator")]
    public string? ShipIndicator { get; init; }
}
