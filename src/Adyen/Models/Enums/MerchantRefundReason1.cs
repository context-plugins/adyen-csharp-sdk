using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Your reason for the refund request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MerchantRefundReason1>))]
public sealed record MerchantRefundReason1 : OpenStringEnum<MerchantRefundReason1>
{
    private MerchantRefundReason1(string value) : base(value)
    {
    }

    public static readonly MerchantRefundReason1 Fraud = new("FRAUD");

    public static readonly MerchantRefundReason1 CustomerRequest = new("CUSTOMER REQUEST");

    public static readonly MerchantRefundReason1 Return = new("RETURN");

    public static readonly MerchantRefundReason1 Duplicate = new("DUPLICATE");

    public static readonly MerchantRefundReason1 Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onFraud,
        Func<TResult> onCustomerRequest,
        Func<TResult> onReturn,
        Func<TResult> onDuplicate,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Fraud => onFraud(),
            _ when this == CustomerRequest => onCustomerRequest(),
            _ when this == Return => onReturn(),
            _ when this == Duplicate => onDuplicate(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onFraud,
        Action onCustomerRequest,
        Action onReturn,
        Action onDuplicate,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Fraud) onFraud();
        else if (this == CustomerRequest) onCustomerRequest();
        else if (this == Return) onReturn();
        else if (this == Duplicate) onDuplicate();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
