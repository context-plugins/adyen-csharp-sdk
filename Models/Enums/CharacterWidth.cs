using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>SingleWidth</b>
/// * <b>DoubleWidth</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterWidth>))]
public sealed record CharacterWidth : StringEnum<CharacterWidth>
{
    private CharacterWidth(string value) : base(value)
    {
    }

    public static readonly CharacterWidth SingleWidth = new("SingleWidth");

    public static readonly CharacterWidth DoubleWidth = new("DoubleWidth");

    public static CharacterWidth FromValue(string value) => FromValueCore(value);
}
