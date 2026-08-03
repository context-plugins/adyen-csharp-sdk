using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The risk level of the transaction as classified by the <see href="https://docs.adyen.com/risk-management/configure-your-risk-profile/machine-learning-rules/">machine learning</see> fraud risk rule. The risk level indicates the likelihood that a transaction will result in a fraudulent dispute. Possible values:
/// * veryLow
/// * low
/// * medium
/// * high
/// * veryHigh
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FraudRiskLevel>))]
public sealed record FraudRiskLevel : StringEnum<FraudRiskLevel>
{
    private FraudRiskLevel(string value) : base(value)
    {
    }

    public static readonly FraudRiskLevel VeryLow = new("veryLow");

    public static readonly FraudRiskLevel Low = new("low");

    public static readonly FraudRiskLevel Medium = new("medium");

    public static readonly FraudRiskLevel High = new("high");

    public static readonly FraudRiskLevel VeryHigh = new("veryHigh");

    public static FraudRiskLevel FromValue(string value) => FromValueCore(value);
}
