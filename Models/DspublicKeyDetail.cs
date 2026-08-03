using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DspublicKeyDetail
{
    /// <summary>
    /// Card brand.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand")]
    public string? Brand { get; init; }

    /// <summary>
    /// Directory Server (DS) identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("directoryServerId")]
    public string? DirectoryServerId { get; init; }

    /// <summary>
    /// The version of the mobile 3D Secure 2 SDK. For the possible values, refer to the versions in <see href="https://github.com/Adyen/adyen-3ds2-android/releases">Adyen 3DS2 Android</see> and <see href="https://github.com/Adyen/adyen-3ds2-ios/releases">Adyen 3DS2 iOS</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fromSDKVersion")]
    public string? FromSdkversion { get; init; }

    /// <summary>
    /// Public key. The 3D Secure 2 SDK encrypts the device information by using the DS public key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; init; }

    /// <summary>
    /// Directory Server root certificates. The 3D Secure 2 SDK verifies the ACS signed content using the rootCertificates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rootCertificates")]
    public string? RootCertificates { get; init; }
}
