using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values:
/// * iOS
/// * Android
/// * Web
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Channel3>))]
public sealed record Channel3 : OpenStringEnum<Channel3>
{
    private Channel3(string value) : base(value)
    {
    }

    public static readonly Channel3 IOs = new("iOS");

    public static readonly Channel3 Android = new("Android");

    public static readonly Channel3 Web = new("Web");

    public TResult Match<TResult>(Func<TResult> onIOs,
        Func<TResult> onAndroid,
        Func<TResult> onWeb,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == IOs => onIOs(),
            _ when this == Android => onAndroid(),
            _ when this == Web => onWeb(),
            _ => otherwise(Value)
        };

    public void Match(Action onIOs, Action onAndroid, Action onWeb, Action<string> otherwise)
    {
        if (this == IOs) onIOs();
        else if (this == Android) onAndroid();
        else if (this == Web) onWeb();
        else otherwise(Value);
    }
}
