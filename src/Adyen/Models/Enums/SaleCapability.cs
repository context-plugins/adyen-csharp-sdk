using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SaleCapability>))]
public sealed record SaleCapability : OpenStringEnum<SaleCapability>
{
    private SaleCapability(string value) : base(value)
    {
    }

    public static readonly SaleCapability CashierStatus = new("CashierStatus");

    public static readonly SaleCapability CashierError = new("CashierError");

    public static readonly SaleCapability CashierDisplay = new("CashierDisplay");

    public static readonly SaleCapability PoiReplication = new("POIReplication");

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

    public static readonly SaleCapability EmvContactless = new("EMVContactless");

    public TResult Match<TResult>(Func<TResult> onCashierStatus,
        Func<TResult> onCashierError,
        Func<TResult> onCashierDisplay,
        Func<TResult> onPoiReplication,
        Func<TResult> onCashierInput,
        Func<TResult> onCustomerAssistance,
        Func<TResult> onCustomerDisplay,
        Func<TResult> onCustomerError,
        Func<TResult> onCustomerInput,
        Func<TResult> onPrinterReceipt,
        Func<TResult> onPrinterDocument,
        Func<TResult> onPrinterVoucher,
        Func<TResult> onMagStripe,
        Func<TResult> onIcc,
        Func<TResult> onEmvContactless,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CashierStatus => onCashierStatus(),
            _ when this == CashierError => onCashierError(),
            _ when this == CashierDisplay => onCashierDisplay(),
            _ when this == PoiReplication => onPoiReplication(),
            _ when this == CashierInput => onCashierInput(),
            _ when this == CustomerAssistance => onCustomerAssistance(),
            _ when this == CustomerDisplay => onCustomerDisplay(),
            _ when this == CustomerError => onCustomerError(),
            _ when this == CustomerInput => onCustomerInput(),
            _ when this == PrinterReceipt => onPrinterReceipt(),
            _ when this == PrinterDocument => onPrinterDocument(),
            _ when this == PrinterVoucher => onPrinterVoucher(),
            _ when this == MagStripe => onMagStripe(),
            _ when this == Icc => onIcc(),
            _ when this == EmvContactless => onEmvContactless(),
            _ => otherwise(Value)
        };

    public void Match(Action onCashierStatus,
        Action onCashierError,
        Action onCashierDisplay,
        Action onPoiReplication,
        Action onCashierInput,
        Action onCustomerAssistance,
        Action onCustomerDisplay,
        Action onCustomerError,
        Action onCustomerInput,
        Action onPrinterReceipt,
        Action onPrinterDocument,
        Action onPrinterVoucher,
        Action onMagStripe,
        Action onIcc,
        Action onEmvContactless,
        Action<string> otherwise)
    {
        if (this == CashierStatus) onCashierStatus();
        else if (this == CashierError) onCashierError();
        else if (this == CashierDisplay) onCashierDisplay();
        else if (this == PoiReplication) onPoiReplication();
        else if (this == CashierInput) onCashierInput();
        else if (this == CustomerAssistance) onCustomerAssistance();
        else if (this == CustomerDisplay) onCustomerDisplay();
        else if (this == CustomerError) onCustomerError();
        else if (this == CustomerInput) onCustomerInput();
        else if (this == PrinterReceipt) onPrinterReceipt();
        else if (this == PrinterDocument) onPrinterDocument();
        else if (this == PrinterVoucher) onPrinterVoucher();
        else if (this == MagStripe) onMagStripe();
        else if (this == Icc) onIcc();
        else if (this == EmvContactless) onEmvContactless();
        else otherwise(Value);
    }
}
