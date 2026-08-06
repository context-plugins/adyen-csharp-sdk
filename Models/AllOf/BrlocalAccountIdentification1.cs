using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, BRLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(BrlocalAccountIdentification1Converter))]
public record BrlocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required BrlocalAccountIdentification1Properties BrlocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out BrlocalAccountIdentification1Properties brlocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        brlocalAccountIdentification1Properties = BrlocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(BrlocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator BrlocalAccountIdentification1Properties(BrlocalAccountIdentification1 value) =>
        value.BrlocalAccountIdentification1Properties;
}

file class BrlocalAccountIdentification1Converter : JsonConverter<BrlocalAccountIdentification1>
{
    public override BrlocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var brlocalAccountIdentification1Properties = root.Deserialize<BrlocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize BrlocalAccountIdentification1Properties");
        return new BrlocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            BrlocalAccountIdentification1Properties = brlocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        BrlocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var brlocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.BrlocalAccountIdentification1Properties, options);
        foreach (var property in brlocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
