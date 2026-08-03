using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Logical device located on a Sale Terminal or a POI Terminal, regarding the class of information to output (display, print or store), or input (keyboard) for the Cashier or the Customer.
/// Possible values:
/// * <b>CashierDisplay</b>
/// * <b>CashierInput</b>
/// * <b>CustomerDisplay</b>
/// * <b>CustomerInput</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Device2>))]
public sealed record Device2 : StringEnum<Device2>
{
    private Device2(string value) : base(value)
    {
    }

    public static readonly Device2 CashierDisplay = new("CashierDisplay");

    public static readonly Device2 CustomerDisplay = new("CustomerDisplay");

    public static readonly Device2 CashierInput = new("CashierInput");

    public static readonly Device2 CustomerInput = new("CustomerInput");

    public static Device2 FromValue(string value) => FromValueCore(value);
}
