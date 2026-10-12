<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersCompanyLevel — operations

Accessor: `client.UsersCompanyLevel` · Source: `src/Adyen/Api/UsersCompanyLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCompaniesCompanyIdUsers

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdUsers(GetCompaniesCompanyIdUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `username` ← `Username`
- **Returns**: `ListCompanyUsersResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdUsersRequest` | `src/Adyen/Requests/UsersCompanyLevel/GetCompaniesCompanyIdUsersRequest.cs` |
| `ListCompanyUsersResponse` | `src/Adyen/Models/ListCompanyUsersResponse.cs` |
| `GetCompaniesCompanyIdUsersError` | `src/Adyen/Errors/GetCompaniesCompanyIdUsersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdUsersUserId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdUsersUserId(GetCompaniesCompanyIdUsersUserIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `UserId`
- **Returns**: `CompanyUser`
- **Error**: `ApiException<GetCompaniesCompanyIdUsersUserIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdUsersUserIdRequest` | `src/Adyen/Requests/UsersCompanyLevel/GetCompaniesCompanyIdUsersUserIdRequest.cs` |
| `CompanyUser` | `src/Adyen/Models/CompanyUser.cs` |
| `GetCompaniesCompanyIdUsersUserIdError` | `src/Adyen/Errors/GetCompaniesCompanyIdUsersUserIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchCompaniesCompanyIdUsersUserId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchCompaniesCompanyIdUsersUserId(PatchCompaniesCompanyIdUsersUserIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `UserId`
- **Returns**: `CompanyUser`
- **Error**: `ApiException<PatchCompaniesCompanyIdUsersUserIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchCompaniesCompanyIdUsersUserIdRequest` | `src/Adyen/Requests/UsersCompanyLevel/PatchCompaniesCompanyIdUsersUserIdRequest.cs` |
| `UpdateCompanyUserRequest` | `src/Adyen/Models/UpdateCompanyUserRequest.cs` |
| `CompanyUser` | `src/Adyen/Models/CompanyUser.cs` |
| `PatchCompaniesCompanyIdUsersUserIdError` | `src/Adyen/Errors/PatchCompaniesCompanyIdUsersUserIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCompaniesCompanyIdUsers

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdUsers(PostCompaniesCompanyIdUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `CreateCompanyUserResponse`
- **Error**: `ApiException<PostCompaniesCompanyIdUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdUsersRequest` | `src/Adyen/Requests/UsersCompanyLevel/PostCompaniesCompanyIdUsersRequest.cs` |
| `CreateCompanyUserRequest` | `src/Adyen/Models/CreateCompanyUserRequest.cs` |
| `CreateCompanyUserResponse` | `src/Adyen/Models/CreateCompanyUserResponse.cs` |
| `PostCompaniesCompanyIdUsersError` | `src/Adyen/Errors/PostCompaniesCompanyIdUsersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

