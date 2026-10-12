<!-- Generated file — do not edit; regenerated with the SDK. -->

# PciQuestionnaires — operations

Accessor: `client.PciQuestionnaires` · Source: `src/Adyen/Api/PciQuestionnaires.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetLegalEntitiesIdPciQuestionnaires

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetLegalEntitiesIdPciQuestionnaires(GetLegalEntitiesIdPciQuestionnairesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GetPciQuestionnaireInfosResponse`
- **Error**: `ApiException<GetLegalEntitiesIdPciQuestionnairesError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLegalEntitiesIdPciQuestionnairesRequest` | `src/Adyen/Requests/PciQuestionnaires/GetLegalEntitiesIdPciQuestionnairesRequest.cs` |
| `GetPciQuestionnaireInfosResponse` | `src/Adyen/Models/GetPciQuestionnaireInfosResponse.cs` |
| `GetLegalEntitiesIdPciQuestionnairesError` | `src/Adyen/Errors/GetLegalEntitiesIdPciQuestionnairesError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### GetLegalEntitiesIdPciQuestionnairesPciid

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetLegalEntitiesIdPciQuestionnairesPciid(GetLegalEntitiesIdPciQuestionnairesPciidRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Pciid`
- **Returns**: `GetPciQuestionnaireResponse`
- **Error**: `ApiException<GetLegalEntitiesIdPciQuestionnairesPciidError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLegalEntitiesIdPciQuestionnairesPciidRequest` | `src/Adyen/Requests/PciQuestionnaires/GetLegalEntitiesIdPciQuestionnairesPciidRequest.cs` |
| `GetPciQuestionnaireResponse` | `src/Adyen/Models/GetPciQuestionnaireResponse.cs` |
| `GetLegalEntitiesIdPciQuestionnairesPciidError` | `src/Adyen/Errors/GetLegalEntitiesIdPciQuestionnairesPciidError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplates

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplates(PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GeneratePciDescriptionResponse`
- **Error**: `ApiException<PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesRequest` | `src/Adyen/Requests/PciQuestionnaires/PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesRequest.cs` |
| `GeneratePciDescriptionRequest` | `src/Adyen/Models/GeneratePciDescriptionRequest.cs` |
| `GeneratePciDescriptionResponse` | `src/Adyen/Models/GeneratePciDescriptionResponse.cs` |
| `PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError` | `src/Adyen/Errors/PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostLegalEntitiesIdPciQuestionnairesSignPciTemplates

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostLegalEntitiesIdPciQuestionnairesSignPciTemplates(PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `PciSigningResponse`
- **Error**: `ApiException<PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesRequest` | `src/Adyen/Requests/PciQuestionnaires/PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesRequest.cs` |
| `PciSigningRequest` | `src/Adyen/Models/PciSigningRequest.cs` |
| `PciSigningResponse` | `src/Adyen/Models/PciSigningResponse.cs` |
| `PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError` | `src/Adyen/Errors/PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostLegalEntitiesIdPciQuestionnairesSigningRequired

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostLegalEntitiesIdPciQuestionnairesSigningRequired(PostLegalEntitiesIdPciQuestionnairesSigningRequiredRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CalculatePciStatusResponse`
- **Error**: `ApiException<PostLegalEntitiesIdPciQuestionnairesSigningRequiredError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLegalEntitiesIdPciQuestionnairesSigningRequiredRequest` | `src/Adyen/Requests/PciQuestionnaires/PostLegalEntitiesIdPciQuestionnairesSigningRequiredRequest.cs` |
| `CalculatePciStatusRequest` | `src/Adyen/Models/CalculatePciStatusRequest.cs` |
| `CalculatePciStatusResponse` | `src/Adyen/Models/CalculatePciStatusResponse.cs` |
| `PostLegalEntitiesIdPciQuestionnairesSigningRequiredError` | `src/Adyen/Errors/PostLegalEntitiesIdPciQuestionnairesSigningRequiredError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

