using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Length of time since the cardholder’s account information with the 3DS Requestor was last changed, including Billing or Shipping address, new payment account, or new user(s) added.
/// Allowed values:
/// * <b>01</b> — Changed during this transaction
/// * <b>02</b> — Less than 30 days
/// * <b>03</b> — 30–60 days
/// * <b>04</b> — More than 60 days, Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.
/// Allowed values:
/// * <b>01</b> — This transaction
/// * <b>02</b> — Less than 30 days
/// * <b>03</b> — 30–60 days
/// * <b>04</b> — More than 60 days, Mechanism used by the Cardholder to previously authenticate to the 3DS Requestor. Allowed values:
/// * <b>01</b> — Frictionless authentication occurred by ACS.
/// * <b>02</b> — Cardholder challenge occurred by ACS.
/// * <b>03</b> — AVS verified.
/// * <b>04</b> — Other issuer methods.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChAccChangeInd>))]
public sealed record ChAccChangeInd : StringEnum<ChAccChangeInd>
{
    private ChAccChangeInd(string value) : base(value)
    {
    }

    public static readonly ChAccChangeInd _01 = new("01");

    public static readonly ChAccChangeInd _02 = new("02");

    public static readonly ChAccChangeInd _03 = new("03");

    public static readonly ChAccChangeInd _04 = new("04");

    public static ChAccChangeInd FromValue(string value) => FromValueCore(value);
}
