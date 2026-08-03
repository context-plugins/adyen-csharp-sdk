using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Information about your application. For more details, see <see href="https://docs.adyen.com/development-resources/building-adyen-solutions">Building Adyen solutions</see>.
/// </summary>
public record ApplicationInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenLibrary")]
    public AdyenLibrary? AdyenLibrary { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenPaymentSource")]
    public AdyenPaymentSource? AdyenPaymentSource { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalPlatform")]
    public ExternalPlatform2? ExternalPlatform { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantApplication")]
    public MerchantApplication? MerchantApplication { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDevice")]
    public MerchantDevice2? MerchantDevice { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteractionDevice")]
    public ShopperInteractionDevice2? ShopperInteractionDevice { get; init; }
}
