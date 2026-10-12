using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Books the amount left over after currency conversion to the specified balance account.
/// <para>
/// Possible values: <b>addToLiableAccount</b>, <b>addToOneBalanceAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Remainder>))]
public sealed record Remainder : OpenStringEnum<Remainder>
{
    private Remainder(string value) : base(value)
    {
    }

    public static readonly Remainder AddToLiableAccount = new("addToLiableAccount");

    public static readonly Remainder AddToOneBalanceAccount = new("addToOneBalanceAccount");

    public TResult Match<TResult>(Func<TResult> onAddToLiableAccount,
        Func<TResult> onAddToOneBalanceAccount,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AddToLiableAccount => onAddToLiableAccount(),
            _ when this == AddToOneBalanceAccount => onAddToOneBalanceAccount(),
            _ => otherwise(Value)
        };

    public void Match(Action onAddToLiableAccount, Action onAddToOneBalanceAccount, Action<string> otherwise)
    {
        if (this == AddToLiableAccount) onAddToLiableAccount();
        else if (this == AddToOneBalanceAccount) onAddToOneBalanceAccount();
        else otherwise(Value);
    }
}
