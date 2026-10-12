<!-- Generated file — do not edit; regenerated with the SDK. -->

# MyApiCredential — operations

Accessor: `client.MyApiCredential` · Source: `src/Adyen/Api/MyApiCredential.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteMeAllowedOriginsOriginId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteMeAllowedOriginsOriginId(DeleteMeAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OriginId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteMeAllowedOriginsOriginIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMeAllowedOriginsOriginIdRequest` | `src/Adyen/Requests/MyApiCredential/DeleteMeAllowedOriginsOriginIdRequest.cs` |
| `DeleteMeAllowedOriginsOriginIdError` | `src/Adyen/Errors/DeleteMeAllowedOriginsOriginIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMe

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMe(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `MeApiCredential`
- **Error**: `ApiException<GetMeError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeApiCredential` | `src/Adyen/Models/MeApiCredential.cs` |
| `GetMeError` | `src/Adyen/Errors/GetMeError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMeAllowedOrigins

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMeAllowedOrigins(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AllowedOriginsResponse`
- **Error**: `ApiException<GetMeAllowedOriginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AllowedOriginsResponse` | `src/Adyen/Models/AllowedOriginsResponse.cs` |
| `GetMeAllowedOriginsError` | `src/Adyen/Errors/GetMeAllowedOriginsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMeAllowedOriginsOriginId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMeAllowedOriginsOriginId(GetMeAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OriginId`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<GetMeAllowedOriginsOriginIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMeAllowedOriginsOriginIdRequest` | `src/Adyen/Requests/MyApiCredential/GetMeAllowedOriginsOriginIdRequest.cs` |
| `AllowedOrigin` | `src/Adyen/Models/AllowedOrigin.cs` |
| `GetMeAllowedOriginsOriginIdError` | `src/Adyen/Errors/GetMeAllowedOriginsOriginIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMeAllowedOrigins

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMeAllowedOrigins(PostMeAllowedOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<PostMeAllowedOriginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMeAllowedOriginsRequest` | `src/Adyen/Requests/MyApiCredential/PostMeAllowedOriginsRequest.cs` |
| `CreateAllowedOriginRequest` | `src/Adyen/Models/CreateAllowedOriginRequest.cs` |
| `AllowedOrigin` | `src/Adyen/Models/AllowedOrigin.cs` |
| `PostMeAllowedOriginsError` | `src/Adyen/Errors/PostMeAllowedOriginsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMeGenerateClientKey

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMeGenerateClientKey(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenerateClientKeyResponse`
- **Error**: `ApiException<PostMeGenerateClientKeyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GenerateClientKeyResponse` | `src/Adyen/Models/GenerateClientKeyResponse.cs` |
| `PostMeGenerateClientKeyError` | `src/Adyen/Errors/PostMeGenerateClientKeyError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

