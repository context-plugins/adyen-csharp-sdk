using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Dimensions of the 3DS2 challenge window to be displayed to the cardholder.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>01</b> - size of 250x400</description></item>
///   <item><description><b>02</b> - size of 390x400</description></item>
///   <item><description><b>03</b> - size of 500x600</description></item>
///   <item><description><b>04</b> - size of 600x400</description></item>
///   <item><description><b>05</b> - Fullscreen</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChallengeWindowSize>))]
public sealed record ChallengeWindowSize : OpenStringEnum<ChallengeWindowSize>
{
    private ChallengeWindowSize(string value) : base(value)
    {
    }

    public static readonly ChallengeWindowSize _01 = new("01");

    public static readonly ChallengeWindowSize _02 = new("02");

    public static readonly ChallengeWindowSize _03 = new("03");

    public static readonly ChallengeWindowSize _04 = new("04");

    public static readonly ChallengeWindowSize _05 = new("05");

    public TResult Match<TResult>(Func<TResult> on_01,
        Func<TResult> on_02,
        Func<TResult> on_03,
        Func<TResult> on_04,
        Func<TResult> on_05,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _01 => on_01(),
            _ when this == _02 => on_02(),
            _ when this == _03 => on_03(),
            _ when this == _04 => on_04(),
            _ when this == _05 => on_05(),
            _ => otherwise(Value)
        };

    public void Match(Action on_01, Action on_02, Action on_03, Action on_04, Action on_05, Action<string> otherwise)
    {
        if (this == _01) on_01();
        else if (this == _02) on_02();
        else if (this == _03) on_03();
        else if (this == _04) on_04();
        else if (this == _05) on_05();
        else otherwise(Value);
    }
}
