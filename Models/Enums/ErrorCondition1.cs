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
public sealed record ErrorCondition1 : StringEnum<ErrorCondition1>
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

    public static ErrorCondition1 FromValue(string value) => FromValueCore(value);
}
