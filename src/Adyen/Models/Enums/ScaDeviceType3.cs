using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the device.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaDeviceType3>))]
public sealed record ScaDeviceType3 : OpenStringEnum<ScaDeviceType3>
{
    private ScaDeviceType3(string value) : base(value)
    {
    }

    public static readonly ScaDeviceType3 Browser = new("browser");

    public static readonly ScaDeviceType3 Ios = new("ios");

    public static readonly ScaDeviceType3 Android = new("android");

    public TResult Match<TResult>(Func<TResult> onBrowser,
        Func<TResult> onIos,
        Func<TResult> onAndroid,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Browser => onBrowser(),
            _ when this == Ios => onIos(),
            _ when this == Android => onAndroid(),
            _ => otherwise(Value)
        };

    public void Match(Action onBrowser, Action onIos, Action onAndroid, Action<string> otherwise)
    {
        if (this == Browser) onBrowser();
        else if (this == Ios) onIos();
        else if (this == Android) onAndroid();
        else otherwise(Value);
    }
}
