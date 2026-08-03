using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>NotRequired</b>
/// * <b>Immediate</b>
/// * <b>PrintEnd</b>
/// * <b>SoundEnd</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseMode>))]
public sealed record ResponseMode : StringEnum<ResponseMode>
{
    private ResponseMode(string value) : base(value)
    {
    }

    public static readonly ResponseMode NotRequired = new("NotRequired");

    public static readonly ResponseMode Immediate = new("Immediate");

    public static readonly ResponseMode PrintEnd = new("PrintEnd");

    public static readonly ResponseMode SoundEnd = new("SoundEnd");

    public static ResponseMode FromValue(string value) => FromValueCore(value);
}
