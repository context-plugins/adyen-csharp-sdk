using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Your reason for the refund request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MerchantRefundReason1>))]
public sealed record MerchantRefundReason1 : StringEnum<MerchantRefundReason1>
{
    private MerchantRefundReason1(string value) : base(value)
    {
    }

    public static readonly MerchantRefundReason1 Fraud = new("FRAUD");

    public static readonly MerchantRefundReason1 CustomerRequest = new("CUSTOMER REQUEST");

    public static readonly MerchantRefundReason1 Return = new("RETURN");

    public static readonly MerchantRefundReason1 Duplicate = new("DUPLICATE");

    public static readonly MerchantRefundReason1 Other = new("OTHER");

    public static MerchantRefundReason1 FromValue(string value) => FromValueCore(value);
}
