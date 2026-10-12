using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of MandateAccountIdentification, UKLocalMandateAccountIdentification.
/// </summary>
[JsonConverter(typeof(UkLocalMandateAccountIdentificationConverter))]
public record UkLocalMandateAccountIdentification
{
    public required MandateAccountIdentification MandateAccountIdentification { get; init; }

    public required UkLocalMandateAccountIdentificationProperties UkLocalMandateAccountIdentificationProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out MandateAccountIdentification mandateAccountIdentification,
        out UkLocalMandateAccountIdentificationProperties ukLocalMandateAccountIdentificationProperties)
    {
        mandateAccountIdentification = MandateAccountIdentification;
        ukLocalMandateAccountIdentificationProperties = UkLocalMandateAccountIdentificationProperties;
    }

    public static implicit operator MandateAccountIdentification(UkLocalMandateAccountIdentification value) =>
        value.MandateAccountIdentification;

    public static implicit operator UkLocalMandateAccountIdentificationProperties(UkLocalMandateAccountIdentification value) =>
        value.UkLocalMandateAccountIdentificationProperties;
}

file class UkLocalMandateAccountIdentificationConverter : JsonConverter<UkLocalMandateAccountIdentification>
{
    public override UkLocalMandateAccountIdentification Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var mandateAccountIdentification = root.Deserialize<MandateAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize MandateAccountIdentification");
        var ukLocalMandateAccountIdentificationProperties = root.Deserialize<UkLocalMandateAccountIdentificationProperties>(
            options) ??
            throw new JsonException("Failed to deserialize UkLocalMandateAccountIdentificationProperties");
        var extras =
            AdditionalProperties.SharedBy(
                mandateAccountIdentification.AdditionalProperties,
                ukLocalMandateAccountIdentificationProperties.AdditionalProperties);
        mandateAccountIdentification.AdditionalProperties.Clear();
        ukLocalMandateAccountIdentificationProperties.AdditionalProperties.Clear();
        return new UkLocalMandateAccountIdentification
        {
            MandateAccountIdentification = mandateAccountIdentification,
            UkLocalMandateAccountIdentificationProperties = ukLocalMandateAccountIdentificationProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        UkLocalMandateAccountIdentification value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.MandateAccountIdentification, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.UkLocalMandateAccountIdentificationProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
