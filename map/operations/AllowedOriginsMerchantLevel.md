<!-- Generated file — do not edit; regenerated with the SDK. -->

# AllowedOriginsMerchantLevel — operations

Accessor: `client.AllowedOriginsMerchantLevel` · Source: `src/Adyen/Api/AllowedOriginsMerchantLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`, `OriginId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest` | `src/Adyen/Requests/AllowedOriginsMerchantLevel/DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest.cs` |
| `DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError` | `src/Adyen/Errors/DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `AllowedOriginsResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest` | `src/Adyen/Requests/AllowedOriginsMerchantLevel/GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest.cs` |
| `AllowedOriginsResponse` | `src/Adyen/Models/AllowedOriginsResponse.cs` |
| `GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError` | `src/Adyen/Errors/GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`, `OriginId`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest` | `src/Adyen/Requests/AllowedOriginsMerchantLevel/GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest.cs` |
| `AllowedOrigin` | `src/Adyen/Models/AllowedOrigin.cs` |
| `GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError` | `src/Adyen/Errors/GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest` | `src/Adyen/Requests/AllowedOriginsMerchantLevel/PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest.cs` |
| `AllowedOrigin` | `src/Adyen/Models/AllowedOrigin.cs` |
| `PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError` | `src/Adyen/Errors/PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

