using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AuthenticationData
{
    /// <summary>
    /// Indicates when 3D Secure authentication should be attempted. This overrides all other rules, including <see href="https://docs.adyen.com/risk-management/dynamic-3d-secure">Dynamic 3D Secure settings</see>.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>always</b>: Perform 3D Secure authentication.</description></item>
    ///   <item><description><b>never</b>: Don't perform 3D Secure authentication. If PSD2 SCA or other national regulations require authentication, the transaction gets declined.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attemptAuthentication")]
    public AttemptAuthentication? AttemptAuthentication { get; init; }

    /// <summary>
    /// Required to trigger the <see href="https://docs.adyen.com/online-payments/3d-secure/authentication-only/">authentication-only flow</see>. If set to <b>true</b>, you will only perform the 3D Secure 2 authentication, and will not proceed to the payment authorization.
    /// Default: <b>false</b>.
    /// </summary>
    [JsonPropertyName("authenticationOnly")]
    public bool? AuthenticationOnly { get; init; } = false;

    /// <summary>
    /// Object with additional parameters for the 3D Secure authentication flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestData")]
    public ThreeDsRequestData2? ThreeDsRequestData { get; init; }
}
