using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>BarCode</b>
/// * <b>MessageRef</b>
/// * <b>Text</b>
/// * <b>XHTML</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OutputFormat2>))]
public sealed record OutputFormat2 : StringEnum<OutputFormat2>
{
    private OutputFormat2(string value) : base(value)
    {
    }

    public static readonly OutputFormat2 MessageRef = new("MessageRef");

    public static readonly OutputFormat2 Text = new("Text");

    public static readonly OutputFormat2 Xhtml = new("XHTML");

    public static readonly OutputFormat2 BarCode = new("BarCode");

    public static OutputFormat2 FromValue(string value) => FromValueCore(value);
}
