using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Authentication;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;

namespace Adyen.Api;

public sealed class ManageCardPin
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageCardPin(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get an RSA public key
    /// </summary>
    /// <param name="purpose">The purpose of the public key.  Possible values: <b>pinChange</b>, <b>pinReveal</b>, <b>panReveal</b>.  Default value: <b>pinReveal</b>.</param>
    /// <param name="format">The encoding format of public key.  Possible values: <b>jwk</b>, <b>pem</b>.  Default value: <b>pem</b>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PublicKeyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPublicKeyError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get an <see href="https://en.wikipedia.org/wiki/RSA_(cryptosystem">RSA</see>) public key to encrypt or decrypt card data.
    /// <para>
    ///  You need the RSA public key to generate the <c>encryptedKey</c> required to:
    /// - <see href="https://docs.adyen.com/api-explorer/balanceplatform/2/post/pins/change">Change a PIN</see>.
    /// - <see href="https://docs.adyen.com/api-explorer/balanceplatform/2/post/pins/reveal">Reveal a PIN</see>.
    /// - <see href="https://docs.adyen.com/api-explorer/balanceplatform/2/post/paymentInstruments/reveal">Reveal a PAN</see>.
    /// </para>
    /// </remarks>
    public Task<PublicKeyResponse> GetPublicKey(string? purpose,
        string? format,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/publicKey"),
            [],
            [new Param("purpose", purpose), new Param("format", format)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PublicKeyResponse>(),
            GetPublicKeyErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Change a card PIN
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PinChangeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPinsChangeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the personal identification number (PIN) of a specified card.
    /// <para>
    /// To make this request, your API credential must have the following role:
    /// * Bank Issuing PIN Change Webservice role
    /// </para>
    /// </remarks>
    public Task<PinChangeResponse> PostPinsChange(PinChangeRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/pins/change"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PinChangeResponse>(),
            PostPinsChangeErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Reveal a card PIN
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevealPinResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPinsRevealError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an encrypted PIN block that contains the PIN of a specified card. You can use the decrypted data to reveal the PIN in your user interface.
    /// <para>
    /// To make this request, your API credential must have the following role:
    /// * Bank Issuing PIN Reveal Webservice role
    /// </para>
    /// </remarks>
    public Task<RevealPinResponse> PostPinsReveal(RevealPinRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/pins/reveal"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RevealPinResponse>(),
            PostPinsRevealErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
