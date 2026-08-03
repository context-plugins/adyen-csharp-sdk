using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<AttemptAuthentication>))]
public sealed record AttemptAuthentication : StringEnum<AttemptAuthentication>
{
    private AttemptAuthentication(string value) : base(value)
    {
    }

    public static readonly AttemptAuthentication Always = new("always");

    public static readonly AttemptAuthentication Never = new("never");

    public static AttemptAuthentication FromValue(string value) => FromValueCore(value);
}
