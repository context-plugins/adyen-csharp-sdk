<!-- Generated file — do not edit; regenerated with the SDK. -->

# General — operations

Accessor: `client.General` · Source: `src/Adyen/Api/General.cs` · 41 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostAcceptDispute

- **Server group**: `Default22`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostAcceptDispute(PostAcceptDisputeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AcceptDisputeResponse`
- **Error**: `ApiException<PostAcceptDisputeError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAcceptDisputeRequest` | `src/Adyen/Requests/General/PostAcceptDisputeRequest.cs` |
| `AcceptDisputeRequest` | `src/Adyen/Models/AcceptDisputeRequest.cs` |
| `AcceptDisputeResponse` | `src/Adyen/Models/AcceptDisputeResponse.cs` |
| `PostAcceptDisputeError` | `src/Adyen/Errors/PostAcceptDisputeError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostAccountHolderBalance

- **Server group**: `Default16`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostAccountHolderBalance(PostAccountHolderBalanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AccountHolderBalanceResponse`
- **Error**: `ApiException<PostAccountHolderBalanceError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAccountHolderBalanceRequest` | `src/Adyen/Requests/General/PostAccountHolderBalanceRequest.cs` |
| `CloseAccountHolderRequest` | `src/Adyen/Models/CloseAccountHolderRequest.cs` |
| `AccountHolderBalanceResponse` | `src/Adyen/Models/AccountHolderBalanceResponse.cs` |
| `PostAccountHolderBalanceError` | `src/Adyen/Errors/PostAccountHolderBalanceError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostAccountHolderTransactionList

- **Server group**: `Default16`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostAccountHolderTransactionList(PostAccountHolderTransactionListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AccountHolderTransactionListResponse`
- **Error**: `ApiException<PostAccountHolderTransactionListError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAccountHolderTransactionListRequest` | `src/Adyen/Requests/General/PostAccountHolderTransactionListRequest.cs` |
| `AccountHolderTransactionListRequest` | `src/Adyen/Models/AccountHolderTransactionListRequest.cs` |
| `AccountHolderTransactionListResponse` | `src/Adyen/Models/AccountHolderTransactionListResponse.cs` |
| `PostAccountHolderTransactionListError` | `src/Adyen/Errors/PostAccountHolderTransactionListError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostAssignTerminals

- **Server group**: `Default28`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostAssignTerminals(PostAssignTerminalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AssignTerminalsResponse`
- **Error**: `ApiException<PostAssignTerminalsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAssignTerminalsRequest` | `src/Adyen/Requests/General/PostAssignTerminalsRequest.cs` |
| `AssignTerminalsRequest` | `src/Adyen/Models/AssignTerminalsRequest.cs` |
| `AssignTerminalsResponse` | `src/Adyen/Models/AssignTerminalsResponse.cs` |
| `PostAssignTerminalsError` | `src/Adyen/Errors/PostAssignTerminalsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostChangeStatus

- **Server group**: `Default5`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostChangeStatus(PostChangeStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoredValueStatusChangeResponse`
- **Error**: `ApiException<PostChangeStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostChangeStatusRequest` | `src/Adyen/Requests/General/PostChangeStatusRequest.cs` |
| `StoredValueStatusChangeRequest` | `src/Adyen/Models/StoredValueStatusChangeRequest.cs` |
| `StoredValueStatusChangeResponse` | `src/Adyen/Models/StoredValueStatusChangeResponse.cs` |
| `PostChangeStatusError` | `src/Adyen/Errors/PostChangeStatusError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostCheckBalance

- **Server group**: `Default5`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCheckBalance(PostCheckBalanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoredValueBalanceCheckResponse`
- **Error**: `ApiException<PostCheckBalanceError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCheckBalanceRequest` | `src/Adyen/Requests/General/PostCheckBalanceRequest.cs` |
| `StoredValueBalanceCheckRequest` | `src/Adyen/Models/StoredValueBalanceCheckRequest.cs` |
| `StoredValueBalanceCheckResponse` | `src/Adyen/Models/StoredValueBalanceCheckResponse.cs` |
| `PostCheckBalanceError` | `src/Adyen/Errors/PostCheckBalanceError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostCreateNotificationConfiguration

- **Server group**: `Default12`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCreateNotificationConfiguration(PostCreateNotificationConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetNotificationConfigurationResponse`
- **Error**: `ApiException<PostCreateNotificationConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCreateNotificationConfigurationRequest` | `src/Adyen/Requests/General/PostCreateNotificationConfigurationRequest.cs` |
| `CreateNotificationConfigurationRequest` | `src/Adyen/Models/CreateNotificationConfigurationRequest.cs` |
| `GetNotificationConfigurationResponse` | `src/Adyen/Models/GetNotificationConfigurationResponse.cs` |
| `PostCreateNotificationConfigurationError` | `src/Adyen/Errors/PostCreateNotificationConfigurationError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostCreatePermit

- **Server group**: `Default2`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCreatePermit(PostCreatePermitRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CreatePermitResult`
- **Error**: `ApiException<PostCreatePermitError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCreatePermitRequest` | `src/Adyen/Requests/General/PostCreatePermitRequest.cs` |
| `CreatePermitRequest` | `src/Adyen/Models/CreatePermitRequest.cs` |
| `CreatePermitResult` | `src/Adyen/Models/CreatePermitResult.cs` |
| `PostCreatePermitError` | `src/Adyen/Errors/PostCreatePermitError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostCreateTestCardRanges

- **Server group**: `Default8`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCreateTestCardRanges(PostCreateTestCardRangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CreateTestCardRangesResult`
- **Error**: `ApiException<PostCreateTestCardRangesError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCreateTestCardRangesRequest` | `src/Adyen/Requests/General/PostCreateTestCardRangesRequest.cs` |
| `CreateTestCardRangesRequest` | `src/Adyen/Models/CreateTestCardRangesRequest.cs` |
| `CreateTestCardRangesResult` | `src/Adyen/Models/CreateTestCardRangesResult.cs` |
| `PostCreateTestCardRangesError` | `src/Adyen/Errors/PostCreateTestCardRangesError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostDebitAccountHolder

- **Server group**: `Default16`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDebitAccountHolder(PostDebitAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DebitAccountHolderResponse`
- **Error**: `ApiException<PostDebitAccountHolderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDebitAccountHolderRequest` | `src/Adyen/Requests/General/PostDebitAccountHolderRequest.cs` |
| `DebitAccountHolderRequest` | `src/Adyen/Models/DebitAccountHolderRequest.cs` |
| `DebitAccountHolderResponse` | `src/Adyen/Models/DebitAccountHolderResponse.cs` |
| `PostDebitAccountHolderError` | `src/Adyen/Errors/PostDebitAccountHolderError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostDefendDispute

- **Server group**: `Default22`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDefendDispute(PostDefendDisputeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DefendDisputeResponse`
- **Error**: `ApiException<PostDefendDisputeError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDefendDisputeRequest` | `src/Adyen/Requests/General/PostDefendDisputeRequest.cs` |
| `DefendDisputeRequest` | `src/Adyen/Models/DefendDisputeRequest.cs` |
| `DefendDisputeResponse` | `src/Adyen/Models/DefendDisputeResponse.cs` |
| `PostDefendDisputeError` | `src/Adyen/Errors/PostDefendDisputeError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostDeleteDisputeDefenseDocument

- **Server group**: `Default22`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDeleteDisputeDefenseDocument(PostDeleteDisputeDefenseDocumentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DeleteDefenseDocumentResponse`
- **Error**: `ApiException<PostDeleteDisputeDefenseDocumentError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDeleteDisputeDefenseDocumentRequest` | `src/Adyen/Requests/General/PostDeleteDisputeDefenseDocumentRequest.cs` |
| `DeleteDefenseDocumentRequest` | `src/Adyen/Models/DeleteDefenseDocumentRequest.cs` |
| `DeleteDefenseDocumentResponse` | `src/Adyen/Models/DeleteDefenseDocumentResponse.cs` |
| `PostDeleteDisputeDefenseDocumentError` | `src/Adyen/Errors/PostDeleteDisputeDefenseDocumentError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostDeleteNotificationConfigurations

- **Server group**: `Default12`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDeleteNotificationConfigurations(PostDeleteNotificationConfigurationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenericResponse`
- **Error**: `ApiException<PostDeleteNotificationConfigurationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDeleteNotificationConfigurationsRequest` | `src/Adyen/Requests/General/PostDeleteNotificationConfigurationsRequest.cs` |
| `DeleteNotificationConfigurationRequest` | `src/Adyen/Models/DeleteNotificationConfigurationRequest.cs` |
| `GenericResponse` | `src/Adyen/Models/GenericResponse.cs` |
| `PostDeleteNotificationConfigurationsError` | `src/Adyen/Errors/PostDeleteNotificationConfigurationsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostDisable

- **Server group**: `Default2`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDisable(PostDisableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DisableResult`
- **Error**: `ApiException<PostDisableError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDisableRequest` | `src/Adyen/Requests/General/PostDisableRequest.cs` |
| `DisableRequest` | `src/Adyen/Models/DisableRequest.cs` |
| `DisableResult` | `src/Adyen/Models/DisableResult.cs` |
| `PostDisableError` | `src/Adyen/Errors/PostDisableError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostDisablePermit

- **Server group**: `Default2`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDisablePermit(PostDisablePermitRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DisablePermitResult`
- **Error**: `ApiException<PostDisablePermitError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDisablePermitRequest` | `src/Adyen/Requests/General/PostDisablePermitRequest.cs` |
| `DisablePermitRequest` | `src/Adyen/Models/DisablePermitRequest.cs` |
| `DisablePermitResult` | `src/Adyen/Models/DisablePermitResult.cs` |
| `PostDisablePermitError` | `src/Adyen/Errors/PostDisablePermitError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostFindTerminal

- **Server group**: `Default28`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostFindTerminal(PostFindTerminalRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `FindTerminalResponse`
- **Error**: `ApiException<PostFindTerminalError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostFindTerminalRequest` | `src/Adyen/Requests/General/PostFindTerminalRequest.cs` |
| `FindTerminalRequest` | `src/Adyen/Models/FindTerminalRequest.cs` |
| `FindTerminalResponse` | `src/Adyen/Models/FindTerminalResponse.cs` |
| `PostFindTerminalError` | `src/Adyen/Errors/PostFindTerminalError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostGet3DsAvailability

- **Server group**: `Default4`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGet3DsAvailability(PostGet3DsAvailabilityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ThreeDsAvailabilityResponse`
- **Error**: `ApiException<PostGet3DsAvailabilityError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGet3DsAvailabilityRequest` | `src/Adyen/Requests/General/PostGet3DsAvailabilityRequest.cs` |
| `ThreeDsAvailabilityRequest` | `src/Adyen/Models/ThreeDsAvailabilityRequest.cs` |
| `ThreeDsAvailabilityResponse` | `src/Adyen/Models/ThreeDsAvailabilityResponse.cs` |
| `PostGet3DsAvailabilityError` | `src/Adyen/Errors/PostGet3DsAvailabilityError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostGetCostEstimate

- **Server group**: `Default4`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetCostEstimate(PostGetCostEstimateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CostEstimateResponse`
- **Error**: `ApiException<PostGetCostEstimateError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetCostEstimateRequest` | `src/Adyen/Requests/General/PostGetCostEstimateRequest.cs` |
| `CostEstimateRequest` | `src/Adyen/Models/CostEstimateRequest.cs` |
| `CostEstimateResponse` | `src/Adyen/Models/CostEstimateResponse.cs` |
| `PostGetCostEstimateError` | `src/Adyen/Errors/PostGetCostEstimateError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostGetNotificationConfiguration

- **Server group**: `Default12`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetNotificationConfiguration(PostGetNotificationConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetNotificationConfigurationResponse`
- **Error**: `ApiException<PostGetNotificationConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetNotificationConfigurationRequest` | `src/Adyen/Requests/General/PostGetNotificationConfigurationRequest.cs` |
| `GetNotificationConfigurationRequest` | `src/Adyen/Models/GetNotificationConfigurationRequest.cs` |
| `GetNotificationConfigurationResponse` | `src/Adyen/Models/GetNotificationConfigurationResponse.cs` |
| `PostGetNotificationConfigurationError` | `src/Adyen/Errors/PostGetNotificationConfigurationError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostGetNotificationConfigurationList

- **Server group**: `Default12`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetNotificationConfigurationList(PostGetNotificationConfigurationListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetNotificationConfigurationListResponse`
- **Error**: `ApiException<PostGetNotificationConfigurationListError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetNotificationConfigurationListRequest` | `src/Adyen/Requests/General/PostGetNotificationConfigurationListRequest.cs` |
| `GetNotificationConfigurationListResponse` | `src/Adyen/Models/GetNotificationConfigurationListResponse.cs` |
| `PostGetNotificationConfigurationListError` | `src/Adyen/Errors/PostGetNotificationConfigurationListError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostGetStoresUnderAccount

- **Server group**: `Default28`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetStoresUnderAccount(PostGetStoresUnderAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetStoresUnderAccountResponse`
- **Error**: `ApiException<PostGetStoresUnderAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetStoresUnderAccountRequest` | `src/Adyen/Requests/General/PostGetStoresUnderAccountRequest.cs` |
| `GetStoresUnderAccountRequest` | `src/Adyen/Models/GetStoresUnderAccountRequest.cs` |
| `GetStoresUnderAccountResponse` | `src/Adyen/Models/GetStoresUnderAccountResponse.cs` |
| `PostGetStoresUnderAccountError` | `src/Adyen/Errors/PostGetStoresUnderAccountError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostGetTerminalDetails

- **Server group**: `Default28`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetTerminalDetails(PostGetTerminalDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetTerminalDetailsResponse`
- **Error**: `ApiException<PostGetTerminalDetailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetTerminalDetailsRequest` | `src/Adyen/Requests/General/PostGetTerminalDetailsRequest.cs` |
| `GetTerminalDetailsRequest` | `src/Adyen/Models/GetTerminalDetailsRequest.cs` |
| `GetTerminalDetailsResponse` | `src/Adyen/Models/GetTerminalDetailsResponse.cs` |
| `PostGetTerminalDetailsError` | `src/Adyen/Errors/PostGetTerminalDetailsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostGetTerminalsUnderAccount

- **Server group**: `Default28`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetTerminalsUnderAccount(PostGetTerminalsUnderAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetTerminalsUnderAccountResponse`
- **Error**: `ApiException<PostGetTerminalsUnderAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetTerminalsUnderAccountRequest` | `src/Adyen/Requests/General/PostGetTerminalsUnderAccountRequest.cs` |
| `GetTerminalsUnderAccountRequest` | `src/Adyen/Models/GetTerminalsUnderAccountRequest.cs` |
| `GetTerminalsUnderAccountResponse` | `src/Adyen/Models/GetTerminalsUnderAccountResponse.cs` |
| `PostGetTerminalsUnderAccountError` | `src/Adyen/Errors/PostGetTerminalsUnderAccountError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostIssue

- **Server group**: `Default5`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostIssue(PostIssueRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoredValueIssueResponse`
- **Error**: `ApiException<PostIssueError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostIssueRequest` | `src/Adyen/Requests/General/PostIssueRequest.cs` |
| `StoredValueIssueRequest` | `src/Adyen/Models/StoredValueIssueRequest.cs` |
| `StoredValueIssueResponse` | `src/Adyen/Models/StoredValueIssueResponse.cs` |
| `PostIssueError` | `src/Adyen/Errors/PostIssueError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostListRecurringDetails

- **Server group**: `Default2`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostListRecurringDetails(PostListRecurringDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `RecurringDetailsResult`
- **Error**: `ApiException<PostListRecurringDetailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostListRecurringDetailsRequest` | `src/Adyen/Requests/General/PostListRecurringDetailsRequest.cs` |
| `RecurringDetailsRequest` | `src/Adyen/Models/RecurringDetailsRequest.cs` |
| `RecurringDetailsResult` | `src/Adyen/Models/RecurringDetailsResult.cs` |
| `PostListRecurringDetailsError` | `src/Adyen/Errors/PostListRecurringDetailsError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostLoad

- **Server group**: `Default5`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostLoad(PostLoadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoredValueLoadResponse`
- **Error**: `ApiException<PostLoadError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLoadRequest` | `src/Adyen/Requests/General/PostLoadRequest.cs` |
| `StoredValueLoadRequest` | `src/Adyen/Models/StoredValueLoadRequest.cs` |
| `StoredValueLoadResponse` | `src/Adyen/Models/StoredValueLoadResponse.cs` |
| `PostLoadError` | `src/Adyen/Errors/PostLoadError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostMergeBalance

- **Server group**: `Default5`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMergeBalance(PostMergeBalanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoredValueBalanceMergeResponse`
- **Error**: `ApiException<PostMergeBalanceError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMergeBalanceRequest` | `src/Adyen/Requests/General/PostMergeBalanceRequest.cs` |
| `StoredValueBalanceMergeRequest` | `src/Adyen/Models/StoredValueBalanceMergeRequest.cs` |
| `StoredValueBalanceMergeResponse` | `src/Adyen/Models/StoredValueBalanceMergeResponse.cs` |
| `PostMergeBalanceError` | `src/Adyen/Errors/PostMergeBalanceError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostNotifyShopper

- **Server group**: `Default2`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostNotifyShopper(PostNotifyShopperRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `NotifyShopperResult`
- **Error**: `ApiException<PostNotifyShopperError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostNotifyShopperRequest` | `src/Adyen/Requests/General/PostNotifyShopperRequest.cs` |
| `NotifyShopperRequest` | `src/Adyen/Models/NotifyShopperRequest.cs` |
| `NotifyShopperResult` | `src/Adyen/Models/NotifyShopperResult.cs` |
| `PostNotifyShopperError` | `src/Adyen/Errors/PostNotifyShopperError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPayoutAccountHolder

- **Server group**: `Default16`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPayoutAccountHolder(PostPayoutAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PayoutAccountHolderResponse`
- **Error**: `ApiException<PostPayoutAccountHolderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPayoutAccountHolderRequest` | `src/Adyen/Requests/General/PostPayoutAccountHolderRequest.cs` |
| `PayoutAccountHolderRequest` | `src/Adyen/Models/PayoutAccountHolderRequest.cs` |
| `PayoutAccountHolderResponse` | `src/Adyen/Models/PayoutAccountHolderResponse.cs` |
| `PostPayoutAccountHolderError` | `src/Adyen/Errors/PostPayoutAccountHolderError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostRefundFundsTransfer

- **Server group**: `Default16`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostRefundFundsTransfer(PostRefundFundsTransferRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `RefundFundsTransferResponse`
- **Error**: `ApiException<PostRefundFundsTransferError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostRefundFundsTransferRequest` | `src/Adyen/Requests/General/PostRefundFundsTransferRequest.cs` |
| `RefundFundsTransferRequest` | `src/Adyen/Models/RefundFundsTransferRequest.cs` |
| `RefundFundsTransferResponse` | `src/Adyen/Models/RefundFundsTransferResponse.cs` |
| `PostRefundFundsTransferError` | `src/Adyen/Errors/PostRefundFundsTransferError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostRefundNotPaidOutTransfers

- **Server group**: `Default16`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostRefundNotPaidOutTransfers(PostRefundNotPaidOutTransfersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenericResponse`
- **Error**: `ApiException<PostRefundNotPaidOutTransfersError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostRefundNotPaidOutTransfersRequest` | `src/Adyen/Requests/General/PostRefundNotPaidOutTransfersRequest.cs` |
| `RefundNotPaidOutTransfersRequest` | `src/Adyen/Models/RefundNotPaidOutTransfersRequest.cs` |
| `GenericResponse` | `src/Adyen/Models/GenericResponse.cs` |
| `PostRefundNotPaidOutTransfersError` | `src/Adyen/Errors/PostRefundNotPaidOutTransfersError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostRequestSubjectErasure

- **Server group**: `Default6`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostRequestSubjectErasure(PostRequestSubjectErasureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SubjectErasureResponse`
- **Error**: `ApiException<PostRequestSubjectErasureError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostRequestSubjectErasureRequest` | `src/Adyen/Requests/General/PostRequestSubjectErasureRequest.cs` |
| `SubjectErasureByPspReferenceRequest` | `src/Adyen/Models/SubjectErasureByPspReferenceRequest.cs` |
| `SubjectErasureResponse` | `src/Adyen/Models/SubjectErasureResponse.cs` |
| `PostRequestSubjectErasureError` | `src/Adyen/Errors/PostRequestSubjectErasureError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostRetrieveApplicableDefenseReasons

- **Server group**: `Default22`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostRetrieveApplicableDefenseReasons(PostRetrieveApplicableDefenseReasonsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DefenseReasonsResponse`
- **Error**: `ApiException<PostRetrieveApplicableDefenseReasonsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostRetrieveApplicableDefenseReasonsRequest` | `src/Adyen/Requests/General/PostRetrieveApplicableDefenseReasonsRequest.cs` |
| `DefenseReasonsRequest` | `src/Adyen/Models/DefenseReasonsRequest.cs` |
| `DefenseReasonsResponse` | `src/Adyen/Models/DefenseReasonsResponse.cs` |
| `PostRetrieveApplicableDefenseReasonsError` | `src/Adyen/Errors/PostRetrieveApplicableDefenseReasonsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostScheduleAccountUpdater

- **Server group**: `Default2`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostScheduleAccountUpdater(PostScheduleAccountUpdaterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ScheduleAccountUpdaterResult`
- **Error**: `ApiException<PostScheduleAccountUpdaterError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostScheduleAccountUpdaterRequest` | `src/Adyen/Requests/General/PostScheduleAccountUpdaterRequest.cs` |
| `ScheduleAccountUpdaterRequest` | `src/Adyen/Models/ScheduleAccountUpdaterRequest.cs` |
| `ScheduleAccountUpdaterResult` | `src/Adyen/Models/ScheduleAccountUpdaterResult.cs` |
| `PostScheduleAccountUpdaterError` | `src/Adyen/Errors/PostScheduleAccountUpdaterError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostSessions3

- **Server group**: `Default27`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostSessions3(PostSessions3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CertificateLoadingResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostSessions3Request` | `src/Adyen/Requests/General/PostSessions3Request.cs` |
| `CreateSessionRequest` | `src/Adyen/Models/CreateSessionRequest.cs` |
| `CertificateLoadingResponse` | `src/Adyen/Models/CertificateLoadingResponse.cs` |

### PostSetupBeneficiary

- **Server group**: `Default16`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostSetupBeneficiary(PostSetupBeneficiaryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenericResponse`
- **Error**: `ApiException<PostSetupBeneficiaryError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostSetupBeneficiaryRequest` | `src/Adyen/Requests/General/PostSetupBeneficiaryRequest.cs` |
| `SetupBeneficiaryRequest` | `src/Adyen/Models/SetupBeneficiaryRequest.cs` |
| `GenericResponse` | `src/Adyen/Models/GenericResponse.cs` |
| `PostSetupBeneficiaryError` | `src/Adyen/Errors/PostSetupBeneficiaryError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostSupplyDefenseDocument

- **Server group**: `Default22`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostSupplyDefenseDocument(PostSupplyDefenseDocumentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SupplyDefenseDocumentResponse`
- **Error**: `ApiException<PostSupplyDefenseDocumentError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostSupplyDefenseDocumentRequest` | `src/Adyen/Requests/General/PostSupplyDefenseDocumentRequest.cs` |
| `SupplyDefenseDocumentRequest` | `src/Adyen/Models/SupplyDefenseDocumentRequest.cs` |
| `SupplyDefenseDocumentResponse` | `src/Adyen/Models/SupplyDefenseDocumentResponse.cs` |
| `PostSupplyDefenseDocumentError` | `src/Adyen/Errors/PostSupplyDefenseDocumentError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostTestNotificationConfiguration

- **Server group**: `Default12`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTestNotificationConfiguration(PostTestNotificationConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TestNotificationConfigurationResponse`
- **Error**: `ApiException<PostTestNotificationConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTestNotificationConfigurationRequest` | `src/Adyen/Requests/General/PostTestNotificationConfigurationRequest.cs` |
| `TestNotificationConfigurationRequest` | `src/Adyen/Models/TestNotificationConfigurationRequest.cs` |
| `TestNotificationConfigurationResponse` | `src/Adyen/Models/TestNotificationConfigurationResponse.cs` |
| `PostTestNotificationConfigurationError` | `src/Adyen/Errors/PostTestNotificationConfigurationError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostTransferFunds

- **Server group**: `Default16`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTransferFunds(PostTransferFundsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TransferFundsResponse`
- **Error**: `ApiException<PostTransferFundsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTransferFundsRequest` | `src/Adyen/Requests/General/PostTransferFundsRequest.cs` |
| `TransferFundsRequest` | `src/Adyen/Models/TransferFundsRequest.cs` |
| `TransferFundsResponse` | `src/Adyen/Models/TransferFundsResponse.cs` |
| `PostTransferFundsError` | `src/Adyen/Errors/PostTransferFundsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostUpdateNotificationConfiguration

- **Server group**: `Default12`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostUpdateNotificationConfiguration(PostUpdateNotificationConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetNotificationConfigurationResponse`
- **Error**: `ApiException<PostUpdateNotificationConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostUpdateNotificationConfigurationRequest` | `src/Adyen/Requests/General/PostUpdateNotificationConfigurationRequest.cs` |
| `UpdateNotificationConfigurationRequest` | `src/Adyen/Models/UpdateNotificationConfigurationRequest.cs` |
| `GetNotificationConfigurationResponse` | `src/Adyen/Models/GetNotificationConfigurationResponse.cs` |
| `PostUpdateNotificationConfigurationError` | `src/Adyen/Errors/PostUpdateNotificationConfigurationError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostVoidTransaction

- **Server group**: `Default5`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostVoidTransaction(PostVoidTransactionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoredValueVoidResponse`
- **Error**: `ApiException<PostVoidTransactionError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostVoidTransactionRequest` | `src/Adyen/Requests/General/PostVoidTransactionRequest.cs` |
| `StoredValueVoidRequest` | `src/Adyen/Models/StoredValueVoidRequest.cs` |
| `StoredValueVoidResponse` | `src/Adyen/Models/StoredValueVoidResponse.cs` |
| `PostVoidTransactionError` | `src/Adyen/Errors/PostVoidTransactionError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

