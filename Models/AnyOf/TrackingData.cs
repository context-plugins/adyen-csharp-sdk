using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Additional information for the tracking event.
/// </summary>
[JsonConverter(typeof(TrackingDataConverter))]
public record TrackingData
{
    private readonly Optional<ConfirmationTrackingData> _confirmationTrackingDataValue;

    private readonly Optional<EstimationTrackingData> _estimationTrackingDataValue;

    private readonly Optional<InternalReviewTrackingData> _internalReviewTrackingDataValue;

    private TrackingData(Optional<ConfirmationTrackingData> confirmationTrackingDataValue,
        Optional<EstimationTrackingData> estimationTrackingDataValue,
        Optional<InternalReviewTrackingData> internalReviewTrackingDataValue)
    {
        _confirmationTrackingDataValue = confirmationTrackingDataValue;
        _estimationTrackingDataValue = estimationTrackingDataValue;
        _internalReviewTrackingDataValue = internalReviewTrackingDataValue;
    }

    public static TrackingData ConfirmationTrackingData(ConfirmationTrackingData value) =>
        new(Optional<ConfirmationTrackingData>.Some(value), default, default);

    public static TrackingData EstimationTrackingData(EstimationTrackingData value) =>
        new(default, Optional<EstimationTrackingData>.Some(value), default);

    public static TrackingData InternalReviewTrackingData(InternalReviewTrackingData value) =>
        new(default, default, Optional<InternalReviewTrackingData>.Some(value));

    public bool TryGetConfirmationTrackingData(out ConfirmationTrackingData value) =>
        _confirmationTrackingDataValue.TryGetValue(out value);

    public bool TryGetEstimationTrackingData(out EstimationTrackingData value) =>
        _estimationTrackingDataValue.TryGetValue(out value);

    public bool TryGetInternalReviewTrackingData(out InternalReviewTrackingData value) =>
        _internalReviewTrackingDataValue.TryGetValue(out value);

    public static implicit operator TrackingData(ConfirmationTrackingData value) =>
        ConfirmationTrackingData(value);

    public static implicit operator TrackingData(EstimationTrackingData value) => EstimationTrackingData(value);

    public static implicit operator TrackingData(InternalReviewTrackingData value) =>
        InternalReviewTrackingData(value);
}

file sealed class TrackingDataConverter : JsonConverter<TrackingData>
{
    public override TrackingData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ConfirmationTrackingData>(root,
            options,
            out var confirmationTrackingDataValue))
        {
            return TrackingData.ConfirmationTrackingData(confirmationTrackingDataValue);
        }
        if (JsonSerializer.TryDeserialize<EstimationTrackingData>(root,
            options,
            out var estimationTrackingDataValue))
        {
            return TrackingData.EstimationTrackingData(estimationTrackingDataValue);
        }
        if (JsonSerializer.TryDeserialize<InternalReviewTrackingData>(root,
            options,
            out var internalReviewTrackingDataValue))
        {
            return TrackingData.InternalReviewTrackingData(internalReviewTrackingDataValue);
        }
        throw new JsonException($"JSON does not match ConfirmationTrackingData or EstimationTrackingData or InternalReviewTrackingData schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TrackingData value, JsonSerializerOptions options)
    {
        if (value.TryGetConfirmationTrackingData(out var confirmationTrackingDataValue))
        {
            JsonSerializer.Serialize(writer, confirmationTrackingDataValue, options);
        }
        else if (value.TryGetEstimationTrackingData(out var estimationTrackingDataValue))
        {
            JsonSerializer.Serialize(writer, estimationTrackingDataValue, options);
        }
        else if (value.TryGetInternalReviewTrackingData(out var internalReviewTrackingDataValue))
        {
            JsonSerializer.Serialize(writer, internalReviewTrackingDataValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TrackingData)} contains no valid value to serialize.");
        }
    }
}
