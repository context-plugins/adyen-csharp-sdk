using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, PLLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(PlLocalAccountIdentification1Converter))]
public record PlLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required PlLocalAccountIdentification1Properties PlLocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out PlLocalAccountIdentification1Properties plLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        plLocalAccountIdentification1Properties = PlLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(PlLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator PlLocalAccountIdentification1Properties(PlLocalAccountIdentification1 value) =>
        value.PlLocalAccountIdentification1Properties;
}

file class PlLocalAccountIdentification1Converter : JsonConverter<PlLocalAccountIdentification1>
{
    public override PlLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var plLocalAccountIdentification1Properties = root.Deserialize<PlLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize PlLocalAccountIdentification1Properties");
        return new PlLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            PlLocalAccountIdentification1Properties = plLocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        PlLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var plLocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.PlLocalAccountIdentification1Properties, options);
        foreach (var property in plLocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
