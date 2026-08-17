using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of AccountIdentification, IbanAccountIdentification2.
/// </summary>
[JsonConverter(typeof(IbanAccountIdentification2Converter))]
public record IbanAccountIdentification2
{
    public required AccountIdentification AccountIdentification { get; init; }

    public required IbanAccountIdentification2Properties IbanAccountIdentification2Properties { get; init; }

    public void Deconstruct(out AccountIdentification accountIdentification,
        out IbanAccountIdentification2Properties ibanAccountIdentification2Properties)
    {
        accountIdentification = AccountIdentification;
        ibanAccountIdentification2Properties = IbanAccountIdentification2Properties;
    }

    public static implicit operator AccountIdentification(IbanAccountIdentification2 value) =>
        value.AccountIdentification;

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
        var accountIdentification = root.Deserialize<AccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize AccountIdentification");
        var ibanAccountIdentification2Properties = root.Deserialize<IbanAccountIdentification2Properties>(options) ??
            throw new JsonException("Failed to deserialize IbanAccountIdentification2Properties");
        return new IbanAccountIdentification2
        {
            AccountIdentification = accountIdentification,
            IbanAccountIdentification2Properties = ibanAccountIdentification2Properties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        IbanAccountIdentification2 value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var accountIdentificationJson = JsonSerializer.SerializeToElement(value.AccountIdentification, options);
        foreach (var property in accountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var ibanAccountIdentification2PropertiesJson =
            JsonSerializer.SerializeToElement(value.IbanAccountIdentification2Properties, options);
        foreach (var property in ibanAccountIdentification2PropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
