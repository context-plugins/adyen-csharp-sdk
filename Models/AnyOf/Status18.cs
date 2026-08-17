using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The current status of the dispute.
/// <para>
/// When you create a dispute, you can only set the <c>status</c> to <b>draft</b>. When you update a dispute, you can set the <c>status</c> to <b>submitted</b> or <b>closed</b>.
/// </para>
/// <para>
/// Possible values: <b>draft</b>, <b>submitted</b>, <b>closed</b>, <b>won</b>, <b>chargeback</b>, <b>secondPresentment</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(Status18Converter))]
public record Status18
{
    private readonly Optional<DisputeStatus> _disputeStatusValue;

    private Status18(Optional<DisputeStatus> disputeStatusValue)
    {
        _disputeStatusValue = disputeStatusValue;
    }

    public static Status18 DisputeStatus(DisputeStatus value) => new(Optional<DisputeStatus>.Some(value));

    public bool TryGetDisputeStatus(out DisputeStatus value) => _disputeStatusValue.TryGetValue(out value);

    public static implicit operator Status18(DisputeStatus value) => DisputeStatus(value);
}

file sealed class Status18Converter : JsonConverter<Status18>
{
    public override Status18 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DisputeStatus>(root, options, out var disputeStatusValue))
        {
            return Status18.DisputeStatus(disputeStatusValue);
        }
        throw new JsonException($"JSON does not match DisputeStatus schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Status18 value, JsonSerializerOptions options)
    {
        if (value.TryGetDisputeStatus(out var disputeStatusValue))
        {
            JsonSerializer.Serialize(writer, disputeStatusValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Status18)} contains no valid value to serialize.");
        }
    }
}
