using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Format or protocol for receiving webhooks. Possible values:
/// * <b>soap</b>
/// * <b>http</b>
/// * <b>json</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CommunicationFormat>))]
public sealed record CommunicationFormat : StringEnum<CommunicationFormat>
{
    private CommunicationFormat(string value) : base(value)
    {
    }

    public static readonly CommunicationFormat Http = new("http");

    public static readonly CommunicationFormat Json = new("json");

    public static readonly CommunicationFormat Soap = new("soap");

    public static CommunicationFormat FromValue(string value) => FromValueCore(value);
}
