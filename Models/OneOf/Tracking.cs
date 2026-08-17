using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

/// <summary>
/// The latest tracking information of the transfer.
/// </summary>
[JsonConverter(typeof(TrackingConverter))]
public record Tracking
{
    private readonly Optional<EstimationTrackingData> _estimationTrackingDataValue;

    private readonly Optional<ConfirmationTrackingData> _confirmationTrackingDataValue;

    private readonly Optional<InternalReviewTrackingData> _internalReviewTrackingDataValue;

    private Tracking(Optional<EstimationTrackingData> estimationTrackingDataValue,
        Optional<ConfirmationTrackingData> confirmationTrackingDataValue,
        Optional<InternalReviewTrackingData> internalReviewTrackingDataValue)
    {
        _estimationTrackingDataValue = estimationTrackingDataValue;
        _confirmationTrackingDataValue = confirmationTrackingDataValue;
        _internalReviewTrackingDataValue = internalReviewTrackingDataValue;
    }

    public static Tracking EstimationTrackingData(EstimationTrackingData value) =>
        new(Optional<EstimationTrackingData>.Some(value), default, default);

    public static Tracking ConfirmationTrackingData(ConfirmationTrackingData value) =>
        new(default, Optional<ConfirmationTrackingData>.Some(value), default);

    public static Tracking InternalReviewTrackingData(InternalReviewTrackingData value) =>
        new(default, default, Optional<InternalReviewTrackingData>.Some(value));

    public bool TryGetEstimationTrackingData(out EstimationTrackingData value) =>
        _estimationTrackingDataValue.TryGetValue(out value);

    public bool TryGetConfirmationTrackingData(out ConfirmationTrackingData value) =>
        _confirmationTrackingDataValue.TryGetValue(out value);

    public bool TryGetInternalReviewTrackingData(out InternalReviewTrackingData value) =>
        _internalReviewTrackingDataValue.TryGetValue(out value);

    public static implicit operator Tracking(EstimationTrackingData value) => EstimationTrackingData(value);

    public static implicit operator Tracking(ConfirmationTrackingData value) => ConfirmationTrackingData(value);

    public static implicit operator Tracking(InternalReviewTrackingData value) =>
        InternalReviewTrackingData(value);
}

file sealed class TrackingConverter : JsonConverter<Tracking>
{
    public override Tracking Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
            "estimation" => Tracking.EstimationTrackingData(root.Deserialize<EstimationTrackingData>(options)!),
            "confirmation" => Tracking.ConfirmationTrackingData(root.Deserialize<ConfirmationTrackingData>(options)!),
            "internalReview" => Tracking.InternalReviewTrackingData(root.Deserialize<InternalReviewTrackingData>(options)!),
            _ => throw new JsonException($"JSON does not match EstimationTrackingData or ConfirmationTrackingData or InternalReviewTrackingData schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, Tracking value, JsonSerializerOptions options)
    {
        if (value.TryGetEstimationTrackingData(out var estimationTrackingDataValue))
        {
            JsonSerializer.Serialize(writer, estimationTrackingDataValue, options);
        }
        else if (value.TryGetConfirmationTrackingData(out var confirmationTrackingDataValue))
        {
            JsonSerializer.Serialize(writer, confirmationTrackingDataValue, options);
        }
        else if (value.TryGetInternalReviewTrackingData(out var internalReviewTrackingDataValue))
        {
            JsonSerializer.Serialize(writer, internalReviewTrackingDataValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Tracking)} contains no valid value to serialize.");
        }
    }
}
