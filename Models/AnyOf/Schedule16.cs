using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Contains the details about the schedule that determines when the top up is executed.
/// </summary>
[JsonConverter(typeof(Schedule16Converter))]
public record Schedule16
{
    private readonly Optional<PatchableSchedule> _patchableScheduleValue;

    private readonly Optional<object?> _anonymousObjectValue;

    private Schedule16(Optional<PatchableSchedule> patchableScheduleValue, Optional<object?> anonymousObjectValue)
    {
        _patchableScheduleValue = patchableScheduleValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static Schedule16 PatchableSchedule(PatchableSchedule value) =>
        new(Optional<PatchableSchedule>.Some(value), default);

    public static Schedule16 AnonymousObject(object? value) => new(default, Optional<object?>.Some(value));

    public bool TryGetPatchableSchedule(out PatchableSchedule value) =>
        _patchableScheduleValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator Schedule16(PatchableSchedule value) => PatchableSchedule(value);
}

file sealed class Schedule16Converter : JsonConverter<Schedule16>
{
    public override Schedule16 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<PatchableSchedule>(root, options, out var patchableScheduleValue))
        {
            return Schedule16.PatchableSchedule(patchableScheduleValue);
        }
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return Schedule16.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match PatchableSchedule or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Schedule16 value, JsonSerializerOptions options)
    {
        if (value.TryGetPatchableSchedule(out var patchableScheduleValue))
        {
            JsonSerializer.Serialize(writer, patchableScheduleValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Schedule16)} contains no valid value to serialize.");
        }
    }
}
