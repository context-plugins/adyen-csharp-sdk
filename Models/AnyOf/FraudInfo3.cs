using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Additional information for raising a dispute of <c>type</c> <b>fraud</b>. Required for disputes of <c>type</c> <b>fraud</b>.
/// </summary>
[JsonConverter(typeof(FraudInfo3Converter))]
public record FraudInfo3
{
    private readonly Optional<PatchableFraudInfo> _patchableFraudInfoValue;

    private FraudInfo3(Optional<PatchableFraudInfo> patchableFraudInfoValue)
    {
        _patchableFraudInfoValue = patchableFraudInfoValue;
    }

    public static FraudInfo3 PatchableFraudInfo(PatchableFraudInfo value) =>
        new(Optional<PatchableFraudInfo>.Some(value));

    public bool TryGetPatchableFraudInfo(out PatchableFraudInfo value) =>
        _patchableFraudInfoValue.TryGetValue(out value);

    public static implicit operator FraudInfo3(PatchableFraudInfo value) => PatchableFraudInfo(value);
}

file sealed class FraudInfo3Converter : JsonConverter<FraudInfo3>
{
    public override FraudInfo3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<PatchableFraudInfo>(root, options, out var patchableFraudInfoValue))
        {
            return FraudInfo3.PatchableFraudInfo(patchableFraudInfoValue);
        }
        throw new JsonException($"JSON does not match PatchableFraudInfo schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, FraudInfo3 value, JsonSerializerOptions options)
    {
        if (value.TryGetPatchableFraudInfo(out var patchableFraudInfoValue))
        {
            JsonSerializer.Serialize(writer, patchableFraudInfoValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(FraudInfo3)} contains no valid value to serialize.");
        }
    }
}
