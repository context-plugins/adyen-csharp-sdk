using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates where the funds used for the transfer originated. Possible values are:
/// - <b>DEBIT</b> for card-to-card transfers.
/// - <b>DEPOSIT_ACCOUNT</b> for wallet-to-card transfers.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SourceOfFunds>))]
public sealed record SourceOfFunds : OpenStringEnum<SourceOfFunds>
{
    private SourceOfFunds(string value) : base(value)
    {
    }

    public static readonly SourceOfFunds Debit = new("DEBIT");

    public static readonly SourceOfFunds DepositAccount = new("DEPOSIT_ACCOUNT");

    public TResult Match<TResult>(Func<TResult> onDebit,
        Func<TResult> onDepositAccount,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Debit => onDebit(),
            _ when this == DepositAccount => onDepositAccount(),
            _ => otherwise(Value)
        };

    public void Match(Action onDebit, Action onDepositAccount, Action<string> otherwise)
    {
        if (this == Debit) onDebit();
        else if (this == DepositAccount) onDepositAccount();
        else otherwise(Value);
    }
}
