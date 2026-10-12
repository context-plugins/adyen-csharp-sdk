using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Supported SDK interface types.
/// Allowed values:
/// * native
/// * html
/// * both
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SdkInterface>))]
public sealed record SdkInterface : OpenStringEnum<SdkInterface>
{
    private SdkInterface(string value) : base(value)
    {
    }

    public static readonly SdkInterface Native = new("native");

    public static readonly SdkInterface Html = new("html");

    public static readonly SdkInterface Both = new("both");

    public TResult Match<TResult>(Func<TResult> onNative,
        Func<TResult> onHtml,
        Func<TResult> onBoth,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Native => onNative(),
            _ when this == Html => onHtml(),
            _ when this == Both => onBoth(),
            _ => otherwise(Value)
        };

    public void Match(Action onNative, Action onHtml, Action onBoth, Action<string> otherwise)
    {
        if (this == Native) onNative();
        else if (this == Html) onHtml();
        else if (this == Both) onBoth();
        else otherwise(Value);
    }
}
