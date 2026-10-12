using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>genericissuer</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type31>))]
public sealed record Type31 : OpenStringEnum<Type31>
{
    private Type31(string value) : base(value)
    {
    }

    public static readonly Type31 OnlineBankingPl = new("onlineBanking_PL");

    public static readonly Type31 Eps = new("eps");

    public static readonly Type31 OnlineBankingSk = new("onlineBanking_SK");

    public static readonly Type31 OnlineBankingCz = new("onlineBanking_CZ");

    public static readonly Type31 OnlinebankingIn = new("onlinebanking_IN");

    public TResult Match<TResult>(Func<TResult> onOnlineBankingPl,
        Func<TResult> onEps,
        Func<TResult> onOnlineBankingSk,
        Func<TResult> onOnlineBankingCz,
        Func<TResult> onOnlinebankingIn,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OnlineBankingPl => onOnlineBankingPl(),
            _ when this == Eps => onEps(),
            _ when this == OnlineBankingSk => onOnlineBankingSk(),
            _ when this == OnlineBankingCz => onOnlineBankingCz(),
            _ when this == OnlinebankingIn => onOnlinebankingIn(),
            _ => otherwise(Value)
        };

    public void Match(Action onOnlineBankingPl,
        Action onEps,
        Action onOnlineBankingSk,
        Action onOnlineBankingCz,
        Action onOnlinebankingIn,
        Action<string> otherwise)
    {
        if (this == OnlineBankingPl) onOnlineBankingPl();
        else if (this == Eps) onEps();
        else if (this == OnlineBankingSk) onOnlineBankingSk();
        else if (this == OnlineBankingCz) onOnlineBankingCz();
        else if (this == OnlinebankingIn) onOnlinebankingIn();
        else otherwise(Value);
    }
}
