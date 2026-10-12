<!-- Generated file — do not edit; regenerated with the SDK. -->

# Initialization — operations

Accessor: `client.Initialization` · Source: `src/Adyen/Api/Initialization.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostStoreDetail

- **Server group**: `Default3`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostStoreDetail(PostStoreDetailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoreDetailResponse`
- **Error**: `ApiException<PostStoreDetailError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostStoreDetailRequest` | `src/Adyen/Requests/Initialization/PostStoreDetailRequest.cs` |
| `StoreDetailRequest` | `src/Adyen/Models/StoreDetailRequest.cs` |
| `StoreDetailResponse` | `src/Adyen/Models/StoreDetailResponse.cs` |
| `PostStoreDetailError` | `src/Adyen/Errors/PostStoreDetailError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostStoreDetailAndSubmitThirdParty

- **Server group**: `Default3`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostStoreDetailAndSubmitThirdParty(PostStoreDetailAndSubmitThirdPartyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoreDetailAndSubmitResponse`
- **Error**: `ApiException<PostStoreDetailAndSubmitThirdPartyError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostStoreDetailAndSubmitThirdPartyRequest` | `src/Adyen/Requests/Initialization/PostStoreDetailAndSubmitThirdPartyRequest.cs` |
| `StoreDetailAndSubmitRequest` | `src/Adyen/Models/StoreDetailAndSubmitRequest.cs` |
| `StoreDetailAndSubmitResponse` | `src/Adyen/Models/StoreDetailAndSubmitResponse.cs` |
| `PostStoreDetailAndSubmitThirdPartyError` | `src/Adyen/Errors/PostStoreDetailAndSubmitThirdPartyError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostSubmitThirdParty

- **Server group**: `Default3`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostSubmitThirdParty(PostSubmitThirdPartyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SubmitResponse`
- **Error**: `ApiException<PostSubmitThirdPartyError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostSubmitThirdPartyRequest` | `src/Adyen/Requests/Initialization/PostSubmitThirdPartyRequest.cs` |
| `SubmitRequest` | `src/Adyen/Models/SubmitRequest.cs` |
| `SubmitResponse` | `src/Adyen/Models/SubmitResponse.cs` |
| `PostSubmitThirdPartyError` | `src/Adyen/Errors/PostSubmitThirdPartyError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

