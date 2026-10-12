using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The format of the Terms of Service document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TermsOfServiceDocumentFormat>))]
public sealed record TermsOfServiceDocumentFormat : OpenStringEnum<TermsOfServiceDocumentFormat>
{
    private TermsOfServiceDocumentFormat(string value) : base(value)
    {
    }

    public static readonly TermsOfServiceDocumentFormat Json = new("JSON");

    public static readonly TermsOfServiceDocumentFormat Pdf = new("PDF");

    public static readonly TermsOfServiceDocumentFormat Txt = new("TXT");

    public TResult Match<TResult>(Func<TResult> onJson,
        Func<TResult> onPdf,
        Func<TResult> onTxt,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Json => onJson(),
            _ when this == Pdf => onPdf(),
            _ when this == Txt => onTxt(),
            _ => otherwise(Value)
        };

    public void Match(Action onJson, Action onPdf, Action onTxt, Action<string> otherwise)
    {
        if (this == Json) onJson();
        else if (this == Pdf) onPdf();
        else if (this == Txt) onTxt();
        else otherwise(Value);
    }
}
