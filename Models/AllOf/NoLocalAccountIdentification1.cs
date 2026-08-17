using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, NOLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(NoLocalAccountIdentification1Converter))]
public record NoLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required NoLocalAccountIdentification1Properties NoLocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out NoLocalAccountIdentification1Properties noLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        noLocalAccountIdentification1Properties = NoLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(NoLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator NoLocalAccountIdentification1Properties(NoLocalAccountIdentification1 value) =>
        value.NoLocalAccountIdentification1Properties;
}

file class NoLocalAccountIdentification1Converter : JsonConverter<NoLocalAccountIdentification1>
{
    public override NoLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var noLocalAccountIdentification1Properties = root.Deserialize<NoLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize NoLocalAccountIdentification1Properties");
        return new NoLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            NoLocalAccountIdentification1Properties = noLocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        NoLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var noLocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.NoLocalAccountIdentification1Properties, options);
        foreach (var property in noLocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
