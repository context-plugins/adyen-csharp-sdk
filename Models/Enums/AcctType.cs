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
public sealed record AcctType : StringEnum<AcctType>
{
    private AcctType(string value) : base(value)
    {
    }

    public static readonly AcctType _01 = new("01");

    public static readonly AcctType _02 = new("02");

    public static readonly AcctType _03 = new("03");

    public static AcctType FromValue(string value) => FromValueCore(value);
}
