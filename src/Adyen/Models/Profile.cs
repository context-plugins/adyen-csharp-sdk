using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Profile
{
    /// <summary>
    /// The type of Wi-Fi network. Possible values: <b>wpa-psk</b>, <b>wpa2-psk</b>, <b>wpa-eap</b>, <b>wpa2-eap</b>.
    /// </summary>
    [JsonPropertyName("authType")]
    public required string AuthType { get; init; }

    /// <summary>
    /// Indicates whether to automatically select the best authentication method available. Does not work on older terminal models.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoWifi")]
    public bool? AutoWifi { get; init; }

    /// <summary>
    /// Use <b>infra</b> for infrastructure-based networks. This applies to most networks. Use <b>adhoc</b> only if the communication is p2p-based between base stations.
    /// </summary>
    [JsonPropertyName("bssType")]
    public required string BssType { get; init; }

    /// <summary>
    /// The channel number of the Wi-Fi network. The recommended setting is <b>0</b> for automatic channel selection.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel")]
    public int? Channel { get; init; }

    /// <summary>
    /// Indicates whether this is your preferred wireless network. If <b>true</b>, the terminal will try connecting to this network first.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultProfile")]
    public bool? DefaultProfile { get; init; }

    /// <summary>
    /// Specifies the server domain name for EAP-TLS and EAP-PEAP WiFi profiles on Android 11 and above.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domainSuffix")]
    public string? DomainSuffix { get; init; }

    /// <summary>
    /// For <c>authType</c> <b>wpa-eap</b> or <b>wpa2-eap</b>. Possible values: <b>tls</b>, <b>peap</b>, <b>leap</b>, <b>fast</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eap")]
    public string? Eap { get; init; }

    /// <summary>
    /// For <c>authType</c> <b>wpa-eap</b> or <b>wpa2-eap</b>. The root certificate from the CA that signed the certificate of the RADIUS server that is part of your wireless network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eapCaCert")]
    public File1? EapCaCert { get; init; }

    /// <summary>
    /// For <c>eap</c> <b>tls</b>. The certificate chain for the terminals. All terminals in the same network will use the same EAP client certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eapClientCert")]
    public File2? EapClientCert { get; init; }

    /// <summary>
    /// For <c>eap</c> <b>tls</b>. The RSA private key for the client. Include the lines BEGIN RSA PRIVATE KEY and END RSA PRIVATE KEY.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eapClientKey")]
    public File3? EapClientKey { get; init; }

    /// <summary>
    /// For <c>eap</c> <b>tls</b>. The password of the RSA key file, if that file is password-protected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eapClientPwd")]
    public string? EapClientPwd { get; init; }

    /// <summary>
    /// For <c>authType</c> <b>wpa-eap</b> or <b>wpa2-eap</b>. The EAP-PEAP username from your MS-CHAP account. Must match the configuration of your RADIUS server.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eapIdentity")]
    public string? EapIdentity { get; init; }

    /// <summary>
    /// For <c>eap</c> <b>tls</b>. The EAP intermediate certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eapIntermediateCert")]
    public File4? EapIntermediateCert { get; init; }

    /// <summary>
    /// For <c>eap</c> <b>peap</b>. The EAP-PEAP password from your MS-CHAP account. Must match the configuration of your RADIUS server.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eapPwd")]
    public string? EapPwd { get; init; }

    /// <summary>
    /// Indicates if the network doesn't broadcast its SSID. Mandatory for Android terminals, because these terminals rely on this setting to be able to connect to any network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hiddenSsid")]
    public bool? HiddenSsid { get; init; }

    /// <summary>
    /// Your name for the Wi-Fi profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// For <c>authType</c> <b>wpa-psk or </b>wpa2-psk**. The password to the wireless network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("psk")]
    public string? Psk { get; init; }

    /// <summary>
    /// The name of the wireless network.
    /// </summary>
    [JsonPropertyName("ssid")]
    public required string Ssid { get; init; }

    /// <summary>
    /// The type of encryption. Possible values: <b>auto</b>, <b>ccmp</b> (recommended), <b>tkip</b>
    /// </summary>
    [JsonPropertyName("wsec")]
    public required string Wsec { get; init; }
}
