using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Information about the action to take.
/// </summary>
[JsonConverter(typeof(ActionDetailsConverter))]
public record ActionDetails
{
    private readonly Optional<ForceRebootDetails> _forceRebootDetailsValue;

    private readonly Optional<InstallAndroidAppDetails> _installAndroidAppDetailsValue;

    private readonly Optional<InstallAndroidCertificateDetails> _installAndroidCertificateDetailsValue;

    private readonly Optional<ReleaseUpdateDetails> _releaseUpdateDetailsValue;

    private readonly Optional<UninstallAndroidAppDetails> _uninstallAndroidAppDetailsValue;

    private readonly Optional<UninstallAndroidCertificateDetails> _uninstallAndroidCertificateDetailsValue;

    private ActionDetails(Optional<ForceRebootDetails> forceRebootDetailsValue,
        Optional<InstallAndroidAppDetails> installAndroidAppDetailsValue,
        Optional<InstallAndroidCertificateDetails> installAndroidCertificateDetailsValue,
        Optional<ReleaseUpdateDetails> releaseUpdateDetailsValue,
        Optional<UninstallAndroidAppDetails> uninstallAndroidAppDetailsValue,
        Optional<UninstallAndroidCertificateDetails> uninstallAndroidCertificateDetailsValue)
    {
        _forceRebootDetailsValue = forceRebootDetailsValue;
        _installAndroidAppDetailsValue = installAndroidAppDetailsValue;
        _installAndroidCertificateDetailsValue = installAndroidCertificateDetailsValue;
        _releaseUpdateDetailsValue = releaseUpdateDetailsValue;
        _uninstallAndroidAppDetailsValue = uninstallAndroidAppDetailsValue;
        _uninstallAndroidCertificateDetailsValue = uninstallAndroidCertificateDetailsValue;
    }

    public static ActionDetails ForceRebootDetails(ForceRebootDetails value) =>
        new(Optional<ForceRebootDetails>.Some(value), default, default, default, default, default);

    public static ActionDetails InstallAndroidAppDetails(InstallAndroidAppDetails value) =>
        new(default, Optional<InstallAndroidAppDetails>.Some(value), default, default, default, default);

    public static ActionDetails InstallAndroidCertificateDetails(InstallAndroidCertificateDetails value) =>
        new(default, default, Optional<InstallAndroidCertificateDetails>.Some(value), default, default, default);

    public static ActionDetails ReleaseUpdateDetails(ReleaseUpdateDetails value) =>
        new(default, default, default, Optional<ReleaseUpdateDetails>.Some(value), default, default);

    public static ActionDetails UninstallAndroidAppDetails(UninstallAndroidAppDetails value) =>
        new(default, default, default, default, Optional<UninstallAndroidAppDetails>.Some(value), default);

    public static ActionDetails UninstallAndroidCertificateDetails(UninstallAndroidCertificateDetails value) =>
        new(default, default, default, default, default, Optional<UninstallAndroidCertificateDetails>.Some(value));

    public bool TryGetForceRebootDetails(out ForceRebootDetails value) =>
        _forceRebootDetailsValue.TryGetValue(out value);

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

    public static implicit operator ActionDetails(ForceRebootDetails value) => ForceRebootDetails(value);

    public static implicit operator ActionDetails(InstallAndroidAppDetails value) =>
        InstallAndroidAppDetails(value);

    public static implicit operator ActionDetails(InstallAndroidCertificateDetails value) =>
        InstallAndroidCertificateDetails(value);

    public static implicit operator ActionDetails(ReleaseUpdateDetails value) => ReleaseUpdateDetails(value);

    public static implicit operator ActionDetails(UninstallAndroidAppDetails value) =>
        UninstallAndroidAppDetails(value);

    public static implicit operator ActionDetails(UninstallAndroidCertificateDetails value) =>
        UninstallAndroidCertificateDetails(value);
}

file sealed class ActionDetailsConverter : JsonConverter<ActionDetails>
{
    public override ActionDetails Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ForceRebootDetails>(root, options, out var forceRebootDetailsValue))
        {
            return ActionDetails.ForceRebootDetails(forceRebootDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<InstallAndroidAppDetails>(root,
            options,
            out var installAndroidAppDetailsValue))
        {
            return ActionDetails.InstallAndroidAppDetails(installAndroidAppDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<InstallAndroidCertificateDetails>(root,
            options,
            out var installAndroidCertificateDetailsValue))
        {
            return ActionDetails.InstallAndroidCertificateDetails(installAndroidCertificateDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<ReleaseUpdateDetails>(root, options, out var releaseUpdateDetailsValue))
        {
            return ActionDetails.ReleaseUpdateDetails(releaseUpdateDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<UninstallAndroidAppDetails>(root,
            options,
            out var uninstallAndroidAppDetailsValue))
        {
            return ActionDetails.UninstallAndroidAppDetails(uninstallAndroidAppDetailsValue);
        }
        if (JsonSerializer.TryDeserialize<UninstallAndroidCertificateDetails>(root,
            options,
            out var uninstallAndroidCertificateDetailsValue))
        {
            return ActionDetails.UninstallAndroidCertificateDetails(uninstallAndroidCertificateDetailsValue);
        }
        throw new JsonException($"JSON does not match ForceRebootDetails or InstallAndroidAppDetails or InstallAndroidCertificateDetails or ReleaseUpdateDetails or UninstallAndroidAppDetails or UninstallAndroidCertificateDetails schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ActionDetails value, JsonSerializerOptions options)
    {
        if (value.TryGetForceRebootDetails(out var forceRebootDetailsValue))
        {
            JsonSerializer.Serialize(writer, forceRebootDetailsValue, options);
        }
        else if (value.TryGetInstallAndroidAppDetails(out var installAndroidAppDetailsValue))
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
        else
        {
            throw new JsonException($"{nameof(ActionDetails)} contains no valid value to serialize.");
        }
    }
}
