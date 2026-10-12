using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Event the POI notifies to the Sale System.
/// Possible values:
/// * <b>Abort</b>
/// * <b>BeginMaintenance</b>
/// * <b>CardInserted</b>
/// * <b>CardRemoved</b>
/// * <b>Completed</b>
/// * <b>CustomerLanguage</b>
/// * <b>EndMaintenance</b>
/// * <b>Initialised</b>
/// * <b>KeyPressed</b>
/// * <b>OutOfOrder</b>
/// * <b>Reject</b>
/// * <b>SaleAdmin</b>
/// * <b>SaleWakeUp</b>
/// * <b>ScanBarcodeResult</b>
/// * <b>SecurityAlarm</b>
/// * <b>Shutdown</b>
/// * <b>StopAssistance</b>
/// * <b>UseAnotherCardForPreauth</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EventToNotify1>))]
public sealed record EventToNotify1 : OpenStringEnum<EventToNotify1>
{
    private EventToNotify1(string value) : base(value)
    {
    }

    public static readonly EventToNotify1 BeginMaintenance = new("BeginMaintenance");

    public static readonly EventToNotify1 EndMaintenance = new("EndMaintenance");

    public static readonly EventToNotify1 Shutdown = new("Shutdown");

    public static readonly EventToNotify1 Initialised = new("Initialised");

    public static readonly EventToNotify1 OutOfOrder = new("OutOfOrder");

    public static readonly EventToNotify1 Completed = new("Completed");

    public static readonly EventToNotify1 Abort = new("Abort");

    public static readonly EventToNotify1 SaleWakeUp = new("SaleWakeUp");

    public static readonly EventToNotify1 SaleAdmin = new("SaleAdmin");

    public static readonly EventToNotify1 CustomerLanguage = new("CustomerLanguage");

    public static readonly EventToNotify1 KeyPressed = new("KeyPressed");

    public static readonly EventToNotify1 SecurityAlarm = new("SecurityAlarm");

    public static readonly EventToNotify1 StopAssistance = new("StopAssistance");

    public static readonly EventToNotify1 CardInserted = new("CardInserted");

    public static readonly EventToNotify1 CardRemoved = new("CardRemoved");

    public static readonly EventToNotify1 Reject = new("Reject");

    public static readonly EventToNotify1 UseAnotherCardForPreauth = new("UseAnotherCardForPreauth");

    public static readonly EventToNotify1 ScanBarcodeResult = new("ScanBarcodeResult");

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
