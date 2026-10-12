<!-- Generated file — do not edit; regenerated with the SDK. -->

# TermsOfService — operations

Accessor: `client.TermsOfService` · Source: `src/Adyen/Api/TermsOfService.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereference

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereference(GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Termsofserviceacceptancereference`
- **Query params (wire ← C#)**: `termsOfServiceDocumentFormat` ← `TermsOfServiceDocumentFormat`
- **Returns**: `GetAcceptedTermsOfServiceDocumentResponse`
- **Error**: `ApiException<GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceRequest` | `src/Adyen/Requests/TermsOfService/GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceRequest.cs` |
| `GetAcceptedTermsOfServiceDocumentResponse` | `src/Adyen/Models/GetAcceptedTermsOfServiceDocumentResponse.cs` |
| `GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError` | `src/Adyen/Errors/GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### GetLegalEntitiesIdTermsOfServiceAcceptanceInfos

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetLegalEntitiesIdTermsOfServiceAcceptanceInfos(GetLegalEntitiesIdTermsOfServiceAcceptanceInfosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GetTermsOfServiceAcceptanceInfosResponse`
- **Error**: `ApiException<GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLegalEntitiesIdTermsOfServiceAcceptanceInfosRequest` | `src/Adyen/Requests/TermsOfService/GetLegalEntitiesIdTermsOfServiceAcceptanceInfosRequest.cs` |
| `GetTermsOfServiceAcceptanceInfosResponse` | `src/Adyen/Models/GetTermsOfServiceAcceptanceInfosResponse.cs` |
| `GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError` | `src/Adyen/Errors/GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### GetLegalEntitiesIdTermsOfServiceStatus

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetLegalEntitiesIdTermsOfServiceStatus(GetLegalEntitiesIdTermsOfServiceStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CalculateTermsOfServiceStatusResponse`
- **Error**: `ApiException<GetLegalEntitiesIdTermsOfServiceStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLegalEntitiesIdTermsOfServiceStatusRequest` | `src/Adyen/Requests/TermsOfService/GetLegalEntitiesIdTermsOfServiceStatusRequest.cs` |
| `CalculateTermsOfServiceStatusResponse` | `src/Adyen/Models/CalculateTermsOfServiceStatusResponse.cs` |
| `GetLegalEntitiesIdTermsOfServiceStatusError` | `src/Adyen/Errors/GetLegalEntitiesIdTermsOfServiceStatusError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentid

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentid(PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Termsofservicedocumentid`
- **Returns**: `AcceptTermsOfServiceResponse`
- **Error**: `ApiException<PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidRequest` | `src/Adyen/Requests/TermsOfService/PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidRequest.cs` |
| `AcceptTermsOfServiceRequest` | `src/Adyen/Models/AcceptTermsOfServiceRequest.cs` |
| `AcceptTermsOfServiceResponse` | `src/Adyen/Models/AcceptTermsOfServiceResponse.cs` |
| `PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError` | `src/Adyen/Errors/PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostLegalEntitiesIdTermsOfService

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostLegalEntitiesIdTermsOfService(PostLegalEntitiesIdTermsOfServiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GetTermsOfServiceDocumentResponse`
- **Error**: `ApiException<PostLegalEntitiesIdTermsOfServiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLegalEntitiesIdTermsOfServiceRequest` | `src/Adyen/Requests/TermsOfService/PostLegalEntitiesIdTermsOfServiceRequest.cs` |
| `GetTermsOfServiceDocumentRequest` | `src/Adyen/Models/GetTermsOfServiceDocumentRequest.cs` |
| `GetTermsOfServiceDocumentResponse` | `src/Adyen/Models/GetTermsOfServiceDocumentResponse.cs` |
| `PostLegalEntitiesIdTermsOfServiceError` | `src/Adyen/Errors/PostLegalEntitiesIdTermsOfServiceError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

