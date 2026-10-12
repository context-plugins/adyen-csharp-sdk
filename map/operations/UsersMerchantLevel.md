<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersMerchantLevel — operations

Accessor: `client.UsersMerchantLevel` · Source: `src/Adyen/Api/UsersMerchantLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantsMerchantIdUsers

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdUsers(GetMerchantsMerchantIdUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `username` ← `Username`
- **Returns**: `ListMerchantUsersResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdUsersRequest` | `src/Adyen/Requests/UsersMerchantLevel/GetMerchantsMerchantIdUsersRequest.cs` |
| `ListMerchantUsersResponse` | `src/Adyen/Models/ListMerchantUsersResponse.cs` |
| `GetMerchantsMerchantIdUsersError` | `src/Adyen/Errors/GetMerchantsMerchantIdUsersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdUsersUserId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdUsersUserId(GetMerchantsMerchantIdUsersUserIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `UserId`
- **Returns**: `User`
- **Error**: `ApiException<GetMerchantsMerchantIdUsersUserIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdUsersUserIdRequest` | `src/Adyen/Requests/UsersMerchantLevel/GetMerchantsMerchantIdUsersUserIdRequest.cs` |
| `User` | `src/Adyen/Models/User.cs` |
| `GetMerchantsMerchantIdUsersUserIdError` | `src/Adyen/Errors/GetMerchantsMerchantIdUsersUserIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdUsersUserId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdUsersUserId(PatchMerchantsMerchantIdUsersUserIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `UserId`
- **Returns**: `User`
- **Error**: `ApiException<PatchMerchantsMerchantIdUsersUserIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdUsersUserIdRequest` | `src/Adyen/Requests/UsersMerchantLevel/PatchMerchantsMerchantIdUsersUserIdRequest.cs` |
| `UpdateMerchantUserRequest` | `src/Adyen/Models/UpdateMerchantUserRequest.cs` |
| `User` | `src/Adyen/Models/User.cs` |
| `PatchMerchantsMerchantIdUsersUserIdError` | `src/Adyen/Errors/PatchMerchantsMerchantIdUsersUserIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdUsers

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdUsers(PostMerchantsMerchantIdUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `CreateUserResponse`
- **Error**: `ApiException<PostMerchantsMerchantIdUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdUsersRequest` | `src/Adyen/Requests/UsersMerchantLevel/PostMerchantsMerchantIdUsersRequest.cs` |
| `CreateMerchantUserRequest` | `src/Adyen/Models/CreateMerchantUserRequest.cs` |
| `CreateUserResponse` | `src/Adyen/Models/CreateUserResponse.cs` |
| `PostMerchantsMerchantIdUsersError` | `src/Adyen/Errors/PostMerchantsMerchantIdUsersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

