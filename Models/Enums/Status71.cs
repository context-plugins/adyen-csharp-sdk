using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the transaction.
/// <para>
///  Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>pending</b>: The transaction is still pending.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>booked</b>: The transaction has been booked to the balance account.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status71>))]
public sealed record Status71 : StringEnum<Status71>
{
    private Status71(string value) : base(value)
    {
    }

    public static readonly Status71 Booked = new("booked");

    public static readonly Status71 Pending = new("pending");

    public static Status71 FromValue(string value) => FromValueCore(value);
}
