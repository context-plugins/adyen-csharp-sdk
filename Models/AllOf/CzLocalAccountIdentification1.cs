using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, CZLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(CzLocalAccountIdentification1Converter))]
public record CzLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required CzLocalAccountIdentification1Properties CzLocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out CzLocalAccountIdentification1Properties czLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        czLocalAccountIdentification1Properties = CzLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(CzLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator CzLocalAccountIdentification1Properties(CzLocalAccountIdentification1 value) =>
        value.CzLocalAccountIdentification1Properties;
}

file class CzLocalAccountIdentification1Converter : JsonConverter<CzLocalAccountIdentification1>
{
    public override CzLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var czLocalAccountIdentification1Properties = root.Deserialize<CzLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize CzLocalAccountIdentification1Properties");
        return new CzLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            CzLocalAccountIdentification1Properties = czLocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        CzLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var czLocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.CzLocalAccountIdentification1Properties, options);
        foreach (var property in czLocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
