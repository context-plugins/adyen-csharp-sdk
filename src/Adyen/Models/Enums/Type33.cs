using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of entity.
/// <para>
/// Possible values: <b>LegalEntity</b>, <b>BankAccount</b>, <b>Document</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type33>))]
public sealed record Type33 : OpenStringEnum<Type33>
{
    private Type33(string value) : base(value)
    {
    }

    public static readonly Type33 BankAccount = new("BankAccount");

    public static readonly Type33 Document = new("Document");

    public static readonly Type33 LegalEntity = new("LegalEntity");

    public TResult Match<TResult>(Func<TResult> onBankAccount,
        Func<TResult> onDocument,
        Func<TResult> onLegalEntity,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankAccount => onBankAccount(),
            _ when this == Document => onDocument(),
            _ when this == LegalEntity => onLegalEntity(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankAccount, Action onDocument, Action onLegalEntity, Action<string> otherwise)
    {
        if (this == BankAccount) onBankAccount();
        else if (this == Document) onDocument();
        else if (this == LegalEntity) onLegalEntity();
        else otherwise(Value);
    }
}
