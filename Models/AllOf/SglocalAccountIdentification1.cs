using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, SGLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(SglocalAccountIdentification1Converter))]
public record SglocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required SglocalAccountIdentification1Properties SglocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out SglocalAccountIdentification1Properties sglocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        sglocalAccountIdentification1Properties = SglocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(SglocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator SglocalAccountIdentification1Properties(SglocalAccountIdentification1 value) =>
        value.SglocalAccountIdentification1Properties;
}

file class SglocalAccountIdentification1Converter : JsonConverter<SglocalAccountIdentification1>
{
    public override SglocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var sglocalAccountIdentification1Properties = root.Deserialize<SglocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize SglocalAccountIdentification1Properties");
        return new SglocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            SglocalAccountIdentification1Properties = sglocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SglocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var sglocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.SglocalAccountIdentification1Properties, options);
        foreach (var property in sglocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
