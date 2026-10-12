using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdateCompanyWebhookRequest
{
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
    /// Indicates if the webhook configuration is active. The field must be <b>true</b> for us to send webhooks about events related an account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// Additional shopper and transaction information to be included in your <see href="https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes">standard webhooks</see>. Find out more about the available <see href="https://docs.adyen.com/development-resources/webhooks/additional-settings">additional settings</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalSettings")]
    public AdditionalSettings1? AdditionalSettings { get; init; }

    /// <summary>
    /// Format or protocol for receiving webhooks. Possible values:
    /// * <b>soap</b>
    /// * <b>http</b>
    /// * <b>json</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("communicationFormat")]
    public CommunicationFormat? CommunicationFormat { get; init; }

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
    /// Shows how merchant accounts are filtered when configuring the webhook. Possible values:
    /// * <b>includeAccounts</b>: The webhook is configured for the merchant accounts listed in <c>filterMerchantAccounts</c>.
    /// * <b>excludeAccounts</b>: The webhook is not configured for the merchant accounts listed in <c>filterMerchantAccounts</c>.
    /// * <b>allAccounts</b>: Includes all merchant accounts, and does not require specifying <c>filterMerchantAccounts</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterMerchantAccountType")]
    public FilterMerchantAccountType2? FilterMerchantAccountType { get; init; }

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
    /// Network type for Terminal API notification webhooks. Possible values:
    /// * <b>public</b>
    /// * <b>local</b>
    /// <para>
    /// Default Value: <b>public</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkType")]
    public NetworkType? NetworkType { get; init; }

    /// <summary>
    /// Password to access the webhook URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }

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
    /// Public URL where webhooks will be sent, for example <b>https://www.domain.com/webhook-endpoint</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    /// Username to access the webhook URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("username")]
    [MaxLength(255)]
    public string? Username { get; init; }
}
