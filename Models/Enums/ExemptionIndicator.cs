using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the exemption type that was applied by the issuer to the authentication, if exemption applied.
/// Allowed values:
/// * <c>lowValue</c>
/// * <c>secureCorporate</c>
/// * <c>trustedBeneficiary</c>
/// * <c>transactionRiskAnalysis</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ExemptionIndicator>))]
public sealed record ExemptionIndicator : StringEnum<ExemptionIndicator>
{
    private ExemptionIndicator(string value) : base(value)
    {
    }

    public static readonly ExemptionIndicator LowValue = new("lowValue");

    public static readonly ExemptionIndicator SecureCorporate = new("secureCorporate");

    public static readonly ExemptionIndicator TrustedBeneficiary = new("trustedBeneficiary");

    public static readonly ExemptionIndicator TransactionRiskAnalysis = new("transactionRiskAnalysis");

    public static ExemptionIndicator FromValue(string value) => FromValueCore(value);
}
