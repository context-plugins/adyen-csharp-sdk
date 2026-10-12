<!-- Generated file — do not edit; regenerated with the SDK. -->

# Accounts — operations

Accessor: `client.Accounts` · Source: `src/Adyen/Api/Accounts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostCloseAccount

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCloseAccount(PostCloseAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CloseAccountResponse`
- **Error**: `ApiException<PostCloseAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCloseAccountRequest` | `src/Adyen/Requests/Accounts/PostCloseAccountRequest.cs` |
| `CloseAccountRequest` | `src/Adyen/Models/CloseAccountRequest.cs` |
| `CloseAccountResponse` | `src/Adyen/Models/CloseAccountResponse.cs` |
| `PostCloseAccountError` | `src/Adyen/Errors/PostCloseAccountError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostCreateAccount

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCreateAccount(PostCreateAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CreateAccountResponse`
- **Error**: `ApiException<PostCreateAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCreateAccountRequest` | `src/Adyen/Requests/Accounts/PostCreateAccountRequest.cs` |
| `CreateAccountRequest` | `src/Adyen/Models/CreateAccountRequest.cs` |
| `CreateAccountResponse` | `src/Adyen/Models/CreateAccountResponse.cs` |
| `PostCreateAccountError` | `src/Adyen/Errors/PostCreateAccountError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostUpdateAccount

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostUpdateAccount(PostUpdateAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UpdateAccountResponse`
- **Error**: `ApiException<PostUpdateAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostUpdateAccountRequest` | `src/Adyen/Requests/Accounts/PostUpdateAccountRequest.cs` |
| `UpdateAccountRequest` | `src/Adyen/Models/UpdateAccountRequest.cs` |
| `UpdateAccountResponse` | `src/Adyen/Models/UpdateAccountResponse.cs` |
| `PostUpdateAccountError` | `src/Adyen/Errors/PostUpdateAccountError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

