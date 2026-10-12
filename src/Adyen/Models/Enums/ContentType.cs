using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The content type of the tax form.
/// <para>
/// Possible values:
/// *  <b>application/pdf</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ContentType>))]
public sealed record ContentType : OpenStringEnum<ContentType>
{
    private ContentType(string value) : base(value)
    {
    }

    public static readonly ContentType ApplicationPdf = new("application/pdf");

    public TResult Match<TResult>(Func<TResult> onApplicationPdf, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ApplicationPdf => onApplicationPdf(),
            _ => otherwise(Value)
        };

    public void Match(Action onApplicationPdf, Action<string> otherwise)
    {
        if (this == ApplicationPdf) onApplicationPdf();
        else otherwise(Value);
    }
}
