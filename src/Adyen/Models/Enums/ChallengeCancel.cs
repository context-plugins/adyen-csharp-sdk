using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to <see href="https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata">3D Secure API reference</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChallengeCancel>))]
public sealed record ChallengeCancel : OpenStringEnum<ChallengeCancel>
{
    private ChallengeCancel(string value) : base(value)
    {
    }

    public static readonly ChallengeCancel _01 = new("01");

    public static readonly ChallengeCancel _02 = new("02");

    public static readonly ChallengeCancel _03 = new("03");

    public static readonly ChallengeCancel _04 = new("04");

    public static readonly ChallengeCancel _05 = new("05");

    public static readonly ChallengeCancel _06 = new("06");

    public static readonly ChallengeCancel _07 = new("07");

    public TResult Match<TResult>(Func<TResult> on_01,
        Func<TResult> on_02,
        Func<TResult> on_03,
        Func<TResult> on_04,
        Func<TResult> on_05,
        Func<TResult> on_06,
        Func<TResult> on_07,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _01 => on_01(),
            _ when this == _02 => on_02(),
            _ when this == _03 => on_03(),
            _ when this == _04 => on_04(),
            _ when this == _05 => on_05(),
            _ when this == _06 => on_06(),
            _ when this == _07 => on_07(),
            _ => otherwise(Value)
        };

    public void Match(Action on_01,
        Action on_02,
        Action on_03,
        Action on_04,
        Action on_05,
        Action on_06,
        Action on_07,
        Action<string> otherwise)
    {
        if (this == _01) on_01();
        else if (this == _02) on_02();
        else if (this == _03) on_03();
        else if (this == _04) on_04();
        else if (this == _05) on_05();
        else if (this == _06) on_06();
        else if (this == _07) on_07();
        else otherwise(Value);
    }
}
