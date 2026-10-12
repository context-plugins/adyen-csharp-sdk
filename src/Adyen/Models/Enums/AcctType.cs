using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the type of account. For example, for a multi-account card product. Length: 2 characters. Allowed values:
/// * <b>01</b> — Not applicable
/// * <b>02</b> — Credit
/// * <b>03</b> — Debit
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AcctType>))]
public sealed record AcctType : OpenStringEnum<AcctType>
{
    private AcctType(string value) : base(value)
    {
    }

    public static readonly AcctType _01 = new("01");

    public static readonly AcctType _02 = new("02");

    public static readonly AcctType _03 = new("03");

    public TResult Match<TResult>(Func<TResult> on_01,
        Func<TResult> on_02,
        Func<TResult> on_03,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _01 => on_01(),
            _ when this == _02 => on_02(),
            _ when this == _03 => on_03(),
            _ => otherwise(Value)
        };

    public void Match(Action on_01, Action on_02, Action on_03, Action<string> otherwise)
    {
        if (this == _01) on_01();
        else if (this == _02) on_02();
        else if (this == _03) on_03();
        else otherwise(Value);
    }
}
