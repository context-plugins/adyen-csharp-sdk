using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Contains information for tracing the transfer after Adyen forwards it to the network.
/// </summary>
[JsonConverter(typeof(TracingConverter))]
public record Tracing
{
    private readonly Optional<UkfpsTracingData> _ukfpsTracingDataValue;

    private readonly Optional<UsachTracingData> _usachTracingDataValue;

    private Tracing(Optional<UkfpsTracingData> ukfpsTracingDataValue,
        Optional<UsachTracingData> usachTracingDataValue)
    {
        _ukfpsTracingDataValue = ukfpsTracingDataValue;
        _usachTracingDataValue = usachTracingDataValue;
    }

    public static Tracing UkfpsTracingData(UkfpsTracingData value) =>
        new(Optional<UkfpsTracingData>.Some(value), default);

    public static Tracing UsachTracingData(UsachTracingData value) =>
        new(default, Optional<UsachTracingData>.Some(value));

    public bool TryGetUkfpsTracingData(out UkfpsTracingData value) =>
        _ukfpsTracingDataValue.TryGetValue(out value);

    public bool TryGetUsachTracingData(out UsachTracingData value) =>
        _usachTracingDataValue.TryGetValue(out value);

    public static implicit operator Tracing(UkfpsTracingData value) => UkfpsTracingData(value);

    public static implicit operator Tracing(UsachTracingData value) => UsachTracingData(value);
}

file sealed class TracingConverter : JsonConverter<Tracing>
{
    public override Tracing Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<UkfpsTracingData>(root, options, out var ukfpsTracingDataValue))
        {
            return Tracing.UkfpsTracingData(ukfpsTracingDataValue);
        }
        if (JsonSerializer.TryDeserialize<UsachTracingData>(root, options, out var usachTracingDataValue))
        {
            return Tracing.UsachTracingData(usachTracingDataValue);
        }
        throw new JsonException($"JSON does not match UkfpsTracingData or UsachTracingData schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Tracing value, JsonSerializerOptions options)
    {
        if (value.TryGetUkfpsTracingData(out var ukfpsTracingDataValue))
        {
            JsonSerializer.Serialize(writer, ukfpsTracingDataValue, options);
        }
        else if (value.TryGetUsachTracingData(out var usachTracingDataValue))
        {
            JsonSerializer.Serialize(writer, usachTracingDataValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Tracing)} contains no valid value to serialize.");
        }
    }
}
