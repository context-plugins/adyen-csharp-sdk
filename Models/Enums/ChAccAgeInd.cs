using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Length of time that the cardholder has had the account with the 3DS Requestor.
/// Allowed values:
/// * <b>01</b> — No account
/// * <b>02</b> — Created during this transaction
/// * <b>03</b> — Less than 30 days
/// * <b>04</b> — 30–60 days
/// * <b>05</b> — More than 60 days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChAccAgeInd>))]
public sealed record ChAccAgeInd : StringEnum<ChAccAgeInd>
{
    private ChAccAgeInd(string value) : base(value)
    {
    }

    public static readonly ChAccAgeInd _01 = new("01");

    public static readonly ChAccAgeInd _02 = new("02");

    public static readonly ChAccAgeInd _03 = new("03");

    public static readonly ChAccAgeInd _04 = new("04");

    public static readonly ChAccAgeInd _05 = new("05");

    public static ChAccAgeInd FromValue(string value) => FromValueCore(value);
}
