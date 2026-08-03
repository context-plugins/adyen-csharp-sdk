using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Configuration data for 3DS payments.
/// </summary>
public record AuthenticationData1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attemptAuthentication")]
    public AttemptAuthentication? AttemptAuthentication { get; init; }

    /// <summary>
    /// Required to trigger the <see href="https://docs.adyen.com/online-payments/3d-secure/authentication-only/">authentication-only flow</see>. If set to <b>true</b>, you will only perform the 3D Secure 2 authentication, and will not proceed to the payment authorization.
    /// Default: <b>false</b>.
    /// </summary>
    [JsonPropertyName("authenticationOnly")]
    public bool? AuthenticationOnly { get; init; } = false;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestData")]
    public ThreeDsrequestData? ThreeDsrequestData { get; init; }
}
