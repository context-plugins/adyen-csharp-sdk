using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ScaEntityType>))]
public sealed record ScaEntityType : OpenStringEnum<ScaEntityType>
{
    private ScaEntityType(string value) : base(value)
    {
    }

    public static readonly ScaEntityType AccountHolder = new("accountHolder");

    public static readonly ScaEntityType LegalEntity = new("legalEntity");

    public static readonly ScaEntityType PaymentInstrument = new("paymentInstrument");

    public TResult Match<TResult>(Func<TResult> onAccountHolder,
        Func<TResult> onLegalEntity,
        Func<TResult> onPaymentInstrument,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountHolder => onAccountHolder(),
            _ when this == LegalEntity => onLegalEntity(),
            _ when this == PaymentInstrument => onPaymentInstrument(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountHolder,
        Action onLegalEntity,
        Action onPaymentInstrument,
        Action<string> otherwise)
    {
        if (this == AccountHolder) onAccountHolder();
        else if (this == LegalEntity) onLegalEntity();
        else if (this == PaymentInstrument) onPaymentInstrument();
        else otherwise(Value);
    }
}
