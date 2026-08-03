using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Network type for Terminal API notification webhooks. Possible values:
/// * <b>public</b>
/// * <b>local</b>
/// <para>
/// Default Value: <b>public</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NetworkType>))]
public sealed record NetworkType : StringEnum<NetworkType>
{
    private NetworkType(string value) : base(value)
    {
    }

    public static readonly NetworkType Local = new("local");

    public static readonly NetworkType Public = new("public");

    public static NetworkType FromValue(string value) => FromValueCore(value);
}
