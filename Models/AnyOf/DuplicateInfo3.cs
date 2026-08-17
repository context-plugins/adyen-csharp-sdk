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

    private DuplicateInfo3(Optional<PatchableDuplicateInfo> patchableDuplicateInfoValue)
    {
        _patchableDuplicateInfoValue = patchableDuplicateInfoValue;
    }

    public static DuplicateInfo3 PatchableDuplicateInfo(PatchableDuplicateInfo value) =>
        new(Optional<PatchableDuplicateInfo>.Some(value));

    public bool TryGetPatchableDuplicateInfo(out PatchableDuplicateInfo value) =>
        _patchableDuplicateInfoValue.TryGetValue(out value);

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
        throw new JsonException($"JSON does not match PatchableDuplicateInfo schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DuplicateInfo3 value, JsonSerializerOptions options)
    {
        if (value.TryGetPatchableDuplicateInfo(out var patchableDuplicateInfoValue))
        {
            JsonSerializer.Serialize(writer, patchableDuplicateInfoValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DuplicateInfo3)} contains no valid value to serialize.");
        }
    }
}
