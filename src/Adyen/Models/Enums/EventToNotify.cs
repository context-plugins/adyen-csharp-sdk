using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Event the POI notifies to the Sale System.
/// Possible values:
/// * <b>BeginMaintenance</b>
/// * <b>EndMaintenance</b>
/// * <b>Shutdown</b>
/// * <b>Initialised</b>
/// * <b>OutOfOrder</b>
/// * <b>Completed</b>
/// * <b>Abort</b>
/// * <b>SaleWakeUp</b>
/// * <b>SaleAdmin</b>
/// * <b>CustomerLanguage</b>
/// * <b>KeyPressed</b>
/// * <b>SecurityAlarm</b>
/// * <b>StopAssistance</b>
/// * <b>CardInserted</b>
/// * <b>CardRemoved</b>
/// * <b>Reject</b>
/// * <b>UseAnotherCardForPreauth</b>
/// * <b>ScanBarcodeResult</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EventToNotify>))]
public sealed record EventToNotify : OpenStringEnum<EventToNotify>
{
    private EventToNotify(string value) : base(value)
    {
    }

    public static readonly EventToNotify BeginMaintenance = new("BeginMaintenance");

    public static readonly EventToNotify EndMaintenance = new("EndMaintenance");

    public static readonly EventToNotify Shutdown = new("Shutdown");

    public static readonly EventToNotify Initialised = new("Initialised");

    public static readonly EventToNotify OutOfOrder = new("OutOfOrder");

    public static readonly EventToNotify Completed = new("Completed");

    public static readonly EventToNotify Abort = new("Abort");

    public static readonly EventToNotify SaleWakeUp = new("SaleWakeUp");

    public static readonly EventToNotify SaleAdmin = new("SaleAdmin");

    public static readonly EventToNotify CustomerLanguage = new("CustomerLanguage");

    public static readonly EventToNotify KeyPressed = new("KeyPressed");

    public static readonly EventToNotify SecurityAlarm = new("SecurityAlarm");

    public static readonly EventToNotify StopAssistance = new("StopAssistance");

    public static readonly EventToNotify CardInserted = new("CardInserted");

    public static readonly EventToNotify CardRemoved = new("CardRemoved");

    public static readonly EventToNotify Reject = new("Reject");

    public static readonly EventToNotify UseAnotherCardForPreauth = new("UseAnotherCardForPreauth");

    public static readonly EventToNotify ScanBarcodeResult = new("ScanBarcodeResult");

    public TResult Match<TResult>(Func<TResult> onBeginMaintenance,
        Func<TResult> onEndMaintenance,
        Func<TResult> onShutdown,
        Func<TResult> onInitialised,
        Func<TResult> onOutOfOrder,
        Func<TResult> onCompleted,
        Func<TResult> onAbort,
        Func<TResult> onSaleWakeUp,
        Func<TResult> onSaleAdmin,
        Func<TResult> onCustomerLanguage,
        Func<TResult> onKeyPressed,
        Func<TResult> onSecurityAlarm,
        Func<TResult> onStopAssistance,
        Func<TResult> onCardInserted,
        Func<TResult> onCardRemoved,
        Func<TResult> onReject,
        Func<TResult> onUseAnotherCardForPreauth,
        Func<TResult> onScanBarcodeResult,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BeginMaintenance => onBeginMaintenance(),
            _ when this == EndMaintenance => onEndMaintenance(),
            _ when this == Shutdown => onShutdown(),
            _ when this == Initialised => onInitialised(),
            _ when this == OutOfOrder => onOutOfOrder(),
            _ when this == Completed => onCompleted(),
            _ when this == Abort => onAbort(),
            _ when this == SaleWakeUp => onSaleWakeUp(),
            _ when this == SaleAdmin => onSaleAdmin(),
            _ when this == CustomerLanguage => onCustomerLanguage(),
            _ when this == KeyPressed => onKeyPressed(),
            _ when this == SecurityAlarm => onSecurityAlarm(),
            _ when this == StopAssistance => onStopAssistance(),
            _ when this == CardInserted => onCardInserted(),
            _ when this == CardRemoved => onCardRemoved(),
            _ when this == Reject => onReject(),
            _ when this == UseAnotherCardForPreauth => onUseAnotherCardForPreauth(),
            _ when this == ScanBarcodeResult => onScanBarcodeResult(),
            _ => otherwise(Value)
        };

    public void Match(Action onBeginMaintenance,
        Action onEndMaintenance,
        Action onShutdown,
        Action onInitialised,
        Action onOutOfOrder,
        Action onCompleted,
        Action onAbort,
        Action onSaleWakeUp,
        Action onSaleAdmin,
        Action onCustomerLanguage,
        Action onKeyPressed,
        Action onSecurityAlarm,
        Action onStopAssistance,
        Action onCardInserted,
        Action onCardRemoved,
        Action onReject,
        Action onUseAnotherCardForPreauth,
        Action onScanBarcodeResult,
        Action<string> otherwise)
    {
        if (this == BeginMaintenance) onBeginMaintenance();
        else if (this == EndMaintenance) onEndMaintenance();
        else if (this == Shutdown) onShutdown();
        else if (this == Initialised) onInitialised();
        else if (this == OutOfOrder) onOutOfOrder();
        else if (this == Completed) onCompleted();
        else if (this == Abort) onAbort();
        else if (this == SaleWakeUp) onSaleWakeUp();
        else if (this == SaleAdmin) onSaleAdmin();
        else if (this == CustomerLanguage) onCustomerLanguage();
        else if (this == KeyPressed) onKeyPressed();
        else if (this == SecurityAlarm) onSecurityAlarm();
        else if (this == StopAssistance) onStopAssistance();
        else if (this == CardInserted) onCardInserted();
        else if (this == CardRemoved) onCardRemoved();
        else if (this == Reject) onReject();
        else if (this == UseAnotherCardForPreauth) onUseAnotherCardForPreauth();
        else if (this == ScanBarcodeResult) onScanBarcodeResult();
        else otherwise(Value);
    }
}
