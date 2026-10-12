using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The bank account type.
/// <para>
/// Possible values: <b>checking</b> or <b>savings</b>. Defaults to <b>checking</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType2>))]
public sealed record AccountType2 : OpenStringEnum<AccountType2>
{
    private AccountType2(string value) : base(value)
    {
    }

    public static readonly AccountType2 Checking = new("checking");

    public static readonly AccountType2 Savings = new("savings");

    public TResult Match<TResult>(Func<TResult> onChecking, Func<TResult> onSavings, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Checking => onChecking(),
            _ when this == Savings => onSavings(),
            _ => otherwise(Value)
        };

    public void Match(Action onChecking, Action onSavings, Action<string> otherwise)
    {
        if (this == Checking) onChecking();
        else if (this == Savings) onSavings();
        else otherwise(Value);
    }
}
