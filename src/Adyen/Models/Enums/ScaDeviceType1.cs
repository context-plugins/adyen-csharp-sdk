using System;
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
public sealed record ScaDeviceType1 : OpenStringEnum<ScaDeviceType1>
{
    private ScaDeviceType1(string value) : base(value)
    {
    }

    public static readonly ScaDeviceType1 Browser = new("browser");

    public static readonly ScaDeviceType1 Ios = new("ios");

    public static readonly ScaDeviceType1 Android = new("android");

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
