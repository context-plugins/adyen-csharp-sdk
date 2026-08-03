using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostValidateBankAccountIdentificationError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private PostValidateBankAccountIdentificationError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static PostValidateBankAccountIdentificationError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static PostValidateBankAccountIdentificationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<PostValidateBankAccountIdentificationError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostValidateBankAccountIdentificationErrorResponse : IErrorResponse<PostValidateBankAccountIdentificationError>
{
    public static PostValidateBankAccountIdentificationErrorResponse Instance { get; } = new();

    private PostValidateBankAccountIdentificationErrorResponse()
    {
    }

    public Task<PostValidateBankAccountIdentificationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostValidateBankAccountIdentificationError.Create(response, ct);
}
