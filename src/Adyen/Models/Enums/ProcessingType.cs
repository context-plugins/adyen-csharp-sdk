using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transactions processed over this payment method.
///  Allowed values:
/// - <b>pos</b> for in-person payments.
/// - <b>billpay</b> for subscription payments, both the initial payment and the later recurring payments. These transactions have <c>recurringProcessingModel</c> <b>Subscription</b>.
/// - <b>ecom</b> for all other card not present transactions. This includes non-recurring transactions and transactions with <c>recurringProcessingModel</c> <b>CardOnFile</b> or <b>UnscheduledCardOnFile</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProcessingType>))]
public sealed record ProcessingType : OpenStringEnum<ProcessingType>
{
    private ProcessingType(string value) : base(value)
    {
    }

    public static readonly ProcessingType Billpay = new("billpay");

    public static readonly ProcessingType Ecom = new("ecom");

    public static readonly ProcessingType Pos = new("pos");

    public TResult Match<TResult>(Func<TResult> onBillpay,
        Func<TResult> onEcom,
        Func<TResult> onPos,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Billpay => onBillpay(),
            _ when this == Ecom => onEcom(),
            _ when this == Pos => onPos(),
            _ => otherwise(Value)
        };

    public void Match(Action onBillpay, Action onEcom, Action onPos, Action<string> otherwise)
    {
        if (this == Billpay) onBillpay();
        else if (this == Ecom) onEcom();
        else if (this == Pos) onPos();
        else otherwise(Value);
    }
}
