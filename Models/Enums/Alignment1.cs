using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Alignment of the text string on the display line or print line. Absence of this data element means the characters have normal alignment.
/// Possible values:
/// * <b>Centred</b>
/// * <b>Justified</b>
/// * <b>Left</b>
/// * <b>Right</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Alignment1>))]
public sealed record Alignment1 : StringEnum<Alignment1>
{
    private Alignment1(string value) : base(value)
    {
    }

    public static readonly Alignment1 Left = new("Left");

    public static readonly Alignment1 Right = new("Right");

    public static readonly Alignment1 Centred = new("Centred");

    public static readonly Alignment1 Justified = new("Justified");

    public static Alignment1 FromValue(string value) => FromValueCore(value);
}
