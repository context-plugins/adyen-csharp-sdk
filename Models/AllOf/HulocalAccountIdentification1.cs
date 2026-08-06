using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, HULocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(HulocalAccountIdentification1Converter))]
public record HulocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required HulocalAccountIdentification1Properties HulocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out HulocalAccountIdentification1Properties hulocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        hulocalAccountIdentification1Properties = HulocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(HulocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator HulocalAccountIdentification1Properties(HulocalAccountIdentification1 value) =>
        value.HulocalAccountIdentification1Properties;
}

file class HulocalAccountIdentification1Converter : JsonConverter<HulocalAccountIdentification1>
{
    public override HulocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var hulocalAccountIdentification1Properties = root.Deserialize<HulocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize HulocalAccountIdentification1Properties");
        return new HulocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            HulocalAccountIdentification1Properties = hulocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        HulocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var hulocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.HulocalAccountIdentification1Properties, options);
        foreach (var property in hulocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
