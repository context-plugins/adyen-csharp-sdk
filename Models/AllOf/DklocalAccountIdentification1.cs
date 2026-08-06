using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, DKLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(DklocalAccountIdentification1Converter))]
public record DklocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required DklocalAccountIdentification1Properties DklocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out DklocalAccountIdentification1Properties dklocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        dklocalAccountIdentification1Properties = DklocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(DklocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator DklocalAccountIdentification1Properties(DklocalAccountIdentification1 value) =>
        value.DklocalAccountIdentification1Properties;
}

file class DklocalAccountIdentification1Converter : JsonConverter<DklocalAccountIdentification1>
{
    public override DklocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var dklocalAccountIdentification1Properties = root.Deserialize<DklocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize DklocalAccountIdentification1Properties");
        return new DklocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            DklocalAccountIdentification1Properties = dklocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        DklocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var dklocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.DklocalAccountIdentification1Properties, options);
        foreach (var property in dklocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
