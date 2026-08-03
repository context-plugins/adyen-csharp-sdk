using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Logical device located on a Sale Terminal or a POI Terminal, in terms of class of information to output (display, print or store), or input (keyboard) for the Cashier or the Customer.
/// Possible values:
/// * <b>CashierDisplay</b>
/// * <b>CashierInput</b>
/// * <b>CustomerDisplay</b>
/// * <b>CustomerInput</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Device4>))]
public sealed record Device4 : StringEnum<Device4>
{
    private Device4(string value) : base(value)
    {
    }

    public static readonly Device4 CashierDisplay = new("CashierDisplay");

    public static readonly Device4 CustomerDisplay = new("CustomerDisplay");

    public static readonly Device4 CashierInput = new("CashierInput");

    public static readonly Device4 CustomerInput = new("CustomerInput");

    public static Device4 FromValue(string value) => FromValueCore(value);
}
