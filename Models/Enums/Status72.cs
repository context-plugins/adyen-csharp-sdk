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
[JsonConverter(typeof(StringEnumConverter<Status72>))]
public sealed record Status72 : StringEnum<Status72>
{
    private Status72(string value) : base(value)
    {
    }

    public static readonly Status72 Booked = new("booked");

    public static readonly Status72 Pending = new("pending");

    public static Status72 FromValue(string value) => FromValueCore(value);
}
