using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of MandateAccountIdentification, UKLocalMandateAccountIdentification.
/// </summary>
[JsonConverter(typeof(UkLocalMandateAccountIdentificationConverter))]
public record UkLocalMandateAccountIdentification
{
    public required MandateAccountIdentification MandateAccountIdentification { get; init; }

    public required UkLocalMandateAccountIdentificationProperties UkLocalMandateAccountIdentificationProperties { get; init; }

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
        var ukLocalMandateAccountIdentificationProperties = root.Deserialize<UkLocalMandateAccountIdentificationProperties>(options) ??
            throw new JsonException("Failed to deserialize UkLocalMandateAccountIdentificationProperties");
        return new UkLocalMandateAccountIdentification
        {
            MandateAccountIdentification = mandateAccountIdentification,
            UkLocalMandateAccountIdentificationProperties = ukLocalMandateAccountIdentificationProperties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        UkLocalMandateAccountIdentification value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var mandateAccountIdentificationJson =
            JsonSerializer.SerializeToElement(value.MandateAccountIdentification, options);
        foreach (var property in mandateAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var ukLocalMandateAccountIdentificationPropertiesJson =
            JsonSerializer.SerializeToElement(value.UkLocalMandateAccountIdentificationProperties, options);
        foreach (var property in ukLocalMandateAccountIdentificationPropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
