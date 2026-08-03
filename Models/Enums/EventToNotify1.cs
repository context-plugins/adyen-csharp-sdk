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
public sealed record EventToNotify1 : StringEnum<EventToNotify1>
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

    public static EventToNotify1 FromValue(string value) => FromValueCore(value);
}
