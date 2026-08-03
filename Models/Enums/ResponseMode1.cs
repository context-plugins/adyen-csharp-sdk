using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Message response awaited by the initiator of the Request. Allows various types and synchronisation of requests for Print or Sound.
/// Possible values:
/// * <b>Immediate</b>
/// * <b>NotRequired</b>
/// * <b>PrintEnd</b>
/// * <b>SoundEnd</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseMode1>))]
public sealed record ResponseMode1 : StringEnum<ResponseMode1>
{
    private ResponseMode1(string value) : base(value)
    {
    }

    public static readonly ResponseMode1 NotRequired = new("NotRequired");

    public static readonly ResponseMode1 Immediate = new("Immediate");

    public static readonly ResponseMode1 PrintEnd = new("PrintEnd");

    public static readonly ResponseMode1 SoundEnd = new("SoundEnd");

    public static ResponseMode1 FromValue(string value) => FromValueCore(value);
}
