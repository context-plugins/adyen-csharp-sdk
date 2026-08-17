using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

/// <summary>
/// Additional tracing information for the tracing event.
/// </summary>
[JsonConverter(typeof(TracingDataConverter))]
public record TracingData
{
    private readonly Optional<UsAchTracingData> _usAchTracingDataValue;

    private readonly Optional<UkFpsTracingData> _ukFpsTracingDataValue;

    private TracingData(Optional<UsAchTracingData> usAchTracingDataValue,
        Optional<UkFpsTracingData> ukFpsTracingDataValue)
    {
        _usAchTracingDataValue = usAchTracingDataValue;
        _ukFpsTracingDataValue = ukFpsTracingDataValue;
    }

    public static TracingData UsAchTracingData(UsAchTracingData value) =>
        new(Optional<UsAchTracingData>.Some(value), default);

    public static TracingData UkFpsTracingData(UkFpsTracingData value) =>
        new(default, Optional<UkFpsTracingData>.Some(value));

    public bool TryGetUsAchTracingData(out UsAchTracingData value) =>
        _usAchTracingDataValue.TryGetValue(out value);

    public bool TryGetUkFpsTracingData(out UkFpsTracingData value) =>
        _ukFpsTracingDataValue.TryGetValue(out value);

    public static implicit operator TracingData(UsAchTracingData value) => UsAchTracingData(value);

    public static implicit operator TracingData(UkFpsTracingData value) => UkFpsTracingData(value);
}

file sealed class TracingDataConverter : JsonConverter<TracingData>
{
    public override TracingData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var typeProperty))
        {
            throw new JsonException("Missing required 'type' discriminator field");
        }
        var discriminator = typeProperty.GetString();
        return discriminator switch
        {
            "usAch" => TracingData.UsAchTracingData(root.Deserialize<UsAchTracingData>(options)!),
            "ukFps" => TracingData.UkFpsTracingData(root.Deserialize<UkFpsTracingData>(options)!),
            _ => throw new JsonException($"JSON does not match UsAchTracingData or UkFpsTracingData schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, TracingData value, JsonSerializerOptions options)
    {
        if (value.TryGetUsAchTracingData(out var usAchTracingDataValue))
        {
            JsonSerializer.Serialize(writer, usAchTracingDataValue, options);
        }
        else if (value.TryGetUkFpsTracingData(out var ukFpsTracingDataValue))
        {
            JsonSerializer.Serialize(writer, ukFpsTracingDataValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TracingData)} contains no valid value to serialize.");
        }
    }
}
