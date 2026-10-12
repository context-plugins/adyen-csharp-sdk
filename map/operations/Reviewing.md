<!-- Generated file — do not edit; regenerated with the SDK. -->

# Reviewing — operations

Accessor: `client.Reviewing` · Source: `src/Adyen/Api/Reviewing.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostConfirmThirdParty

- **Server group**: `Default3`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostConfirmThirdParty(PostConfirmThirdPartyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ModifyResponse`
- **Error**: `ApiException<PostConfirmThirdPartyError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostConfirmThirdPartyRequest` | `src/Adyen/Requests/Reviewing/PostConfirmThirdPartyRequest.cs` |
| `ModifyRequest` | `src/Adyen/Models/ModifyRequest.cs` |
| `ModifyResponse` | `src/Adyen/Models/ModifyResponse.cs` |
| `PostConfirmThirdPartyError` | `src/Adyen/Errors/PostConfirmThirdPartyError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostDeclineThirdParty

- **Server group**: `Default3`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDeclineThirdParty(PostDeclineThirdPartyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ModifyResponse`
- **Error**: `ApiException<PostDeclineThirdPartyError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDeclineThirdPartyRequest` | `src/Adyen/Requests/Reviewing/PostDeclineThirdPartyRequest.cs` |
| `ModifyRequest` | `src/Adyen/Models/ModifyRequest.cs` |
| `ModifyResponse` | `src/Adyen/Models/ModifyResponse.cs` |
| `PostDeclineThirdPartyError` | `src/Adyen/Errors/PostDeclineThirdPartyError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

