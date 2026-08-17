using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ValidateShopperIdRequest
{
    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    [StringLength(1000, MinimumLength = 0)]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// paymentMethod
    /// </summary>
    [JsonPropertyName("paymentMethod")]
    public required ShopperIdPaymentMethod1 PaymentMethod { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    [StringLength(300, MinimumLength = 0)]
    public string? ShopperEmail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperIP")]
    [StringLength(15, MinimumLength = 0)]
    public string? ShopperIp { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    [StringLength(256, MinimumLength = 0)]
    public string? ShopperReference { get; init; }
}
