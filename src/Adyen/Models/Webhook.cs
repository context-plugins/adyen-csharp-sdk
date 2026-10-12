using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Webhook
{
    /// <summary>
    /// References to resources connected with this webhook.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public WebhookLinks2? Links { get; init; }

    /// <summary>
    /// Indicates if expired SSL certificates are accepted. Default value: <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acceptsExpiredCertificate")]
    public bool? AcceptsExpiredCertificate { get; init; }

    /// <summary>
    /// Indicates if self-signed SSL certificates are accepted. Default value: <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acceptsSelfSignedCertificate")]
    public bool? AcceptsSelfSignedCertificate { get; init; }

    /// <summary>
    /// Indicates if untrusted SSL certificates are accepted. Default value: <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acceptsUntrustedRootCertificate")]
    public bool? AcceptsUntrustedRootCertificate { get; init; }

    /// <summary>
    /// Reference to the account the webook is set on.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountReference")]
    public string? AccountReference { get; init; }

    /// <summary>
    /// Indicates if the webhook configuration is active. The field must be <b>true</b> for you to receive webhooks about events related an account.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// Additional shopper and transaction information to be included in your <see href="https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes">standard webhooks</see>. Find out more about the available <see href="https://docs.adyen.com/development-resources/webhooks/additional-settings">additional settings</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalSettings")]
    public AdditionalSettingsResponse1? AdditionalSettings { get; init; }

    /// <summary>
    /// The alias of our SSL certificate. When you receive a notification from us, the alias from the HMAC signature will match this alias.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("certificateAlias")]
    public string? CertificateAlias { get; init; }

    /// <summary>
    /// Format or protocol for receiving webhooks. Possible values:
    /// * <b>soap</b>
    /// * <b>http</b>
    /// * <b>json</b>
    /// </summary>
    [JsonPropertyName("communicationFormat")]
    public required CommunicationFormat CommunicationFormat { get; init; }

    /// <summary>
    /// Your description for this webhook configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// SSL version to access the public webhook URL specified in the <c>url</c> field. Possible values:
    /// * <b>TLSv1.3</b>
    /// * <b>TLSv1.2</b>
    /// * <b>HTTP</b> - Only allowed on Test environment.
    /// <para>
    /// If not specified, the webhook will use <c>sslVersion</c>: <b>TLSv1.2</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptionProtocol")]
    public EncryptionProtocol? EncryptionProtocol { get; init; }

    /// <summary>
    /// Shows how merchant accounts are included in company-level webhooks. Possible values:
    /// * <b>includeAccounts</b>
    /// * <b>excludeAccounts</b>
    /// * <b>allAccounts</b>: Includes all merchant accounts, and does not require specifying <c>filterMerchantAccounts</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterMerchantAccountType")]
    public FilterMerchantAccountType1? FilterMerchantAccountType { get; init; }

    /// <summary>
    /// A list of merchant account names that are included or excluded from receiving the webhook. Inclusion or exclusion is based on the value defined for <c>filterMerchantAccountType</c>.
    /// <para>
    /// Required if <c>filterMerchantAccountType</c> is either:
    /// * <b>includeAccounts</b>
    /// * <b>excludeAccounts</b>
    /// </para>
    /// <para>
    /// Not needed for <c>filterMerchantAccountType</c>: <b>allAccounts</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterMerchantAccounts")]
    public IReadOnlyList<string>? FilterMerchantAccounts { get; init; }

    /// <summary>
    /// Indicates if the webhook configuration has errors that need troubleshooting. If the value is <b>true</b>, troubleshoot the configuration using the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/webhooks/{webhookid}/test">testing endpoint</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasError")]
    public bool? HasError { get; init; }

    /// <summary>
    /// Indicates if the webhook is password protected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasPassword")]
    public bool? HasPassword { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/Key_checksum_value">checksum</see> of the HMAC key generated for this webhook. You can use this value to uniquely identify the HMAC key configured for this webhook.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hmacKeyCheckValue")]
    public string? HmacKeyCheckValue { get; init; }

    /// <summary>
    /// Unique identifier for this webhook.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Network type for Terminal API details webhooks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkType")]
    public NetworkType2? NetworkType { get; init; }

    /// <summary>
    /// Indicates if the SOAP action header needs to be populated. Default value: <b>false</b>.
    /// <para>
    /// Only applies if <c>communicationFormat</c>: <b>soap</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("populateSoapActionHeader")]
    public bool? PopulateSoapActionHeader { get; init; }

    /// <summary>
    /// The type of webhook. Possible values are:
    /// <list type="bullet">
    ///   <item><description><b>standard</b></description></item>
    ///   <item><description><b>account-settings-notification</b></description></item>
    ///   <item><description><b>banktransfer-notification</b></description></item>
    ///   <item><description><b>boletobancario-notification</b></description></item>
    ///   <item><description><b>directdebit-notification</b></description></item>
    ///   <item><description><b>ach-notification-of-change-notification</b></description></item>
    ///   <item><description><b>direct-debit-notice-of-change-notification</b></description></item>
    ///   <item><description><b>pending-notification</b></description></item>
    ///   <item><description><b>ideal-notification</b></description></item>
    ///   <item><description><b>ideal-pending-notification</b></description></item>
    ///   <item><description><b>report-notification</b></description></item>
    ///   <item><description><b>terminal-api-notification</b></description></item>
    ///   <item><description><b>terminal-settings</b></description></item>
    ///   <item><description><b>terminal-boarding</b></description></item>
    /// </list>
    /// <para>
    /// Find out more about <see href="https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes">standard webhooks</see> and <see href="https://docs.adyen.com/development-resources/webhooks/webhook-types/#other-webhooks">other types of webhooks</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Public URL where webhooks will be sent, for example <b>https://www.domain.com/webhook-endpoint</b>.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    /// <summary>
    /// Username to access the webhook URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("username")]
    public string? Username { get; init; }
}
