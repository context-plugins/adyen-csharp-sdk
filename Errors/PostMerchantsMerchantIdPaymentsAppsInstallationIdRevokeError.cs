using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeErrorResponse : IErrorResponse<PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError>
{
    public static PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeErrorResponse Instance { get; } = new();

    private PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeErrorResponse()
    {
    }

    public Task<PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError.Create(response, ct);
}
