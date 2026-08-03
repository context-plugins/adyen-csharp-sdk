using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The target balance for the balance account that the top-up must achieve.
/// </summary>
[JsonConverter(typeof(Target4Converter))]
public record Target4
{
    private readonly Optional<PatchableAmountDto> _patchableAmountDtoValue;

    private readonly Optional<object?> _anonymousObjectValue;

    private Target4(Optional<PatchableAmountDto> patchableAmountDtoValue, Optional<object?> anonymousObjectValue)
    {
        _patchableAmountDtoValue = patchableAmountDtoValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static Target4 PatchableAmountDto(PatchableAmountDto value) =>
        new(Optional<PatchableAmountDto>.Some(value), default);

    public static Target4 AnonymousObject(object? value) => new(default, Optional<object?>.Some(value));

    public bool TryGetPatchableAmountDto(out PatchableAmountDto value) =>
        _patchableAmountDtoValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator Target4(PatchableAmountDto value) => PatchableAmountDto(value);
}

file sealed class Target4Converter : JsonConverter<Target4>
{
    public override Target4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<PatchableAmountDto>(root, options, out var patchableAmountDtoValue))
        {
            return Target4.PatchableAmountDto(patchableAmountDtoValue);
        }
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return Target4.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match PatchableAmountDto or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Target4 value, JsonSerializerOptions options)
    {
        if (value.TryGetPatchableAmountDto(out var patchableAmountDtoValue))
        {
            JsonSerializer.Serialize(writer, patchableAmountDtoValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Target4)} contains no valid value to serialize.");
        }
    }
}
