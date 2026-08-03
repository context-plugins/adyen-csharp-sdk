using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The format of the Terms of Service document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TermsOfServiceDocumentFormat>))]
public sealed record TermsOfServiceDocumentFormat : StringEnum<TermsOfServiceDocumentFormat>
{
    private TermsOfServiceDocumentFormat(string value) : base(value)
    {
    }

    public static readonly TermsOfServiceDocumentFormat Json = new("JSON");

    public static readonly TermsOfServiceDocumentFormat Pdf = new("PDF");

    public static readonly TermsOfServiceDocumentFormat Txt = new("TXT");

    public static TermsOfServiceDocumentFormat FromValue(string value) => FromValueCore(value);
}
