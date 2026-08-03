using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason for the status of the payment instrument.
/// <para>
/// Possible values: <b>accountClosure</b>, <b>damaged</b>, <b>endOfLife</b>, <b>expired</b>, <b>lost</b>, <b>stolen</b>, <b>suspectedFraud</b>, <b>transactionRule</b>, <b>other</b>.
/// If the reason is <b>other</b>, you must also send the <c>statusComment</c> parameter describing the status change.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatusReason>))]
public sealed record StatusReason : StringEnum<StatusReason>
{
    private StatusReason(string value) : base(value)
    {
    }

    public static readonly StatusReason AccountClosure = new("accountClosure");

    public static readonly StatusReason Damaged = new("damaged");

    public static readonly StatusReason EndOfLife = new("endOfLife");

    public static readonly StatusReason Expired = new("expired");

    public static readonly StatusReason Lost = new("lost");

    public static readonly StatusReason Other = new("other");

    public static readonly StatusReason Stolen = new("stolen");

    public static readonly StatusReason SuspectedFraud = new("suspectedFraud");

    public static readonly StatusReason TransactionRule = new("transactionRule");

    public static StatusReason FromValue(string value) => FromValueCore(value);
}
