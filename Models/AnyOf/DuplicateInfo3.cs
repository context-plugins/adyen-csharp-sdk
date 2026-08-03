using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Additional information for raising a dispute of <c>type</c> <b>duplicate</b>. Required for disputes of <c>type</c> <b>duplicate</b>.
/// </summary>
[JsonConverter(typeof(DuplicateInfo3Converter))]
public record DuplicateInfo3
{
    private readonly Optional<PatchableDuplicateInfo> _patchableDuplicateInfoValue;

    private readonly Optional<object?> _anonymousObjectValue;

    private DuplicateInfo3(Optional<PatchableDuplicateInfo> patchableDuplicateInfoValue,
        Optional<object?> anonymousObjectValue)
    {
        _patchableDuplicateInfoValue = patchableDuplicateInfoValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static DuplicateInfo3 PatchableDuplicateInfo(PatchableDuplicateInfo value) =>
        new(Optional<PatchableDuplicateInfo>.Some(value), default);

    public static DuplicateInfo3 AnonymousObject(object? value) =>
        new(default, Optional<object?>.Some(value));

    public bool TryGetPatchableDuplicateInfo(out PatchableDuplicateInfo value) =>
        _patchableDuplicateInfoValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator DuplicateInfo3(PatchableDuplicateInfo value) =>
        PatchableDuplicateInfo(value);
}

file sealed class DuplicateInfo3Converter : JsonConverter<DuplicateInfo3>
{
    public override DuplicateInfo3 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<PatchableDuplicateInfo>(root,
            options,
            out var patchableDuplicateInfoValue))
        {
            return DuplicateInfo3.PatchableDuplicateInfo(patchableDuplicateInfoValue);
        }
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return DuplicateInfo3.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match PatchableDuplicateInfo or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DuplicateInfo3 value, JsonSerializerOptions options)
    {
        if (value.TryGetPatchableDuplicateInfo(out var patchableDuplicateInfoValue))
        {
            JsonSerializer.Serialize(writer, patchableDuplicateInfoValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DuplicateInfo3)} contains no valid value to serialize.");
        }
    }
}
