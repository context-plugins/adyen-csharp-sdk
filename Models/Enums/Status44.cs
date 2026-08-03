using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the transfer.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>pending</b>: the transfer is under internal review by Adyen.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>failed</b>: the transfer failed Adyen's internal review. For details, see <c>reason</c>.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status44>))]
public sealed record Status44 : StringEnum<Status44>
{
    private Status44(string value) : base(value)
    {
    }

    public static readonly Status44 Pending = new("pending");

    public static readonly Status44 Failed = new("failed");

    public static Status44 FromValue(string value) => FromValueCore(value);
}
