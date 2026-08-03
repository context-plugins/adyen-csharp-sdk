using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ScaDeviceType>))]
public sealed record ScaDeviceType : StringEnum<ScaDeviceType>
{
    private ScaDeviceType(string value) : base(value)
    {
    }

    public static readonly ScaDeviceType Browser = new("browser");

    public static readonly ScaDeviceType Ios = new("ios");

    public static readonly ScaDeviceType Android = new("android");

    public static ScaDeviceType FromValue(string value) => FromValueCore(value);
}
