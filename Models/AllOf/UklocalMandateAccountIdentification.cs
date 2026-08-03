using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of MandateAccountIdentification, UKLocalMandateAccountIdentification.
/// </summary>
[JsonConverter(typeof(UklocalMandateAccountIdentificationConverter))]
public record UklocalMandateAccountIdentification
{
    public required MandateAccountIdentification MandateAccountIdentification { get; init; }

    public void Deconstruct(out MandateAccountIdentification mandateAccountIdentification)
    {
        mandateAccountIdentification = MandateAccountIdentification;
    }

    public static implicit operator MandateAccountIdentification(UklocalMandateAccountIdentification value) =>
        value.MandateAccountIdentification;
}

file class UklocalMandateAccountIdentificationConverter : JsonConverter<UklocalMandateAccountIdentification>
{
    public override UklocalMandateAccountIdentification Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var mandateAccountIdentification = root.Deserialize<MandateAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize MandateAccountIdentification");
        return new UklocalMandateAccountIdentification
        {
            MandateAccountIdentification = mandateAccountIdentification,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        UklocalMandateAccountIdentification value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var mandateAccountIdentificationJson =
            JsonSerializer.SerializeToElement(value.MandateAccountIdentification, options);
        foreach (var property in mandateAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
