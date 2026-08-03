using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The result of the payment. For more information, see <see href="https://docs.adyen.com/online-payments/payment-result-codes">Result codes</see>.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>Authorised</b> – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state.</description></item>
///   <item><description><b>Received</b> – Indicates the payment request was successfully received by Adyen, and will be processed. This is the initial state for all payments.</description></item>
///   <item><description><b>Pending</b> – The payment order was successfully received but the final status of the payment is not available yet. This is common for payment methods with an asynchronous flow.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResultCode2>))]
public sealed record ResultCode2 : StringEnum<ResultCode2>
{
    private ResultCode2(string value) : base(value)
    {
    }

    public static readonly ResultCode2 Authorised = new("Authorised");

    public static readonly ResultCode2 Received = new("Received");

    public static readonly ResultCode2 Pending = new("Pending");

    public static ResultCode2 FromValue(string value) => FromValueCore(value);
}
