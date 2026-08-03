using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of event notification sent when you select the notification button.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Category1>))]
public sealed record Category1 : StringEnum<Category1>
{
    private Category1(string value) : base(value)
    {
    }

    public static readonly Category1 SaleWakeUp = new("SaleWakeUp");

    public static readonly Category1 KeyPressed = new("KeyPressed");

    public static Category1 FromValue(string value) => FromValueCore(value);
}
