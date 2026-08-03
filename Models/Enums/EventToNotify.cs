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
public sealed record EventToNotify : StringEnum<EventToNotify>
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

    public static EventToNotify FromValue(string value) => FromValueCore(value);
}
