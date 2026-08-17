using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Additional information for raising a dispute of <c>type</c> <b>notDelivered</b>. Required for disputes of <c>type</c> <b>notDelivered</b>.
/// </summary>
[JsonConverter(typeof(NotDeliveredInfo3Converter))]
public record NotDeliveredInfo3
{
    private readonly Optional<PatchableNotDeliveredInfo> _patchableNotDeliveredInfoValue;

    private NotDeliveredInfo3(Optional<PatchableNotDeliveredInfo> patchableNotDeliveredInfoValue)
    {
        _patchableNotDeliveredInfoValue = patchableNotDeliveredInfoValue;
    }

    public static NotDeliveredInfo3 PatchableNotDeliveredInfo(PatchableNotDeliveredInfo value) =>
        new(Optional<PatchableNotDeliveredInfo>.Some(value));

    public bool TryGetPatchableNotDeliveredInfo(out PatchableNotDeliveredInfo value) =>
        _patchableNotDeliveredInfoValue.TryGetValue(out value);

    public static implicit operator NotDeliveredInfo3(PatchableNotDeliveredInfo value) =>
        PatchableNotDeliveredInfo(value);
}

file sealed class NotDeliveredInfo3Converter : JsonConverter<NotDeliveredInfo3>
{
    public override NotDeliveredInfo3 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<PatchableNotDeliveredInfo>(root,
            options,
            out var patchableNotDeliveredInfoValue))
        {
            return NotDeliveredInfo3.PatchableNotDeliveredInfo(patchableNotDeliveredInfoValue);
        }
        throw new JsonException($"JSON does not match PatchableNotDeliveredInfo schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, NotDeliveredInfo3 value, JsonSerializerOptions options)
    {
        if (value.TryGetPatchableNotDeliveredInfo(out var patchableNotDeliveredInfoValue))
        {
            JsonSerializer.Serialize(writer, patchableNotDeliveredInfoValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(NotDeliveredInfo3)} contains no valid value to serialize.");
        }
    }
}
