using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.
/// Allowed values:
/// * <b>01</b> — This transaction
/// * <b>02</b> — Less than 30 days
/// * <b>03</b> — 30–60 days
/// * <b>04</b> — More than 60 days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShipAddressUsageInd>))]
public sealed record ShipAddressUsageInd : OpenStringEnum<ShipAddressUsageInd>
{
    private ShipAddressUsageInd(string value) : base(value)
    {
    }

    public static readonly ShipAddressUsageInd _01 = new("01");

    public static readonly ShipAddressUsageInd _02 = new("02");

    public static readonly ShipAddressUsageInd _03 = new("03");

    public static readonly ShipAddressUsageInd _04 = new("04");

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
