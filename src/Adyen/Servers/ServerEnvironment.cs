using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public sealed record ServerEnvironment : ClosedStringEnum<ServerEnvironment>
{
    private ServerEnvironment(string value) : base(value)
    {
    }

    /// <summary>
    /// Adyen test environment. Adyen's live endpoints are merchant-prefixed ({prefix}-checkout-live.adyenpayments.com), so no static live URL is correct here - point the client's BaseUrl at the merchant's own live host instead.
    /// </summary>
    public static readonly ServerEnvironment Test = new("Test");

    public static ServerEnvironment Default() => Test;

    internal TResult Match<TResult>(Func<TResult> onTest) =>
        this switch
        {
            _ when this == Test => onTest(),
            _ => throw new InvalidOperationException($"{nameof(ServerEnvironment)} holds no known value.")
        };
}
