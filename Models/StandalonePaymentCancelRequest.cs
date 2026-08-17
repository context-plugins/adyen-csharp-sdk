using System.Text.Json.Serialization;

namespace Adyen.Models;

public record StandalonePaymentCancelRequest
{
    /// <summary>
    /// Information about your application. For more details, see <see href="https://docs.adyen.com/development-resources/building-adyen-solutions">Building Adyen solutions</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationInfo")]
    public ApplicationInfo? ApplicationInfo { get; init; }

    /// <summary>
    /// The merchant account that is used to process the payment.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_reference"><c>reference</c></see> of the payment that you want to cancel.
    /// </summary>
    [JsonPropertyName("paymentReference")]
    public required string PaymentReference { get; init; }

    /// <summary>
    /// Your reference for the cancel request. Maximum length: 80 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }
}
