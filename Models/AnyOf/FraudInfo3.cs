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

    private readonly Optional<object?> _anonymousObjectValue;

    private FraudInfo3(Optional<PatchableFraudInfo> patchableFraudInfoValue, Optional<object?> anonymousObjectValue)
    {
        _patchableFraudInfoValue = patchableFraudInfoValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static FraudInfo3 PatchableFraudInfo(PatchableFraudInfo value) =>
        new(Optional<PatchableFraudInfo>.Some(value), default);

    public static FraudInfo3 AnonymousObject(object? value) => new(default, Optional<object?>.Some(value));

    public bool TryGetPatchableFraudInfo(out PatchableFraudInfo value) =>
        _patchableFraudInfoValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

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
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return FraudInfo3.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match PatchableFraudInfo or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, FraudInfo3 value, JsonSerializerOptions options)
    {
        if (value.TryGetPatchableFraudInfo(out var patchableFraudInfoValue))
        {
            JsonSerializer.Serialize(writer, patchableFraudInfoValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(FraudInfo3)} contains no valid value to serialize.");
        }
    }
}
