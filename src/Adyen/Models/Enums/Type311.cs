using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type311>))]
public sealed record Type311 : OpenStringEnum<Type311>
{
    private Type311(string value) : base(value)
    {
    }

    public static readonly Type311 BankAccount = new("BankAccount");

    public static readonly Type311 Document = new("Document");

    public static readonly Type311 LegalEntity = new("LegalEntity");

    public static readonly Type311 Product = new("product");

    public TResult Match<TResult>(Func<TResult> onBankAccount,
        Func<TResult> onDocument,
        Func<TResult> onLegalEntity,
        Func<TResult> onProduct,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankAccount => onBankAccount(),
            _ when this == Document => onDocument(),
            _ when this == LegalEntity => onLegalEntity(),
            _ when this == Product => onProduct(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankAccount,
        Action onDocument,
        Action onLegalEntity,
        Action onProduct,
        Action<string> otherwise)
    {
        if (this == BankAccount) onBankAccount();
        else if (this == Document) onDocument();
        else if (this == LegalEntity) onLegalEntity();
        else if (this == Product) onProduct();
        else otherwise(Value);
    }
}
