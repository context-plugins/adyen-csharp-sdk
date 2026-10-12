using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value5>))]
public sealed record Value5 : OpenStringEnum<Value5>
{
    private Value5(string value) : base(value)
    {
    }

    public static readonly Value5 BalanceAccount = new("balanceAccount");

    public static readonly Value5 BusinessAccount = new("businessAccount");

    public TResult Match<TResult>(Func<TResult> onBalanceAccount,
        Func<TResult> onBusinessAccount,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BalanceAccount => onBalanceAccount(),
            _ when this == BusinessAccount => onBusinessAccount(),
            _ => otherwise(Value)
        };

    public void Match(Action onBalanceAccount, Action onBusinessAccount, Action<string> otherwise)
    {
        if (this == BalanceAccount) onBalanceAccount();
        else if (this == BusinessAccount) onBusinessAccount();
        else otherwise(Value);
    }
}
