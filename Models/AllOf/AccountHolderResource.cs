using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of Resource, AccountHolderResource.
/// </summary>
[JsonConverter(typeof(AccountHolderResourceConverter))]
public record AccountHolderResource
{
    public required Resource Resource { get; init; }

    public required AccountHolderResourceProperties AccountHolderResourceProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out Resource resource,
        out AccountHolderResourceProperties accountHolderResourceProperties)
    {
        resource = Resource;
        accountHolderResourceProperties = AccountHolderResourceProperties;
    }

    public static implicit operator Resource(AccountHolderResource value) => value.Resource;

    public static implicit operator AccountHolderResourceProperties(AccountHolderResource value) =>
        value.AccountHolderResourceProperties;
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
        var accountHolderResourceProperties = root.Deserialize<AccountHolderResourceProperties>(options) ??
            throw new JsonException("Failed to deserialize AccountHolderResourceProperties");
        var extras =
            AdditionalProperties.SharedBy(resource.AdditionalProperties, accountHolderResourceProperties.AdditionalProperties);
        resource.AdditionalProperties.Clear();
        accountHolderResourceProperties.AdditionalProperties.Clear();
        return new AccountHolderResource
        {
            Resource = resource,
            AccountHolderResourceProperties = accountHolderResourceProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer, AccountHolderResource value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.Resource, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.AccountHolderResourceProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
