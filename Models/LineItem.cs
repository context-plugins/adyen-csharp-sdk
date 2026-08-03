using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LineItem
{
    /// <summary>
    /// Item amount excluding the tax, in <see href="https://docs.adyen.com/development-resources/currency-codes/#minor-units">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountExcludingTax")]
    public long? AmountExcludingTax { get; init; }

    /// <summary>
    /// Item amount including the tax, in <see href="https://docs.adyen.com/development-resources/currency-codes/#minor-units">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountIncludingTax")]
    public long? AmountIncludingTax { get; init; }

    /// <summary>
    /// Brand of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand")]
    public string? Brand { get; init; }

    /// <summary>
    /// Color of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color")]
    public string? Color { get; init; }

    /// <summary>
    /// Description of the line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(10000)]
    public string? Description { get; init; }

    /// <summary>
    /// ID of the line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Link to the picture of the purchased item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("imageUrl")]
    public string? ImageUrl { get; init; }

    /// <summary>
    /// Item category, used by the payment methods PayPal and Ratepay.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("itemCategory")]
    public string? ItemCategory { get; init; }

    /// <summary>
    /// Manufacturer of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; init; }

    /// <summary>
    /// Marketplace seller id.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("marketplaceSellerId")]
    public string? MarketplaceSellerId { get; init; }

    /// <summary>
    /// Link to the purchased item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productUrl")]
    public string? ProductUrl { get; init; }

    /// <summary>
    /// Number of items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity")]
    public long? Quantity { get; init; }

    /// <summary>
    /// Email associated with the given product in the basket (usually in electronic gift cards).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("receiverEmail")]
    public string? ReceiverEmail { get; init; }

    /// <summary>
    /// Shipping company handling the return of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnShippingCompany")]
    public string? ReturnShippingCompany { get; init; }

    /// <summary>
    /// Tracking number for the return of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnTrackingNumber")]
    public string? ReturnTrackingNumber { get; init; }

    /// <summary>
    /// Tracking URI for the return of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnTrackingUri")]
    public string? ReturnTrackingUri { get; init; }

    /// <summary>
    /// Shipping company handling the delivery of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingCompany")]
    public string? ShippingCompany { get; init; }

    /// <summary>
    /// Shipping method used to deliver the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingMethod")]
    public string? ShippingMethod { get; init; }

    /// <summary>
    /// Size of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("size")]
    public string? Size { get; init; }

    /// <summary>
    /// Stock keeping unit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sku")]
    public string? Sku { get; init; }

    /// <summary>
    /// Tax amount, in <see href="https://docs.adyen.com/development-resources/currency-codes/#minor-units">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxAmount")]
    public long? TaxAmount { get; init; }

    /// <summary>
    /// Tax percentage, represented as a <see href="https://en.wikipedia.org/wiki/Basis_point">basis point</see> integer. For example:
    ///  - <b>530</b> for 5.3% (five point three percent)
    ///  - <b>2100</b> for 21% (twenty-one percent)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxPercentage")]
    public long? TaxPercentage { get; init; }

    /// <summary>
    /// Tracking number for the delivery of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trackingNumber")]
    public string? TrackingNumber { get; init; }

    /// <summary>
    /// Tracking URI for the delivery of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trackingUri")]
    public string? TrackingUri { get; init; }

    /// <summary>
    /// Universal Product Code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upc")]
    public string? Upc { get; init; }
}
