using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Typographic style of the sequence of characters to display or print. Absence of this data element means the characters have normal style.
/// Possible values:
/// * <b>Bold</b>
/// * <b>Italic</b>
/// * <b>Normal</b>
/// * <b>Underline</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterStyle1>))]
public sealed record CharacterStyle1 : StringEnum<CharacterStyle1>
{
    private CharacterStyle1(string value) : base(value)
    {
    }

    public static readonly CharacterStyle1 Normal = new("Normal");

    public static readonly CharacterStyle1 Bold = new("Bold");

    public static readonly CharacterStyle1 Italic = new("Italic");

    public static readonly CharacterStyle1 Underline = new("Underline");

    public static CharacterStyle1 FromValue(string value) => FromValueCore(value);
}
