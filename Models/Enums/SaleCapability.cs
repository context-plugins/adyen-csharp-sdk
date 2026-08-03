using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SaleCapability>))]
public sealed record SaleCapability : StringEnum<SaleCapability>
{
    private SaleCapability(string value) : base(value)
    {
    }

    public static readonly SaleCapability CashierStatus = new("CashierStatus");

    public static readonly SaleCapability CashierError = new("CashierError");

    public static readonly SaleCapability CashierDisplay = new("CashierDisplay");

    public static readonly SaleCapability Poireplication = new("POIReplication");

    public static readonly SaleCapability CashierInput = new("CashierInput");

    public static readonly SaleCapability CustomerAssistance = new("CustomerAssistance");

    public static readonly SaleCapability CustomerDisplay = new("CustomerDisplay");

    public static readonly SaleCapability CustomerError = new("CustomerError");

    public static readonly SaleCapability CustomerInput = new("CustomerInput");

    public static readonly SaleCapability PrinterReceipt = new("PrinterReceipt");

    public static readonly SaleCapability PrinterDocument = new("PrinterDocument");

    public static readonly SaleCapability PrinterVoucher = new("PrinterVoucher");

    public static readonly SaleCapability MagStripe = new("MagStripe");

    public static readonly SaleCapability Icc = new("ICC");

    public static readonly SaleCapability Emvcontactless = new("EMVContactless");

    public static SaleCapability FromValue(string value) => FromValueCore(value);
}
