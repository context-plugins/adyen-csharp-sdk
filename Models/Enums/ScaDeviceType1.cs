using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of device registered.
/// <para>
/// Possible values: <b>ios</b>, <b>android</b>, <b>browser</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaDeviceType1>))]
public sealed record ScaDeviceType1 : StringEnum<ScaDeviceType1>
{
    private ScaDeviceType1(string value) : base(value)
    {
    }

    public static readonly ScaDeviceType1 Browser = new("browser");

    public static readonly ScaDeviceType1 Ios = new("ios");

    public static readonly ScaDeviceType1 Android = new("android");

    public static ScaDeviceType1 FromValue(string value) => FromValueCore(value);
}
