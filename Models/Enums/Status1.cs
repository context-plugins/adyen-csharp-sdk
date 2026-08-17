using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the donation transaction.
/// <para>
/// Possible values:
/// * <b>completed</b>
/// * <b>pending</b>
/// * <b>refused</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : StringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Completed = new("completed");

    public static readonly Status1 Pending = new("pending");

    public static readonly Status1 Refused = new("refused");

    public static Status1 FromValue(string value) => FromValueCore(value);
}
