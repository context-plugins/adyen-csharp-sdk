using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, AULocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(AulocalAccountIdentification1Converter))]
public record AulocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required AulocalAccountIdentification1Properties AulocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out AulocalAccountIdentification1Properties aulocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        aulocalAccountIdentification1Properties = AulocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(AulocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator AulocalAccountIdentification1Properties(AulocalAccountIdentification1 value) =>
        value.AulocalAccountIdentification1Properties;
}

file class AulocalAccountIdentification1Converter : JsonConverter<AulocalAccountIdentification1>
{
    public override AulocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var aulocalAccountIdentification1Properties = root.Deserialize<AulocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize AulocalAccountIdentification1Properties");
        return new AulocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            AulocalAccountIdentification1Properties = aulocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        AulocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var aulocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.AulocalAccountIdentification1Properties, options);
        foreach (var property in aulocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
