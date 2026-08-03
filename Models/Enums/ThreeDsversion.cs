using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The version of 3D Secure to use.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>2.1.0</b></description></item>
///   <item><description><b>2.2.0</b></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThreeDsversion>))]
public sealed record ThreeDsversion : StringEnum<ThreeDsversion>
{
    private ThreeDsversion(string value) : base(value)
    {
    }

    public static readonly ThreeDsversion _210 = new("2.1.0");

    public static readonly ThreeDsversion _220 = new("2.2.0");

    public static ThreeDsversion FromValue(string value) => FromValueCore(value);
}
