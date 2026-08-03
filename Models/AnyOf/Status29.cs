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
[JsonConverter(typeof(Status29Converter))]
public record Status29
{
    private readonly Optional<DisputeStatus> _disputeStatusValue;

    private readonly Optional<object?> _anonymousObjectValue;

    private Status29(Optional<DisputeStatus> disputeStatusValue, Optional<object?> anonymousObjectValue)
    {
        _disputeStatusValue = disputeStatusValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static Status29 DisputeStatus(DisputeStatus value) =>
        new(Optional<DisputeStatus>.Some(value), default);

    public static Status29 AnonymousObject(object? value) => new(default, Optional<object?>.Some(value));

    public bool TryGetDisputeStatus(out DisputeStatus value) => _disputeStatusValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator Status29(DisputeStatus value) => DisputeStatus(value);
}

file sealed class Status29Converter : JsonConverter<Status29>
{
    public override Status29 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DisputeStatus>(root, options, out var disputeStatusValue))
        {
            return Status29.DisputeStatus(disputeStatusValue);
        }
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return Status29.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match DisputeStatus or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Status29 value, JsonSerializerOptions options)
    {
        if (value.TryGetDisputeStatus(out var disputeStatusValue))
        {
            JsonSerializer.Serialize(writer, disputeStatusValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Status29)} contains no valid value to serialize.");
        }
    }
}
