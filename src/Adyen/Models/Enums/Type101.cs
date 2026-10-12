using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of device.
/// <para>
/// Possible values: <b>ios</b>, <b>android</b>, <b>browser</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type101>))]
public sealed record Type101 : OpenStringEnum<Type101>
{
    private Type101(string value) : base(value)
    {
    }

    public static readonly Type101 Ios = new("ios");

    public static readonly Type101 Android = new("android");

    public static readonly Type101 Browser = new("browser");

    public TResult Match<TResult>(Func<TResult> onIos,
        Func<TResult> onAndroid,
        Func<TResult> onBrowser,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ios => onIos(),
            _ when this == Android => onAndroid(),
            _ when this == Browser => onBrowser(),
            _ => otherwise(Value)
        };

    public void Match(Action onIos, Action onAndroid, Action onBrowser, Action<string> otherwise)
    {
        if (this == Ios) onIos();
        else if (this == Android) onAndroid();
        else if (this == Browser) onBrowser();
        else otherwise(Value);
    }
}
