using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record InstalledApks
{
    /// <summary>
    /// The date and time when the app was installed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confirmationDate")]
    public DateTimeOffset? ConfirmationDate { get; init; }

    /// <summary>
    /// The package name of the app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("packageName")]
    public string? PackageName { get; init; }

    /// <summary>
    /// The version name of the app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("versionName")]
    public string? VersionName { get; init; }
}
