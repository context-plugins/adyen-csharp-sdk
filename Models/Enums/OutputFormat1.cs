using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Format of the content to display or print.
/// Possible values:
/// * <b>BarCode</b>
/// * <b>MessageRef</b>
/// * <b>Text</b>
/// * <b>XHTML</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OutputFormat1>))]
public sealed record OutputFormat1 : StringEnum<OutputFormat1>
{
    private OutputFormat1(string value) : base(value)
    {
    }

    public static readonly OutputFormat1 MessageRef = new("MessageRef");

    public static readonly OutputFormat1 Text = new("Text");

    public static readonly OutputFormat1 Xhtml = new("XHTML");

    public static readonly OutputFormat1 BarCode = new("BarCode");

    public static OutputFormat1 FromValue(string value) => FromValueCore(value);
}
