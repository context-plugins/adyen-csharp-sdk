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
public sealed record ErrorCondition : StringEnum<ErrorCondition>
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

    public static ErrorCondition FromValue(string value) => FromValueCore(value);
}
