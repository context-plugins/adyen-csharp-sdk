using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the card order.
/// <para>
/// Possible values: <b>Open</b>, <b>Closed</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status61>))]
public sealed record Status61 : StringEnum<Status61>
{
    private Status61(string value) : base(value)
    {
    }

    public static readonly Status61 Closed = new("closed");

    public static readonly Status61 Open = new("open");

    public static Status61 FromValue(string value) => FromValueCore(value);
}
