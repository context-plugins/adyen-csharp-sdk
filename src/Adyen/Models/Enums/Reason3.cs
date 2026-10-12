using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason why the web data was not provided. Possible value: <b>noOnlinePresence</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason3>))]
public sealed record Reason3 : OpenStringEnum<Reason3>
{
    private Reason3(string value) : base(value)
    {
    }

    public static readonly Reason3 NoOnlinePresence = new("noOnlinePresence");

    public static readonly Reason3 NotCollectedDuringOnboarding = new("notCollectedDuringOnboarding");

    public TResult Match<TResult>(Func<TResult> onNoOnlinePresence,
        Func<TResult> onNotCollectedDuringOnboarding,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoOnlinePresence => onNoOnlinePresence(),
            _ when this == NotCollectedDuringOnboarding => onNotCollectedDuringOnboarding(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoOnlinePresence, Action onNotCollectedDuringOnboarding, Action<string> otherwise)
    {
        if (this == NoOnlinePresence) onNoOnlinePresence();
        else if (this == NotCollectedDuringOnboarding) onNotCollectedDuringOnboarding();
        else otherwise(Value);
    }
}
