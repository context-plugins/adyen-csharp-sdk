using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Additional information for raising a dispute of <c>type</c> <b>other</b>. Required for disputes of <c>type</c> <b>other</b>.
/// <para>
/// <b>Note:</b> The <b>other</b> dispute <c>type</c> is currently in beta testing. Do not create or submit any disputes for this dispute <c>type</c> at this time.
/// </para>
/// </summary>
[JsonConverter(typeof(OtherInfo31Converter))]
public record OtherInfo31
{
    private readonly Optional<PatchableOtherInfo> _patchableOtherInfoValue;

    private readonly Optional<object?> _anonymousObjectValue;

    private OtherInfo31(Optional<PatchableOtherInfo> patchableOtherInfoValue,
        Optional<object?> anonymousObjectValue)
    {
        _patchableOtherInfoValue = patchableOtherInfoValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static OtherInfo31 PatchableOtherInfo(PatchableOtherInfo value) =>
        new(Optional<PatchableOtherInfo>.Some(value), default);

    public static OtherInfo31 AnonymousObject(object? value) => new(default, Optional<object?>.Some(value));

    public bool TryGetPatchableOtherInfo(out PatchableOtherInfo value) =>
        _patchableOtherInfoValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator OtherInfo31(PatchableOtherInfo value) => PatchableOtherInfo(value);
}

file sealed class OtherInfo31Converter : JsonConverter<OtherInfo31>
{
    public override OtherInfo31 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<PatchableOtherInfo>(root, options, out var patchableOtherInfoValue))
        {
            return OtherInfo31.PatchableOtherInfo(patchableOtherInfoValue);
        }
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return OtherInfo31.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match PatchableOtherInfo or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, OtherInfo31 value, JsonSerializerOptions options)
    {
        if (value.TryGetPatchableOtherInfo(out var patchableOtherInfoValue))
        {
            JsonSerializer.Serialize(writer, patchableOtherInfoValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(OtherInfo31)} contains no valid value to serialize.");
        }
    }
}
