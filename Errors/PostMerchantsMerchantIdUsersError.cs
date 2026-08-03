using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostMerchantsMerchantIdUsersError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private PostMerchantsMerchantIdUsersError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static PostMerchantsMerchantIdUsersError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static PostMerchantsMerchantIdUsersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<PostMerchantsMerchantIdUsersError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostMerchantsMerchantIdUsersErrorResponse : IErrorResponse<PostMerchantsMerchantIdUsersError>
{
    public static PostMerchantsMerchantIdUsersErrorResponse Instance { get; } = new();

    private PostMerchantsMerchantIdUsersErrorResponse()
    {
    }

    public Task<PostMerchantsMerchantIdUsersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostMerchantsMerchantIdUsersError.Create(response, ct);
}
