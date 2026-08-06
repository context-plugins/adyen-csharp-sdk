using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of AccountIdentification, IbanAccountIdentification.
/// </summary>
[JsonConverter(typeof(IbanAccountIdentificationConverter))]
public record IbanAccountIdentification
{
    public required AccountIdentification AccountIdentification { get; init; }

    public required IbanAccountIdentificationProperties IbanAccountIdentificationProperties { get; init; }

    public void Deconstruct(out AccountIdentification accountIdentification,
        out IbanAccountIdentificationProperties ibanAccountIdentificationProperties)
    {
        accountIdentification = AccountIdentification;
        ibanAccountIdentificationProperties = IbanAccountIdentificationProperties;
    }

    public static implicit operator AccountIdentification(IbanAccountIdentification value) =>
        value.AccountIdentification;

    public static implicit operator IbanAccountIdentificationProperties(IbanAccountIdentification value) =>
        value.IbanAccountIdentificationProperties;
}

file class IbanAccountIdentificationConverter : JsonConverter<IbanAccountIdentification>
{
    public override IbanAccountIdentification Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var accountIdentification = root.Deserialize<AccountIdentification>(options) ??
            throw new JsonException("Failed to deserialize AccountIdentification");
        var ibanAccountIdentificationProperties = root.Deserialize<IbanAccountIdentificationProperties>(options) ??
            throw new JsonException("Failed to deserialize IbanAccountIdentificationProperties");
        return new IbanAccountIdentification
        {
            AccountIdentification = accountIdentification,
            IbanAccountIdentificationProperties = ibanAccountIdentificationProperties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        IbanAccountIdentification value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var accountIdentificationJson = JsonSerializer.SerializeToElement(value.AccountIdentification, options);
        foreach (var property in accountIdentificationJson.EnumerateObject())
            property.WriteTo(writer);
        var ibanAccountIdentificationPropertiesJson =
            JsonSerializer.SerializeToElement(value.IbanAccountIdentificationProperties, options);
        foreach (var property in ibanAccountIdentificationPropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
