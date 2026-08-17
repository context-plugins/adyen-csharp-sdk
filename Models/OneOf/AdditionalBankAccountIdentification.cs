using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

[JsonConverter(typeof(AdditionalBankAccountIdentificationConverter))]
public record AdditionalBankAccountIdentification
{
    private readonly Optional<IbanAccountIdentification> _ibanAccountIdentificationValue;

    private AdditionalBankAccountIdentification(Optional<IbanAccountIdentification> ibanAccountIdentificationValue)
    {
        _ibanAccountIdentificationValue = ibanAccountIdentificationValue;
    }

    public static AdditionalBankAccountIdentification IbanAccountIdentification(IbanAccountIdentification value) =>
        new(Optional<IbanAccountIdentification>.Some(value));

    public bool TryGetIbanAccountIdentification(out IbanAccountIdentification value) =>
        _ibanAccountIdentificationValue.TryGetValue(out value);

    public static implicit operator AdditionalBankAccountIdentification(IbanAccountIdentification value) =>
        IbanAccountIdentification(value);
}

file sealed class AdditionalBankAccountIdentificationConverter : JsonConverter<AdditionalBankAccountIdentification>
{
    public override AdditionalBankAccountIdentification Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var typeProperty))
        {
            throw new JsonException("Missing required 'type' discriminator field");
        }
        var discriminator = typeProperty.GetString();
        return discriminator switch
        {
            "iban" => AdditionalBankAccountIdentification.IbanAccountIdentification(root.Deserialize<IbanAccountIdentification>(options)!),
            _ => throw new JsonException($"JSON does not match IbanAccountIdentification schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer,
        AdditionalBankAccountIdentification value,
        JsonSerializerOptions options)
    {
        if (value.TryGetIbanAccountIdentification(out var ibanAccountIdentificationValue))
        {
            JsonSerializer.Serialize(writer, ibanAccountIdentificationValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AdditionalBankAccountIdentification)} contains no valid value to serialize.");
        }
    }
}
