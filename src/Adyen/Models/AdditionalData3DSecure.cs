using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AdditionalData3DSecure
{
    /// <summary>
    /// Indicates if you are able to process 3D Secure 2 transactions natively on your payment page. Send this parameter when you are using <c>/payments</c> endpoint with any of our <see href="https://docs.adyen.com/online-payments/3d-secure/native-3ds2">native 3D Secure 2 solutions</see>.
    /// <para>
    ///  &gt; This parameter only indicates readiness to support native 3D Secure 2 authentication. To specify if you _want_ to perform 3D Secure, use <see href="/risk-management/dynamic-3d-secure">Dynamic 3D Secure</see> or send the <c>executeThreeD</c> parameter.
    /// </para>
    /// <para>
    /// Possible values:
    /// * <b>true</b> - Ready to support native 3D Secure 2 authentication. Setting this to true does not mean always applying 3D Secure 2. Adyen selects redirect or native authentication based on your configuration to optimize authorization rates and improve the shopper's experience.
    /// * <b>false</b> – Not ready to support native 3D Secure 2 authentication. Adyen offers redirect 3D Secure 2 authentication instead, based on your configuration.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow3DS2")]
    public string? Allow3Ds2 { get; init; }

    /// <summary>
    /// Dimensions of the 3DS2 challenge window to be displayed to the cardholder.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>01</b> - size of 250x400</description></item>
    ///   <item><description><b>02</b> - size of 390x400</description></item>
    ///   <item><description><b>03</b> - size of 500x600</description></item>
    ///   <item><description><b>04</b> - size of 600x400</description></item>
    ///   <item><description><b>05</b> - Fullscreen</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("challengeWindowSize")]
    public ChallengeWindowSize? ChallengeWindowSize { get; init; }

    /// <summary>
    /// Indicates if you want to perform 3D Secure authentication on a transaction.
    /// <para>
    ///  &gt; Alternatively, you can use <see href="/risk-management/dynamic-3d-secure">Dynamic 3D Secure</see> to configure rules for applying 3D Secure.
    /// </para>
    /// <para>
    /// Possible values:
    /// * <b>true</b> – Perform 3D Secure authentication.
    /// * <b>false</b> – Don't perform 3D Secure authentication. Note that this setting results in refusals if the issuer mandates 3D Secure because of the PSD2 directive  or other, national regulations.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("executeThreeD")]
    public string? ExecuteThreeD { get; init; }

    /// <summary>
    /// In case of Secure+, this field must be set to <b>CUPSecurePlus</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mpiImplementationType")]
    public string? MpiImplementationType { get; init; }

    /// <summary>
    /// Indicates the <see href="https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest">exemption type</see> that you want to request for the transaction.
    /// <para>
    ///  Possible values:
    /// * <b>lowValue</b>
    /// * <b>secureCorporate</b>
    /// * <b>trustedBeneficiary</b>
    /// * <b>transactionRiskAnalysis</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaExemption")]
    public string? ScaExemption { get; init; }

    /// <summary>
    /// Indicates your preference for the 3D Secure version.
    /// &gt; If you use this parameter, you override the checks from Adyen's Authentication Engine. We recommend to use this field only if you have an extensive knowledge of 3D Secure.
    /// <para>
    /// Possible values:
    /// * <b>2.1.0</b>: Apply 3D Secure version 2.1.0.
    /// * <b>2.2.0</b>: Apply 3D Secure version 2.2.0. If the issuer does not support version 2.2.0, we will fall back to 2.1.0.
    /// </para>
    /// <para>
    /// The following rules apply:
    /// * If you prefer 2.1.0 or 2.2.0 but we receive a negative <c>transStatus</c> in the <c>ARes</c>, we will apply the fallback policy configured in your account.
    /// * If you the BIN is not enrolled, you will receive an error.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSVersion")]
    public string? ThreeDsVersion { get; init; }
}
