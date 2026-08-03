using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the device.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaDeviceType3>))]
public sealed record ScaDeviceType3 : StringEnum<ScaDeviceType3>
{
    private ScaDeviceType3(string value) : base(value)
    {
    }

    public static readonly ScaDeviceType3 Browser = new("browser");

    public static readonly ScaDeviceType3 Ios = new("ios");

    public static readonly ScaDeviceType3 Android = new("android");

    public static ScaDeviceType3 FromValue(string value) => FromValueCore(value);
}
