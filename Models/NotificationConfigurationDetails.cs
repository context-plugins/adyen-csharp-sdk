using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record NotificationConfigurationDetails
{
    /// <summary>
    /// Indicates whether the notification subscription is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// The version of the notification to which you are subscribing. To make sure that your integration can properly process the notification, subscribe to the same version as the API that you're using.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("apiVersion")]
    public int? ApiVersion { get; init; }

    /// <summary>
    /// A description of the notification subscription configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Contains objects that define event types and their subscription settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventConfigs")]
    public IReadOnlyList<NotificationEventConfiguration>? EventConfigs { get; init; }

    /// <summary>
    /// A string with which to salt the notification(s) before hashing. If this field is provided, a hash value will be included under the notification header <c>HmacSignature</c> and the hash protocol will be included under the notification header <c>Protocol</c>. A notification body along with its <c>hmacSignatureKey</c> and <c>Protocol</c> can be used to calculate a hash value; matching this hash value with the <c>HmacSignature</c> will ensure that the notification body has not been tampered with or corrupted.
    /// <para>
    /// &gt;Must be a 32-byte hex-encoded string (i.e. a string containing 64 hexadecimal characters; e.g. "b0ea55c2fe60d4d1d605e9c385e0e7f7e6cafbb939ce07010f31a327a0871f27").
    /// </para>
    /// <para>
    /// The omission of this field will preclude the provision of the <c>HmacSignature</c> and <c>Protocol</c> headers in notification(s).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hmacSignatureKey")]
    public string? HmacSignatureKey { get; init; }

    /// <summary>
    /// Adyen-generated ID for the entry, returned in the response when you create a notification configuration. Required when updating an existing configuration using <see href="https://docs.adyen.com/api-explorer/#/NotificationConfigurationService/latest/post/updateNotificationConfiguration"><c>/updateNotificationConfiguration</c></see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notificationId")]
    public long? NotificationId { get; init; }

    /// <summary>
    /// The password to use when accessing the notifyURL with the specified username.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notifyPassword")]
    public string? NotifyPassword { get; init; }

    /// <summary>
    /// The URL to which the notifications are to be sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notifyURL")]
    public string? NotifyUrl { get; init; }

    /// <summary>
    /// The username to use when accessing the notifyURL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notifyUsername")]
    public string? NotifyUsername { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sslProtocol")]
    public SslProtocol? SslProtocol { get; init; }
}
