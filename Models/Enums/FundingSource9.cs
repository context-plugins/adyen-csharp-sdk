using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The funding source of the payment method.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FundingSource9>))]
public sealed record FundingSource9 : StringEnum<FundingSource9>
{
    private FundingSource9(string value) : base(value)
    {
    }

    public static readonly FundingSource9 Credit = new("credit");

    public static readonly FundingSource9 Debit = new("debit");

    public static readonly FundingSource9 Prepaid = new("prepaid");

    public static FundingSource9 FromValue(string value) => FromValueCore(value);
}
