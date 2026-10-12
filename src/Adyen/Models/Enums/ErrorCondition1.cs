using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Condition that has produced an error on the processing of a message request.
/// Returned if Result is not Success.
/// Possible values:
/// * <b>Aborted</b>
/// * <b>Busy</b>
/// * <b>Cancel</b>
/// * <b>DeviceOut</b>
/// * <b>InProgress</b>
/// * <b>InsertedCard</b>
/// * <b>InvalidCard</b>
/// * <b>LoggedOut</b>
/// * <b>MessageFormat</b>
/// * <b>NotAllowed</b>
/// * <b>NotFound</b>
/// * <b>PaymentRestriction</b>
/// * <b>Refusal</b>
/// * <b>UnavailableDevice</b>
/// * <b>UnavailableService</b>
/// * <b>UnreachableHost</b>
/// * <b>WrongPIN</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ErrorCondition1>))]
public sealed record ErrorCondition1 : OpenStringEnum<ErrorCondition1>
{
    private ErrorCondition1(string value) : base(value)
    {
    }

    public static readonly ErrorCondition1 Aborted = new("Aborted");

    public static readonly ErrorCondition1 Busy = new("Busy");

    public static readonly ErrorCondition1 Cancel = new("Cancel");

    public static readonly ErrorCondition1 DeviceOut = new("DeviceOut");

    public static readonly ErrorCondition1 InsertedCard = new("InsertedCard");

    public static readonly ErrorCondition1 InProgress = new("InProgress");

    public static readonly ErrorCondition1 LoggedOut = new("LoggedOut");

    public static readonly ErrorCondition1 MessageFormat = new("MessageFormat");

    public static readonly ErrorCondition1 NotAllowed = new("NotAllowed");

    public static readonly ErrorCondition1 NotFound = new("NotFound");

    public static readonly ErrorCondition1 PaymentRestriction = new("PaymentRestriction");

    public static readonly ErrorCondition1 Refusal = new("Refusal");

    public static readonly ErrorCondition1 UnavailableDevice = new("UnavailableDevice");

    public static readonly ErrorCondition1 UnavailableService = new("UnavailableService");

    public static readonly ErrorCondition1 InvalidCard = new("InvalidCard");

    public static readonly ErrorCondition1 UnreachableHost = new("UnreachableHost");

    public static readonly ErrorCondition1 WrongPin = new("WrongPIN");

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
