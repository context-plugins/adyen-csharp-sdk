using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, SGLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(SgLocalAccountIdentification1Converter))]
public record SgLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required SgLocalAccountIdentification1Properties SgLocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out SgLocalAccountIdentification1Properties sgLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        sgLocalAccountIdentification1Properties = SgLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(SgLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator SgLocalAccountIdentification1Properties(SgLocalAccountIdentification1 value) =>
        value.SgLocalAccountIdentification1Properties;
}

file class SgLocalAccountIdentification1Converter : JsonConverter<SgLocalAccountIdentification1>
{
    public override SgLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var sgLocalAccountIdentification1Properties = root.Deserialize<SgLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize SgLocalAccountIdentification1Properties");
        return new SgLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            SgLocalAccountIdentification1Properties = sgLocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        SgLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var sgLocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.SgLocalAccountIdentification1Properties, options);
        foreach (var property in sgLocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
