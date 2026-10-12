<!-- Generated file — do not edit; regenerated with the SDK. -->

# HostedOnboardingPage — operations

Accessor: `client.HostedOnboardingPage` · Source: `src/Adyen/Api/HostedOnboardingPage.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostGetOnboardingUrl

- **Server group**: `Default19`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetOnboardingUrl(PostGetOnboardingUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetOnboardingUrlResponse`
- **Error**: `ApiException<PostGetOnboardingUrlError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetOnboardingUrlRequest` | `src/Adyen/Requests/HostedOnboardingPage/PostGetOnboardingUrlRequest.cs` |
| `GetOnboardingUrlRequest` | `src/Adyen/Models/GetOnboardingUrlRequest.cs` |
| `GetOnboardingUrlResponse` | `src/Adyen/Models/GetOnboardingUrlResponse.cs` |
| `PostGetOnboardingUrlError` | `src/Adyen/Errors/PostGetOnboardingUrlError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

