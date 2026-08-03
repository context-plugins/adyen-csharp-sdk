using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// PIN Support. For ecommerce, PIN is required.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PinSupport>))]
public sealed record PinSupport : StringEnum<PinSupport>
{
    private PinSupport(string value) : base(value)
    {
    }

    public static readonly PinSupport Pin = new("PIN");

    public static readonly PinSupport NoPin = new("NO PIN");

    public static PinSupport FromValue(string value) => FromValueCore(value);
}
