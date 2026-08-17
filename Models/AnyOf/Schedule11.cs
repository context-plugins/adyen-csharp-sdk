using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// Contains the details about the schedule that determines when the top up is executed.
/// </summary>
[JsonConverter(typeof(Schedule11Converter))]
public record Schedule11
{
    private readonly Optional<PatchableSchedule> _patchableScheduleValue;

    private Schedule11(Optional<PatchableSchedule> patchableScheduleValue)
    {
        _patchableScheduleValue = patchableScheduleValue;
    }

    public static Schedule11 PatchableSchedule(PatchableSchedule value) =>
        new(Optional<PatchableSchedule>.Some(value));

    public bool TryGetPatchableSchedule(out PatchableSchedule value) =>
        _patchableScheduleValue.TryGetValue(out value);

    public static implicit operator Schedule11(PatchableSchedule value) => PatchableSchedule(value);
}

file sealed class Schedule11Converter : JsonConverter<Schedule11>
{
    public override Schedule11 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<PatchableSchedule>(root, options, out var patchableScheduleValue))
        {
            return Schedule11.PatchableSchedule(patchableScheduleValue);
        }
        throw new JsonException($"JSON does not match PatchableSchedule schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Schedule11 value, JsonSerializerOptions options)
    {
        if (value.TryGetPatchableSchedule(out var patchableScheduleValue))
        {
            JsonSerializer.Serialize(writer, patchableScheduleValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Schedule11)} contains no valid value to serialize.");
        }
    }
}
