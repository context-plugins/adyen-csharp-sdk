using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of event notification sent when you select the notification button.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Category>))]
public sealed record Category : StringEnum<Category>
{
    private Category(string value) : base(value)
    {
    }

    public static readonly Category SaleWakeUp = new("SaleWakeUp");

    public static readonly Category KeyPressed = new("KeyPressed");

    public static Category FromValue(string value) => FromValueCore(value);
}
