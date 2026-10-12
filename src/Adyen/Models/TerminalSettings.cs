using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalSettings
{
    /// <summary>
    /// Settings to define the header of the shopper receipt.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardholderReceipt")]
    public CardholderReceipt1? CardholderReceipt { get; init; }

    /// <summary>
    /// Settings for terminal connectivity features.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connectivity")]
    public Connectivity1? Connectivity { get; init; }

    /// <summary>
    /// Settings for Dynamic Currency Conversion (DCC).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dcc")]
    public Dcc1? Dcc { get; init; }

    /// <summary>
    /// Settings for tipping with or without predefined options to choose from. The maximum number of predefined options is four, or three plus the option to enter a custom tip.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gratuities")]
    public IReadOnlyList<Gratuity>? Gratuities { get; init; }

    /// <summary>
    /// Settings for terminal hardware features.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hardware")]
    public Hardware1? Hardware { get; init; }

    /// <summary>
    /// Settings for the home screen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homeScreen")]
    public HomeScreenSettings1? HomeScreen { get; init; }

    /// <summary>
    /// Settings for kiosk mode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kioskMode")]
    public KioskModeSettings1? KioskMode { get; init; }

    /// <summary>
    /// Settings for localization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("localization")]
    public Localization1? Localization { get; init; }

    /// <summary>
    /// Settings for Mail Order/Telephone Order transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("moto")]
    public Moto1? Moto { get; init; }

    /// <summary>
    /// Settings for a Terminal API integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nexo")]
    public Nexo1? Nexo { get; init; }

    /// <summary>
    /// Settings for EMV <see href="https://docs.adyen.com/point-of-sale/offline-payments">offline payment</see> features.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offlineProcessing")]
    public OfflineProcessing1? OfflineProcessing { get; init; }

    /// <summary>
    /// Settings for an Oracle Payment Interface (OPI) integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("opi")]
    public Opi1? Opi { get; init; }

    /// <summary>
    /// Settings for <see href="https://docs.adyen.com/point-of-sale/managing-terminals/menu-access?tab=manage_passcodes_with_an_api_call_2#manage-passcodes">passcodes</see> features.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passcodes")]
    public Passcodes1? Passcodes { get; init; }

    /// <summary>
    /// Settings for <see href="https://docs.adyen.com/point-of-sale/pay-at-x">Pay-at-table</see> features.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payAtTable")]
    public PayAtTable1? PayAtTable { get; init; }

    /// <summary>
    /// Settings for payment features.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment")]
    public Payment11? Payment { get; init; }

    /// <summary>
    /// Generic receipt settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("receiptOptions")]
    public ReceiptOptions1? ReceiptOptions { get; init; }

    /// <summary>
    /// Transaction outcomes that you want the terminal to print a merchant receipt or a shopper receipt for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("receiptPrinting")]
    public ReceiptPrinting1? ReceiptPrinting { get; init; }

    /// <summary>
    /// Settings for refunds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refunds")]
    public Refunds1? Refunds { get; init; }

    /// <summary>
    /// Settings to skip signature, sign on display, or sign on receipt.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature")]
    public Signature1? Signature { get; init; }

    /// <summary>
    /// Settings for <see href="https://docs.adyen.com/point-of-sale/standalone/standalone-build/set-up-standalone#set-up-standalone-using-an-api-call">standalone</see> features.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("standalone")]
    public Standalone1? Standalone { get; init; }

    /// <summary>
    /// Settings for store-and-forward offline payments. The <c>maxAmount</c>, <c>maxPayments</c>, and <c>supportedCardTypes</c> parameters must be configured, either in the request or inherited from a higher level in your account structure.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeAndForward")]
    public StoreAndForward1? StoreAndForward { get; init; }

    /// <summary>
    /// Settings for payment <see href="https://docs.adyen.com/point-of-sale/surcharge">surcharge</see> features.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surcharge")]
    public Surcharge21? Surcharge { get; init; }

    /// <summary>
    /// Settings for Tap to Pay.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tapToPay")]
    public TapToPay1? TapToPay { get; init; }

    /// <summary>
    /// Settings to define the behaviour of the payment terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalInstructions")]
    public TerminalInstructions1? TerminalInstructions { get; init; }

    /// <summary>
    /// Settings for device <see href="https://docs.adyen.com/point-of-sale/pos-timeouts#device-time-out">time-outs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeouts")]
    public Timeouts2? Timeouts { get; init; }

    /// <summary>
    /// Remote Wi-Fi profiles for WPA and WPA2 PSK and EAP Wi-Fi networks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wifiProfiles")]
    public WifiProfiles2? WifiProfiles { get; init; }
}
