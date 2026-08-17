using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AndroidApp
{
    /// <summary>
    /// The description that was provided when uploading the app. The description is not shown on the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The error code of the Android app with the <c>status</c> of either <b>error</b> or <b>invalid</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; init; }

    /// <summary>
    /// The list of errors of the Android app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<AndroidAppError>? Errors { get; init; }

    /// <summary>
    /// The unique identifier of the app.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The app name that is shown on the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label")]
    public string? Label { get; init; }

    /// <summary>
    /// The package name that uniquely identifies the Android app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("packageName")]
    public string? PackageName { get; init; }

    /// <summary>
    /// The status of the app. Possible values:
    /// * <c>processing</c>: the app is being signed and converted to a format that the terminal can handle.
    /// * <c>error</c>: something went wrong. Check that the app matches the <see href="https://docs.adyen.com/point-of-sale/android-terminals/app-requirements">requirements</see>.
    /// * <c>invalid</c>: there is something wrong with the APK file of the app.
    /// * <c>ready</c>: the app has been signed and converted.
    /// * <c>archived</c>: the app is no longer available.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status7 Status { get; init; }

    /// <summary>
    /// The version number of the app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("versionCode")]
    public int? VersionCode { get; init; }

    /// <summary>
    /// The app version number that is shown on the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("versionName")]
    public string? VersionName { get; init; }
}
