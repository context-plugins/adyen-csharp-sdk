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
public sealed record MerchantRefundReason : StringEnum<MerchantRefundReason>
{
    private MerchantRefundReason(string value) : base(value)
    {
    }

    public static readonly MerchantRefundReason Fraud = new("FRAUD");

    public static readonly MerchantRefundReason CustomerRequest = new("CUSTOMER REQUEST");

    public static readonly MerchantRefundReason Return = new("RETURN");

    public static readonly MerchantRefundReason Duplicate = new("DUPLICATE");

    public static readonly MerchantRefundReason Other = new("OTHER");

    public static MerchantRefundReason FromValue(string value) => FromValueCore(value);
}
