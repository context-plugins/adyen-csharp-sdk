using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, BRLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(BrLocalAccountIdentification1Converter))]
public record BrLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required BrLocalAccountIdentification1Properties BrLocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out BrLocalAccountIdentification1Properties brLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        brLocalAccountIdentification1Properties = BrLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(BrLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator BrLocalAccountIdentification1Properties(BrLocalAccountIdentification1 value) =>
        value.BrLocalAccountIdentification1Properties;
}

file class BrLocalAccountIdentification1Converter : JsonConverter<BrLocalAccountIdentification1>
{
    public override BrLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var brLocalAccountIdentification1Properties = root.Deserialize<BrLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize BrLocalAccountIdentification1Properties");
        return new BrLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            BrLocalAccountIdentification1Properties = brLocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        BrLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var brLocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.BrLocalAccountIdentification1Properties, options);
        foreach (var property in brLocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
