using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of BankAccountIdentification, IbanAccountIdentification2.
/// </summary>
[JsonConverter(typeof(IbanAccountIdentification2Converter))]
public record IbanAccountIdentification2
{
    public required BankAccountIdentification BankAccountIdentification { get; init; }

    public required IbanAccountIdentification2Properties IbanAccountIdentification2Properties { get; init; }

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification,
        out IbanAccountIdentification2Properties ibanAccountIdentification2Properties)
    {
        bankAccountIdentification = BankAccountIdentification;
        ibanAccountIdentification2Properties = IbanAccountIdentification2Properties;
    }

    public static implicit operator BankAccountIdentification(IbanAccountIdentification2 value) =>
        value.BankAccountIdentification;

    public static implicit operator IbanAccountIdentification2Properties(IbanAccountIdentification2 value) =>
        value.IbanAccountIdentification2Properties;
}

file class IbanAccountIdentification2Converter : JsonConverter<IbanAccountIdentification2>
{
    public override IbanAccountIdentification2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var bankAccountIdentification = root.Deserialize<BankAccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize BankAccountIdentification");
        var ibanAccountIdentification2Properties = root.Deserialize<IbanAccountIdentification2Properties>(options) ??
            throw new JsonException("Failed to deserialize IbanAccountIdentification2Properties");
        return new IbanAccountIdentification2
        {
            BankAccountIdentification = bankAccountIdentification,
            IbanAccountIdentification2Properties = ibanAccountIdentification2Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        IbanAccountIdentification2 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var bankAccountIdentificationJson = JsonSerializer.SerializeToElement(value.BankAccountIdentification, options);
        foreach (var property in bankAccountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var ibanAccountIdentification2PropertiesJson =
            JsonSerializer.SerializeToElement(value.IbanAccountIdentification2Properties, options);
        foreach (var property in ibanAccountIdentification2PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
