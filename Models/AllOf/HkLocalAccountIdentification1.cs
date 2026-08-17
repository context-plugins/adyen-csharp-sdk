using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, HKLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(HkLocalAccountIdentification1Converter))]
public record HkLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required HkLocalAccountIdentification1Properties HkLocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out HkLocalAccountIdentification1Properties hkLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        hkLocalAccountIdentification1Properties = HkLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(HkLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator HkLocalAccountIdentification1Properties(HkLocalAccountIdentification1 value) =>
        value.HkLocalAccountIdentification1Properties;
}

file class HkLocalAccountIdentification1Converter : JsonConverter<HkLocalAccountIdentification1>
{
    public override HkLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var hkLocalAccountIdentification1Properties = root.Deserialize<HkLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize HkLocalAccountIdentification1Properties");
        return new HkLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            HkLocalAccountIdentification1Properties = hkLocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        HkLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var hkLocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.HkLocalAccountIdentification1Properties, options);
        foreach (var property in hkLocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
