using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason why the web data was not provided. Possible value: <b>noOnlinePresence</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason3>))]
public sealed record Reason3 : StringEnum<Reason3>
{
    private Reason3(string value) : base(value)
    {
    }

    public static readonly Reason3 NoOnlinePresence = new("noOnlinePresence");

    public static readonly Reason3 NotCollectedDuringOnboarding = new("notCollectedDuringOnboarding");

    public static Reason3 FromValue(string value) => FromValueCore(value);
}
