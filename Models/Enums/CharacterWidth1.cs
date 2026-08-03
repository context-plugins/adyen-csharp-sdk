using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Character width of the text string to display or print. Absence of this data element means the characters have normal width.
/// Possible values:
/// * <b>DoubleWidth</b>
/// * <b>SingleWidth</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterWidth1>))]
public sealed record CharacterWidth1 : StringEnum<CharacterWidth1>
{
    private CharacterWidth1(string value) : base(value)
    {
    }

    public static readonly CharacterWidth1 SingleWidth = new("SingleWidth");

    public static readonly CharacterWidth1 DoubleWidth = new("DoubleWidth");

    public static CharacterWidth1 FromValue(string value) => FromValueCore(value);
}
