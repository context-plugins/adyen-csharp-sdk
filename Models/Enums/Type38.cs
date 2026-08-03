using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>molpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type38>))]
public sealed record Type38 : StringEnum<Type38>
{
    private Type38(string value) : base(value)
    {
    }

    public static readonly Type38 MolpayEbankingFpxMy = new("molpay_ebanking_fpx_MY");

    public static readonly Type38 MolpayEbankingTh = new("molpay_ebanking_TH");

    public static Type38 FromValue(string value) => FromValueCore(value);
}
