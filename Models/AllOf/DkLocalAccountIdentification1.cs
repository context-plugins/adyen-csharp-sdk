using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, DKLocalAccountIdentification1.
/// </summary>
[JsonConverter(typeof(DkLocalAccountIdentification1Converter))]
public record DkLocalAccountIdentification1
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required DkLocalAccountIdentification1Properties DkLocalAccountIdentification1Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out DkLocalAccountIdentification1Properties dkLocalAccountIdentification1Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        dkLocalAccountIdentification1Properties = DkLocalAccountIdentification1Properties;
    }

    public static implicit operator BankAccountIdentification(DkLocalAccountIdentification1 value) =>
        value.BankAccountIdentification;

    public static implicit operator DkLocalAccountIdentification1Properties(DkLocalAccountIdentification1 value) =>
        value.DkLocalAccountIdentification1Properties;
}

file class DkLocalAccountIdentification1Converter : JsonConverter<DkLocalAccountIdentification1>
{
    public override DkLocalAccountIdentification1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var dkLocalAccountIdentification1Properties = root.Deserialize<DkLocalAccountIdentification1Properties>(options) ??
            throw new JsonException("Failed to deserialize DkLocalAccountIdentification1Properties");
        return new DkLocalAccountIdentification1
        {
            BankAccountIdentification = bankAccountIdentification,
            DkLocalAccountIdentification1Properties = dkLocalAccountIdentification1Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        DkLocalAccountIdentification1 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var dkLocalAccountIdentification1PropertiesJson =
            JsonSerializer.SerializeToElement(value.DkLocalAccountIdentification1Properties, options);
        foreach (var property in dkLocalAccountIdentification1PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
