using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The fixed amount with which you want to top up the balance account.
/// </summary>
[JsonConverter(typeof(FixedConverter))]
public record Fixed
{
    private readonly Optional<PatchableAmountDto> _patchableAmountDtoValue;

    private Fixed(Optional<PatchableAmountDto> patchableAmountDtoValue)
    {
        _patchableAmountDtoValue = patchableAmountDtoValue;
    }

    public static Fixed PatchableAmountDto(PatchableAmountDto value) =>
        new(Optional<PatchableAmountDto>.Some(value));

    public bool TryGetPatchableAmountDto(out PatchableAmountDto value) =>
        _patchableAmountDtoValue.TryGetValue(out value);

    public static implicit operator Fixed(PatchableAmountDto value) => PatchableAmountDto(value);
}

file sealed class FixedConverter : JsonConverter<Fixed>
{
    public override Fixed Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<PatchableAmountDto>(root, options, out var patchableAmountDtoValue))
        {
            return Fixed.PatchableAmountDto(patchableAmountDtoValue);
        }
        throw new JsonException($"JSON does not match PatchableAmountDto schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Fixed value, JsonSerializerOptions options)
    {
        if (value.TryGetPatchableAmountDto(out var patchableAmountDtoValue))
        {
            JsonSerializer.Serialize(writer, patchableAmountDtoValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Fixed)} contains no valid value to serialize.");
        }
    }
}
