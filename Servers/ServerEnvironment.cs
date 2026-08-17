using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public record ServerEnvironment : StringEnum<ServerEnvironment>
{
    /// <summary>
    /// Adyen test environment. Adyen's live endpoints are merchant-prefixed ({prefix}-checkout-live.adyenpayments.com), so no static live URL is correct here - point the client's BaseUrl at the merchant's own live host instead.
    /// </summary>
    public static readonly ServerEnvironment Test = new("Test");

    private ServerEnvironment(string value) : base(value)
    {
    }

    internal T Match<T>(Func<T> onTest) =>
        this switch
        {
            _ when this == Test => onTest(),
            _ => throw new ArgumentOutOfRangeException(nameof(ServerEnvironment),
                this,
                $"Unknown {nameof(ServerEnvironment)} value.")
        };

    public static ServerEnvironment Default() => Test;
}
