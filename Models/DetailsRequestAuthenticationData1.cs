using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Data for 3DS authentication.
/// </summary>
public record DetailsRequestAuthenticationData1
{
    /// <summary>
    /// Required to trigger the <see href="https://docs.adyen.com/online-payments/3d-secure/authentication-only/">authentication-only flow</see>. If set to <b>true</b>, you will only perform the 3D Secure 2 authentication, and will not proceed to the payment authorization.Default: <b>false</b>.
    /// </summary>
    [JsonPropertyName("authenticationOnly")]
    public bool? AuthenticationOnly { get; init; } = false;
}
