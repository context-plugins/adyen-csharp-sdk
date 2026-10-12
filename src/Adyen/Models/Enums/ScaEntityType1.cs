using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of entity you are associating the device with.
/// <para>
/// Possible values: <b>accountHolder</b>, <b>legalEntity</b> or <b>paymentInstrument</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaEntityType1>))]
public sealed record ScaEntityType1 : OpenStringEnum<ScaEntityType1>
{
    private ScaEntityType1(string value) : base(value)
    {
    }

    public static readonly ScaEntityType1 AccountHolder = new("accountHolder");

    public static readonly ScaEntityType1 LegalEntity = new("legalEntity");

    public static readonly ScaEntityType1 PaymentInstrument = new("paymentInstrument");

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
