using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>CashierDisplay</b>
/// * <b>CustomerDisplay</b>
/// * <b>CashierInput</b>
/// * <b>CustomerInput</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Device1>))]
public sealed record Device1 : StringEnum<Device1>
{
    private Device1(string value) : base(value)
    {
    }

    public static readonly Device1 CashierDisplay = new("CashierDisplay");

    public static readonly Device1 CustomerDisplay = new("CustomerDisplay");

    public static readonly Device1 CashierInput = new("CashierInput");

    public static readonly Device1 CustomerInput = new("CustomerInput");

    public static Device1 FromValue(string value) => FromValueCore(value);
}
