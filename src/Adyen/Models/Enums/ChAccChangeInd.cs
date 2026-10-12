using System;
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
public sealed record ChAccChangeInd : OpenStringEnum<ChAccChangeInd>
{
    private ChAccChangeInd(string value) : base(value)
    {
    }

    public static readonly ChAccChangeInd _01 = new("01");

    public static readonly ChAccChangeInd _02 = new("02");

    public static readonly ChAccChangeInd _03 = new("03");

    public static readonly ChAccChangeInd _04 = new("04");

    public TResult Match<TResult>(Func<TResult> on_01,
        Func<TResult> on_02,
        Func<TResult> on_03,
        Func<TResult> on_04,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _01 => on_01(),
            _ when this == _02 => on_02(),
            _ when this == _03 => on_03(),
            _ when this == _04 => on_04(),
            _ => otherwise(Value)
        };

    public void Match(Action on_01, Action on_02, Action on_03, Action on_04, Action<string> otherwise)
    {
        if (this == _01) on_01();
        else if (this == _02) on_02();
        else if (this == _03) on_03();
        else if (this == _04) on_04();
        else otherwise(Value);
    }
}
