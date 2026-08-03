# Adyen

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The Adyen SDK for .NET provides access to the Adyen REST APIs from .NET applications.

The A2A payments API provides endpoints for A2A payment flows, enabling issuers to facilitate direct payments through Adyen for users with an Adyen business account.

With these endpoints, you can:
- **Retrieve payment details**: Retrieve transaction information for specific payments.
- **Confirm payments**: Confirm payments with Strong Customer Authentication (SCA).
- **Cancel payments**: Cancel pending transactions.

## Authentication
Each request made to the A2A Payments API must be signed with an API key. Generate an API key in your Customer Area.

To connect to the API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

## Roles and permissions
To use the A2A Payments API, your API credential must have the following roles:
- **Role for A2A Issuer payments - API**

Reach out to your Adyen contact to set up these roles.
## Going live
When going live, generate an API key in your [live Customer Area](https://ca-live.adyen.com/ca). You can then use the API key to send requests to `https://balanceplatform-api-live.adyen.com/a2aissuer-api/v{version}/payments`.



---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/Adyen.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [AdyenClientOptions](AdyenClientOptions.cs).

```csharp
services.AddAdyenClient(options =>
    {
        options.BasicAuth =
            new BasicAuthCredentials
            {
                Username = "YOUR_USERNAME",
                Password = "YOUR_PASSWORD",
            };
        options.ApiKeyAuth = "YOUR_API_KEY";
        options.ClientKey = "YOUR_API_KEY";
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [AdyenClientOptions](AdyenClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new AdyenClientOptions
    {
        BasicAuth = new BasicAuthCredentials
        {
            Username = "YOUR_USERNAME",
            Password = "YOUR_PASSWORD",
        },
        ApiKeyAuth = "YOUR_API_KEY",
        ClientKey = "YOUR_API_KEY",
        Environment = ServerEnvironment.Production,
    };
var client = new AdyenClient(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## Best Practices

> [!TIP]
> Use a **single `AdyenClient` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
