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
public sealed record TransType : StringEnum<TransType>
{
    private TransType(string value) : base(value)
    {
    }

    public static readonly TransType _01 = new("01");

    public static readonly TransType _03 = new("03");

    public static readonly TransType _10 = new("10");

    public static readonly TransType _11 = new("11");

    public static readonly TransType _28 = new("28");

    public static TransType FromValue(string value) => FromValueCore(value);
}
