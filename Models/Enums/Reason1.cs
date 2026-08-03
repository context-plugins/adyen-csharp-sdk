using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason why the web data was not provided. Possible value: <b>noOnlinePresence</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason1>))]
public sealed record Reason1 : StringEnum<Reason1>
{
    private Reason1(string value) : base(value)
    {
    }

    public static readonly Reason1 NoOnlinePresence = new("noOnlinePresence");

    public static readonly Reason1 NotCollectedDuringOnboarding = new("notCollectedDuringOnboarding");

    public static Reason1 FromValue(string value) => FromValueCore(value);
}
