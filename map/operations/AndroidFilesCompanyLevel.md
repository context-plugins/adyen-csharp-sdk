<!-- Generated file — do not edit; regenerated with the SDK. -->

# AndroidFilesCompanyLevel — operations

Accessor: `client.AndroidFilesCompanyLevel` · Source: `src/Adyen/Api/AndroidFilesCompanyLevel.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCompaniesCompanyIdAndroidApps

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdAndroidApps(GetCompaniesCompanyIdAndroidAppsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `packageName` ← `PackageName`, `versionCode` ← `VersionCode`
- **Returns**: `AndroidAppsResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdAndroidAppsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdAndroidAppsRequest` | `src/Adyen/Requests/AndroidFilesCompanyLevel/GetCompaniesCompanyIdAndroidAppsRequest.cs` |
| `AndroidAppsResponse` | `src/Adyen/Models/AndroidAppsResponse.cs` |
| `GetCompaniesCompanyIdAndroidAppsError` | `src/Adyen/Errors/GetCompaniesCompanyIdAndroidAppsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdAndroidAppsId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdAndroidAppsId(GetCompaniesCompanyIdAndroidAppsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `Id`
- **Returns**: `AndroidApp`
- **Error**: `ApiException<GetCompaniesCompanyIdAndroidAppsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdAndroidAppsIdRequest` | `src/Adyen/Requests/AndroidFilesCompanyLevel/GetCompaniesCompanyIdAndroidAppsIdRequest.cs` |
| `AndroidApp` | `src/Adyen/Models/AndroidApp.cs` |
| `GetCompaniesCompanyIdAndroidAppsIdError` | `src/Adyen/Errors/GetCompaniesCompanyIdAndroidAppsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdAndroidCertificates

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdAndroidCertificates(GetCompaniesCompanyIdAndroidCertificatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `certificateName` ← `CertificateName`
- **Returns**: `AndroidCertificatesResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdAndroidCertificatesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdAndroidCertificatesRequest` | `src/Adyen/Requests/AndroidFilesCompanyLevel/GetCompaniesCompanyIdAndroidCertificatesRequest.cs` |
| `AndroidCertificatesResponse` | `src/Adyen/Models/AndroidCertificatesResponse.cs` |
| `GetCompaniesCompanyIdAndroidCertificatesError` | `src/Adyen/Errors/GetCompaniesCompanyIdAndroidCertificatesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchCompaniesCompanyIdAndroidAppsId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchCompaniesCompanyIdAndroidAppsId(PatchCompaniesCompanyIdAndroidAppsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `Id`
- **Returns**: `ReprocessAndroidAppResponse`
- **Error**: `ApiException<PatchCompaniesCompanyIdAndroidAppsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchCompaniesCompanyIdAndroidAppsIdRequest` | `src/Adyen/Requests/AndroidFilesCompanyLevel/PatchCompaniesCompanyIdAndroidAppsIdRequest.cs` |
| `ReprocessAndroidAppResponse` | `src/Adyen/Models/ReprocessAndroidAppResponse.cs` |
| `PatchCompaniesCompanyIdAndroidAppsIdError` | `src/Adyen/Errors/PatchCompaniesCompanyIdAndroidAppsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCompaniesCompanyIdAndroidApps

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdAndroidApps(PostCompaniesCompanyIdAndroidAppsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `UploadAndroidAppResponse`
- **Error**: `ApiException<PostCompaniesCompanyIdAndroidAppsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdAndroidAppsRequest` | `src/Adyen/Requests/AndroidFilesCompanyLevel/PostCompaniesCompanyIdAndroidAppsRequest.cs` |
| `UploadAndroidAppResponse` | `src/Adyen/Models/UploadAndroidAppResponse.cs` |
| `PostCompaniesCompanyIdAndroidAppsError` | `src/Adyen/Errors/PostCompaniesCompanyIdAndroidAppsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCompaniesCompanyIdAndroidCertificates

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdAndroidCertificates(PostCompaniesCompanyIdAndroidCertificatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `UploadAndroidCertificateResponse`
- **Error**: `ApiException<PostCompaniesCompanyIdAndroidCertificatesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdAndroidCertificatesRequest` | `src/Adyen/Requests/AndroidFilesCompanyLevel/PostCompaniesCompanyIdAndroidCertificatesRequest.cs` |
| `UploadAndroidCertificateResponse` | `src/Adyen/Models/UploadAndroidCertificateResponse.cs` |
| `PostCompaniesCompanyIdAndroidCertificatesError` | `src/Adyen/Errors/PostCompaniesCompanyIdAndroidCertificatesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

