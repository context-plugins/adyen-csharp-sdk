using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Supported SDK interface types.
/// Allowed values:
/// * native
/// * html
/// * both
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SdkInterface>))]
public sealed record SdkInterface : StringEnum<SdkInterface>
{
    private SdkInterface(string value) : base(value)
    {
    }

    public static readonly SdkInterface Native = new("native");

    public static readonly SdkInterface Html = new("html");

    public static readonly SdkInterface Both = new("both");

    public static SdkInterface FromValue(string value) => FromValueCore(value);
}
