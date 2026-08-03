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
public sealed record ContentType : StringEnum<ContentType>
{
    private ContentType(string value) : base(value)
    {
    }

    public static readonly ContentType ApplicationPdf = new("application/pdf");

    public static ContentType FromValue(string value) => FromValueCore(value);
}
