using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Format of the content to display or print. Display or print device function.
/// Possible values:
/// * <b>MessageRef</b>
/// * <b>Text</b>
/// * <b>XHTML</b>
/// * <b>BarCode</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OutputFormat>))]
public sealed record OutputFormat : OpenStringEnum<OutputFormat>
{
    private OutputFormat(string value) : base(value)
    {
    }

    public static readonly OutputFormat MessageRef = new("MessageRef");

    public static readonly OutputFormat Text = new("Text");

    public static readonly OutputFormat Xhtml = new("XHTML");

    public static readonly OutputFormat BarCode = new("BarCode");

    public TResult Match<TResult>(Func<TResult> onMessageRef,
        Func<TResult> onText,
        Func<TResult> onXhtml,
        Func<TResult> onBarCode,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MessageRef => onMessageRef(),
            _ when this == Text => onText(),
            _ when this == Xhtml => onXhtml(),
            _ when this == BarCode => onBarCode(),
            _ => otherwise(Value)
        };

    public void Match(Action onMessageRef, Action onText, Action onXhtml, Action onBarCode, Action<string> otherwise)
    {
        if (this == MessageRef) onMessageRef();
        else if (this == Text) onText();
        else if (this == Xhtml) onXhtml();
        else if (this == BarCode) onBarCode();
        else otherwise(Value);
    }
}
