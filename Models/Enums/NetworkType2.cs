using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Network type for Terminal API details webhooks.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NetworkType2>))]
public sealed record NetworkType2 : StringEnum<NetworkType2>
{
    private NetworkType2(string value) : base(value)
    {
    }

    public static readonly NetworkType2 Local = new("local");

    public static readonly NetworkType2 Public = new("public");

    public static NetworkType2 FromValue(string value) => FromValueCore(value);
}
