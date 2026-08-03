using System.Text.Json.Serialization;

namespace Adyen.Models;

public record NetworkTokenActivationDataResponse
{
    /// <summary>
    /// A block of data that contains the activation data for a network token. This <c>sdkInput</c> is required to initialize Adyen's SDK for network token provisioning.
    /// <para>
    /// For more information, see the repositories for Adyen's SDKs for network token provisioning:
    /// * <see href="https://github.com/Adyen/adyen-apple-pay-provisioning-ios">Adyen Apple Pay Provisioning SDK</see>.
    /// * <see href="https://github.com/Adyen/adyen-issuing-android">Adyen Google Wallet Provisioning SDK</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkInput")]
    public string? SdkInput { get; init; }
}
