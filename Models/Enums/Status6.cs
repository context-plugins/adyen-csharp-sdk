using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the card order.
/// <para>
/// Possible values: <b>Open</b>, <b>Closed</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status6>))]
public sealed record Status6 : StringEnum<Status6>
{
    private Status6(string value) : base(value)
    {
    }

    public static readonly Status6 Closed = new("closed");

    public static readonly Status6 Open = new("open");

    public static Status6 FromValue(string value) => FromValueCore(value);
}
