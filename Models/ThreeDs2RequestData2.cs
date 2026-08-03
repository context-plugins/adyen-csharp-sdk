using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Request fields for 3D Secure 2. To check if any of the following fields are required for your integration, refer to <see href="https://docs.adyen.com/online-payments">Online payments</see> or <see href="https://docs.adyen.com/classic-integration">Classic integration</see> documentation.
/// </summary>
public record ThreeDs2RequestData2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acctInfo")]
    public AcctInfo1? AcctInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acctType")]
    public AcctType? AcctType { get; init; }

    /// <summary>
    /// Required for <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">authentication-only integration</see>. The acquiring BIN enrolled for 3D Secure 2. This string should match the value that you will use in the authorisation. Use 123456 on the Test platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquirerBIN")]
    public string? AcquirerBin { get; init; }

    /// <summary>
    /// Required for <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">authentication-only integration</see>. The merchantId that is enrolled for 3D Secure 2 by the merchant's acquirer. This string should match the value that you will use in the authorisation. Use 123456 on the Test platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquirerMerchantID")]
    public string? AcquirerMerchantId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addrMatch")]
    public AddrMatch? AddrMatch { get; init; }

    /// <summary>
    /// If set to true, you will only perform the <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">3D Secure 2 authentication</see>, and not the payment authorisation.
    /// </summary>
    [JsonPropertyName("authenticationOnly")]
    public bool? AuthenticationOnly { get; init; } = false;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("challengeIndicator")]
    public ChallengeIndicator? ChallengeIndicator { get; init; }

    /// <summary>
    /// The environment of the shopper.
    /// Allowed values:
    /// * <c>app</c>
    /// * <c>browser</c>
    /// </summary>
    [JsonPropertyName("deviceChannel")]
    public required string DeviceChannel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceRenderOptions")]
    public DeviceRenderOptions2? DeviceRenderOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homePhone")]
    public HomePhone? HomePhone { get; init; }

    /// <summary>
    /// Required for merchants that have been enrolled for 3D Secure 2 by another party than Adyen, mostly <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">authentication-only integrations</see>. The <c>mcc</c> is a four-digit code with which the previously given <c>acquirerMerchantID</c> is registered at the scheme.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcc")]
    public string? Mcc { get; init; }

    /// <summary>
    /// Required for <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">authentication-only integration</see>. The merchant name that the issuer presents to the shopper if they get a challenge. We recommend to use the same value that you will use in the authorization. Maximum length is 40 characters.
    /// &gt; Optional for a <see href="https://docs.adyen.com/online-payments/3d-secure/native-3ds2/api-integration">full 3D Secure 2 integration</see>. Use this field if you are enrolled for 3D Secure 2 with us and want to override the merchant name already configured on your account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantName")]
    public string? MerchantName { get; init; }

    /// <summary>
    /// The <c>messageVersion</c> value indicating the 3D Secure 2 protocol version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("messageVersion")]
    public string? MessageVersion { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mobilePhone")]
    public MobilePhone? MobilePhone { get; init; }

    /// <summary>
    /// URL to where the issuer should send the <c>CRes</c>. Required if you are not using components for <c>channel</c> <b>Web</b> or if you are using classic integration <c>deviceChannel</c> <b>browser</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notificationURL")]
    public string? NotificationUrl { get; init; }

    /// <summary>
    /// Value <b>true</b> indicates that the transaction was de-tokenised prior to being received by the ACS.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payTokenInd")]
    public bool? PayTokenInd { get; init; }

    /// <summary>
    /// Indicates the type of payment for which an authentication is requested (message extension)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAuthenticationUseCase")]
    public string? PaymentAuthenticationUseCase { get; init; }

    /// <summary>
    /// Indicates the maximum number of authorisations permitted for instalment payments. Length: 1–3 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseInstalData")]
    [StringLength(3, MinimumLength = 1)]
    public string? PurchaseInstalData { get; init; }

    /// <summary>
    /// Date after which no further authorisations shall be performed. Format: YYYYMMDD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringExpiry")]
    public string? RecurringExpiry { get; init; }

    /// <summary>
    /// Indicates the minimum number of days between authorisations. Maximum length: 4 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringFrequency")]
    [MaxLength(4)]
    public string? RecurringFrequency { get; init; }

    /// <summary>
    /// The <c>sdkAppID</c> value as received from the 3D Secure 2 SDK.
    /// Required for <c>deviceChannel</c> set to <b>app</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkAppID")]
    public string? SdkAppId { get; init; }

    /// <summary>
    /// The <c>sdkEncData</c> value as received from the 3D Secure 2 SDK.
    /// Required for <c>deviceChannel</c> set to <b>app</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkEncData")]
    public string? SdkEncData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkEphemPubKey")]
    public SdkEphemPubKey3? SdkEphemPubKey { get; init; }

    /// <summary>
    /// The maximum amount of time in minutes for the 3D Secure 2 authentication process.
    /// Optional and only for <c>deviceChannel</c> set to <b>app</b>. Defaults to <b>60</b> minutes.
    /// </summary>
    [JsonPropertyName("sdkMaxTimeout")]
    public int? SdkMaxTimeout { get; init; } = 60;

    /// <summary>
    /// The <c>sdkReferenceNumber</c> value as received from the 3D Secure 2 SDK.
    /// Only for <c>deviceChannel</c> set to <b>app</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkReferenceNumber")]
    public string? SdkReferenceNumber { get; init; }

    /// <summary>
    /// The <c>sdkTransID</c> value as received from the 3D Secure 2 SDK.
    /// Only for <c>deviceChannel</c> set to <b>app</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkTransID")]
    public string? SdkTransId { get; init; }

    /// <summary>
    /// Version of the 3D Secure 2 mobile SDK.
    /// Only for <c>deviceChannel</c> set to <b>app</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkVersion")]
    public string? SdkVersion { get; init; }

    /// <summary>
    /// Completion indicator for the device fingerprinting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSCompInd")]
    public string? ThreeDscompInd { get; init; }

    /// <summary>
    /// Indicates the type of Authentication request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorAuthenticationInd")]
    public string? ThreeDsrequestorAuthenticationInd { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorAuthenticationInfo")]
    public ThreeDsrequestorAuthenticationInfo1? ThreeDsrequestorAuthenticationInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorChallengeInd")]
    public ThreeDsrequestorChallengeInd? ThreeDsrequestorChallengeInd { get; init; }

    /// <summary>
    /// Required for <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">authentication-only integration</see> for Visa. Unique 3D Secure requestor identifier assigned by the Directory Server when you enrol for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorID")]
    public string? ThreeDsrequestorId { get; init; }

    /// <summary>
    /// Required for <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">authentication-only integration</see> for Visa. Unique 3D Secure requestor name assigned by the Directory Server when you enrol for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorName")]
    public string? ThreeDsrequestorName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorPriorAuthenticationInfo")]
    public ThreeDsrequestorPriorAuthenticationInfo1? ThreeDsrequestorPriorAuthenticationInfo { get; init; }

    /// <summary>
    /// URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3D Secure 2 process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorURL")]
    public string? ThreeDsrequestorUrl { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transType")]
    public TransType? TransType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionType")]
    public TransactionType? TransactionType { get; init; }

    /// <summary>
    /// The <c>whiteListStatus</c> value returned from a previous 3D Secure 2 transaction, only applicable for 3D Secure 2 protocol version 2.2.0.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whiteListStatus")]
    public string? WhiteListStatus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("workPhone")]
    public WorkPhone? WorkPhone { get; init; }
}
