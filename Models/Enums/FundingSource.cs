using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to <b>debit</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FundingSource>))]
public sealed record FundingSource : StringEnum<FundingSource>
{
    private FundingSource(string value) : base(value)
    {
    }

    public static readonly FundingSource Credit = new("credit");

    public static readonly FundingSource Debit = new("debit");

    public static readonly FundingSource Prepaid = new("prepaid");

    public static FundingSource FromValue(string value) => FromValueCore(value);
}
