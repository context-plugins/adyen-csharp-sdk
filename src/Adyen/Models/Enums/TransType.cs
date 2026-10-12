using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Identifies the type of transaction being authenticated. Length: 2 characters. Allowed values:
/// * <b>01</b> — Goods/Service Purchase
/// * <b>03</b> — Check Acceptance
/// * <b>10</b> — Account Funding
/// * <b>11</b> — Quasi-Cash Transaction
/// * <b>28</b> — Prepaid Activation and Load
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransType>))]
public sealed record TransType : OpenStringEnum<TransType>
{
    private TransType(string value) : base(value)
    {
    }

    public static readonly TransType _01 = new("01");

    public static readonly TransType _03 = new("03");

    public static readonly TransType _10 = new("10");

    public static readonly TransType _11 = new("11");

    public static readonly TransType _28 = new("28");

    public TResult Match<TResult>(Func<TResult> on_01,
        Func<TResult> on_03,
        Func<TResult> on_10,
        Func<TResult> on_11,
        Func<TResult> on_28,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _01 => on_01(),
            _ when this == _03 => on_03(),
            _ when this == _10 => on_10(),
            _ when this == _11 => on_11(),
            _ when this == _28 => on_28(),
            _ => otherwise(Value)
        };

    public void Match(Action on_01, Action on_03, Action on_10, Action on_11, Action on_28, Action<string> otherwise)
    {
        if (this == _01) on_01();
        else if (this == _03) on_03();
        else if (this == _10) on_10();
        else if (this == _11) on_11();
        else if (this == _28) on_28();
        else otherwise(Value);
    }
}
