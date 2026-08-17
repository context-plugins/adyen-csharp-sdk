using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The SSL protocol employed by the endpoint.
/// &gt;Permitted values: <c>TLSv12</c>, <c>TLSv13</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SslProtocol>))]
public sealed record SslProtocol : StringEnum<SslProtocol>
{
    private SslProtocol(string value) : base(value)
    {
    }

    public static readonly SslProtocol TlSv12 = new("TLSv12");

    public static readonly SslProtocol TlSv13 = new("TLSv13");

    public static SslProtocol FromValue(string value) => FromValueCore(value);
}
