using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// 3D Secure server response. It notifies whether the specified card holder is enrolled in a 3D Secure service. Possible values:
/// <list type="bullet">
///   <item><description>Y (Authentication available)</description></item>
///   <item><description>N (Card holder not enrolled/not participating)</description></item>
///   <item><description>U (Unable to authenticate)</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThreeDDirectoryServerResponse>))]
public sealed record ThreeDDirectoryServerResponse : StringEnum<ThreeDDirectoryServerResponse>
{
    private ThreeDDirectoryServerResponse(string value) : base(value)
    {
    }

    public static readonly ThreeDDirectoryServerResponse N = new("N");

    public static readonly ThreeDDirectoryServerResponse U = new("U");

    public static readonly ThreeDDirectoryServerResponse Y = new("Y");

    public static ThreeDDirectoryServerResponse FromValue(string value) => FromValueCore(value);
}
