<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiCredentialsMerchantLevel — operations

Accessor: `client.ApiCredentialsMerchantLevel` · Source: `src/Adyen/Api/ApiCredentialsMerchantLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantsMerchantIdApiCredentials

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdApiCredentials(GetMerchantsMerchantIdApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListMerchantApiCredentialsResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdApiCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdApiCredentialsRequest` | `src/Adyen/Requests/ApiCredentialsMerchantLevel/GetMerchantsMerchantIdApiCredentialsRequest.cs` |
| `ListMerchantApiCredentialsResponse` | `src/Adyen/Models/ListMerchantApiCredentialsResponse.cs` |
| `GetMerchantsMerchantIdApiCredentialsError` | `src/Adyen/Errors/GetMerchantsMerchantIdApiCredentialsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdApiCredentialsApiCredentialId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdApiCredentialsApiCredentialId(GetMerchantsMerchantIdApiCredentialsApiCredentialIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `ApiCredential`
- **Error**: `ApiException<GetMerchantsMerchantIdApiCredentialsApiCredentialIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdApiCredentialsApiCredentialIdRequest` | `src/Adyen/Requests/ApiCredentialsMerchantLevel/GetMerchantsMerchantIdApiCredentialsApiCredentialIdRequest.cs` |
| `ApiCredential` | `src/Adyen/Models/ApiCredential.cs` |
| `GetMerchantsMerchantIdApiCredentialsApiCredentialIdError` | `src/Adyen/Errors/GetMerchantsMerchantIdApiCredentialsApiCredentialIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdApiCredentialsApiCredentialId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdApiCredentialsApiCredentialId(PatchMerchantsMerchantIdApiCredentialsApiCredentialIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `ApiCredential`
- **Error**: `ApiException<PatchMerchantsMerchantIdApiCredentialsApiCredentialIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdApiCredentialsApiCredentialIdRequest` | `src/Adyen/Requests/ApiCredentialsMerchantLevel/PatchMerchantsMerchantIdApiCredentialsApiCredentialIdRequest.cs` |
| `UpdateMerchantApiCredentialRequest` | `src/Adyen/Models/UpdateMerchantApiCredentialRequest.cs` |
| `ApiCredential` | `src/Adyen/Models/ApiCredential.cs` |
| `PatchMerchantsMerchantIdApiCredentialsApiCredentialIdError` | `src/Adyen/Errors/PatchMerchantsMerchantIdApiCredentialsApiCredentialIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdApiCredentials

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdApiCredentials(PostMerchantsMerchantIdApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `CreateApiCredentialResponse`
- **Error**: `ApiException<PostMerchantsMerchantIdApiCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdApiCredentialsRequest` | `src/Adyen/Requests/ApiCredentialsMerchantLevel/PostMerchantsMerchantIdApiCredentialsRequest.cs` |
| `CreateMerchantApiCredentialRequest` | `src/Adyen/Models/CreateMerchantApiCredentialRequest.cs` |
| `CreateApiCredentialResponse` | `src/Adyen/Models/CreateApiCredentialResponse.cs` |
| `PostMerchantsMerchantIdApiCredentialsError` | `src/Adyen/Errors/PostMerchantsMerchantIdApiCredentialsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

