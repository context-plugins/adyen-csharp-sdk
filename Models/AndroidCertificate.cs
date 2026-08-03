using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AndroidCertificate
{
    /// <summary>
    /// The description that was provided when uploading the certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The file format of the certificate, as indicated by the file extension. For example, <b>.cert</b> or <b>.pem</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extension")]
    public string? Extension { get; init; }

    /// <summary>
    /// The unique identifier of the certificate.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The file name of the certificate. For example, <b>mycert</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The date when the certificate stops to be valid.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notAfter")]
    public DateTimeOffset? NotAfter { get; init; }

    /// <summary>
    /// The date when the certificate starts to be valid.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notBefore")]
    public DateTimeOffset? NotBefore { get; init; }

    /// <summary>
    /// The status of the certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
