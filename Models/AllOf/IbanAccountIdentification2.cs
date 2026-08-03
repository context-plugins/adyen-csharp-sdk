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

    public void Deconstruct(out BankAccountIdentification bankAccountIdentification)
    {
        bankAccountIdentification = BankAccountIdentification;
    }

    public static implicit operator BankAccountIdentification(IbanAccountIdentification2 value) =>
        value.BankAccountIdentification;
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
        return new IbanAccountIdentification2
        {
            BankAccountIdentification = bankAccountIdentification,
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
        writer.WriteEndObject();
    }
}
