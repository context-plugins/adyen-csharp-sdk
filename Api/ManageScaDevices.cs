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

public sealed class ManageScaDevices
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ManageScaDevices(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// delete-registeredDevices-id
    /// </summary>
    /// <param name="id">The unique identifier of the SCA device.</param>
    /// <param name="paymentInstrumentId">The unique identifier of the payment instrument linked to the SCA device.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteRegisteredDevicesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an SCA device from the list of registered devices of a specific payment instrument.
    /// </remarks>
    public Task DeleteRegisteredDevicesId(string id,
        string paymentInstrumentId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/registeredDevices/{id}"),
            [new TemplateParam("id", id)],
            [new Param("paymentInstrumentId", paymentInstrumentId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteRegisteredDevicesIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-registeredDevices
    /// </summary>
    /// <param name="paymentInstrumentId">The unique identifier of a payment instrument. It limits the returned list to SCA devices associated to this payment instrument.</param>
    /// <param name="pageNumber">The index of the page to retrieve. The index of the first page is 0 (zero).  Default: 0.</param>
    /// <param name="pageSize">The number of items to have on a page.  Default: 20. Maximum: 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchRegisteredDevicesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetRegisteredDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a paginated list of the SCA devices you have currently registered for a specific payment instrument.
    /// </remarks>
    public Task<SearchRegisteredDevicesResponse> GetRegisteredDevices(string paymentInstrumentId,
        int? pageNumber,
        int? pageSize,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/registeredDevices"),
            [],
            [new Param("paymentInstrumentId", paymentInstrumentId),
                new Param("pageNumber", pageNumber),
                new Param("pageSize", pageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SearchRegisteredDevicesResponse>(),
            GetRegisteredDevicesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-registeredDevices-deviceId-associations
    /// </summary>
    /// <param name="deviceId">The unique identifier of the SCA device that you are associating with a resource.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssociationFinaliseResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchRegisteredDevicesDeviceIdAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Completes an association between a user's registered SCA device and an Adyen resource. For example, you can associate an SCA device with additional <see href="https://docs.adyen.com/platforms/business-accounts/sca/register-devices">business accounts</see> or <see href="https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices">Adyen-issued cards</see>.
    /// <para>
    /// To complete the association, this endpoint validates the authentication data of the registered device.
    /// </para>
    /// </remarks>
    public Task<AssociationFinaliseResponse> PatchRegisteredDevicesDeviceIdAssociations(string deviceId,
        AssociationFinaliseRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/registeredDevices/{deviceId}/associations"),
            [new TemplateParam("deviceId", deviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<AssociationFinaliseResponse>(),
            PatchRegisteredDevicesDeviceIdAssociationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-registeredDevices-id
    /// </summary>
    /// <param name="id">The unique identifier of the SCA device. You obtain this <c>id</c> in the response of a POST&amp;nbsp;<see href="https://docs.adyen.com/api-explorer/balanceplatform/2/post/registeredDevices#responses-200-id">/registeredDevices</see> request.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RegisterScafinalResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchRegisteredDevicesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Completes the registration of an SCA device by validating the authentication data of the device. You can register SCA devices for <see href="https://docs.adyen.com/platforms/business-accounts/sca">business accounts</see> or <see href="https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk">Adyen-issued cards</see>.
    /// </remarks>
    public Task<RegisterScafinalResponse> PatchRegisteredDevicesId(string id,
        RegisterScarequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/registeredDevices/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<RegisterScafinalResponse>(),
            PatchRegisteredDevicesIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-registeredDevices
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RegisterScaresponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostRegisteredDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates the registration of a user's device for Strong Customer Authentication (SCA). You can register SCA devices for <see href="https://docs.adyen.com/platforms/business-accounts/sca/register-devices">business accounts</see> or <see href="https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices">Adyen-issued cards</see>.
    /// <para>
    /// For a successful request, the device must be eligible for SCA.
    /// </para>
    /// </remarks>
    public Task<RegisterScaresponse> PostRegisteredDevices(RegisterScarequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/registeredDevices"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RegisterScaresponse>(),
            PostRegisteredDevicesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-registeredDevices-deviceId-associations
    /// </summary>
    /// <param name="deviceId">The unique identifier of the SCA device that you are associating with a resource.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssociationInitiateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostRegisteredDevicesDeviceIdAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates an association between a user's registered SCA device and an Adyen resource. For example, you can associate an SCA device with additional <see href="https://docs.adyen.com/platforms/business-accounts/sca/register-devices">business accounts</see> or <see href="https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices">Adyen-issued cards</see>.
    /// </remarks>
    public Task<AssociationInitiateResponse> PostRegisteredDevicesDeviceIdAssociations(string deviceId,
        AssociationInitiateRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/registeredDevices/{deviceId}/associations"),
            [new TemplateParam("deviceId", deviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssociationInitiateResponse>(),
            PostRegisteredDevicesDeviceIdAssociationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
