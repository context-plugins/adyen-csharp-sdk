using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Additional tracing information for the tracing event.
/// </summary>
[JsonConverter(typeof(TracingDataConverter))]
public record TracingData
{
    private readonly Optional<UkfpsTracingData> _ukfpsTracingDataValue;

    private readonly Optional<UsachTracingData> _usachTracingDataValue;

    private TracingData(Optional<UkfpsTracingData> ukfpsTracingDataValue,
        Optional<UsachTracingData> usachTracingDataValue)
    {
        _ukfpsTracingDataValue = ukfpsTracingDataValue;
        _usachTracingDataValue = usachTracingDataValue;
    }

    public static TracingData UkfpsTracingData(UkfpsTracingData value) =>
        new(Optional<UkfpsTracingData>.Some(value), default);

    public static TracingData UsachTracingData(UsachTracingData value) =>
        new(default, Optional<UsachTracingData>.Some(value));

    public bool TryGetUkfpsTracingData(out UkfpsTracingData value) =>
        _ukfpsTracingDataValue.TryGetValue(out value);

    public bool TryGetUsachTracingData(out UsachTracingData value) =>
        _usachTracingDataValue.TryGetValue(out value);

    public static implicit operator TracingData(UkfpsTracingData value) => UkfpsTracingData(value);

    public static implicit operator TracingData(UsachTracingData value) => UsachTracingData(value);
}

file sealed class TracingDataConverter : JsonConverter<TracingData>
{
    public override TracingData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<UkfpsTracingData>(root, options, out var ukfpsTracingDataValue))
        {
            return TracingData.UkfpsTracingData(ukfpsTracingDataValue);
        }
        if (JsonSerializer.TryDeserialize<UsachTracingData>(root, options, out var usachTracingDataValue))
        {
            return TracingData.UsachTracingData(usachTracingDataValue);
        }
        throw new JsonException($"JSON does not match UkfpsTracingData or UsachTracingData schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TracingData value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TracingData)} contains no valid value to serialize.");
        }
    }
}
