using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, CZLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(CzlocalAccountIdentification1Converter))]
public record CzlocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required CzlocalAccountIdentification1Properties CzlocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out CzlocalAccountIdentification1Properties czlocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        czlocalAccountIdentification1Properties = CzlocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(CzlocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator CzlocalAccountIdentification1Properties(CzlocalAccountIdentification1 value) =>
        value.CzlocalAccountIdentification1Properties;
}

file class CzlocalAccountIdentification1Converter : JsonConverter<CzlocalAccountIdentification1>
{
    public override CzlocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var czlocalAccountIdentification1Properties = root.Deserialize<CzlocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize CzlocalAccountIdentification1Properties");
        return new CzlocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            CzlocalAccountIdentification1Properties = czlocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        CzlocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var czlocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.CzlocalAccountIdentification1Properties, options);
        foreach (var property in czlocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
