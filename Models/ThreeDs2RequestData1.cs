using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ThreeDs2RequestData1
{
    /// <summary>
    /// Additional information about the cardholder’s account provided by the 3DS Requestor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acctInfo")]
    public AcctInfo? AcctInfo { get; init; }

    /// <summary>
    /// Indicates the type of account. For example, for a multi-account card product. Length: 2 characters. Allowed values:
    /// * <b>01</b> — Not applicable
    /// * <b>02</b> — Credit
    /// * <b>03</b> — Debit
    /// </summary>
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

    /// <summary>
    /// Indicates whether the cardholder shipping address and cardholder billing address are the same. Allowed values:
    /// * <b>Y</b> — Shipping address matches billing address.
    /// * <b>N</b> — Shipping address does not match billing address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addrMatch")]
    public AddrMatch? AddrMatch { get; init; }

    /// <summary>
    /// If set to true, you will only perform the <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">3D Secure 2 authentication</see>, and not the payment authorisation.
    /// </summary>
    [JsonPropertyName("authenticationOnly")]
    public bool? AuthenticationOnly { get; init; } = false;

    /// <summary>
    /// Possibility to specify a preference for receiving a challenge from the issuer.
    /// Allowed values:
    /// * <c>noPreference</c>
    /// * <c>requestNoChallenge</c>
    /// * <c>requestChallenge</c>
    /// * <c>requestChallengeAsMandate</c>
    /// </summary>
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

    /// <summary>
    /// Display options for the 3D Secure 2 SDK.
    /// Optional and only for <c>deviceChannel</c> <b>app</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceRenderOptions")]
    public DeviceRenderOptions? DeviceRenderOptions { get; init; }

    /// <summary>
    /// The home phone number provided by the cardholder. The phone number must consist of a country code, followed by the number. If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>, and did not send the shopper's phone number in <c>telephoneNumber</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homePhone")]
    public Phone? HomePhone { get; init; }

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

    /// <summary>
    /// The mobile phone number provided by the cardholder. The phone number must consist of a country code, followed by the number. If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>, and did not send the shopper's phone number in <c>telephoneNumber</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mobilePhone")]
    public Phone? MobilePhone { get; init; }

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

    /// <summary>
    /// The <c>sdkEphemPubKey</c> value as received from the 3D Secure 2 SDK.
    /// Required for <c>deviceChannel</c> set to <b>app</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkEphemPubKey")]
    public SdkEphemPubKey? SdkEphemPubKey { get; init; }

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
    public string? ThreeDsCompInd { get; init; }

    /// <summary>
    /// Indicates the type of Authentication request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorAuthenticationInd")]
    public string? ThreeDsRequestorAuthenticationInd { get; init; }

    /// <summary>
    /// Information about how the 3DS Requestor authenticated the cardholder before or during the transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorAuthenticationInfo")]
    public ThreeDsRequestorAuthenticationInfo? ThreeDsRequestorAuthenticationInfo { get; init; }

    /// <summary>
    /// Indicates whether a challenge is requested for this transaction. Possible values:
    /// * <b>01</b> — No preference
    /// * <b>02</b> — No challenge requested
    /// * <b>03</b> — Challenge requested (3DS Requestor preference)
    /// * <b>04</b> — Challenge requested (Mandate)
    /// * <b>05</b> — No challenge (transactional risk analysis is already performed)
    /// * <b>06</b> — Data Only
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorChallengeInd")]
    public ThreeDsReqAuthMethod? ThreeDsRequestorChallengeInd { get; init; }

    /// <summary>
    /// Required for <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">authentication-only integration</see> for Visa. Unique 3D Secure requestor identifier assigned by the Directory Server when you enrol for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorID")]
    public string? ThreeDsRequestorId { get; init; }

    /// <summary>
    /// Required for <see href="https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only">authentication-only integration</see> for Visa. Unique 3D Secure requestor name assigned by the Directory Server when you enrol for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorName")]
    public string? ThreeDsRequestorName { get; init; }

    /// <summary>
    /// Information about how the 3DS Requestor authenticated the cardholder as part of a previous 3DS transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorPriorAuthenticationInfo")]
    public ThreeDsRequestorPriorAuthenticationInfo? ThreeDsRequestorPriorAuthenticationInfo { get; init; }

    /// <summary>
    /// URL of the (customer service) website that will be shown to the shopper in case of technical errors during the 3D Secure 2 process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorURL")]
    public string? ThreeDsRequestorUrl { get; init; }

    /// <summary>
    /// Identifies the type of transaction being authenticated. Length: 2 characters. Allowed values:
    /// * <b>01</b> — Goods/Service Purchase
    /// * <b>03</b> — Check Acceptance
    /// * <b>10</b> — Account Funding
    /// * <b>11</b> — Quasi-Cash Transaction
    /// * <b>28</b> — Prepaid Activation and Load
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transType")]
    public TransType? TransType { get; init; }

    /// <summary>
    /// Identify the type of the transaction being authenticated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionType")]
    public TransactionType? TransactionType { get; init; }

    /// <summary>
    /// The <c>whiteListStatus</c> value returned from a previous 3D Secure 2 transaction, only applicable for 3D Secure 2 protocol version 2.2.0.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whiteListStatus")]
    public string? WhiteListStatus { get; init; }

    /// <summary>
    /// The work phone number provided by the cardholder. The phone number must consist of a country code, followed by the number. If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>, and did not send the shopper's phone number in <c>telephoneNumber</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("workPhone")]
    public Phone? WorkPhone { get; init; }
}
