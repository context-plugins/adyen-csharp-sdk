using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Aborted</b>
/// * <b>Busy</b>
/// * <b>Cancel</b>
/// * <b>DeviceOut</b>
/// * <b>InsertedCard</b>
/// * <b>InProgress</b>
/// * <b>LoggedOut</b>
/// * <b>MessageFormat</b>
/// * <b>NotAllowed</b>
/// * <b>NotFound</b>
/// * <b>PaymentRestriction</b>
/// * <b>Refusal</b>
/// * <b>UnavailableDevice</b>
/// * <b>UnavailableService</b>
/// * <b>InvalidCard</b>
/// * <b>UnreachableHost</b>
/// * <b>WrongPIN</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ErrorCondition>))]
public sealed record ErrorCondition : OpenStringEnum<ErrorCondition>
{
    private ErrorCondition(string value) : base(value)
    {
    }

    public static readonly ErrorCondition Aborted = new("Aborted");

    public static readonly ErrorCondition Busy = new("Busy");

    public static readonly ErrorCondition Cancel = new("Cancel");

    public static readonly ErrorCondition DeviceOut = new("DeviceOut");

    public static readonly ErrorCondition InsertedCard = new("InsertedCard");

    public static readonly ErrorCondition InProgress = new("InProgress");

    public static readonly ErrorCondition LoggedOut = new("LoggedOut");

    public static readonly ErrorCondition MessageFormat = new("MessageFormat");

    public static readonly ErrorCondition NotAllowed = new("NotAllowed");

    public static readonly ErrorCondition NotFound = new("NotFound");

    public static readonly ErrorCondition PaymentRestriction = new("PaymentRestriction");

    public static readonly ErrorCondition Refusal = new("Refusal");

    public static readonly ErrorCondition UnavailableDevice = new("UnavailableDevice");

    public static readonly ErrorCondition UnavailableService = new("UnavailableService");

    public static readonly ErrorCondition InvalidCard = new("InvalidCard");

    public static readonly ErrorCondition UnreachableHost = new("UnreachableHost");

    public static readonly ErrorCondition WrongPin = new("WrongPIN");

    public TResult Match<TResult>(Func<TResult> onAborted,
        Func<TResult> onBusy,
        Func<TResult> onCancel,
        Func<TResult> onDeviceOut,
        Func<TResult> onInsertedCard,
        Func<TResult> onInProgress,
        Func<TResult> onLoggedOut,
        Func<TResult> onMessageFormat,
        Func<TResult> onNotAllowed,
        Func<TResult> onNotFound,
        Func<TResult> onPaymentRestriction,
        Func<TResult> onRefusal,
        Func<TResult> onUnavailableDevice,
        Func<TResult> onUnavailableService,
        Func<TResult> onInvalidCard,
        Func<TResult> onUnreachableHost,
        Func<TResult> onWrongPin,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Aborted => onAborted(),
            _ when this == Busy => onBusy(),
            _ when this == Cancel => onCancel(),
            _ when this == DeviceOut => onDeviceOut(),
            _ when this == InsertedCard => onInsertedCard(),
            _ when this == InProgress => onInProgress(),
            _ when this == LoggedOut => onLoggedOut(),
            _ when this == MessageFormat => onMessageFormat(),
            _ when this == NotAllowed => onNotAllowed(),
            _ when this == NotFound => onNotFound(),
            _ when this == PaymentRestriction => onPaymentRestriction(),
            _ when this == Refusal => onRefusal(),
            _ when this == UnavailableDevice => onUnavailableDevice(),
            _ when this == UnavailableService => onUnavailableService(),
            _ when this == InvalidCard => onInvalidCard(),
            _ when this == UnreachableHost => onUnreachableHost(),
            _ when this == WrongPin => onWrongPin(),
            _ => otherwise(Value)
        };

    public void Match(Action onAborted,
        Action onBusy,
        Action onCancel,
        Action onDeviceOut,
        Action onInsertedCard,
        Action onInProgress,
        Action onLoggedOut,
        Action onMessageFormat,
        Action onNotAllowed,
        Action onNotFound,
        Action onPaymentRestriction,
        Action onRefusal,
        Action onUnavailableDevice,
        Action onUnavailableService,
        Action onInvalidCard,
        Action onUnreachableHost,
        Action onWrongPin,
        Action<string> otherwise)
    {
        if (this == Aborted) onAborted();
        else if (this == Busy) onBusy();
        else if (this == Cancel) onCancel();
        else if (this == DeviceOut) onDeviceOut();
        else if (this == InsertedCard) onInsertedCard();
        else if (this == InProgress) onInProgress();
        else if (this == LoggedOut) onLoggedOut();
        else if (this == MessageFormat) onMessageFormat();
        else if (this == NotAllowed) onNotAllowed();
        else if (this == NotFound) onNotFound();
        else if (this == PaymentRestriction) onPaymentRestriction();
        else if (this == Refusal) onRefusal();
        else if (this == UnavailableDevice) onUnavailableDevice();
        else if (this == UnavailableService) onUnavailableService();
        else if (this == InvalidCard) onInvalidCard();
        else if (this == UnreachableHost) onUnreachableHost();
        else if (this == WrongPin) onWrongPin();
        else otherwise(Value);
    }
}
