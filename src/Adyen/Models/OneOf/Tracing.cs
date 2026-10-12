using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

/// <summary>
/// Contains information for tracing the transfer after Adyen forwards it to the network.
/// </summary>
[JsonConverter(typeof(TracingConverter))]
public record Tracing
{
    private readonly Optional<UsAchTracingData> _usAchTracingDataValue;

    private readonly Optional<UkFpsTracingData> _ukFpsTracingDataValue;

    private Tracing(Optional<UsAchTracingData> usAchTracingDataValue, Optional<UkFpsTracingData> ukFpsTracingDataValue)
    {
        _usAchTracingDataValue = usAchTracingDataValue;
        _ukFpsTracingDataValue = ukFpsTracingDataValue;
    }

    public static Tracing UsAchTracingData(UsAchTracingData value) =>
        new(Optional<UsAchTracingData>.Some(value), default);

    public static Tracing UkFpsTracingData(UkFpsTracingData value) =>
        new(default, Optional<UkFpsTracingData>.Some(value));

    public bool TryGetUsAchTracingData(out UsAchTracingData value) => _usAchTracingDataValue.TryGetValue(out value);

    public bool TryGetUkFpsTracingData(out UkFpsTracingData value) => _ukFpsTracingDataValue.TryGetValue(out value);

    public static implicit operator Tracing(UsAchTracingData value) => UsAchTracingData(value);

    public static implicit operator Tracing(UkFpsTracingData value) => UkFpsTracingData(value);
}

file sealed class TracingConverter : JsonConverter<Tracing>
{
    public override Tracing Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
            "usAch" => Tracing.UsAchTracingData(root.Deserialize<UsAchTracingData>(options)!),
            "ukFps" => Tracing.UkFpsTracingData(root.Deserialize<UkFpsTracingData>(options)!),
            _ => throw new JsonException(
                $"JSON does not match UsAchTracingData or UkFpsTracingData schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, Tracing value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(Tracing)} contains no valid value to serialize.");
        }
    }
}
