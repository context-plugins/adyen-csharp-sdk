using System;
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
public sealed record ExemptionIndicator : OpenStringEnum<ExemptionIndicator>
{
    private ExemptionIndicator(string value) : base(value)
    {
    }

    public static readonly ExemptionIndicator LowValue = new("lowValue");

    public static readonly ExemptionIndicator SecureCorporate = new("secureCorporate");

    public static readonly ExemptionIndicator TrustedBeneficiary = new("trustedBeneficiary");

    public static readonly ExemptionIndicator TransactionRiskAnalysis = new("transactionRiskAnalysis");

    public TResult Match<TResult>(Func<TResult> onLowValue,
        Func<TResult> onSecureCorporate,
        Func<TResult> onTrustedBeneficiary,
        Func<TResult> onTransactionRiskAnalysis,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LowValue => onLowValue(),
            _ when this == SecureCorporate => onSecureCorporate(),
            _ when this == TrustedBeneficiary => onTrustedBeneficiary(),
            _ when this == TransactionRiskAnalysis => onTransactionRiskAnalysis(),
            _ => otherwise(Value)
        };

    public void Match(Action onLowValue,
        Action onSecureCorporate,
        Action onTrustedBeneficiary,
        Action onTransactionRiskAnalysis,
        Action<string> otherwise)
    {
        if (this == LowValue) onLowValue();
        else if (this == SecureCorporate) onSecureCorporate();
        else if (this == TrustedBeneficiary) onTrustedBeneficiary();
        else if (this == TransactionRiskAnalysis) onTransactionRiskAnalysis();
        else otherwise(Value);
    }
}
