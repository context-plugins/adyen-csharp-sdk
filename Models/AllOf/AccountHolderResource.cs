using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of Resource, AccountHolderResource.
/// </summary>
[JsonConverter(typeof(AccountHolderResourceConverter))]
public record AccountHolderResource
{
    public required Resource Resource { get; init; }

    public void Deconstruct(out Resource resource)
    {
        resource = Resource;
    }

    public static implicit operator Resource(AccountHolderResource value) => value.Resource;
}

file class AccountHolderResourceConverter : JsonConverter<AccountHolderResource>
{
    public override AccountHolderResource Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var resource = root.Deserialize<Resource>(options) ??
            throw new JsonException("Failed to deserialize Resource");
        return new AccountHolderResource
        {
            Resource = resource,
        };
    }

    public override void Write(Utf8JsonWriter writer, AccountHolderResource value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var resourceJson = JsonSerializer.SerializeToElement(value.Resource, options);
        foreach (var property in resourceJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
