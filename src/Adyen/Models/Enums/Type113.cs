using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>bankTransfer</b>: for push transfers to a transfer instrument or a bank account. The <c>category</c> must be <b>bank</b>.</description></item>
///   <item><description><b>internalTransfer</b>: for push transfers between balance accounts. The <c>category</c> must be <b>internal</b>.</description></item>
///   <item><description><b>internalDirectDebit</b>: for pull transfers (direct debits) between balance accounts. The <c>category</c> must be <b>internal</b>.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type113>))]
public sealed record Type113 : OpenStringEnum<Type113>
{
    private Type113(string value) : base(value)
    {
    }

    public static readonly Type113 BankTransfer = new("bankTransfer");

    public static readonly Type113 InternalTransfer = new("internalTransfer");

    public static readonly Type113 InternalDirectDebit = new("internalDirectDebit");

    public TResult Match<TResult>(Func<TResult> onBankTransfer,
        Func<TResult> onInternalTransfer,
        Func<TResult> onInternalDirectDebit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankTransfer => onBankTransfer(),
            _ when this == InternalTransfer => onInternalTransfer(),
            _ when this == InternalDirectDebit => onInternalDirectDebit(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankTransfer,
        Action onInternalTransfer,
        Action onInternalDirectDebit,
        Action<string> otherwise)
    {
        if (this == BankTransfer) onBankTransfer();
        else if (this == InternalTransfer) onInternalTransfer();
        else if (this == InternalDirectDebit) onInternalDirectDebit();
        else otherwise(Value);
    }
}
