using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;

namespace Adyen.Api;

public sealed class CloudEndpointsAndConnection
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal CloudEndpointsAndConnection(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// get-merchants-merchantAccount-connectedDevices
    /// </summary>
    /// <param name="merchantAccount">The unique identifier of the merchant account.</param>
    /// <param name="store">The store ID of the store belonging to the merchant account specified in the path.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConnectedDevicesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantAccountConnectedDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a list of payment terminals or SDK installation IDs (in a Mobile solution) belonging to the specified merchant account that have an active cloud connection.  The <c>store</c> query parameter limits the list of devices to those belonging to a specific store under the specified merchant account.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>Cloud Device API role</b></description></item>
    /// </list>
    /// </remarks>
    public Task<ConnectedDevicesResponse> GetMerchantsMerchantAccountConnectedDevices(string merchantAccount,
        string? store,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantAccount}/connectedDevices"),
            [new TemplateParam("merchantAccount", merchantAccount)],
            [new Param("store", store)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConnectedDevicesResponse>(),
            GetMerchantsMerchantAccountConnectedDevicesErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// get-merchants-merchantAccount-devices-deviceId-status
    /// </summary>
    /// <param name="merchantAccount">The unique identifier of the merchant account.</param>
    /// <param name="deviceId">The unique identifier of the device.   For a payment terminal, use the terminal ID in the format _[terminal model]-[serial number]_, for example, <b>P400‑123456789</b>.  In a Mobile solution, use the installation ID of the SDK.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeviceStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantAccountDevicesDeviceIdStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Check if the specified payment terminal or SDK installation ID (in an IPP Mobile solution) has an active cloud connection.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>Cloud Device API role</b></description></item>
    /// </list>
    /// </remarks>
    public Task<DeviceStatusResponse> GetMerchantsMerchantAccountDevicesDeviceIdStatus(string merchantAccount,
        string deviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantAccount}/devices/{deviceId}/status"),
            [new TemplateParam("merchantAccount", merchantAccount), new TemplateParam("deviceId", deviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeviceStatusResponse>(),
            GetMerchantsMerchantAccountDevicesDeviceIdStatusErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// post-merchants-merchantAccount-devices-deviceId-async
    /// </summary>
    /// <param name="merchantAccount">The unique identifier of the merchant account.</param>
    /// <param name="deviceId">The unique identifier of the payment device that you send this request to. Must be the same as the <c>POIID</c> in the <c>MessageHeader</c> of the Terminal API request.   In an integration with payment terminals, use the terminal ID in the format _[terminal model]-[serial number]_, for example, <b>P400‑123456789</b>. In a Mobile solution, use the installation ID of the SDK.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a Terminal API request and receives the response asynchronously.
    /// <para>
    /// The request body is a JSON object containing a Terminal API request. For the structure, see the various request types under <see href="https://docs.adyen.com/api-explorer/terminal-api/1/overview">Terminal API</see>.
    /// </para>
    /// <para>
    /// A HTTP status code of <b>200 OK</b> is returned when the payment device is online and our backend has sent the request. The actual Terminal API response is returned as an event notification webhook to your event notification endpoint. See <see href="https://docs.adyen.com/point-of-sale/design-your-integration/choose-your-architecture/cloud/#async">Receiving an asynchronous result</see>.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>Cloud Device API role</b></description></item>
    /// </list>
    /// </remarks>
    public Task<string> PostMerchantsMerchantAccountDevicesDeviceIdAsync(string merchantAccount,
        string deviceId,
        string? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantAccount}/devices/{deviceId}/async"),
            [new TemplateParam("merchantAccount", merchantAccount), new TemplateParam("deviceId", deviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<string>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// post-merchants-merchantAccount-devices-deviceId-sync
    /// </summary>
    /// <param name="merchantAccount">The unique identifier of the merchant account.</param>
    /// <param name="deviceId">The unique identifier of the payment device that you send this request to. Must be the same as the <c>POIID</c> in the <c>MessageHeader</c> of the Terminal API request.   In an integration with payment terminals, use the terminal ID in the format _[terminal model]-[serial number]_, for example, <b>P400‑123456789</b>. In a Mobile solution, use the installation ID of the SDK.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a Terminal API request and receives the response synchronously.
    /// <para>
    /// The request body is a JSON object containing a Terminal API request. For the structure, see the various request types under <see href="https://docs.adyen.com/api-explorer/terminal-api/1/overview">Terminal API</see>.
    /// </para>
    /// <para>
    /// The response returns a Terminal API response. See <see href="https://docs.adyen.com/point-of-sale/design-your-integration/choose-your-architecture/cloud/#sync">Receiving a synchronous result</see>.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>Cloud Device API role</b></description></item>
    /// </list>
    /// </remarks>
    public Task<string> PostMerchantsMerchantAccountDevicesDeviceIdSync(string merchantAccount,
        string deviceId,
        string? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantAccount}/devices/{deviceId}/sync"),
            [new TemplateParam("merchantAccount", merchantAccount), new TemplateParam("deviceId", deviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<string>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
