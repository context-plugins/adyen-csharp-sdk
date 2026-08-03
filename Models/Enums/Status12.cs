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
[JsonConverter(typeof(StringEnumConverter<Status12>))]
public sealed record Status12 : StringEnum<Status12>
{
    private Status12(string value) : base(value)
    {
    }

    public static readonly Status12 Completed = new("completed");

    public static readonly Status12 Pending = new("pending");

    public static readonly Status12 Refused = new("refused");

    public static Status12 FromValue(string value) => FromValueCore(value);
}
