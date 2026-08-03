using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.
/// Allowed values:
/// * <b>01</b> — No suspicious activity has been observed
/// * <b>02</b> — Suspicious activity has been observed
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SuspiciousAccActivity>))]
public sealed record SuspiciousAccActivity : StringEnum<SuspiciousAccActivity>
{
    private SuspiciousAccActivity(string value) : base(value)
    {
    }

    public static readonly SuspiciousAccActivity _01 = new("01");

    public static readonly SuspiciousAccActivity _02 = new("02");

    public static SuspiciousAccActivity FromValue(string value) => FromValueCore(value);
}
