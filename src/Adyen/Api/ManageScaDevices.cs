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
using Adyen.Requests.ManageScaDevices;

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
    /// Delete a registration of an SCA device
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteRegisteredDevicesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an SCA device from the list of registered devices of a specific payment instrument.
    /// </remarks>
    public Task DeleteRegisteredDevicesId(DeleteRegisteredDevicesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/registeredDevices/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("paymentInstrumentId", request.PaymentInstrumentId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteRegisteredDevicesIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of registered SCA devices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchRegisteredDevicesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetRegisteredDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a paginated list of the SCA devices you have currently registered for a specific payment instrument.
    /// </remarks>
    public Task<SearchRegisteredDevicesResponse> GetRegisteredDevices(GetRegisteredDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/registeredDevices"),
            [],
            [
                new Param("paymentInstrumentId", request.PaymentInstrumentId),
                new Param("pageNumber", request.PageNumber),
                new Param("pageSize", request.PageSize),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SearchRegisteredDevicesResponse>(),
            GetRegisteredDevicesError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Complete an association between an SCA device and a resource
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssociationFinaliseResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchRegisteredDevicesDeviceIdAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Completes an association between a user's registered SCA device and an Adyen resource. For example, you can associate an SCA device with additional <see href="https://docs.adyen.com/platforms/business-accounts/sca/register-devices">business accounts</see> or <see href="https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices">Adyen-issued cards</see>.
    /// <para>
    /// To complete the association, this endpoint validates the authentication data of the registered device.
    /// </para>
    /// </remarks>
    public Task<AssociationFinaliseResponse> PatchRegisteredDevicesDeviceIdAssociations(PatchRegisteredDevicesDeviceIdAssociationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/registeredDevices/{deviceId}/associations"),
            [new TemplateParam("deviceId", request.DeviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AssociationFinaliseResponse>(),
            PatchRegisteredDevicesDeviceIdAssociationsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Complete the registration of an SCA device
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RegisterScaFinalResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchRegisteredDevicesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Completes the registration of an SCA device by validating the authentication data of the device. You can register SCA devices for <see href="https://docs.adyen.com/platforms/business-accounts/sca">business accounts</see> or <see href="https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk">Adyen-issued cards</see>.
    /// </remarks>
    public Task<RegisterScaFinalResponse> PatchRegisteredDevicesId(PatchRegisteredDevicesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/registeredDevices/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RegisterScaFinalResponse>(),
            PatchRegisteredDevicesIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Initiate the registration of an SCA device
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RegisterScaResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostRegisteredDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates the registration of a user's device for Strong Customer Authentication (SCA). You can register SCA devices for <see href="https://docs.adyen.com/platforms/business-accounts/sca/register-devices">business accounts</see> or <see href="https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices">Adyen-issued cards</see>.
    /// <para>
    /// For a successful request, the device must be eligible for SCA.
    /// </para>
    /// </remarks>
    public Task<RegisterScaResponse> PostRegisteredDevices(PostRegisteredDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/registeredDevices"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RegisterScaResponse>(),
            PostRegisteredDevicesError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Initiate an association between an SCA device and a resource
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssociationInitiateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostRegisteredDevicesDeviceIdAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates an association between a user's registered SCA device and an Adyen resource. For example, you can associate an SCA device with additional <see href="https://docs.adyen.com/platforms/business-accounts/sca/register-devices">business accounts</see> or <see href="https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices">Adyen-issued cards</see>.
    /// </remarks>
    public Task<AssociationInitiateResponse> PostRegisteredDevicesDeviceIdAssociations(PostRegisteredDevicesDeviceIdAssociationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/registeredDevices/{deviceId}/associations"),
            [new TemplateParam("deviceId", request.DeviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AssociationInitiateResponse>(),
            PostRegisteredDevicesDeviceIdAssociationsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}
