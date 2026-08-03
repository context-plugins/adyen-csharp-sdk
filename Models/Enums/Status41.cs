using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the balance account. Payment instruments linked to the balance account can only be used if the balance account status is <b>active</b>.
/// <para>
/// Possible values: <b>active</b>, <b>closed</b>, <b>suspended</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status41>))]
public sealed record Status41 : StringEnum<Status41>
{
    private Status41(string value) : base(value)
    {
    }

    public static readonly Status41 Active = new("active");

    public static readonly Status41 Closed = new("closed");

    public static readonly Status41 Inactive = new("inactive");

    public static readonly Status41 Suspended = new("suspended");

    public static Status41 FromValue(string value) => FromValueCore(value);
}
