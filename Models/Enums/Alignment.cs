using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Left</b>
/// * <b>Right</b>
/// * <b>Centred</b>
/// * <b>Justified</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Alignment>))]
public sealed record Alignment : StringEnum<Alignment>
{
    private Alignment(string value) : base(value)
    {
    }

    public static readonly Alignment Left = new("Left");

    public static readonly Alignment Right = new("Right");

    public static readonly Alignment Centred = new("Centred");

    public static readonly Alignment Justified = new("Justified");

    public static Alignment FromValue(string value) => FromValueCore(value);
}
