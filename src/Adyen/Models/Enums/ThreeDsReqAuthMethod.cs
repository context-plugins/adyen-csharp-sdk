using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Mechanism used by the Cardholder to authenticate to the 3DS Requestor. Allowed values:
/// * <b>01</b> — No 3DS Requestor authentication occurred (for example, cardholder “logged in” as guest).
/// * <b>02</b> — Login to the cardholder account at the 3DS Requestor system using 3DS Requestor’s own credentials.
/// * <b>03</b> — Login to the cardholder account at the 3DS Requestor system using federated ID.
/// * <b>04</b> — Login to the cardholder account at the 3DS Requestor system using issuer credentials.
/// * <b>05</b> — Login to the cardholder account at the 3DS Requestor system using third-party authentication.
/// * <b>06</b> — Login to the cardholder account at the 3DS Requestor system using FIDO Authenticator., Indicates whether a challenge is requested for this transaction. Possible values:
/// * <b>01</b> — No preference
/// * <b>02</b> — No challenge requested
/// * <b>03</b> — Challenge requested (3DS Requestor preference)
/// * <b>04</b> — Challenge requested (Mandate)
/// * <b>05</b> — No challenge (transactional risk analysis is already performed)
/// * <b>06</b> — Data Only
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThreeDsReqAuthMethod>))]
public sealed record ThreeDsReqAuthMethod : OpenStringEnum<ThreeDsReqAuthMethod>
{
    private ThreeDsReqAuthMethod(string value) : base(value)
    {
    }

    public static readonly ThreeDsReqAuthMethod _01 = new("01");

    public static readonly ThreeDsReqAuthMethod _02 = new("02");

    public static readonly ThreeDsReqAuthMethod _03 = new("03");

    public static readonly ThreeDsReqAuthMethod _04 = new("04");

    public static readonly ThreeDsReqAuthMethod _05 = new("05");

    public static readonly ThreeDsReqAuthMethod _06 = new("06");

    public TResult Match<TResult>(Func<TResult> on_01,
        Func<TResult> on_02,
        Func<TResult> on_03,
        Func<TResult> on_04,
        Func<TResult> on_05,
        Func<TResult> on_06,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _01 => on_01(),
            _ when this == _02 => on_02(),
            _ when this == _03 => on_03(),
            _ when this == _04 => on_04(),
            _ when this == _05 => on_05(),
            _ when this == _06 => on_06(),
            _ => otherwise(Value)
        };

    public void Match(Action on_01,
        Action on_02,
        Action on_03,
        Action on_04,
        Action on_05,
        Action on_06,
        Action<string> otherwise)
    {
        if (this == _01) on_01();
        else if (this == _02) on_02();
        else if (this == _03) on_03();
        else if (this == _04) on_04();
        else if (this == _05) on_05();
        else if (this == _06) on_06();
        else otherwise(Value);
    }
}
