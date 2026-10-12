using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Information about your application. For more details, see <see href="https://docs.adyen.com/development-resources/building-adyen-solutions">Building Adyen solutions</see>.
/// </summary>
public record ApplicationInfo
{
    /// <summary>
    /// Adyen-developed software, such as libraries and plugins, used to interact with the Adyen API. For example, Magento plugin, Java API library, etc.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenLibrary")]
    public CommonField4? AdyenLibrary { get; init; }

    /// <summary>
    /// Adyen-developed software to get payment details. For example, Checkout SDK, Secured Fields SDK, etc.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenPaymentSource")]
    public CommonField1? AdyenPaymentSource { get; init; }

    /// <summary>
    /// Third-party developed platform used to initiate payment requests. For example, Magento, Zuora, etc.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalPlatform")]
    public ExternalPlatform? ExternalPlatform { get; init; }

    /// <summary>
    /// Merchant developed software, such as cashier application, used to interact with the Adyen API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantApplication")]
    public CommonField2? MerchantApplication { get; init; }

    /// <summary>
    /// Merchant device information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDevice")]
    public MerchantDevice? MerchantDevice { get; init; }

    /// <summary>
    /// Shopper interaction device, such as terminal, mobile device or web browser, to initiate payment requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteractionDevice")]
    public ShopperInteractionDevice? ShopperInteractionDevice { get; init; }
}
