using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The fixed amount with which you want to top up the balance account.
/// </summary>
[JsonConverter(typeof(Fixed1Converter))]
public record Fixed1
{
    private readonly Optional<PatchableAmountDto> _patchableAmountDtoValue;

    private readonly Optional<object?> _anonymousObjectValue;

    private Fixed1(Optional<PatchableAmountDto> patchableAmountDtoValue, Optional<object?> anonymousObjectValue)
    {
        _patchableAmountDtoValue = patchableAmountDtoValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static Fixed1 PatchableAmountDto(PatchableAmountDto value) =>
        new(Optional<PatchableAmountDto>.Some(value), default);

    public static Fixed1 AnonymousObject(object? value) => new(default, Optional<object?>.Some(value));

    public bool TryGetPatchableAmountDto(out PatchableAmountDto value) =>
        _patchableAmountDtoValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator Fixed1(PatchableAmountDto value) => PatchableAmountDto(value);
}

file sealed class Fixed1Converter : JsonConverter<Fixed1>
{
    public override Fixed1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<PatchableAmountDto>(root, options, out var patchableAmountDtoValue))
        {
            return Fixed1.PatchableAmountDto(patchableAmountDtoValue);
        }
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return Fixed1.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match PatchableAmountDto or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Fixed1 value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(Fixed1)} contains no valid value to serialize.");
        }
    }
}
