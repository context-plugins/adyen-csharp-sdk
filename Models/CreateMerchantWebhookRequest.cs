using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CreateMerchantWebhookRequest
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
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalSettings")]
    public AdditionalSettings? AdditionalSettings { get; init; }

    [JsonPropertyName("communicationFormat")]
    public required CommunicationFormat CommunicationFormat { get; init; }

    /// <summary>
    /// Your description for this webhook configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptionProtocol")]
    public EncryptionProtocol? EncryptionProtocol { get; init; }

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
    /// The type of webhook that is being created. Possible values are:
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
    ///   <item><description><b>rreq-notification</b></description></item>
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
    [MaxLength(255)]
    public string? Username { get; init; }
}
