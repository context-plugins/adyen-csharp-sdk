using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The party that initiated the cancellation of the transaction.
/// <para>
/// Possible values: <b>merchant</b>, <b>cardholder</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(WhoCancelledConverter))]
public record WhoCancelled
{
    private readonly Optional<CancellingEntity> _cancellingEntityValue;

    private readonly Optional<object?> _anonymousObjectValue;

    private WhoCancelled(Optional<CancellingEntity> cancellingEntityValue, Optional<object?> anonymousObjectValue)
    {
        _cancellingEntityValue = cancellingEntityValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static WhoCancelled CancellingEntity(CancellingEntity value) =>
        new(Optional<CancellingEntity>.Some(value), default);

    public static WhoCancelled AnonymousObject(object? value) =>
        new(default, Optional<object?>.Some(value));

    public bool TryGetCancellingEntity(out CancellingEntity value) =>
        _cancellingEntityValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator WhoCancelled(CancellingEntity value) => CancellingEntity(value);
}

file sealed class WhoCancelledConverter : JsonConverter<WhoCancelled>
{
    public override WhoCancelled Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<CancellingEntity>(root, options, out var cancellingEntityValue))
        {
            return WhoCancelled.CancellingEntity(cancellingEntityValue);
        }
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return WhoCancelled.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match CancellingEntity or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, WhoCancelled value, JsonSerializerOptions options)
    {
        if (value.TryGetCancellingEntity(out var cancellingEntityValue))
        {
            JsonSerializer.Serialize(writer, cancellingEntityValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(WhoCancelled)} contains no valid value to serialize.");
        }
    }
}
