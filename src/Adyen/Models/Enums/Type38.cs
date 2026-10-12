using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>molpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type38>))]
public sealed record Type38 : OpenStringEnum<Type38>
{
    private Type38(string value) : base(value)
    {
    }

    public static readonly Type38 MolpayEbankingFpxMy = new("molpay_ebanking_fpx_MY");

    public static readonly Type38 MolpayEbankingTh = new("molpay_ebanking_TH");

    public TResult Match<TResult>(Func<TResult> onMolpayEbankingFpxMy,
        Func<TResult> onMolpayEbankingTh,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MolpayEbankingFpxMy => onMolpayEbankingFpxMy(),
            _ when this == MolpayEbankingTh => onMolpayEbankingTh(),
            _ => otherwise(Value)
        };

    public void Match(Action onMolpayEbankingFpxMy, Action onMolpayEbankingTh, Action<string> otherwise)
    {
        if (this == MolpayEbankingFpxMy) onMolpayEbankingFpxMy();
        else if (this == MolpayEbankingTh) onMolpayEbankingTh();
        else otherwise(Value);
    }
}
