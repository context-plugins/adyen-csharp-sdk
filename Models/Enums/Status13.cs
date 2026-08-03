using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the request for PIN change.
/// <para>
/// Possible values: <b>completed</b>, <b>pending</b>, <b>unavailable</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status13>))]
public sealed record Status13 : StringEnum<Status13>
{
    private Status13(string value) : base(value)
    {
    }

    public static readonly Status13 Completed = new("completed");

    public static readonly Status13 Pending = new("pending");

    public static readonly Status13 Unavailable = new("unavailable");

    public static Status13 FromValue(string value) => FromValueCore(value);
}
