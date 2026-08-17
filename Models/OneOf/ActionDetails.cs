using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

/// <summary>
/// Information about the action to take.
/// </summary>
[JsonConverter(typeof(ActionDetailsConverter))]
public record ActionDetails
{
    private readonly Optional<InstallAndroidAppDetails> _installAndroidAppDetailsValue;

    private readonly Optional<InstallAndroidCertificateDetails> _installAndroidCertificateDetailsValue;

    private readonly Optional<ReleaseUpdateDetails> _releaseUpdateDetailsValue;

    private readonly Optional<UninstallAndroidAppDetails> _uninstallAndroidAppDetailsValue;

    private readonly Optional<UninstallAndroidCertificateDetails> _uninstallAndroidCertificateDetailsValue;

    private readonly Optional<ForceRebootDetails> _forceRebootDetailsValue;

    private ActionDetails(Optional<InstallAndroidAppDetails> installAndroidAppDetailsValue,
        Optional<InstallAndroidCertificateDetails> installAndroidCertificateDetailsValue,
        Optional<ReleaseUpdateDetails> releaseUpdateDetailsValue,
        Optional<UninstallAndroidAppDetails> uninstallAndroidAppDetailsValue,
        Optional<UninstallAndroidCertificateDetails> uninstallAndroidCertificateDetailsValue,
        Optional<ForceRebootDetails> forceRebootDetailsValue)
    {
        _installAndroidAppDetailsValue = installAndroidAppDetailsValue;
        _installAndroidCertificateDetailsValue = installAndroidCertificateDetailsValue;
        _releaseUpdateDetailsValue = releaseUpdateDetailsValue;
        _uninstallAndroidAppDetailsValue = uninstallAndroidAppDetailsValue;
        _uninstallAndroidCertificateDetailsValue = uninstallAndroidCertificateDetailsValue;
        _forceRebootDetailsValue = forceRebootDetailsValue;
    }

    public static ActionDetails InstallAndroidAppDetails(InstallAndroidAppDetails value) =>
        new(Optional<InstallAndroidAppDetails>.Some(value), default, default, default, default, default);

    public static ActionDetails InstallAndroidCertificateDetails(InstallAndroidCertificateDetails value) =>
        new(default, Optional<InstallAndroidCertificateDetails>.Some(value), default, default, default, default);

    public static ActionDetails ReleaseUpdateDetails(ReleaseUpdateDetails value) =>
        new(default, default, Optional<ReleaseUpdateDetails>.Some(value), default, default, default);

    public static ActionDetails UninstallAndroidAppDetails(UninstallAndroidAppDetails value) =>
        new(default, default, default, Optional<UninstallAndroidAppDetails>.Some(value), default, default);

    public static ActionDetails UninstallAndroidCertificateDetails(UninstallAndroidCertificateDetails value) =>
        new(default, default, default, default, Optional<UninstallAndroidCertificateDetails>.Some(value), default);

    public static ActionDetails ForceRebootDetails(ForceRebootDetails value) =>
        new(default, default, default, default, default, Optional<ForceRebootDetails>.Some(value));

    public bool TryGetInstallAndroidAppDetails(out InstallAndroidAppDetails value) =>
        _installAndroidAppDetailsValue.TryGetValue(out value);

    public bool TryGetInstallAndroidCertificateDetails(out InstallAndroidCertificateDetails value) =>
        _installAndroidCertificateDetailsValue.TryGetValue(out value);

    public bool TryGetReleaseUpdateDetails(out ReleaseUpdateDetails value) =>
        _releaseUpdateDetailsValue.TryGetValue(out value);

    public bool TryGetUninstallAndroidAppDetails(out UninstallAndroidAppDetails value) =>
        _uninstallAndroidAppDetailsValue.TryGetValue(out value);

    public bool TryGetUninstallAndroidCertificateDetails(out UninstallAndroidCertificateDetails value) =>
        _uninstallAndroidCertificateDetailsValue.TryGetValue(out value);

    public bool TryGetForceRebootDetails(out ForceRebootDetails value) =>
        _forceRebootDetailsValue.TryGetValue(out value);

    public static implicit operator ActionDetails(InstallAndroidAppDetails value) =>
        InstallAndroidAppDetails(value);

    public static implicit operator ActionDetails(InstallAndroidCertificateDetails value) =>
        InstallAndroidCertificateDetails(value);

    public static implicit operator ActionDetails(ReleaseUpdateDetails value) => ReleaseUpdateDetails(value);

    public static implicit operator ActionDetails(UninstallAndroidAppDetails value) =>
        UninstallAndroidAppDetails(value);

    public static implicit operator ActionDetails(UninstallAndroidCertificateDetails value) =>
        UninstallAndroidCertificateDetails(value);

    public static implicit operator ActionDetails(ForceRebootDetails value) => ForceRebootDetails(value);
}

file sealed class ActionDetailsConverter : JsonConverter<ActionDetails>
{
    public override ActionDetails Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var typeProperty))
        {
            throw new JsonException("Missing required 'type' discriminator field");
        }
        var discriminator = typeProperty.GetString();
        return discriminator switch
        {
            "InstallAndroidApp" => ActionDetails.InstallAndroidAppDetails(root.Deserialize<InstallAndroidAppDetails>(options)!),
            "InstallAndroidCertificate" => ActionDetails.InstallAndroidCertificateDetails(root.Deserialize<InstallAndroidCertificateDetails>(options)!),
            "ReleaseUpdate" => ActionDetails.ReleaseUpdateDetails(root.Deserialize<ReleaseUpdateDetails>(options)!),
            "UninstallAndroidApp" => ActionDetails.UninstallAndroidAppDetails(root.Deserialize<UninstallAndroidAppDetails>(options)!),
            "UninstallAndroidCertificate" => ActionDetails.UninstallAndroidCertificateDetails(root.Deserialize<UninstallAndroidCertificateDetails>(options)!),
            "ForceReboot" => ActionDetails.ForceRebootDetails(root.Deserialize<ForceRebootDetails>(options)!),
            _ => throw new JsonException($"JSON does not match InstallAndroidAppDetails or InstallAndroidCertificateDetails or ReleaseUpdateDetails or UninstallAndroidAppDetails or UninstallAndroidCertificateDetails or ForceRebootDetails schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, ActionDetails value, JsonSerializerOptions options)
    {
        if (value.TryGetInstallAndroidAppDetails(out var installAndroidAppDetailsValue))
        {
            JsonSerializer.Serialize(writer, installAndroidAppDetailsValue, options);
        }
        else if (value.TryGetInstallAndroidCertificateDetails(out var installAndroidCertificateDetailsValue))
        {
            JsonSerializer.Serialize(writer, installAndroidCertificateDetailsValue, options);
        }
        else if (value.TryGetReleaseUpdateDetails(out var releaseUpdateDetailsValue))
        {
            JsonSerializer.Serialize(writer, releaseUpdateDetailsValue, options);
        }
        else if (value.TryGetUninstallAndroidAppDetails(out var uninstallAndroidAppDetailsValue))
        {
            JsonSerializer.Serialize(writer, uninstallAndroidAppDetailsValue, options);
        }
        else if (value.TryGetUninstallAndroidCertificateDetails(out var uninstallAndroidCertificateDetailsValue))
        {
            JsonSerializer.Serialize(writer, uninstallAndroidCertificateDetailsValue, options);
        }
        else if (value.TryGetForceRebootDetails(out var forceRebootDetailsValue))
        {
            JsonSerializer.Serialize(writer, forceRebootDetailsValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ActionDetails)} contains no valid value to serialize.");
        }
    }
}
