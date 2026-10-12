using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>riverty</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type49>))]
public sealed record Type49 : OpenStringEnum<Type49>
{
    private Type49(string value) : base(value)
    {
    }

    public static readonly Type49 Riverty = new("riverty");

    public static readonly Type49 RivertyAccount = new("riverty_account");

    public static readonly Type49 RivertyInstallments = new("riverty_installments");

    public static readonly Type49 SepadirectdebitRiverty = new("sepadirectdebit_riverty");

    public TResult Match<TResult>(Func<TResult> onRiverty,
        Func<TResult> onRivertyAccount,
        Func<TResult> onRivertyInstallments,
        Func<TResult> onSepadirectdebitRiverty,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Riverty => onRiverty(),
            _ when this == RivertyAccount => onRivertyAccount(),
            _ when this == RivertyInstallments => onRivertyInstallments(),
            _ when this == SepadirectdebitRiverty => onSepadirectdebitRiverty(),
            _ => otherwise(Value)
        };

    public void Match(Action onRiverty,
        Action onRivertyAccount,
        Action onRivertyInstallments,
        Action onSepadirectdebitRiverty,
        Action<string> otherwise)
    {
        if (this == Riverty) onRiverty();
        else if (this == RivertyAccount) onRivertyAccount();
        else if (this == RivertyInstallments) onRivertyInstallments();
        else if (this == SepadirectdebitRiverty) onSepadirectdebitRiverty();
        else otherwise(Value);
    }
}
