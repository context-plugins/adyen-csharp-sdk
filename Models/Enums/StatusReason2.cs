using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason for updating the status of the payment instrument.
/// <para>
/// Possible values: <b>lost</b>, <b>stolen</b>, <b>damaged</b>, <b>suspectedFraud</b>, <b>expired</b>, <b>endOfLife</b>, <b>accountClosure</b>, <b>other</b>.
/// If the reason is <b>other</b>, you must also send the <c>statusComment</c> parameter describing the status change.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatusReason2>))]
public sealed record StatusReason2 : StringEnum<StatusReason2>
{
    private StatusReason2(string value) : base(value)
    {
    }

    public static readonly StatusReason2 AccountClosure = new("accountClosure");

    public static readonly StatusReason2 Damaged = new("damaged");

    public static readonly StatusReason2 EndOfLife = new("endOfLife");

    public static readonly StatusReason2 Expired = new("expired");

    public static readonly StatusReason2 Lost = new("lost");

    public static readonly StatusReason2 Other = new("other");

    public static readonly StatusReason2 Stolen = new("stolen");

    public static readonly StatusReason2 SuspectedFraud = new("suspectedFraud");

    public static readonly StatusReason2 TransactionRule = new("transactionRule");

    public static StatusReason2 FromValue(string value) => FromValueCore(value);
}
