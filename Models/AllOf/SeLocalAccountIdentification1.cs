using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, SELocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(SeLocalAccountIdentification1Converter))]
public record SeLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required SeLocalAccountIdentification1Properties SeLocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out SeLocalAccountIdentification1Properties seLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        seLocalAccountIdentification1Properties = SeLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(SeLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator SeLocalAccountIdentification1Properties(SeLocalAccountIdentification1 value) =>
        value.SeLocalAccountIdentification1Properties;
}

file class SeLocalAccountIdentification1Converter : JsonConverter<SeLocalAccountIdentification1>
{
    public override SeLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var seLocalAccountIdentification1Properties = root.Deserialize<SeLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize SeLocalAccountIdentification1Properties");
        return new SeLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            SeLocalAccountIdentification1Properties = seLocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SeLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var seLocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.SeLocalAccountIdentification1Properties, options);
        foreach (var property in seLocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
