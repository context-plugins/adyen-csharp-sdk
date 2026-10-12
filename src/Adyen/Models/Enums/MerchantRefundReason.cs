using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason for the refund request.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>FRAUD</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>CUSTOMER REQUEST</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>RETURN</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>DUPLICATE</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>OTHER</b></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MerchantRefundReason>))]
public sealed record MerchantRefundReason : OpenStringEnum<MerchantRefundReason>
{
    private MerchantRefundReason(string value) : base(value)
    {
    }

    public static readonly MerchantRefundReason Fraud = new("FRAUD");

    public static readonly MerchantRefundReason CustomerRequest = new("CUSTOMER REQUEST");

    public static readonly MerchantRefundReason Return = new("RETURN");

    public static readonly MerchantRefundReason Duplicate = new("DUPLICATE");

    public static readonly MerchantRefundReason Other = new("OTHER");

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
