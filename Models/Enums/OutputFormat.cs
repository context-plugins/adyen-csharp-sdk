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
public sealed record OutputFormat : StringEnum<OutputFormat>
{
    private OutputFormat(string value) : base(value)
    {
    }

    public static readonly OutputFormat MessageRef = new("MessageRef");

    public static readonly OutputFormat Text = new("Text");

    public static readonly OutputFormat Xhtml = new("XHTML");

    public static readonly OutputFormat BarCode = new("BarCode");

    public static OutputFormat FromValue(string value) => FromValueCore(value);
}
