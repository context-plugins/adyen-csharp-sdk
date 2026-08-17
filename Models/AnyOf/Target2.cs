using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The target balance for the balance account that the top-up must achieve.
/// </summary>
[JsonConverter(typeof(Target2Converter))]
public record Target2
{
    private readonly Optional<PatchableAmountDto> _patchableAmountDtoValue;

    private Target2(Optional<PatchableAmountDto> patchableAmountDtoValue)
    {
        _patchableAmountDtoValue = patchableAmountDtoValue;
    }

    public static Target2 PatchableAmountDto(PatchableAmountDto value) =>
        new(Optional<PatchableAmountDto>.Some(value));

    public bool TryGetPatchableAmountDto(out PatchableAmountDto value) =>
        _patchableAmountDtoValue.TryGetValue(out value);

    public static implicit operator Target2(PatchableAmountDto value) => PatchableAmountDto(value);
}

file sealed class Target2Converter : JsonConverter<Target2>
{
    public override Target2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<PatchableAmountDto>(root, options, out var patchableAmountDtoValue))
        {
            return Target2.PatchableAmountDto(patchableAmountDtoValue);
        }
        throw new JsonException($"JSON does not match PatchableAmountDto schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Target2 value, JsonSerializerOptions options)
    {
        if (value.TryGetPatchableAmountDto(out var patchableAmountDtoValue))
        {
            JsonSerializer.Serialize(writer, patchableAmountDtoValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Target2)} contains no valid value to serialize.");
        }
    }
}
