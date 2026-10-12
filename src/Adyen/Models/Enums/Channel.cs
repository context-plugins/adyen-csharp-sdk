using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the <c>sdkVersion</c> or <c>token</c>.
/// <para>
/// Possible values:
/// * <b>iOS</b>
/// * <b>Android</b>
/// * <b>Web</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Channel>))]
public sealed record Channel : OpenStringEnum<Channel>
{
    private Channel(string value) : base(value)
    {
    }

    public static readonly Channel IOs = new("iOS");

    public static readonly Channel Android = new("Android");

    public static readonly Channel Web = new("Web");

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
