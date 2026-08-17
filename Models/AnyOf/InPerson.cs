using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The settings for in-person donations collected as part of the campaign.
/// </summary>
[JsonConverter(typeof(InPersonConverter))]
public record InPerson
{
    private readonly Optional<InPersonDonationSettingsUpdate> _inPersonDonationSettingsUpdateValue;

    private InPerson(Optional<InPersonDonationSettingsUpdate> inPersonDonationSettingsUpdateValue)
    {
        _inPersonDonationSettingsUpdateValue = inPersonDonationSettingsUpdateValue;
    }

    public static InPerson InPersonDonationSettingsUpdate(InPersonDonationSettingsUpdate value) =>
        new(Optional<InPersonDonationSettingsUpdate>.Some(value));

    public bool TryGetInPersonDonationSettingsUpdate(out InPersonDonationSettingsUpdate value) =>
        _inPersonDonationSettingsUpdateValue.TryGetValue(out value);

    public static implicit operator InPerson(InPersonDonationSettingsUpdate value) =>
        InPersonDonationSettingsUpdate(value);
}

file sealed class InPersonConverter : JsonConverter<InPerson>
{
    public override InPerson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<InPersonDonationSettingsUpdate>(root,
            options,
            out var inPersonDonationSettingsUpdateValue))
        {
            return InPerson.InPersonDonationSettingsUpdate(inPersonDonationSettingsUpdateValue);
        }
        throw new JsonException($"JSON does not match InPersonDonationSettingsUpdate schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, InPerson value, JsonSerializerOptions options)
    {
        if (value.TryGetInPersonDonationSettingsUpdate(out var inPersonDonationSettingsUpdateValue))
        {
            JsonSerializer.Serialize(writer, inPersonDonationSettingsUpdateValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(InPerson)} contains no valid value to serialize.");
        }
    }
}
