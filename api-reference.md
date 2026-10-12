# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [AdyenClient](src/Adyen/AdyenClient.cs)

<details>
<summary><code>Task&lt;object&gt; AbortRequest(AbortRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Body of the Abort Request message.
It conveys Information requested for identification of the message request carrying the transaction to abort. A message to display on the CustomerError Device could be sent by the Sale System (DisplayOutput).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AbortRequest(new AbortRequestOperationRequest());
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AbortRequestOperationRequest](src/Adyen/Requests/AbortRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdminResponse&gt; AdminRequest(AdminRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Empty.
Content of the Custom Admin Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AdminRequest(new AdminRequestOperationRequest());
    // TODO: Handle 'response' of type AdminResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdminRequestOperationRequest](src/Adyen/Requests/AdminRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdminResponse](src/Adyen/Models/AdminResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceInquiryResponse&gt; BalanceInquiryRequest(BalanceInquiryRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys Information related to the account for which a Balance Inquiry is requested.
Content of the Balance Inquiry Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceInquiryRequest(new BalanceInquiryRequestOperationRequest());
    // TODO: Handle 'response' of type BalanceInquiryResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BalanceInquiryRequestOperationRequest](src/Adyen/Requests/BalanceInquiryRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceInquiryResponse](src/Adyen/Models/BalanceInquiryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CardAcquisitionResponse&gt; CardAcquisitionRequest(CardAcquisitionRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys Information related to the payment and loyalty cards to read and analyse. This message pair is usually followed by a message pair (e.g. payment or loyalty) which refers to this Card Acquisition message pair.
Content of the Card Acquisition Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CardAcquisitionRequest(new CardAcquisitionRequestOperationRequest());
    // TODO: Handle 'response' of type CardAcquisitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CardAcquisitionRequestOperationRequest](src/Adyen/Requests/CardAcquisitionRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CardAcquisitionResponse](src/Adyen/Models/CardAcquisitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CardReaderApduResponse&gt; CardReaderApduRequest(CardReaderApduRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It contains the APDU request to send to the chip of the card, and a possible invitation message to display on the CashierInterface or the CustomerInterface.
Content of the Card Reader APDU Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CardReaderApduRequest(new CardReaderApduRequestOperationRequest());
    // TODO: Handle 'response' of type CardReaderApduResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CardReaderApduRequestOperationRequest](src/Adyen/Requests/CardReaderApduRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CardReaderApduResponse](src/Adyen/Models/CardReaderApduResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DiagnosisResponse&gt; DiagnosisRequest(DiagnosisRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys Information related to the target POI for which the diagnosis is requested.
Content of the Diagnosis Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DiagnosisRequest(new DiagnosisRequestOperationRequest());
    // TODO: Handle 'response' of type DiagnosisResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DiagnosisRequestOperationRequest](src/Adyen/Requests/DiagnosisRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DiagnosisResponse](src/Adyen/Models/DiagnosisResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisplayResponse&gt; DisplayRequest(DisplayRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys the data to display and the way to process the display. It contains the complete content to display. It might contain an operation (the DisplayOutput element) per Display Device type.
Content of the Display Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisplayRequest(new DisplayRequestOperationRequest());
    // TODO: Handle 'response' of type DisplayResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DisplayRequestOperationRequest](src/Adyen/Requests/DisplayRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisplayResponse](src/Adyen/Models/DisplayResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EnableServiceResponse&gt; EnableServiceRequest(EnableServiceRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys the services that will be enabled for the POI Terminal without the request of the Sale System, and a possible invitation for the Customer to start the services.
Content of the Enable Service Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EnableServiceRequest(new EnableServiceRequestOperationRequest());
    // TODO: Handle 'response' of type EnableServiceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EnableServiceRequestOperationRequest](src/Adyen/Requests/EnableServiceRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EnableServiceResponse](src/Adyen/Models/EnableServiceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTotalsResponse&gt; GetTotalsRequest(GetTotalsRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys information from the Sale System related to the scope and the format of the totals to be computed by the POI System.
Content of the Get Totals Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GetTotalsRequest(new GetTotalsRequestOperationRequest());
    // TODO: Handle 'response' of type GetTotalsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTotalsRequestOperationRequest](src/Adyen/Requests/GetTotalsRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTotalsResponse](src/Adyen/Models/GetTotalsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InputResponse&gt; InputRequest(InputRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Content of the `InputRequest` message. It conveys the data to display and how to process it. In addition to the display on the Input Device, it might contain an operation (the `DisplayOutput` element) per Display Device type.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InputRequest(new InputRequestOperationRequest());
    // TODO: Handle 'response' of type InputResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InputRequestOperationRequest](src/Adyen/Requests/InputRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InputResponse](src/Adyen/Models/InputResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LoginResponse&gt; LoginRequest(LoginRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys information related to the session (period between a Login and the following Logout) to process.
Content of the `LoginRequest` message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LoginRequest(new LoginRequestOperationRequest());
    // TODO: Handle 'response' of type LoginResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LoginRequestOperationRequest](src/Adyen/Requests/LoginRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LoginResponse](src/Adyen/Models/LoginResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LogoutResponse&gt; LogoutRequest(LogoutRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Empty.
Content of the Logout Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LogoutRequest(new LogoutRequestOperationRequest());
    // TODO: Handle 'response' of type LogoutResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LogoutRequestOperationRequest](src/Adyen/Requests/LogoutRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LogoutResponse](src/Adyen/Models/LogoutResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentResponse4&gt; PaymentRequest(PaymentRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Request sent to terminal to initiate payment.
It conveys Information related to the Payment transaction to process.
Content of the `PaymentRequest` message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentRequest(new PaymentRequestOperationRequest());
    // TODO: Handle 'response' of type PaymentResponse4
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentRequestOperationRequest](src/Adyen/Requests/PaymentRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentResponse4](src/Adyen/Models/PaymentResponse4.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PrintResponse&gt; PrintRequest(PrintRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Content of the Print Request message.
It conveys the complete data to print and how to process the print.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PrintRequest(new PrintRequestOperationRequest());
    // TODO: Handle 'response' of type PrintResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PrintRequestOperationRequest](src/Adyen/Requests/PrintRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PrintResponse](src/Adyen/Models/PrintResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReconciliationResponse&gt; ReconciliationRequest(ReconciliationRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Content of the Reconciliation Request message.
It conveys Information related to the Reconciliation requested by the Sale System.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ReconciliationRequest(new ReconciliationRequestOperationRequest());
    // TODO: Handle 'response' of type ReconciliationResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReconciliationRequestOperationRequest](src/Adyen/Requests/ReconciliationRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReconciliationResponse](src/Adyen/Models/ReconciliationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReversalResponse&gt; ReversalRequest(ReversalRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys Information related to the reversal of a previous payment or a loyalty transaction.
Content of the Reversal Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ReversalRequest(new ReversalRequestOperationRequest());
    // TODO: Handle 'response' of type ReversalResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReversalRequestOperationRequest](src/Adyen/Requests/ReversalRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReversalResponse](src/Adyen/Models/ReversalResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueResponse&gt; StoredValueRequest(StoredValueRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

It conveys Information related to the Stored Value transaction to process.
Content of the Stored Value Request message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.StoredValueRequest(new StoredValueRequestOperationRequest());
    // TODO: Handle 'response' of type StoredValueResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StoredValueRequestOperationRequest](src/Adyen/Requests/StoredValueRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueResponse](src/Adyen/Models/StoredValueResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionStatusResponse&gt; TransactionStatusRequest(TransactionStatusRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Content of the TransactionStatus Request message.
It conveys Information requested for status of the last or current Payment, Loyalty or Reversal transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionStatusRequest(new TransactionStatusRequestOperationRequest());
    // TODO: Handle 'response' of type TransactionStatusResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionStatusRequestOperationRequest](src/Adyen/Requests/TransactionStatusRequestOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionStatusResponse](src/Adyen/Models/TransactionStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiCredentialsCompanyLevel

> Source: [ApiCredentialsCompanyLevel](src/Adyen/Api/ApiCredentialsCompanyLevel.cs)

<details>
<summary><code>Task&lt;ListCompanyApiCredentialsResponse&gt; GetCompaniesCompanyIdApiCredentials(GetCompaniesCompanyIdApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [API credentials](https://docs.adyen.com/development-resources/api-credentials) for the company account. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.GetCompaniesCompanyIdApiCredentials(
        new GetCompaniesCompanyIdApiCredentialsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type ListCompanyApiCredentialsResponse
}
catch (ApiException<GetCompaniesCompanyIdApiCredentialsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdApiCredentialsRequest](src/Adyen/Requests/ApiCredentialsCompanyLevel/GetCompaniesCompanyIdApiCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCompanyApiCredentialsResponse](src/Adyen/Models/ListCompanyApiCredentialsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdApiCredentialsError](src/Adyen/Errors/GetCompaniesCompanyIdApiCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyApiCredential&gt; GetCompaniesCompanyIdApiCredentialsApiCredentialId(GetCompaniesCompanyIdApiCredentialsApiCredentialIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [API credential](https://docs.adyen.com/development-resources/api-credentials) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.GetCompaniesCompanyIdApiCredentialsApiCredentialId(
        new GetCompaniesCompanyIdApiCredentialsApiCredentialIdRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
        });
    // TODO: Handle 'response' of type CompanyApiCredential
}
catch (ApiException<GetCompaniesCompanyIdApiCredentialsApiCredentialIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdApiCredentialsApiCredentialIdRequest](src/Adyen/Requests/ApiCredentialsCompanyLevel/GetCompaniesCompanyIdApiCredentialsApiCredentialIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyApiCredential](src/Adyen/Models/CompanyApiCredential.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdApiCredentialsApiCredentialIdError](src/Adyen/Errors/GetCompaniesCompanyIdApiCredentialsApiCredentialIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyApiCredential&gt; PatchCompaniesCompanyIdApiCredentialsApiCredentialId(PatchCompaniesCompanyIdApiCredentialsApiCredentialIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the API credential's roles, merchant account access, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.PatchCompaniesCompanyIdApiCredentialsApiCredentialId(
        new PatchCompaniesCompanyIdApiCredentialsApiCredentialIdRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
            Body = new UpdateCompanyApiCredentialRequest { Active = true },
        });
    // TODO: Handle 'response' of type CompanyApiCredential
}
catch (ApiException<PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchCompaniesCompanyIdApiCredentialsApiCredentialIdRequest](src/Adyen/Requests/ApiCredentialsCompanyLevel/PatchCompaniesCompanyIdApiCredentialsApiCredentialIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyApiCredential](src/Adyen/Models/CompanyApiCredential.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError](src/Adyen/Errors/PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCompanyApiCredentialResponse&gt; PostCompaniesCompanyIdApiCredentials(PostCompaniesCompanyIdApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an [API credential](https://docs.adyen.com/development-resources/api-credentials) for the company account identified in the path. In the request, you can specify which merchant accounts the new API credential will have access to, as well as its roles and allowed origins.

The response includes several types of authentication details:
* [API key](https://docs.adyen.com/development-resources/api-authentication#api-key-authentication): used for API request authentication.
* [Client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works): public key used for client-side authentication.
* [Username and password](https://docs.adyen.com/development-resources/api-authentication#using-basic-authentication): used for basic authentication.

> Make sure you store the API key securely in your system. You won't be able to retrieve it later.

If your API key is lost or compromised, you need to [generate a new API key](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/apiCredentials/{apiCredentialId}/generateApiKey).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsCompanyLevel.PostCompaniesCompanyIdApiCredentials(
        new PostCompaniesCompanyIdApiCredentialsRequest
        {
            CompanyId = "some example string",
            Body = new CreateCompanyApiCredentialRequest
            {
                AllowedOrigins = ["https://www.mystore.com"],
                AssociatedMerchantAccounts = [
                    "YOUR_MERCHANT_ACCOUNT_AU",
                    "YOUR_MERCHANT_ACCOUNT_EU",
                    "YOUR_MERCHANT_ACCOUNT_US",
                ],
                Roles = ["Checkout webservice role"],
            },
        });
    // TODO: Handle 'response' of type CreateCompanyApiCredentialResponse
}
catch (ApiException<PostCompaniesCompanyIdApiCredentialsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdApiCredentialsRequest](src/Adyen/Requests/ApiCredentialsCompanyLevel/PostCompaniesCompanyIdApiCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCompanyApiCredentialResponse](src/Adyen/Models/CreateCompanyApiCredentialResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdApiCredentialsError](src/Adyen/Errors/PostCompaniesCompanyIdApiCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiCredentialsMerchantLevel

> Source: [ApiCredentialsMerchantLevel](src/Adyen/Api/ApiCredentialsMerchantLevel.cs)

<details>
<summary><code>Task&lt;ListMerchantApiCredentialsResponse&gt; GetMerchantsMerchantIdApiCredentials(GetMerchantsMerchantIdApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [API credentials](https://docs.adyen.com/development-resources/api-credentials) for the merchant account. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.GetMerchantsMerchantIdApiCredentials(
        new GetMerchantsMerchantIdApiCredentialsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type ListMerchantApiCredentialsResponse
}
catch (ApiException<GetMerchantsMerchantIdApiCredentialsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdApiCredentialsRequest](src/Adyen/Requests/ApiCredentialsMerchantLevel/GetMerchantsMerchantIdApiCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantApiCredentialsResponse](src/Adyen/Models/ListMerchantApiCredentialsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdApiCredentialsError](src/Adyen/Errors/GetMerchantsMerchantIdApiCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiCredential&gt; GetMerchantsMerchantIdApiCredentialsApiCredentialId(GetMerchantsMerchantIdApiCredentialsApiCredentialIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [API credential](https://docs.adyen.com/development-resources/api-credentials) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.GetMerchantsMerchantIdApiCredentialsApiCredentialId(
        new GetMerchantsMerchantIdApiCredentialsApiCredentialIdRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
        });
    // TODO: Handle 'response' of type ApiCredential
}
catch (ApiException<GetMerchantsMerchantIdApiCredentialsApiCredentialIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdApiCredentialsApiCredentialIdRequest](src/Adyen/Requests/ApiCredentialsMerchantLevel/GetMerchantsMerchantIdApiCredentialsApiCredentialIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiCredential](src/Adyen/Models/ApiCredential.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdApiCredentialsApiCredentialIdError](src/Adyen/Errors/GetMerchantsMerchantIdApiCredentialsApiCredentialIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiCredential&gt; PatchMerchantsMerchantIdApiCredentialsApiCredentialId(PatchMerchantsMerchantIdApiCredentialsApiCredentialIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the API credential's roles, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.PatchMerchantsMerchantIdApiCredentialsApiCredentialId(
        new PatchMerchantsMerchantIdApiCredentialsApiCredentialIdRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
            Body = new UpdateMerchantApiCredentialRequest { Active = true },
        });
    // TODO: Handle 'response' of type ApiCredential
}
catch (ApiException<PatchMerchantsMerchantIdApiCredentialsApiCredentialIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdApiCredentialsApiCredentialIdRequest](src/Adyen/Requests/ApiCredentialsMerchantLevel/PatchMerchantsMerchantIdApiCredentialsApiCredentialIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiCredential](src/Adyen/Models/ApiCredential.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdApiCredentialsApiCredentialIdError](src/Adyen/Errors/PatchMerchantsMerchantIdApiCredentialsApiCredentialIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateApiCredentialResponse&gt; PostMerchantsMerchantIdApiCredentials(PostMerchantsMerchantIdApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an [API credential](https://docs.adyen.com/development-resources/api-credentials) for the company account identified in the path. In the request, you can specify the roles and allowed origins for the new API credential.

The response includes the:
* [API key](https://docs.adyen.com/development-resources/api-authentication#api-key-authentication): used for API request authentication.
* [Client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works): public key used for client-side authentication.
* [Username and password](https://docs.adyen.com/development-resources/api-authentication#using-basic-authentication): used for basic authentication.

> Make sure you store the API key securely in your system. You won't be able to retrieve it later.

If your API key is lost or compromised, you need to [generate a new API key](https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiCredentialsMerchantLevel.PostMerchantsMerchantIdApiCredentials(
        new PostMerchantsMerchantIdApiCredentialsRequest
        {
            MerchantId = "some example string",
            Body = new CreateMerchantApiCredentialRequest
            {
                AllowedOrigins = ["https://www.mystore.com"],
                Roles = ["Checkout webservice role"],
            },
        });
    // TODO: Handle 'response' of type CreateApiCredentialResponse
}
catch (ApiException<PostMerchantsMerchantIdApiCredentialsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdApiCredentialsRequest](src/Adyen/Requests/ApiCredentialsMerchantLevel/PostMerchantsMerchantIdApiCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateApiCredentialResponse](src/Adyen/Models/CreateApiCredentialResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdApiCredentialsError](src/Adyen/Errors/PostMerchantsMerchantIdApiCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiKeyCompanyLevel

> Source: [ApiKeyCompanyLevel](src/Adyen/Api/ApiKeyCompanyLevel.cs)

<details>
<summary><code>Task&lt;GenerateApiKeyResponse&gt; PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKey(PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new API key for the API credential. You can use the new API key a few minutes after generating it. The old API key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeyCompanyLevel.PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKey(
        new PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
        });
    // TODO: Handle 'response' of type GenerateApiKeyResponse
}
catch (ApiException<PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyRequest](src/Adyen/Requests/ApiKeyCompanyLevel/PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateApiKeyResponse](src/Adyen/Models/GenerateApiKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyError](src/Adyen/Errors/PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiKeyMerchantLevel

> Source: [ApiKeyMerchantLevel](src/Adyen/Api/ApiKeyMerchantLevel.cs)

<details>
<summary><code>Task&lt;GenerateApiKeyResponse&gt; PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKey(PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new API key for the API credential. You can use the new API key a few minutes after generating it. The old API key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeyMerchantLevel.PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKey(
        new PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
        });
    // TODO: Handle 'response' of type GenerateApiKeyResponse
}
catch (ApiException<PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyRequest](src/Adyen/Requests/ApiKeyMerchantLevel/PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateApiKeyResponse](src/Adyen/Models/GenerateApiKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyError](src/Adyen/Errors/PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountCompanyLevel

> Source: [AccountCompanyLevel](src/Adyen/Api/AccountCompanyLevel.cs)

<details>
<summary><code>Task&lt;ListCompanyResponse&gt; GetCompanies(GetCompaniesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of company accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountCompanyLevel.GetCompanies(new GetCompaniesRequest());
    // TODO: Handle 'response' of type ListCompanyResponse
}
catch (ApiException<GetCompaniesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesRequest](src/Adyen/Requests/AccountCompanyLevel/GetCompaniesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCompanyResponse](src/Adyen/Models/ListCompanyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesError](src/Adyen/Errors/GetCompaniesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Company2&gt; GetCompaniesCompanyId(GetCompaniesCompanyIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the company account specified in the path. Your API credential must have access to the company account. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountCompanyLevel.GetCompaniesCompanyId(new GetCompaniesCompanyIdRequest
    {
        CompanyId = "some example string",
    });
    // TODO: Handle 'response' of type Company2
}
catch (ApiException<GetCompaniesCompanyIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdRequest](src/Adyen/Requests/AccountCompanyLevel/GetCompaniesCompanyIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Company2](src/Adyen/Models/Company2.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdError](src/Adyen/Errors/GetCompaniesCompanyIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListMerchantResponse&gt; GetCompaniesCompanyIdMerchants(GetCompaniesCompanyIdMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of merchant accounts under the company account specified in the path. The list only includes merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountCompanyLevel.GetCompaniesCompanyIdMerchants(
        new GetCompaniesCompanyIdMerchantsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type ListMerchantResponse
}
catch (ApiException<GetCompaniesCompanyIdMerchantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdMerchantsRequest](src/Adyen/Requests/AccountCompanyLevel/GetCompaniesCompanyIdMerchantsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantResponse](src/Adyen/Models/ListMerchantResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdMerchantsError](src/Adyen/Errors/GetCompaniesCompanyIdMerchantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountMerchantLevel

> Source: [AccountMerchantLevel](src/Adyen/Api/AccountMerchantLevel.cs)

<details>
<summary><code>Task&lt;ListMerchantResponse&gt; GetMerchants(GetMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters. 

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.GetMerchants(new GetMerchantsRequest());
    // TODO: Handle 'response' of type ListMerchantResponse
}
catch (ApiException<GetMerchantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsRequest](src/Adyen/Requests/AccountMerchantLevel/GetMerchantsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantResponse](src/Adyen/Models/ListMerchantResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsError](src/Adyen/Errors/GetMerchantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Merchant&gt; GetMerchantsMerchantId(GetMerchantsMerchantIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the merchant account specified in the path. Your API credential must have access to the merchant account.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Account read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.GetMerchantsMerchantId(new GetMerchantsMerchantIdRequest
    {
        MerchantId = "some example string",
    });
    // TODO: Handle 'response' of type Merchant
}
catch (ApiException<GetMerchantsMerchantIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdRequest](src/Adyen/Requests/AccountMerchantLevel/GetMerchantsMerchantIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Merchant](src/Adyen/Models/Merchant.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdError](src/Adyen/Errors/GetMerchantsMerchantIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateMerchantResponse&gt; PostMerchants(PostMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a merchant account for the company account specified in the request.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Accounts read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.PostMerchants(new PostMerchantsRequest
    {
        Body = new CreateMerchantRequest
        {
            BusinessLineId = "YOUR_BUSINESS_LINE_ID",
            CompanyId = "YOUR_COMPANY_ACCOUNT",
            Description = "YOUR_DESCRIPTION",
            LegalEntityId = "YOUR_LEGAL_ENTITY_ID",
            Reference = "YOUR_OWN_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type CreateMerchantResponse
}
catch (ApiException<PostMerchantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsRequest](src/Adyen/Requests/AccountMerchantLevel/PostMerchantsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateMerchantResponse](src/Adyen/Models/CreateMerchantResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsError](src/Adyen/Errors/PostMerchantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RequestActivationResponse&gt; PostMerchantsMerchantIdActivate(PostMerchantsMerchantIdActivateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a request to activate the merchant account identified in the path.

You get the result of the activation asynchronously through a [`merchant.updated`](https://docs.adyen.com/api-explorer/ManagementNotification/latest/post/merchant.updated) webhook. Once the merchant account is activated, you can start using it to accept payments and payouts.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Accounts read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountMerchantLevel.PostMerchantsMerchantIdActivate(
        new PostMerchantsMerchantIdActivateRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type RequestActivationResponse
}
catch (ApiException<PostMerchantsMerchantIdActivateError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdActivateRequest](src/Adyen/Requests/AccountMerchantLevel/PostMerchantsMerchantIdActivateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RequestActivationResponse](src/Adyen/Models/RequestActivationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdActivateError](src/Adyen/Errors/PostMerchantsMerchantIdActivateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountStoreLevel

> Source: [AccountStoreLevel](src/Adyen/Api/AccountStoreLevel.cs)

<details>
<summary><code>Task&lt;ListStoresResponse&gt; GetMerchantsMerchantIdStores(GetMerchantsMerchantIdStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of stores for the merchant account identified in the path. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.GetMerchantsMerchantIdStores(new GetMerchantsMerchantIdStoresRequest
    {
        MerchantId = "some example string",
    });
    // TODO: Handle 'response' of type ListStoresResponse
}
catch (ApiException<GetMerchantsMerchantIdStoresError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdStoresRequest](src/Adyen/Requests/AccountStoreLevel/GetMerchantsMerchantIdStoresRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListStoresResponse](src/Adyen/Models/ListStoresResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdStoresError](src/Adyen/Errors/GetMerchantsMerchantIdStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; GetMerchantsMerchantIdStoresStoreId(GetMerchantsMerchantIdStoresStoreIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the store identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.GetMerchantsMerchantIdStoresStoreId(
        new GetMerchantsMerchantIdStoresStoreIdRequest
        {
            MerchantId = "some example string",
            StoreId = "some example string",
        });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<GetMerchantsMerchantIdStoresStoreIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdStoresStoreIdRequest](src/Adyen/Requests/AccountStoreLevel/GetMerchantsMerchantIdStoresStoreIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/Adyen/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdStoresStoreIdError](src/Adyen/Errors/GetMerchantsMerchantIdStoresStoreIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListStoresResponse&gt; GetStores(GetStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of stores. The list is grouped into pages as defined by the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.GetStores(new GetStoresRequest());
    // TODO: Handle 'response' of type ListStoresResponse
}
catch (ApiException<GetStoresError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStoresRequest](src/Adyen/Requests/AccountStoreLevel/GetStoresRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListStoresResponse](src/Adyen/Models/ListStoresResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetStoresError](src/Adyen/Errors/GetStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; GetStoresStoreId(GetStoresStoreIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the store identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.GetStoresStoreId(new GetStoresStoreIdRequest
    {
        StoreId = "some example string",
    });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<GetStoresStoreIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStoresStoreIdRequest](src/Adyen/Requests/AccountStoreLevel/GetStoresStoreIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/Adyen/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetStoresStoreIdError](src/Adyen/Errors/GetStoresStoreIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; PatchMerchantsMerchantIdStoresStoreId(PatchMerchantsMerchantIdStoresStoreIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the store identified in the path. You can only update some store parameters.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.PatchMerchantsMerchantIdStoresStoreId(
        new PatchMerchantsMerchantIdStoresStoreIdRequest
        {
            MerchantId = "some example string",
            StoreId = "some example string",
            Body = new UpdateStoreRequest
            {
                Address = new UpdatableAddress1
                {
                    Line1 = "1776 West Pinewood Avenue",
                    Line2 = "Heartland Building",
                    Line3 = "",
                    PostalCode = "20251",
                },
            },
        });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<PatchMerchantsMerchantIdStoresStoreIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdStoresStoreIdRequest](src/Adyen/Requests/AccountStoreLevel/PatchMerchantsMerchantIdStoresStoreIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/Adyen/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdStoresStoreIdError](src/Adyen/Errors/PatchMerchantsMerchantIdStoresStoreIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; PatchStoresStoreId(PatchStoresStoreIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the store identified in the path.
You can only update some store parameters.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.PatchStoresStoreId(new PatchStoresStoreIdRequest
    {
        StoreId = "some example string",
        Body = new UpdateStoreRequest
        {
            Address = new UpdatableAddress1
            {
                Line1 = "1776 West Pinewood Avenue",
                Line2 = "Heartland Building",
                Line3 = "",
                PostalCode = "20251",
            },
        },
    });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<PatchStoresStoreIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchStoresStoreIdRequest](src/Adyen/Requests/AccountStoreLevel/PatchStoresStoreIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/Adyen/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchStoresStoreIdError](src/Adyen/Errors/PatchStoresStoreIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; PostMerchantsMerchantIdStores(PostMerchantsMerchantIdStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a store for the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.PostMerchantsMerchantIdStores(new PostMerchantsMerchantIdStoresRequest
    {
        MerchantId = "some example string",
        Body = new StoreCreationRequest
        {
            Address = new StoreLocation1
            {
                City = "Springfield",
                Country = "US",
                Line1 = "200 Main Street",
                Line2 = "Building 5A",
                Line3 = "Suite 3",
                PostalCode = "20250",
                StateOrProvince = "NY",
            },
            Description = "City centre store",
            PhoneNumber = "13123456789",
            Reference = "Spring_store_2",
            ShopperStatement = "Springfield Shop",
        },
    });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<PostMerchantsMerchantIdStoresError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdStoresRequest](src/Adyen/Requests/AccountStoreLevel/PostMerchantsMerchantIdStoresRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/Adyen/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdStoresError](src/Adyen/Errors/PostMerchantsMerchantIdStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Store&gt; PostStores(PostStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a store for the merchant account specified in the request.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Stores read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountStoreLevel.PostStores(new PostStoresRequest
    {
        Body = new StoreCreationWithMerchantCodeRequest
        {
            Address = new StoreLocation1
            {
                City = "Springfield",
                Country = "US",
                Line1 = "200 Main Street",
                Line2 = "Building 5A",
                Line3 = "Suite 3",
                PostalCode = "20250",
                StateOrProvince = "NY",
            },
            Description = "City centre store",
            MerchantId = "YOUR_MERCHANT_ACCOUNT_ID",
            PhoneNumber = "+13123456789",
            Reference = "Spring_store_2",
            ShopperStatement = "Springfield Shop",
        },
    });
    // TODO: Handle 'response' of type Store
}
catch (ApiException<PostStoresError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostStoresRequest](src/Adyen/Requests/AccountStoreLevel/PostStoresRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Store](src/Adyen/Models/Store.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostStoresError](src/Adyen/Errors/PostStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountVerification

> Source: [AccountVerification](src/Adyen/Api/AccountVerification.cs)

<details>
<summary><code>Task&lt;AccountVerificationReportResponse&gt; GetAccountVerificationReportsCode(GetAccountVerificationReportsCodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the account verification report using a unique code from a successful open banking connection. This report provides identity verification and bank account details.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountVerification.GetAccountVerificationReportsCode(
        new GetAccountVerificationReportsCodeRequest { Code = "some example string" });
    // TODO: Handle 'response' of type AccountVerificationReportResponse
}
catch (ApiException<GetAccountVerificationReportsCodeError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountVerificationReportsCodeRequest](src/Adyen/Requests/AccountVerification/GetAccountVerificationReportsCodeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountVerificationReportResponse](src/Adyen/Models/AccountVerificationReportResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetAccountVerificationReportsCodeError](src/Adyen/Errors/GetAccountVerificationReportsCodeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountVerificationRoutesResponse&gt; PostAccountVerificationRoutes(PostAccountVerificationRoutesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a list of routes for verifying bank accounts of third-party individuals. Successful connections generate a unique code used for requesting bank reports and verifying identity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountVerification.PostAccountVerificationRoutes(
        new PostAccountVerificationRoutesRequest
        {
            Body = new AccountVerificationRoutesRequest
            {
                Country = AccountVerificationCountry2.Nl,
                Locale = "en-US",
                RedirectUrl = "https://merchanturl.example.org/redirect/url",
                State = "11a1e60a-18b0-4dda-9258-e0ae29e1e2a3",
            },
        });
    // TODO: Handle 'response' of type AccountVerificationRoutesResponse
}
catch (ApiException<PostAccountVerificationRoutesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAccountVerificationRoutesRequest](src/Adyen/Requests/AccountVerification/PostAccountVerificationRoutesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountVerificationRoutesResponse](src/Adyen/Models/AccountVerificationRoutesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostAccountVerificationRoutesError](src/Adyen/Errors/PostAccountVerificationRoutesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountHolders

> Source: [AccountHolders](src/Adyen/Api/AccountHolders.cs)

<details>
<summary><code>Task&lt;AccountHolder&gt; GetAccountHoldersId(GetAccountHoldersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.GetAccountHoldersId(new GetAccountHoldersIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type AccountHolder
}
catch (ApiException<GetAccountHoldersIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountHoldersIdRequest](src/Adyen/Requests/AccountHolders/GetAccountHoldersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountHolder](src/Adyen/Models/AccountHolder.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetAccountHoldersIdError](src/Adyen/Errors/GetAccountHoldersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedBalanceAccountsResponse&gt; GetAccountHoldersIdBalanceAccounts(GetAccountHoldersIdBalanceAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of the balance accounts associated with an account holder. To fetch multiple pages, use the query parameters. 

For example, to limit the page to 5 balance accounts and skip the first 10, use `/accountHolders/{id}/balanceAccounts?limit=5&offset=10`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.GetAccountHoldersIdBalanceAccounts(
        new GetAccountHoldersIdBalanceAccountsRequest { Id = "some example string" });
    // TODO: Handle 'response' of type PaginatedBalanceAccountsResponse
}
catch (ApiException<GetAccountHoldersIdBalanceAccountsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountHoldersIdBalanceAccountsRequest](src/Adyen/Requests/AccountHolders/GetAccountHoldersIdBalanceAccountsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedBalanceAccountsResponse](src/Adyen/Models/PaginatedBalanceAccountsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetAccountHoldersIdBalanceAccountsError](src/Adyen/Errors/GetAccountHoldersIdBalanceAccountsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TaxFormSummaryResponse&gt; GetAccountHoldersIdTaxFormSummary(GetAccountHoldersIdTaxFormSummaryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a summary of all tax forms for an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.GetAccountHoldersIdTaxFormSummary(
        new GetAccountHoldersIdTaxFormSummaryRequest { Id = "some example string", FormType = "some example string" });
    // TODO: Handle 'response' of type TaxFormSummaryResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountHoldersIdTaxFormSummaryRequest](src/Adyen/Requests/AccountHolders/GetAccountHoldersIdTaxFormSummaryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TaxFormSummaryResponse](src/Adyen/Models/TaxFormSummaryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTaxFormResponse1&gt; GetAccountHoldersIdTaxForms(GetAccountHoldersIdTaxFormsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a tax form for account holders operating in the US. For more information, refer to US tax forms for [marketplaces](https://docs.adyen.com/marketplaces/us-tax-forms/) or [platforms](https://docs.adyen.com/platforms/us-tax-forms/) .

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.GetAccountHoldersIdTaxForms(new GetAccountHoldersIdTaxFormsRequest
    {
        Id = "some example string",
        FormType = FormType.Us1099K,
        Year = 1,
    });
    // TODO: Handle 'response' of type GetTaxFormResponse1
}
catch (ApiException<GetAccountHoldersIdTaxFormsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountHoldersIdTaxFormsRequest](src/Adyen/Requests/AccountHolders/GetAccountHoldersIdTaxFormsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTaxFormResponse1](src/Adyen/Models/GetTaxFormResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetAccountHoldersIdTaxFormsError](src/Adyen/Errors/GetAccountHoldersIdTaxFormsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRulesResponse&gt; GetAccountHoldersIdTransactionRules(GetAccountHoldersIdTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of transaction rules associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.GetAccountHoldersIdTransactionRules(
        new GetAccountHoldersIdTransactionRulesRequest { Id = "some example string" });
    // TODO: Handle 'response' of type TransactionRulesResponse
}
catch (ApiException<GetAccountHoldersIdTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountHoldersIdTransactionRulesRequest](src/Adyen/Requests/AccountHolders/GetAccountHoldersIdTransactionRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRulesResponse](src/Adyen/Models/TransactionRulesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetAccountHoldersIdTransactionRulesError](src/Adyen/Errors/GetAccountHoldersIdTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountHolder&gt; PatchAccountHoldersId(PatchAccountHoldersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an account holder. When updating an account holder resource, if a parameter is not provided in the request, it is left unchanged.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PatchAccountHoldersId(new PatchAccountHoldersIdRequest
    {
        Id = "some example string",
        Body = new AccountHolderUpdateRequest
        {
            Capabilities = new Dictionary<string, AccountHolderCapability>
            {
                ["receivePayments"] = new AccountHolderCapability { Requested = true },
            },
            Description = "Account holder used for international payments and payouts",
            Reference = "S.Eller-001",
        },
    });
    // TODO: Handle 'response' of type AccountHolder
}
catch (ApiException<PatchAccountHoldersIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchAccountHoldersIdRequest](src/Adyen/Requests/AccountHolders/PatchAccountHoldersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountHolder](src/Adyen/Models/AccountHolder.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchAccountHoldersIdError](src/Adyen/Errors/PatchAccountHoldersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountHolder&gt; PostAccountHolders(PostAccountHoldersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an account holder linked to a [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostAccountHolders(new PostAccountHoldersRequest
    {
        Body = new AccountHolderInfo
        {
            Description = "Account holder used for international payments and payouts",
            LegalEntityId = "LE322JV223222D5GG42KN6869",
            Reference = "S.Eller-001",
        },
    });
    // TODO: Handle 'response' of type AccountHolder
}
catch (ApiException<PostAccountHoldersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAccountHoldersRequest](src/Adyen/Requests/AccountHolders/PostAccountHoldersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountHolder](src/Adyen/Models/AccountHolder.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostAccountHoldersError](src/Adyen/Errors/PostAccountHoldersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CloseAccountHolderResponse&gt; PostCloseAccountHolder(PostCloseAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [status of an account holder](https://docs.adyen.com/classic-platforms/account-holders-and-accounts#account-holder-statuses) to **Closed**. This state is final. If an account holder is closed, you can't process transactions, pay out funds, or reopen it. If payments are made to an account of an account holder with a **Closed** [`status`](https://docs.adyen.com/api-explorer/#/Account/latest/post/getAccountHolder__resParam_verification-accountHolder-checks-status), the payments are sent to your liable account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostCloseAccountHolder(new PostCloseAccountHolderRequest
    {
        Body = new CloseAccountHolderRequest { AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER" },
    });
    // TODO: Handle 'response' of type CloseAccountHolderResponse
}
catch (ApiException<PostCloseAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCloseAccountHolderRequest](src/Adyen/Requests/AccountHolders/PostCloseAccountHolderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CloseAccountHolderResponse](src/Adyen/Models/CloseAccountHolderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCloseAccountHolderError](src/Adyen/Errors/PostCloseAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostCloseStores(PostCloseStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Closes stores associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostCloseStores(new PostCloseStoresRequest());
    // TODO: Handle 'response' of type GenericResponse
}
catch (ApiException<PostCloseStoresError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCloseStoresRequest](src/Adyen/Requests/AccountHolders/PostCloseStoresRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](src/Adyen/Models/GenericResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCloseStoresError](src/Adyen/Errors/PostCloseStoresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateAccountHolderResponse&gt; PostCreateAccountHolder(PostCreateAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an account holder that [represents the sub-merchant's entity](https://docs.adyen.com/classic-platforms/account-structure#your-platform) in your platform. The details that you need to provide in the request depend on the sub-merchant's legal entity type. For more information, refer to [Account holder and accounts](https://docs.adyen.com/classic-platforms/account-holders-and-accounts#legal-entity-types).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostCreateAccountHolder(new PostCreateAccountHolderRequest
    {
        Body = new CreateAccountHolderRequest
        {
            AccountHolderCode = "YOUR_UNIQUE_ACCOUNT_HOLDER_CODE",
            AccountHolderDetails = new AccountHolderDetails1
            {
                Address = new ViasAddress9 { Country = "US" },
                BusinessDetails = new BusinessDetails3
                {
                    DoingBusinessAs = "Real Good Restaurant",
                    LegalBusinessName = "Real Good Restaurant Inc.",
                    Shareholders = [new ShareholderContact()],
                },
                Email = "test@email.com",
                WebAddress = "https://www.your-website.com",
            },
            LegalEntity = LegalEntity.Business,
        },
    });
    // TODO: Handle 'response' of type CreateAccountHolderResponse
}
catch (ApiException<PostCreateAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCreateAccountHolderRequest](src/Adyen/Requests/AccountHolders/PostCreateAccountHolderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateAccountHolderResponse](src/Adyen/Models/CreateAccountHolderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCreateAccountHolderError](src/Adyen/Errors/PostCreateAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetAccountHolderResponse&gt; PostGetAccountHolder(PostGetAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostGetAccountHolder(new PostGetAccountHolderRequest
    {
        Body = new GetAccountHolderRequest { AccountCode = "CODE_OF_ACCOUNT" },
    });
    // TODO: Handle 'response' of type GetAccountHolderResponse
}
catch (ApiException<PostGetAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetAccountHolderRequest](src/Adyen/Requests/AccountHolders/PostGetAccountHolderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAccountHolderResponse](src/Adyen/Models/GetAccountHolderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetAccountHolderError](src/Adyen/Errors/PostGetAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTaxFormResponse&gt; PostGetTaxForm(PostGetTaxFormRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a tax form for account holders operating in the US. For more information, refer to [Providing tax forms](https://docs.adyen.com/classic-platforms/tax-forms).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostGetTaxForm(new PostGetTaxFormRequest
    {
        Body = new GetTaxFormRequest { AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER", FormType = "1099-K", Year = 2020 },
    });
    // TODO: Handle 'response' of type GetTaxFormResponse
}
catch (ApiException<PostGetTaxFormError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetTaxFormRequest](src/Adyen/Requests/AccountHolders/PostGetTaxFormRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTaxFormResponse](src/Adyen/Models/GetTaxFormResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetTaxFormError](src/Adyen/Errors/PostGetTaxFormError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SuspendAccountHolderResponse&gt; PostSuspendAccountHolder(PostSuspendAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [status of an account holder](https://docs.adyen.com/classic-platforms/account-holders-and-accounts#account-holder-statuses) to **Suspended**.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostSuspendAccountHolder(new PostSuspendAccountHolderRequest
    {
        Body = new SuspendAccountHolderRequest { AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER" },
    });
    // TODO: Handle 'response' of type SuspendAccountHolderResponse
}
catch (ApiException<PostSuspendAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostSuspendAccountHolderRequest](src/Adyen/Requests/AccountHolders/PostSuspendAccountHolderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SuspendAccountHolderResponse](src/Adyen/Models/SuspendAccountHolderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostSuspendAccountHolderError](src/Adyen/Errors/PostSuspendAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UnSuspendAccountHolderResponse&gt; PostUnSuspendAccountHolder(PostUnSuspendAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [status of an account holder](https://docs.adyen.com/classic-platforms/account-holders-and-accounts#account-holder-statuses) from **Suspended** to **Inactive**. 
Account holders can have a **Suspended** [`status`](https://docs.adyen.com/api-explorer/#/Account/latest/post/getAccountHolder__resParam_verification-accountHolder-checks-status) if you suspend them through the [`/suspendAccountHolder`](https://docs.adyen.com/api-explorer/#/Account/v5/post/suspendAccountHolder) endpoint or if a verification deadline expires.

You can only unsuspend account holders if they do not have verification checks with a **FAILED** [`status`](https://docs.adyen.com/api-explorer/#/Account/latest/post/getAccountHolder__resParam_verification-accountHolder-checks-status).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostUnSuspendAccountHolder(new PostUnSuspendAccountHolderRequest
    {
        Body = new UnSuspendAccountHolderRequest { AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER" },
    });
    // TODO: Handle 'response' of type UnSuspendAccountHolderResponse
}
catch (ApiException<PostUnSuspendAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostUnSuspendAccountHolderRequest](src/Adyen/Requests/AccountHolders/PostUnSuspendAccountHolderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UnSuspendAccountHolderResponse](src/Adyen/Models/UnSuspendAccountHolderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostUnSuspendAccountHolderError](src/Adyen/Errors/PostUnSuspendAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateAccountHolderResponse&gt; PostUpdateAccountHolder(PostUpdateAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the `accountHolderDetails` and `processingTier` of an account holder, and adds bank accounts and shareholders.

When updating `accountHolderDetails`, parameters that are not included in the request are left unchanged except for the following object:

* `metadata`: Updating the metadata replaces the entire object. This means that to update an existing key-value pair, you must provide the changes, as well as other existing key-value pairs.

When updating any field in the following objects, you must submit all the fields required for validation:

 * `address`

* `fullPhoneNumber`

* `bankAccountDetails.BankAccountDetail`

* `businessDetails.shareholders.ShareholderContact`

 For example, to update the `address.postalCode`, you must also submit the `address.country`, `.city`, `.street`, `.postalCode`, and possibly `.stateOrProvince` so that the address can be validated.

To add a bank account or shareholder, provide the bank account or shareholder details without a `bankAccountUUID` or a `shareholderCode`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostUpdateAccountHolder(new PostUpdateAccountHolderRequest
    {
        Body = new UpdateAccountHolderRequest
        {
            AccountHolderCode = "YOUR_UNIQUE_ACCOUNT_HOLDER_CODE",
            AccountHolderDetails = new AccountHolderDetails4
            {
                Address = new ViasAddress9
                {
                    City = "NY",
                    Country = "US",
                    HouseNumberOrName = "100",
                    PostalCode = "12345",
                    StateOrProvince = "NH",
                    Street = "Main Street",
                },
                Email = "test@adyen.com",
                FullPhoneNumber = "+31612345678",
                MerchantCategoryCode = "7999",
                WebAddress = "http://www.accountholderwebsite.com",
            },
        },
    });
    // TODO: Handle 'response' of type UpdateAccountHolderResponse
}
catch (ApiException<PostUpdateAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostUpdateAccountHolderRequest](src/Adyen/Requests/AccountHolders/PostUpdateAccountHolderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateAccountHolderResponse](src/Adyen/Models/UpdateAccountHolderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostUpdateAccountHolderError](src/Adyen/Errors/PostUpdateAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetAccountHolderStatusResponse&gt; PostUpdateAccountHolderState(PostUpdateAccountHolderStateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disables or enables the processing or payout state of an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountHolders.PostUpdateAccountHolderState(new PostUpdateAccountHolderStateRequest
    {
        Body = new UpdateAccountHolderStateRequest
        {
            AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
            Disable = true,
            Reason = "test reason payout",
            StateType = StateType.Payout,
        },
    });
    // TODO: Handle 'response' of type GetAccountHolderStatusResponse
}
catch (ApiException<PostUpdateAccountHolderStateError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostUpdateAccountHolderStateRequest](src/Adyen/Requests/AccountHolders/PostUpdateAccountHolderStateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAccountHolderStatusResponse](src/Adyen/Models/GetAccountHolderStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostUpdateAccountHolderStateError](src/Adyen/Errors/PostUpdateAccountHolderStateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Accounts

> Source: [Accounts](src/Adyen/Api/Accounts.cs)

<details>
<summary><code>Task&lt;CloseAccountResponse&gt; PostCloseAccount(PostCloseAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Closes an account. If an account is closed, you cannot process transactions, pay out its funds, or reopen it. If payments are made to a closed account, the payments are sent to your liable account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.PostCloseAccount(new PostCloseAccountRequest
    {
        Body = new CloseAccountRequest { AccountCode = "CODE_OF_ACCOUNT" },
    });
    // TODO: Handle 'response' of type CloseAccountResponse
}
catch (ApiException<PostCloseAccountError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCloseAccountRequest](src/Adyen/Requests/Accounts/PostCloseAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CloseAccountResponse](src/Adyen/Models/CloseAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCloseAccountError](src/Adyen/Errors/PostCloseAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateAccountResponse&gt; PostCreateAccount(PostCreateAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an account under an account holder. An account holder can have [multiple accounts](https://docs.adyen.com/classic-platforms/account-holders-and-accounts#create-additional-accounts).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.PostCreateAccount(new PostCreateAccountRequest
    {
        Body = new CreateAccountRequest { AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER" },
    });
    // TODO: Handle 'response' of type CreateAccountResponse
}
catch (ApiException<PostCreateAccountError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCreateAccountRequest](src/Adyen/Requests/Accounts/PostCreateAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateAccountResponse](src/Adyen/Models/CreateAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCreateAccountError](src/Adyen/Errors/PostCreateAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateAccountResponse&gt; PostUpdateAccount(PostUpdateAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the description or payout schedule of an account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.PostUpdateAccount(new PostUpdateAccountRequest
    {
        Body = new UpdateAccountRequest
        {
            AccountCode = "CODE_OF_ACCOUNT",
            PayoutSchedule = new UpdatePayoutScheduleRequest2
            {
                Action = ActionEnum.Close,
                Schedule = Schedule1.Weekly,
            },
        },
    });
    // TODO: Handle 'response' of type UpdateAccountResponse
}
catch (ApiException<PostUpdateAccountError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostUpdateAccountRequest](src/Adyen/Requests/Accounts/PostUpdateAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateAccountResponse](src/Adyen/Models/UpdateAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostUpdateAccountError](src/Adyen/Errors/PostUpdateAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AllowedOriginsCompanyLevel

> Source: [AllowedOriginsCompanyLevel](src/Adyen/Api/AllowedOriginsCompanyLevel.cs)

<details>
<summary><code>Task DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path. As soon as an allowed origin is removed, we no longer accept client-side requests from that domain.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AllowedOriginsCompanyLevel.DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(
        new DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
            OriginId = "some example string",
        });
}
catch (ApiException<DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest](src/Adyen/Requests/AllowedOriginsCompanyLevel/DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError](src/Adyen/Errors/DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOriginsResponse&gt; GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the API credential identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsCompanyLevel.GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(
        new GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
        });
    // TODO: Handle 'response' of type AllowedOriginsResponse
}
catch (ApiException<GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest](src/Adyen/Requests/AllowedOriginsCompanyLevel/GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOriginsResponse](src/Adyen/Models/AllowedOriginsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError](src/Adyen/Errors/GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsCompanyLevel.GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(
        new GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
            OriginId = "some example string",
        });
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest](src/Adyen/Requests/AllowedOriginsCompanyLevel/GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/Adyen/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError](src/Adyen/Errors/GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a new [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) to the API credential's list of allowed origins.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsCompanyLevel.PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(
        new PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
            Body = new AllowedOrigin { Domain = "https://www.eu.mystore.com" },
        });
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest](src/Adyen/Requests/AllowedOriginsCompanyLevel/PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/Adyen/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError](src/Adyen/Errors/PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AllowedOriginsMerchantLevel

> Source: [AllowedOriginsMerchantLevel](src/Adyen/Api/AllowedOriginsMerchantLevel.cs)

<details>
<summary><code>Task DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path. As soon as an allowed origin is removed, we no longer accept client-side requests from that domain.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AllowedOriginsMerchantLevel.DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(
        new DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
            OriginId = "some example string",
        });
}
catch (ApiException<DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest](src/Adyen/Requests/AllowedOriginsMerchantLevel/DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError](src/Adyen/Errors/DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOriginsResponse&gt; GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) for the API credential identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsMerchantLevel.GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(
        new GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
        });
    // TODO: Handle 'response' of type AllowedOriginsResponse
}
catch (ApiException<GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest](src/Adyen/Requests/AllowedOriginsMerchantLevel/GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOriginsResponse](src/Adyen/Models/AllowedOriginsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError](src/Adyen/Errors/GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsMerchantLevel.GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(
        new GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
            OriginId = "some example string",
        });
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest](src/Adyen/Requests/AllowedOriginsMerchantLevel/GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/Adyen/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError](src/Adyen/Errors/GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a new [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) to the API credential's list of allowed origins.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AllowedOriginsMerchantLevel.PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(
        new PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
            Body = new AllowedOrigin { Domain = "https://www.eu.mystore.com" },
        });
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest](src/Adyen/Requests/AllowedOriginsMerchantLevel/PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/Adyen/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError](src/Adyen/Errors/PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AndroidFilesCompanyLevel

> Source: [AndroidFilesCompanyLevel](src/Adyen/Api/AndroidFilesCompanyLevel.cs)

<details>
<summary><code>Task&lt;AndroidAppsResponse&gt; GetCompaniesCompanyIdAndroidApps(GetCompaniesCompanyIdAndroidAppsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of the Android apps that are available for the company identified in the path. 
These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read
* Management API—Android files read and write
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.GetCompaniesCompanyIdAndroidApps(
        new GetCompaniesCompanyIdAndroidAppsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type AndroidAppsResponse
}
catch (ApiException<GetCompaniesCompanyIdAndroidAppsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdAndroidAppsRequest](src/Adyen/Requests/AndroidFilesCompanyLevel/GetCompaniesCompanyIdAndroidAppsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AndroidAppsResponse](src/Adyen/Models/AndroidAppsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdAndroidAppsError](src/Adyen/Errors/GetCompaniesCompanyIdAndroidAppsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AndroidApp&gt; GetCompaniesCompanyIdAndroidAppsId(GetCompaniesCompanyIdAndroidAppsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the Android app identified in the path. 
These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read
* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.GetCompaniesCompanyIdAndroidAppsId(
        new GetCompaniesCompanyIdAndroidAppsIdRequest
        {
            CompanyId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type AndroidApp
}
catch (ApiException<GetCompaniesCompanyIdAndroidAppsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdAndroidAppsIdRequest](src/Adyen/Requests/AndroidFilesCompanyLevel/GetCompaniesCompanyIdAndroidAppsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AndroidApp](src/Adyen/Models/AndroidApp.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdAndroidAppsIdError](src/Adyen/Errors/GetCompaniesCompanyIdAndroidAppsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AndroidCertificatesResponse&gt; GetCompaniesCompanyIdAndroidCertificates(GetCompaniesCompanyIdAndroidCertificatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of the Android certificates that are available for the company identified in the path.
Typically, these certificates enable running apps on Android payment terminals. The certificates in the list have been uploaded to Adyen and can be installed or uninstalled on Android terminals through [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read
* Management API—Android files read and write
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.GetCompaniesCompanyIdAndroidCertificates(
        new GetCompaniesCompanyIdAndroidCertificatesRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type AndroidCertificatesResponse
}
catch (ApiException<GetCompaniesCompanyIdAndroidCertificatesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdAndroidCertificatesRequest](src/Adyen/Requests/AndroidFilesCompanyLevel/GetCompaniesCompanyIdAndroidCertificatesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AndroidCertificatesResponse](src/Adyen/Models/AndroidCertificatesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdAndroidCertificatesError](src/Adyen/Errors/GetCompaniesCompanyIdAndroidCertificatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReprocessAndroidAppResponse&gt; PatchCompaniesCompanyIdAndroidAppsId(PatchCompaniesCompanyIdAndroidAppsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reuploads the Android app identified in the path. 
To make this request, your API credential must have this [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).
>By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.PatchCompaniesCompanyIdAndroidAppsId(
        new PatchCompaniesCompanyIdAndroidAppsIdRequest
        {
            CompanyId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type ReprocessAndroidAppResponse
}
catch (ApiException<PatchCompaniesCompanyIdAndroidAppsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchCompaniesCompanyIdAndroidAppsIdRequest](src/Adyen/Requests/AndroidFilesCompanyLevel/PatchCompaniesCompanyIdAndroidAppsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReprocessAndroidAppResponse](src/Adyen/Models/ReprocessAndroidAppResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchCompaniesCompanyIdAndroidAppsIdError](src/Adyen/Errors/PatchCompaniesCompanyIdAndroidAppsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadAndroidAppResponse&gt; PostCompaniesCompanyIdAndroidApps(PostCompaniesCompanyIdAndroidAppsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads an Android APK file to Adyen.
The maximum APK file size is 200 MB.
To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Android files read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).
>By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.PostCompaniesCompanyIdAndroidApps(
        new PostCompaniesCompanyIdAndroidAppsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type UploadAndroidAppResponse
}
catch (ApiException<PostCompaniesCompanyIdAndroidAppsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdAndroidAppsRequest](src/Adyen/Requests/AndroidFilesCompanyLevel/PostCompaniesCompanyIdAndroidAppsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadAndroidAppResponse](src/Adyen/Models/UploadAndroidAppResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdAndroidAppsError](src/Adyen/Errors/PostCompaniesCompanyIdAndroidAppsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadAndroidCertificateResponse&gt; PostCompaniesCompanyIdAndroidCertificates(PostCompaniesCompanyIdAndroidCertificatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads an Android Certificate file to Adyen.

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AndroidFilesCompanyLevel.PostCompaniesCompanyIdAndroidCertificates(
        new PostCompaniesCompanyIdAndroidCertificatesRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type UploadAndroidCertificateResponse
}
catch (ApiException<PostCompaniesCompanyIdAndroidCertificatesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdAndroidCertificatesRequest](src/Adyen/Requests/AndroidFilesCompanyLevel/PostCompaniesCompanyIdAndroidCertificatesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadAndroidCertificateResponse](src/Adyen/Models/UploadAndroidCertificateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdAndroidCertificatesError](src/Adyen/Errors/PostCompaniesCompanyIdAndroidCertificatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AuthorizedCardUsers

> Source: [AuthorizedCardUsers](src/Adyen/Api/AuthorizedCardUsers.cs)

<details>
<summary><code>Task DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the list of authorized users assigned to a card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AuthorizedCardUsers.DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(
        new DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest
        {
            PaymentInstrumentId = "some example string",
        });
}
catch (ApiException<DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest](src/Adyen/Requests/AuthorizedCardUsers/DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError](src/Adyen/Errors/DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthorisedCardUsers&gt; GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the authorized users for a card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthorizedCardUsers.GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(
        new GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest
        {
            PaymentInstrumentId = "some example string",
        });
    // TODO: Handle 'response' of type AuthorisedCardUsers
}
catch (ApiException<GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest](src/Adyen/Requests/AuthorizedCardUsers/GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthorisedCardUsers](src/Adyen/Models/AuthorisedCardUsers.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError](src/Adyen/Errors/GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the list of authorized users for a card.

>This request replaces all existing authorized users for the card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AuthorizedCardUsers.PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(
        new PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest
        {
            PaymentInstrumentId = "some example string",
            Body = new AuthorisedCardUsers
            {
                LegalEntityIds = ["LE328V522322685LV3KTNF35M", "LE328SW223226B5LWVWNQ8THN"],
            },
        });
}
catch (ApiException<PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest](src/Adyen/Requests/AuthorizedCardUsers/PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError](src/Adyen/Errors/PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Assigns authorized users to a card. Users must have the **authorisedPaymentInstrumentUser** capability to be able to use the card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AuthorizedCardUsers.PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(
        new PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest
        {
            PaymentInstrumentId = "some example string",
            Body = new AuthorisedCardUsers
            {
                LegalEntityIds = ["LE328V522322685LV3KTNF35M", "LE328SW223226B5LWVWNQ8THN"],
            },
        });
}
catch (ApiException<PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest](src/Adyen/Requests/AuthorizedCardUsers/PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError](src/Adyen/Errors/PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BalanceAccounts

> Source: [BalanceAccounts](src/Adyen/Api/BalanceAccounts.cs)

<details>
<summary><code>Task&lt;BalanceAccount&gt; GetBalanceAccountsId(GetBalanceAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a balance account and its balances for the default currency and other currencies with a non-zero balance.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceAccounts.GetBalanceAccountsId(new GetBalanceAccountsIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type BalanceAccount
}
catch (ApiException<GetBalanceAccountsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsIdRequest](src/Adyen/Requests/BalanceAccounts/GetBalanceAccountsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccount](src/Adyen/Models/BalanceAccount.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsIdError](src/Adyen/Errors/GetBalanceAccountsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedPaymentInstrumentsResponse&gt; GetBalanceAccountsIdPaymentInstruments(GetBalanceAccountsIdPaymentInstrumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of the payment instruments associated with a balance account. 

To fetch multiple pages, use the query parameters.For example, to limit the page to 3 payment instruments which are in active status and to skip the first 6, use `/balanceAccounts/{id}/paymentInstruments?limit=3&offset=6&status=active`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceAccounts.GetBalanceAccountsIdPaymentInstruments(
        new GetBalanceAccountsIdPaymentInstrumentsRequest { Id = "some example string" });
    // TODO: Handle 'response' of type PaginatedPaymentInstrumentsResponse
}
catch (ApiException<GetBalanceAccountsIdPaymentInstrumentsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsIdPaymentInstrumentsRequest](src/Adyen/Requests/BalanceAccounts/GetBalanceAccountsIdPaymentInstrumentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedPaymentInstrumentsResponse](src/Adyen/Models/PaginatedPaymentInstrumentsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsIdPaymentInstrumentsError](src/Adyen/Errors/GetBalanceAccountsIdPaymentInstrumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRulesResponse&gt; GetBalanceAccountsIdTransactionRules(GetBalanceAccountsIdTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of transaction rules associated with a balance account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceAccounts.GetBalanceAccountsIdTransactionRules(
        new GetBalanceAccountsIdTransactionRulesRequest { Id = "some example string" });
    // TODO: Handle 'response' of type TransactionRulesResponse
}
catch (ApiException<GetBalanceAccountsIdTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsIdTransactionRulesRequest](src/Adyen/Requests/BalanceAccounts/GetBalanceAccountsIdTransactionRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRulesResponse](src/Adyen/Models/TransactionRulesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsIdTransactionRulesError](src/Adyen/Errors/GetBalanceAccountsIdTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccount&gt; PatchBalanceAccountsId(PatchBalanceAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a balance account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceAccounts.PatchBalanceAccountsId(new PatchBalanceAccountsIdRequest
    {
        Id = "some example string",
        Body = new BalanceAccountUpdateRequest { TimeZone = "Europe/Amsterdam" },
    });
    // TODO: Handle 'response' of type BalanceAccount
}
catch (ApiException<PatchBalanceAccountsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchBalanceAccountsIdRequest](src/Adyen/Requests/BalanceAccounts/PatchBalanceAccountsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccount](src/Adyen/Models/BalanceAccount.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchBalanceAccountsIdError](src/Adyen/Errors/PatchBalanceAccountsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccount&gt; PostBalanceAccounts(PostBalanceAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a balance account that holds the funds of the associated account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceAccounts.PostBalanceAccounts(new PostBalanceAccountsRequest
    {
        Body = new BalanceAccountInfo
        {
            AccountHolderId = "AH32272223222C5GXTD343TKP",
            Description = "S.Hopper - Main balance account",
        },
    });
    // TODO: Handle 'response' of type BalanceAccount
}
catch (ApiException<PostBalanceAccountsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostBalanceAccountsRequest](src/Adyen/Requests/BalanceAccounts/PostBalanceAccountsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccount](src/Adyen/Models/BalanceAccount.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostBalanceAccountsError](src/Adyen/Errors/PostBalanceAccountsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BalanceTransfers

> Source: [BalanceTransfers](src/Adyen/Api/BalanceTransfers.cs)

<details>
<summary><code>Task&lt;BalanceTransferResponse&gt; PostBalanceTransfers(PostBalanceTransfersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Performs a balance transfer between merchant accounts. The following conditions must be met before you can successfully transfer balances:
* The source and destination merchant accounts must be under the same company account and legal entity.
* The source merchant account must have sufficient funds.
* The source and destination merchant accounts must have at least one common processing currency.\n\n
When sending multiple API requests with the same source and destination merchant accounts, send the requests sequentially and *not* in parallel. Some requests may not be processed if the requests are sent in parallel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalanceTransfers.PostBalanceTransfers(new PostBalanceTransfersRequest
    {
        Body = new BalanceTransferRequest
        {
            Amount = new Amount17 { Currency = "EUR", Value = 3000L },
            FromMerchant = "SOURCE_MERCHANT_ACCOUNT",
            Reference = "Your reference for the balance transfer.",
            ToMerchant = "DESTINATION_MERCHANT_ACCOUNT",
            Type = BalanceTransferType2.Adjustment,
        },
    });
    // TODO: Handle 'response' of type BalanceTransferResponse
}
catch (ApiException<PostBalanceTransfersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostBalanceTransfersRequest](src/Adyen/Requests/BalanceTransfers/PostBalanceTransfersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceTransferResponse](src/Adyen/Models/BalanceTransferResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostBalanceTransfersError](src/Adyen/Errors/PostBalanceTransfersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Balances

> Source: [Balances](src/Adyen/Api/Balances.cs)

<details>
<summary><code>Task&lt;JsonElement&gt; DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a balance webhook setting that contains the conditions for triggering [balance webhooks](https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Balances.DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(
        new DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest
        {
            BalancePlatformId = "some example string",
            WebhookId = "some example string",
            SettingId = "some example string",
        });
    // TODO: Handle 'response' of type JsonElement
}
catch (ApiException<DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest](src/Adyen/Requests/Balances/DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError](src/Adyen/Errors/DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WebhookSettings&gt; GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all balance webhook settings configured for triggering [balance webhooks](https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Balances.GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(
        new GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest
        {
            BalancePlatformId = "some example string",
            WebhookId = "some example string",
        });
    // TODO: Handle 'response' of type WebhookSettings
}
catch (ApiException<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest](src/Adyen/Requests/Balances/GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WebhookSettings](src/Adyen/Models/WebhookSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError](src/Adyen/Errors/GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WebhookSetting&gt; GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a specific balance webhook setting configured for triggering [balance webhooks](https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Balances.GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(
        new GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest
        {
            BalancePlatformId = "some example string",
            WebhookId = "some example string",
            SettingId = "some example string",
        });
    // TODO: Handle 'response' of type WebhookSetting
}
catch (ApiException<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest](src/Adyen/Requests/Balances/GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WebhookSetting](src/Adyen/Models/WebhookSetting.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError](src/Adyen/Errors/GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WebhookSetting&gt; PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the conditions the balance change needs to meet for Adyen to send a [balance webhook](https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Balances.PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(
        new PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest
        {
            BalancePlatformId = "some example string",
            WebhookId = "some example string",
            SettingId = "some example string",
            Body = new BalanceWebhookSettingInfoUpdate { Status = Status6.Inactive, Type = Type201.Balance },
        });
    // TODO: Handle 'response' of type WebhookSetting
}
catch (ApiException<PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest](src/Adyen/Requests/Balances/PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WebhookSetting](src/Adyen/Models/WebhookSetting.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError](src/Adyen/Errors/PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WebhookSetting&gt; PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Configures the criteria for triggering [balance webhooks](https://docs.adyen.com/api-explorer/balance-webhooks/1/post/balancePlatform.balanceAccount.balance.updated).

Adyen sends balance webhooks to notify you of balance changes in your balance platform. They can be triggered when the balance reaches, exceeds, or drops below a specific value in a specific currency.

You can get notified about balance changes in your entire balance platform, in the balance accounts of a specific user, or a specific balance account. The hierarchy between the webhook settings are based on the following business logic:

* Settings on a higher level apply to all lower level resources (balance platform > account holder > balance acocunt).

* The most granular setting overrides higher level settings (balance account > account holder > balance platform).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Balances.PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(
        new PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest
        {
            BalancePlatformId = "some example string",
            WebhookId = "some example string",
            Body = new BalanceWebhookSettingInfo
            {
                Conditions = [
                    new Condition
                    {
                        BalanceType = BalanceType.Available,
                        ConditionType = ConditionType.LessThan,
                        Value = 500000L,
                    },
                ],
                Currency = "USD",
                Status = Status6.Active,
                Target = new Target1 { Id = "BA00000000000000000LIABLE", Type = Type181.BalanceAccount },
            },
        });
    // TODO: Handle 'response' of type WebhookSetting
}
catch (ApiException<PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest](src/Adyen/Requests/Balances/PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WebhookSetting](src/Adyen/Models/WebhookSetting.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError](src/Adyen/Errors/PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BalancesOverview

> Source: [BalancesOverview](src/Adyen/Api/BalancesOverview.cs)

<details>
<summary><code>Task&lt;CompanyBalances&gt; GetBalanceOverviewCompaniesCompanyAccountCodeBalances(GetBalanceOverviewCompaniesCompanyAccountCodeBalancesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an array with details about the balances available for all merchant accounts under your company account. For each merchant account, the response returns the following:


* **Available funds**: The funds in the merchant account that have been settled and are available for use.


* **Pending balance**: The funds in the merchant account that have not been settled yet.


* **Next payout amount**: The amount that will be settled to your bank account with the next payout.


* **Reserve**: The available amount to cover refunds, payouts, chargebacks, and other operational expenses that cannot be covered by your in-process funds.


* **Deposit**: The amount withheld by Adyen to cover potential losses and liabilities due to payment processing.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalancesOverview.GetBalanceOverviewCompaniesCompanyAccountCodeBalances(
        new GetBalanceOverviewCompaniesCompanyAccountCodeBalancesRequest
        {
            CompanyAccountCode = "some example string",
            Currency = "some example string",
        });
    // TODO: Handle 'response' of type CompanyBalances
}
catch (ApiException<GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceOverviewCompaniesCompanyAccountCodeBalancesRequest](src/Adyen/Requests/BalancesOverview/GetBalanceOverviewCompaniesCompanyAccountCodeBalancesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyBalances](src/Adyen/Models/CompanyBalances.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError](src/Adyen/Errors/GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MerchantBalance&gt; GetBalanceOverviewMerchantsMerchantAccountCodeBalances(GetBalanceOverviewMerchantsMerchantAccountCodeBalancesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an overview of the different balances available for the merchant account. This includes details about the following:


* **Available funds**: The funds in the merchant account that have been settled and are available for use.


* **Pending balance**: The funds in the merchant account that have not been settled yet.


* **Next payout amount**: The amount that will be settled to your bank account with the next payout.


* **Reserve**: The available amount to cover refunds, payouts, chargebacks, and other operational expenses that cannot be covered by your in-process funds.


* **Deposit**: The amount withheld by Adyen to cover potential losses and liabilities due to payment processing.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BalancesOverview.GetBalanceOverviewMerchantsMerchantAccountCodeBalances(
        new GetBalanceOverviewMerchantsMerchantAccountCodeBalancesRequest
        {
            MerchantAccountCode = "some example string",
            Currency = "some example string",
        });
    // TODO: Handle 'response' of type MerchantBalance
}
catch (ApiException<GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceOverviewMerchantsMerchantAccountCodeBalancesRequest](src/Adyen/Requests/BalancesOverview/GetBalanceOverviewMerchantsMerchantAccountCodeBalancesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MerchantBalance](src/Adyen/Models/MerchantBalance.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError](src/Adyen/Errors/GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BankAccountValidation

> Source: [BankAccountValidation](src/Adyen/Api/BankAccountValidation.cs)

<details>
<summary><code>Task PostValidateBankAccountIdentification(PostValidateBankAccountIdentificationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Validates bank account identification details. You can use this endpoint to validate bank account details before you [make a transfer](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers) or [create a transfer instrument](https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.BankAccountValidation.PostValidateBankAccountIdentification(
        new PostValidateBankAccountIdentificationRequest());
}
catch (ApiException<PostValidateBankAccountIdentificationError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostValidateBankAccountIdentificationRequest](src/Adyen/Requests/BankAccountValidation/PostValidateBankAccountIdentificationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostValidateBankAccountIdentificationError](src/Adyen/Errors/PostValidateBankAccountIdentificationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BusinessLinesApi

> Source: [BusinessLinesApi](src/Adyen/Api/BusinessLinesApi.cs)

<details>
<summary><code>Task DeleteBusinessLinesId(DeleteBusinessLinesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a business line.

 >If you delete a business line linked to a [payment method](https://docs.adyen.com/development-resources/paymentmethodvariant#management-api), it can affect your merchant account's ability to use the [payment method](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/paymentMethodSettings). The business line is removed from all linked merchant accounts.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.BusinessLinesApi.DeleteBusinessLinesId(new DeleteBusinessLinesIdRequest
    {
        Id = "some example string",
    });
}
catch (ApiException<DeleteBusinessLinesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteBusinessLinesIdRequest](src/Adyen/Requests/BusinessLinesApi/DeleteBusinessLinesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteBusinessLinesIdError](src/Adyen/Errors/DeleteBusinessLinesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BusinessLine&gt; GetBusinessLinesId(GetBusinessLinesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the detail of a business line.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BusinessLinesApi.GetBusinessLinesId(new GetBusinessLinesIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type BusinessLine
}
catch (ApiException<GetBusinessLinesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBusinessLinesIdRequest](src/Adyen/Requests/BusinessLinesApi/GetBusinessLinesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BusinessLine](src/Adyen/Models/BusinessLine.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBusinessLinesIdError](src/Adyen/Errors/GetBusinessLinesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BusinessLine&gt; PatchBusinessLinesId(PatchBusinessLinesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a business line.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BusinessLinesApi.PatchBusinessLinesId(new PatchBusinessLinesIdRequest
    {
        Id = "some example string",
        Body = new BusinessLineInfoUpdate
        {
            IndustryCode = "55",
            WebData = [new WebData { WebAddress = "https://www.example.com" }],
        },
    });
    // TODO: Handle 'response' of type BusinessLine
}
catch (ApiException<PatchBusinessLinesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchBusinessLinesIdRequest](src/Adyen/Requests/BusinessLinesApi/PatchBusinessLinesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BusinessLine](src/Adyen/Models/BusinessLine.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchBusinessLinesIdError](src/Adyen/Errors/PatchBusinessLinesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BusinessLine&gt; PostBusinessLines(PostBusinessLinesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a business line. 

This resource contains information about your user's line of business, including their industry and their source of funds. Adyen uses this information to verify your users as required by payment industry regulations.Adyen informs you of the verification results through webhooks or API responses.

You can create a maximum of 200 business lines per legal entity for payment processing.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BusinessLinesApi.PostBusinessLines(new PostBusinessLinesRequest
    {
        Body = new BusinessLineInfo
        {
            IndustryCode = "4531",
            LegalEntityId = "LE00000000000000000000001",
            Service = Service.Banking,
            SourceOfFunds = new SourceOfFunds11
            {
                AdyenProcessedFunds = false,
                Amount = new PatchableAmountDto { Currency = "EUR", Value = 600000L },
                Description = "Funds from my flower shop business",
                Type = Type74.Business,
            },
            WebData = [new WebData { WebAddress = "https://www.adyen.com" }],
        },
    });
    // TODO: Handle 'response' of type BusinessLine
}
catch (ApiException<PostBusinessLinesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostBusinessLinesRequest](src/Adyen/Requests/BusinessLinesApi/PostBusinessLinesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BusinessLine](src/Adyen/Models/BusinessLine.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostBusinessLinesError](src/Adyen/Errors/PostBusinessLinesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Capital

> Source: [Capital](src/Adyen/Api/Capital.cs)

<details>
<summary><code>Task&lt;CapitalGrants&gt; GetGrants(GetGrantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of grants with status and outstanding balances.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Capital.GetGrants(new GetGrantsRequest());
    // TODO: Handle 'response' of type CapitalGrants
}
catch (ApiException<GetGrantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrantsRequest](src/Adyen/Requests/Capital/GetGrantsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CapitalGrants](src/Adyen/Models/CapitalGrants.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrantsError](src/Adyen/Errors/GetGrantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CapitalGrant&gt; GetGrantsId(GetGrantsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a capital account specified in the path.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Capital.GetGrantsId(new GetGrantsIdRequest { Id = "some example string" });
    // TODO: Handle 'response' of type CapitalGrant
}
catch (ApiException<GetGrantsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrantsIdRequest](src/Adyen/Requests/Capital/GetGrantsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CapitalGrant](src/Adyen/Models/CapitalGrant.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrantsIdError](src/Adyen/Errors/GetGrantsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CapitalGrant&gt; PostGrants(PostGrantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Requests the payout of the selected grant offer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Capital.PostGrants(new PostGrantsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CapitalGrantInfo
        {
            Counterparty = new GrantInfoCounterparty2 { BalanceAccountId = "BA00000000000000000000001" },
            GrantAccountId = "CG00000000000000000000001",
            GrantOfferId = "0000000000000001",
        },
    });
    // TODO: Handle 'response' of type CapitalGrant
}
catch (ApiException<PostGrantsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGrantsRequest](src/Adyen/Requests/Capital/PostGrantsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CapitalGrant](src/Adyen/Models/CapitalGrant.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGrantsError](src/Adyen/Errors/PostGrantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CardOrders

> Source: [CardOrders](src/Adyen/Api/CardOrders.cs)

<details>
<summary><code>Task&lt;PaginatedGetCardOrderResponse&gt; GetCardorders(GetCardordersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of card orders.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CardOrders.GetCardorders(new GetCardordersRequest());
    // TODO: Handle 'response' of type PaginatedGetCardOrderResponse
}
catch (ApiException<GetCardordersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCardordersRequest](src/Adyen/Requests/CardOrders/GetCardordersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedGetCardOrderResponse](src/Adyen/Models/PaginatedGetCardOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCardordersError](src/Adyen/Errors/GetCardordersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedGetCardOrderItemResponse&gt; GetCardordersIdItems(GetCardordersIdItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the item list of a specific card order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CardOrders.GetCardordersIdItems(new GetCardordersIdItemsRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type PaginatedGetCardOrderItemResponse
}
catch (ApiException<GetCardordersIdItemsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCardordersIdItemsRequest](src/Adyen/Requests/CardOrders/GetCardordersIdItemsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedGetCardOrderItemResponse](src/Adyen/Models/PaginatedGetCardOrderItemResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCardordersIdItemsError](src/Adyen/Errors/GetCardordersIdItemsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CashOutApi

> Source: [CashOutApi](src/Adyen/Api/CashOutApi.cs)

<details>
<summary><code>Task&lt;CashOut&gt; PostCashouts(PostCashoutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates a [cashout](https://docs.adyen.com/platforms/cash-out-instantly) request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashOutApi.PostCashouts(new PostCashoutsRequest
    {
        Body = new CashOutInfo
        {
            Amount = new Amount17 { Currency = "EUR", Value = 50000L },
            Counterparty = new CashOutInfoCounterparty1 { TransferInstrumentId = "SE00000000000000000000001" },
            Description = "Cashout to bank account",
            Fee = new Fee21 { Amount = new Amount17 { Currency = "EUR", Value = 500L } },
            InstructingBalanceAccountId = "BA00000000000000000000001",
            ReferenceForBeneficiary = "CASHOUT-REF-001",
        },
    });
    // TODO: Handle 'response' of type CashOut
}
catch (ApiException<PostCashoutsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCashoutsRequest](src/Adyen/Requests/CashOutApi/PostCashoutsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CashOut](src/Adyen/Models/CashOut.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCashoutsError](src/Adyen/Errors/PostCashoutsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClientKeyCompanyLevel

> Source: [ClientKeyCompanyLevel](src/Adyen/Api/ClientKeyCompanyLevel.cs)

<details>
<summary><code>Task&lt;GenerateClientKeyResponse&gt; PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKey(PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new [client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works) for the API credential identified in the path. You can use the new client key a few minutes after generating it. The old client key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientKeyCompanyLevel.PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKey(
        new PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyRequest
        {
            CompanyId = "some example string",
            ApiCredentialId = "some example string",
        });
    // TODO: Handle 'response' of type GenerateClientKeyResponse
}
catch (ApiException<PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyRequest](src/Adyen/Requests/ClientKeyCompanyLevel/PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateClientKeyResponse](src/Adyen/Models/GenerateClientKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyError](src/Adyen/Errors/PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClientKeyMerchantLevel

> Source: [ClientKeyMerchantLevel](src/Adyen/Api/ClientKeyMerchantLevel.cs)

<details>
<summary><code>Task&lt;GenerateClientKeyResponse&gt; PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKey(PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a new [client key](https://docs.adyen.com/development-resources/client-side-authentication#how-it-works) for the API credential identified in the path. You can use the new client key a few minutes after generating it. The old client key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClientKeyMerchantLevel.PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKey(
        new PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyRequest
        {
            MerchantId = "some example string",
            ApiCredentialId = "some example string",
        });
    // TODO: Handle 'response' of type GenerateClientKeyResponse
}
catch (ApiException<PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyRequest](src/Adyen/Requests/ClientKeyMerchantLevel/PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateClientKeyResponse](src/Adyen/Models/GenerateClientKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyError](src/Adyen/Errors/PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CustomPayoutSchedulesSweeps

> Source: [CustomPayoutSchedulesSweeps](src/Adyen/Api/CustomPayoutSchedulesSweeps.cs)

<details>
<summary><code>Task DeleteBalanceAccountsBalanceAccountIdSweepsSweepId(DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a sweep for a balance account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CustomPayoutSchedulesSweeps.DeleteBalanceAccountsBalanceAccountIdSweepsSweepId(
        new DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdRequest
        {
            BalanceAccountId = "some example string",
            SweepId = "some example string",
        });
}
catch (ApiException<DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdRequest](src/Adyen/Requests/CustomPayoutSchedulesSweeps/DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError](src/Adyen/Errors/DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceSweepConfigurationsResponse&gt; GetBalanceAccountsBalanceAccountIdSweeps(GetBalanceAccountsBalanceAccountIdSweepsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of the sweeps configured for a balance account.

To fetch multiple pages, use the query parameters. For example, to limit the page to 5 sweeps and to skip the first 10, use `/balanceAccounts/{balanceAccountId}/sweeps?limit=5&offset=10`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomPayoutSchedulesSweeps.GetBalanceAccountsBalanceAccountIdSweeps(
        new GetBalanceAccountsBalanceAccountIdSweepsRequest { BalanceAccountId = "some example string" });
    // TODO: Handle 'response' of type BalanceSweepConfigurationsResponse
}
catch (ApiException<GetBalanceAccountsBalanceAccountIdSweepsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsBalanceAccountIdSweepsRequest](src/Adyen/Requests/CustomPayoutSchedulesSweeps/GetBalanceAccountsBalanceAccountIdSweepsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceSweepConfigurationsResponse](src/Adyen/Models/BalanceSweepConfigurationsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsBalanceAccountIdSweepsError](src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdSweepsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SweepConfigurationV2&gt; GetBalanceAccountsBalanceAccountIdSweepsSweepId(GetBalanceAccountsBalanceAccountIdSweepsSweepIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a sweep.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomPayoutSchedulesSweeps.GetBalanceAccountsBalanceAccountIdSweepsSweepId(
        new GetBalanceAccountsBalanceAccountIdSweepsSweepIdRequest
        {
            BalanceAccountId = "some example string",
            SweepId = "some example string",
        });
    // TODO: Handle 'response' of type SweepConfigurationV2
}
catch (ApiException<GetBalanceAccountsBalanceAccountIdSweepsSweepIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsBalanceAccountIdSweepsSweepIdRequest](src/Adyen/Requests/CustomPayoutSchedulesSweeps/GetBalanceAccountsBalanceAccountIdSweepsSweepIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SweepConfigurationV2](src/Adyen/Models/SweepConfigurationV2.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsBalanceAccountIdSweepsSweepIdError](src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdSweepsSweepIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SweepConfigurationV2&gt; PatchBalanceAccountsBalanceAccountIdSweepsSweepId(PatchBalanceAccountsBalanceAccountIdSweepsSweepIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a sweep. When updating a sweep resource, note that if a request parameter is not provided, the parameter is left unchanged.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomPayoutSchedulesSweeps.PatchBalanceAccountsBalanceAccountIdSweepsSweepId(
        new PatchBalanceAccountsBalanceAccountIdSweepsSweepIdRequest
        {
            BalanceAccountId = "some example string",
            SweepId = "some example string",
            Body = new UpdateSweepConfigurationV2 { Status = Status6.Inactive },
        });
    // TODO: Handle 'response' of type SweepConfigurationV2
}
catch (ApiException<PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchBalanceAccountsBalanceAccountIdSweepsSweepIdRequest](src/Adyen/Requests/CustomPayoutSchedulesSweeps/PatchBalanceAccountsBalanceAccountIdSweepsSweepIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SweepConfigurationV2](src/Adyen/Models/SweepConfigurationV2.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError](src/Adyen/Errors/PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SweepConfigurationV2&gt; PostBalanceAccountsBalanceAccountIdSweeps(PostBalanceAccountsBalanceAccountIdSweepsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a sweep that results in moving funds from or to a balance account.

A sweep pulls in or pushes out funds based on a defined schedule, amount, currency, and a source or a destination.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomPayoutSchedulesSweeps.PostBalanceAccountsBalanceAccountIdSweeps(
        new PostBalanceAccountsBalanceAccountIdSweepsRequest
        {
            BalanceAccountId = "some example string",
            Body = new CreateSweepConfigurationV2
            {
                Counterparty = new SweepCounterparty1 { MerchantAccount = "YOUR_MERCHANT_ACCOUNT" },
                Currency = "EUR",
                Schedule = new SweepSchedule1 { Type = Type62.Balance },
                Status = Status6.Active,
                TriggerAmount = new Amount17 { Currency = "EUR", Value = 50000L },
                Type = Type72.Pull,
            },
        });
    // TODO: Handle 'response' of type SweepConfigurationV2
}
catch (ApiException<PostBalanceAccountsBalanceAccountIdSweepsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostBalanceAccountsBalanceAccountIdSweepsRequest](src/Adyen/Requests/CustomPayoutSchedulesSweeps/PostBalanceAccountsBalanceAccountIdSweepsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SweepConfigurationV2](src/Adyen/Models/SweepConfigurationV2.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostBalanceAccountsBalanceAccountIdSweepsError](src/Adyen/Errors/PostBalanceAccountsBalanceAccountIdSweepsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DirectDebitMandates

> Source: [DirectDebitMandates](src/Adyen/Api/DirectDebitMandates.cs)

<details>
<summary><code>Task&lt;ListMandatesResponse&gt; GetMandates(GetMandatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all [direct debit mandates](https://docs.adyen.com/business-accounts/accept-direct-debits-uk) created for a business account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DirectDebitMandates.GetMandates(new GetMandatesRequest());
    // TODO: Handle 'response' of type ListMandatesResponse
}
catch (ApiException<GetMandatesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMandatesRequest](src/Adyen/Requests/DirectDebitMandates/GetMandatesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMandatesResponse](src/Adyen/Models/ListMandatesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMandatesError](src/Adyen/Errors/GetMandatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Mandate1&gt; GetMandatesMandateId(GetMandatesMandateIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the specified [direct debit mandate](https://docs.adyen.com/business-accounts/accept-direct-debits-uk).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DirectDebitMandates.GetMandatesMandateId(new GetMandatesMandateIdRequest
    {
        MandateId = "some example string",
    });
    // TODO: Handle 'response' of type Mandate1
}
catch (ApiException<GetMandatesMandateIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMandatesMandateIdRequest](src/Adyen/Requests/DirectDebitMandates/GetMandatesMandateIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Mandate1](src/Adyen/Models/Mandate1.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMandatesMandateIdError](src/Adyen/Errors/GetMandatesMandateIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PatchMandatesMandateId(PatchMandatesMandateIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Amend the specified [direct debit mandate](https://docs.adyen.com/business-accounts/accept-direct-debits-uk).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DirectDebitMandates.PatchMandatesMandateId(new PatchMandatesMandateIdRequest
    {
        MandateId = "some example string",
        Body = new MandateUpdate(),
    });
}
catch (ApiException<PatchMandatesMandateIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMandatesMandateIdRequest](src/Adyen/Requests/DirectDebitMandates/PatchMandatesMandateIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMandatesMandateIdError](src/Adyen/Errors/PatchMandatesMandateIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostMandatesMandateIdCancel(PostMandatesMandateIdCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel a specified [direct debit mandate](https://docs.adyen.com/business-accounts/accept-direct-debits-uk).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DirectDebitMandates.PostMandatesMandateIdCancel(new PostMandatesMandateIdCancelRequest
    {
        MandateId = "some example string",
    });
}
catch (ApiException<PostMandatesMandateIdCancelError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMandatesMandateIdCancelRequest](src/Adyen/Requests/DirectDebitMandates/PostMandatesMandateIdCancelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMandatesMandateIdCancelError](src/Adyen/Errors/PostMandatesMandateIdCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DisputeAttachments

> Source: [DisputeAttachments](src/Adyen/Api/DisputeAttachments.cs)

<details>
<summary><code>Task DeleteDisputesDisputeIdAttachmentsAttachmentId(DeleteDisputesDisputeIdAttachmentsAttachmentIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the attachment from the raised dispute. Adyen may keep this file for compliance purposes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DisputeAttachments.DeleteDisputesDisputeIdAttachmentsAttachmentId(
        new DeleteDisputesDisputeIdAttachmentsAttachmentIdRequest
        {
            DisputeId = "some example string",
            AttachmentId = "some example string",
        });
}
catch (ApiException<DeleteDisputesDisputeIdAttachmentsAttachmentIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteDisputesDisputeIdAttachmentsAttachmentIdRequest](src/Adyen/Requests/DisputeAttachments/DeleteDisputesDisputeIdAttachmentsAttachmentIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteDisputesDisputeIdAttachmentsAttachmentIdError](src/Adyen/Errors/DeleteDisputesDisputeIdAttachmentsAttachmentIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DisputeAttachment&gt;&gt; GetDisputesDisputeIdAttachments(GetDisputesDisputeIdAttachmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a list of attachments associated with a dispute ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisputeAttachments.GetDisputesDisputeIdAttachments(
        new GetDisputesDisputeIdAttachmentsRequest { DisputeId = "some example string" });
    // TODO: Handle 'response' of type IReadOnlyList<DisputeAttachment>
}
catch (ApiException<GetDisputesDisputeIdAttachmentsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDisputesDisputeIdAttachmentsRequest](src/Adyen/Requests/DisputeAttachments/GetDisputesDisputeIdAttachmentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DisputeAttachment](src/Adyen/Models/DisputeAttachment.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetDisputesDisputeIdAttachmentsError](src/Adyen/Errors/GetDisputesDisputeIdAttachmentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisputeAttachment&gt; GetDisputesDisputeIdAttachmentsAttachmentId(GetDisputesDisputeIdAttachmentsAttachmentIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for a single attachment, providing the specific dispute ID and attachment ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisputeAttachments.GetDisputesDisputeIdAttachmentsAttachmentId(
        new GetDisputesDisputeIdAttachmentsAttachmentIdRequest
        {
            DisputeId = "some example string",
            AttachmentId = "some example string",
        });
    // TODO: Handle 'response' of type DisputeAttachment
}
catch (ApiException<GetDisputesDisputeIdAttachmentsAttachmentIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDisputesDisputeIdAttachmentsAttachmentIdRequest](src/Adyen/Requests/DisputeAttachments/GetDisputesDisputeIdAttachmentsAttachmentIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisputeAttachment](src/Adyen/Models/DisputeAttachment.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetDisputesDisputeIdAttachmentsAttachmentIdError](src/Adyen/Errors/GetDisputesDisputeIdAttachmentsAttachmentIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AttachDocumentResponse&gt; PostDisputesDisputeIdAttachments(PostDisputesDisputeIdAttachmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add supporting information as an attachment for the raised dispute. Upload receipts, communication, or any other documentation to support the dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisputeAttachments.PostDisputesDisputeIdAttachments(
        new PostDisputesDisputeIdAttachmentsRequest
        {
            DisputeId = "some example string",
            Body = new DisputeAttachment
            {
                AttachmentType = AttachmentType1.Receipt,
                Content = "some example string",
                FileName = "some example string",
            },
        });
    // TODO: Handle 'response' of type AttachDocumentResponse
}
catch (ApiException<PostDisputesDisputeIdAttachmentsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDisputesDisputeIdAttachmentsRequest](src/Adyen/Requests/DisputeAttachments/PostDisputesDisputeIdAttachmentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AttachDocumentResponse](src/Adyen/Models/AttachDocumentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDisputesDisputeIdAttachmentsError](src/Adyen/Errors/PostDisputesDisputeIdAttachmentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Documents

> Source: [Documents](src/Adyen/Api/Documents.cs)

<details>
<summary><code>Task DeleteDocumentsId(DeleteDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a document.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Documents.DeleteDocumentsId(new DeleteDocumentsIdRequest { Id = "some example string" });
}
catch (ApiException<DeleteDocumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteDocumentsIdRequest](src/Adyen/Requests/Documents/DeleteDocumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteDocumentsIdError](src/Adyen/Errors/DeleteDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Document&gt; GetDocumentsId(GetDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a document.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Documents.GetDocumentsId(new GetDocumentsIdRequest { Id = "some example string" });
    // TODO: Handle 'response' of type Document
}
catch (ApiException<GetDocumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDocumentsIdRequest](src/Adyen/Requests/Documents/GetDocumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Document](src/Adyen/Models/Document.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetDocumentsIdError](src/Adyen/Errors/GetDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Document&gt; PatchDocumentsId(PatchDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a document.

 >You can upload a maximum of 15 pages for photo IDs.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Documents.PatchDocumentsId(new PatchDocumentsIdRequest
    {
        Id = "some example string",
        XRequestedVerificationCode = "0_0001",
        Body = new Document
        {
            Description = "Proof of industry doc for Example Company",
            Type = Type84.ProofOfIndustry,
        },
    });
    // TODO: Handle 'response' of type Document
}
catch (ApiException<PatchDocumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchDocumentsIdRequest](src/Adyen/Requests/Documents/PatchDocumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Document](src/Adyen/Models/Document.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchDocumentsIdError](src/Adyen/Errors/PatchDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Document&gt; PostDocuments(PostDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads a document for verification checks.

 Adyen uses the information from the [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities) to run automated verification checks. If these checks fail, you will be notified to provide additional documents.

 You should only upload documents when Adyen requests additional information for the legal entity.

 >You can upload a maximum of 15 pages for photo IDs.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Documents.PostDocuments(new PostDocumentsRequest
    {
        XRequestedVerificationCode = "1_3008",
        Body = new Document
        {
            Attachments = [new Attachment { Content = "JVBERi0xLjQKJcOkw7zDtsOfCjIgMCBv+f/ub0j6JPRX+E3EmC==" }],
            Description = "Registration doc for Example Company",
            Owner = new OwnerEntity2 { Id = "LE00000000000000000000001", Type = "legalEntity" },
            Type = Type84.RegistrationDocument,
        },
    });
    // TODO: Handle 'response' of type Document
}
catch (ApiException<PostDocumentsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDocumentsRequest](src/Adyen/Requests/Documents/PostDocumentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Document](src/Adyen/Models/Document.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDocumentsError](src/Adyen/Errors/PostDocumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DonationCampaigns

> Source: [DonationCampaigns](src/Adyen/Api/DonationCampaigns.cs)

<details>
<summary><code>Task DeleteCompaniesCompanyIdCampaignManagementDonationCampaignId(DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the donation campaign specified in the path. This request is only allowed if the campaign has the status **inactive**.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Campaign Management read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DonationCampaigns.DeleteCompaniesCompanyIdCampaignManagementDonationCampaignId(
        new DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest
        {
            CompanyId = "some example string",
            DonationCampaignId = "some example string",
        });
}
catch (ApiException<DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest](src/Adyen/Requests/DonationCampaigns/DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError](src/Adyen/Errors/DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListDonationCampaignsResponse&gt; GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderId(GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of donation campaigns associated with the account holder specified in the path. You can filter the list by campaign status.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Campaign Management read
* Management API—Campaign Management read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DonationCampaigns.GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderId(
        new GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdRequest
        {
            CompanyId = "some example string",
            AccountHolderId = "some example string",
        });
    // TODO: Handle 'response' of type ListDonationCampaignsResponse
}
catch (ApiException<GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdRequest](src/Adyen/Requests/DonationCampaigns/GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListDonationCampaignsResponse](src/Adyen/Models/ListDonationCampaignsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError](src/Adyen/Errors/GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DonationCampaign1&gt; PatchCompaniesCompanyIdCampaignManagementDonationCampaignId(PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the properties of the donation campaign specified in the path. Note the following restrictions: 

* You cannot use a PATCH request to update the campaign status. To activate or end a campaign, make a POST request to the `/campaignManagement/{campaignId}/status/{status}` endpoint.
* You get a validation error if you add account holders that are not compatible with the nonprofit.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Campaign Management read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DonationCampaigns.PatchCompaniesCompanyIdCampaignManagementDonationCampaignId(
        new PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest
        {
            CompanyId = "some example string",
            DonationCampaignId = "some example string",
        });
    // TODO: Handle 'response' of type DonationCampaign1
}
catch (ApiException<PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest](src/Adyen/Requests/DonationCampaigns/PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationCampaign1](src/Adyen/Models/DonationCampaign1.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError](src/Adyen/Errors/PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DonationCampaign1&gt; PostCompaniesCompanyIdCampaignManagement(PostCompaniesCompanyIdCampaignManagementRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new donation campaign, to give shoppers the option to donate to a nonprofit organization when making a payment. A campaign can be for online payments, in-person payments, or both online and in-person payments.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Campaign Management read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DonationCampaigns.PostCompaniesCompanyIdCampaignManagement(
        new PostCompaniesCompanyIdCampaignManagementRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type DonationCampaign1
}
catch (ApiException<PostCompaniesCompanyIdCampaignManagementError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdCampaignManagementRequest](src/Adyen/Requests/DonationCampaigns/PostCompaniesCompanyIdCampaignManagementRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationCampaign1](src/Adyen/Models/DonationCampaign1.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdCampaignManagementError](src/Adyen/Errors/PostCompaniesCompanyIdCampaignManagementError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DonationCampaign1&gt; PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatus(PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Starts or stops the donation campaign specified in the path, by providing a path parameter. 
Use the path parameter **activate** to start an inactive campaign, or **end** to stop an active campaign. Other status transitions are not allowed.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Campaign Management read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DonationCampaigns.PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatus(
        new PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusRequest
        {
            CompanyId = "some example string",
            DonationCampaignId = "some example string",
            Status = CampaignStatusTransition.Activate,
        });
    // TODO: Handle 'response' of type DonationCampaign1
}
catch (ApiException<PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusRequest](src/Adyen/Requests/DonationCampaigns/PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationCampaign1](src/Adyen/Models/DonationCampaign1.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError](src/Adyen/Errors/PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListNonprofitsResponse&gt; PostCompaniesCompanyIdNonprofits(PostCompaniesCompanyIdNonprofitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of supported nonprofit organizations to choose from when creating a donation campaign. The list only contains nonprofits that are compatible with all the account holders specified in the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DonationCampaigns.PostCompaniesCompanyIdNonprofits(
        new PostCompaniesCompanyIdNonprofitsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type ListNonprofitsResponse
}
catch (ApiException<PostCompaniesCompanyIdNonprofitsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdNonprofitsRequest](src/Adyen/Requests/DonationCampaigns/PostCompaniesCompanyIdNonprofitsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListNonprofitsResponse](src/Adyen/Models/ListNonprofitsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdNonprofitsError](src/Adyen/Errors/PostCompaniesCompanyIdNonprofitsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Donations

> Source: [Donations](src/Adyen/Api/Donations.cs)

<details>
<summary><code>Task&lt;DonationCampaignsResponse&gt; PostDonationCampaigns(PostDonationCampaignsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Queries the available donation campaigns for a donation based on the donation context (like merchant account, currency, and locale). The response contains active donation campaigns.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Donations.PostDonationCampaigns(new PostDonationCampaignsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new DonationCampaignsRequest { Currency = "EUR", MerchantAccount = "YOUR_MERCHANT_ACCOUNT" },
    });
    // TODO: Handle 'response' of type DonationCampaignsResponse
}
catch (ApiException<PostDonationCampaignsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDonationCampaignsRequest](src/Adyen/Requests/Donations/PostDonationCampaignsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationCampaignsResponse](src/Adyen/Models/DonationCampaignsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDonationCampaignsError](src/Adyen/Errors/PostDonationCampaignsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DonationPaymentResponse&gt; PostDonations(PostDonationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Takes in the donation token generated by the `/payments` request and uses it to make the donation.

For more information, see [Donations](https://docs.adyen.com/online-payments/donations).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Donations.PostDonations(new PostDonationsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new DonationPaymentRequest
        {
            Amount = new Amount2 { Currency = "EUR", Value = 1000L },
            DonationCampaignId = "DONATION_CAMPAIGN_ID",
            DonationOriginalPspReference = "991559660454807J",
            DonationToken = "YOUR_DONATION_TOKEN",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PaymentMethod = new CardDonations { Type = Type14.Scheme },
            Reference = "YOUR_DONATION_REFERENCE",
            ReturnUrl = "https://your-company.example.com/...",
        },
    });
    // TODO: Handle 'response' of type DonationPaymentResponse
}
catch (ApiException<PostDonationsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDonationsRequest](src/Adyen/Requests/Donations/PostDonationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DonationPaymentResponse](src/Adyen/Models/DonationPaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDonationsError](src/Adyen/Errors/PostDonationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DynamicOffers

> Source: [DynamicOffers](src/Adyen/Api/DynamicOffers.cs)

<details>
<summary><code>Task&lt;GetDynamicOffersResponse&gt; GetDynamicOffers(GetDynamicOffersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all [dynamic offers](https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/) available for `accountHolderId` specified as a query parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DynamicOffers.GetDynamicOffers(new GetDynamicOffersRequest
    {
        AccountHolderId = "some example string",
    });
    // TODO: Handle 'response' of type GetDynamicOffersResponse
}
catch (ApiException<GetDynamicOffersError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDynamicOffersRequest](src/Adyen/Requests/DynamicOffers/GetDynamicOffersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetDynamicOffersResponse](src/Adyen/Models/GetDynamicOffersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetDynamicOffersError](src/Adyen/Errors/GetDynamicOffersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalculatedGrantOffer&gt; PostDynamicOffersIdCalculate(PostDynamicOffersIdCalculateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Calculates a preliminary offer for the financing amount that the user selected from a [dynamic offer](https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/). The preliminary offer is for informational purposes only and cannot be used to initiate a grant.

Requests to this endpoint are subject to rate limits:

- Live environments: 120 requests per minute.

- Test environments: 120 requests per minute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DynamicOffers.PostDynamicOffersIdCalculate(new PostDynamicOffersIdCalculateRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type CalculatedGrantOffer
}
catch (ApiException<PostDynamicOffersIdCalculateError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDynamicOffersIdCalculateRequest](src/Adyen/Requests/DynamicOffers/PostDynamicOffersIdCalculateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculatedGrantOffer](src/Adyen/Models/CalculatedGrantOffer.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDynamicOffersIdCalculateError](src/Adyen/Errors/PostDynamicOffersIdCalculateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GrantOffer1&gt; PostDynamicOffersIdGrantOffer(PostDynamicOffersIdGrantOfferRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a static offer for the financing amount that the user selected from the [dynamic offer](https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/).

Requests to this endpoint are subject to rate limits:

- Live environments: 30 requests per minute.

- Test environments: 30 requests per minute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DynamicOffers.PostDynamicOffersIdGrantOffer(new PostDynamicOffersIdGrantOfferRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type GrantOffer1
}
catch (ApiException<PostDynamicOffersIdGrantOfferError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDynamicOffersIdGrantOfferRequest](src/Adyen/Requests/DynamicOffers/PostDynamicOffersIdGrantOfferRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantOffer1](src/Adyen/Models/GrantOffer1.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDynamicOffersIdGrantOfferError](src/Adyen/Errors/PostDynamicOffersIdGrantOfferError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## General

> Source: [General](src/Adyen/Api/General.cs)

<details>
<summary><code>Task&lt;AcceptDisputeResponse&gt; PostAcceptDispute(PostAcceptDisputeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Accepts a specific dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostAcceptDispute(new PostAcceptDisputeRequest
    {
        Body = new AcceptDisputeRequest
        {
            DisputePspReference = "DZ4DPSHB4WD2WN82",
            MerchantAccountCode = "YOUR_MERCHANT_ACCOUNT",
        },
    });
    // TODO: Handle 'response' of type AcceptDisputeResponse
}
catch (ApiException<PostAcceptDisputeError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAcceptDisputeRequest](src/Adyen/Requests/General/PostAcceptDisputeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AcceptDisputeResponse](src/Adyen/Models/AcceptDisputeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostAcceptDisputeError](src/Adyen/Errors/PostAcceptDisputeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountHolderBalanceResponse&gt; PostAccountHolderBalance(PostAccountHolderBalanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the account balances of an account holder. An account's balances are organized according by currencies. This mean that an account may have multiple balances: one for each currency.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostAccountHolderBalance(new PostAccountHolderBalanceRequest
    {
        Body = new CloseAccountHolderRequest { AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER" },
    });
    // TODO: Handle 'response' of type AccountHolderBalanceResponse
}
catch (ApiException<PostAccountHolderBalanceError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAccountHolderBalanceRequest](src/Adyen/Requests/General/PostAccountHolderBalanceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountHolderBalanceResponse](src/Adyen/Models/AccountHolderBalanceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostAccountHolderBalanceError](src/Adyen/Errors/PostAccountHolderBalanceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountHolderTransactionListResponse&gt; PostAccountHolderTransactionList(PostAccountHolderTransactionListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of transactions for an account holder's accounts. You can specify the accounts and transaction statuses to be included on the list. The call returns a maximum of 50 transactions for each account. To retrieve all transactions, you must make another call with the 'page' value incremented. Transactions are listed in chronological order, with the most recent transaction first.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostAccountHolderTransactionList(new PostAccountHolderTransactionListRequest
    {
        Body = new AccountHolderTransactionListRequest
        {
            AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
            TransactionListsPerAccount = [new TransactionListForAccount { AccountCode = "195752115", Page = 1 }],
        },
    });
    // TODO: Handle 'response' of type AccountHolderTransactionListResponse
}
catch (ApiException<PostAccountHolderTransactionListError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAccountHolderTransactionListRequest](src/Adyen/Requests/General/PostAccountHolderTransactionListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountHolderTransactionListResponse](src/Adyen/Models/AccountHolderTransactionListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostAccountHolderTransactionListError](src/Adyen/Errors/PostAccountHolderTransactionListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssignTerminalsResponse&gt; PostAssignTerminals(PostAssignTerminalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Assigns one or more payment terminals to a merchant account or a store. You can also use this endpoint to reassign terminals between merchant accounts or stores, and to unassign a terminal and return it to company inventory.

>From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostAssignTerminals(new PostAssignTerminalsRequest
    {
        Body = new AssignTerminalsRequest
        {
            CompanyAccount = "YOUR_COMPANY_ACCOUNT",
            Terminals = ["P400Plus-275479597"],
        },
    });
    // TODO: Handle 'response' of type AssignTerminalsResponse
}
catch (ApiException<PostAssignTerminalsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAssignTerminalsRequest](src/Adyen/Requests/General/PostAssignTerminalsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssignTerminalsResponse](src/Adyen/Models/AssignTerminalsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostAssignTerminalsError](src/Adyen/Errors/PostAssignTerminalsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueStatusChangeResponse&gt; PostChangeStatus(PostChangeStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the status of the provided payment method to the specified status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostChangeStatus(new PostChangeStatusRequest());
    // TODO: Handle 'response' of type StoredValueStatusChangeResponse
}
catch (ApiException<PostChangeStatusError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostChangeStatusRequest](src/Adyen/Requests/General/PostChangeStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueStatusChangeResponse](src/Adyen/Models/StoredValueStatusChangeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostChangeStatusError](src/Adyen/Errors/PostChangeStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueBalanceCheckResponse&gt; PostCheckBalance(PostCheckBalanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Checks the balance of the provided payment method.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostCheckBalance(new PostCheckBalanceRequest());
    // TODO: Handle 'response' of type StoredValueBalanceCheckResponse
}
catch (ApiException<PostCheckBalanceError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCheckBalanceRequest](src/Adyen/Requests/General/PostCheckBalanceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueBalanceCheckResponse](src/Adyen/Models/StoredValueBalanceCheckResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCheckBalanceError](src/Adyen/Errors/PostCheckBalanceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetNotificationConfigurationResponse&gt; PostCreateNotificationConfiguration(PostCreateNotificationConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a subscription to notifications informing you of events on your platform. After the subscription is created, the events specified in the configuration will be sent to the URL specified in the configuration. Subscriptions must be configured on a per-event basis (as opposed to, for example, a per-account holder basis), so all event notifications of a marketplace and of a given type will be sent to the same endpoint(s). A marketplace may have multiple endpoints if desired; an event notification may be sent to as many or as few different endpoints as configured.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostCreateNotificationConfiguration(
        new PostCreateNotificationConfigurationRequest
        {
            Body = new CreateNotificationConfigurationRequest
            {
                ConfigurationDetails = new NotificationConfigurationDetails4
                {
                    Active = true,
                    Description = "Unique description 123",
                    EventConfigs = [
                        new NotificationEventConfiguration
                        {
                            EventType = EventType.AccountHolderVerification,
                            IncludeMode = IncludeMode.Include,
                        },
                    ],
                    NotifyPassword = "testPassword",
                    NotifyUrl = "https://www.adyen.com/notification-handler",
                    NotifyUsername = "testUserName",
                    SslProtocol = SslProtocol.TlSv13,
                },
            },
        });
    // TODO: Handle 'response' of type GetNotificationConfigurationResponse
}
catch (ApiException<PostCreateNotificationConfigurationError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCreateNotificationConfigurationRequest](src/Adyen/Requests/General/PostCreateNotificationConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetNotificationConfigurationResponse](src/Adyen/Models/GetNotificationConfigurationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCreateNotificationConfigurationError](src/Adyen/Errors/PostCreateNotificationConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreatePermitResult&gt; PostCreatePermit(PostCreatePermitRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create permits for a recurring contract, including support for defining restrictions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostCreatePermit(new PostCreatePermitRequest());
    // TODO: Handle 'response' of type CreatePermitResult
}
catch (ApiException<PostCreatePermitError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCreatePermitRequest](src/Adyen/Requests/General/PostCreatePermitRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreatePermitResult](src/Adyen/Models/CreatePermitResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCreatePermitError](src/Adyen/Errors/PostCreatePermitError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateTestCardRangesResult&gt; PostCreateTestCardRanges(PostCreateTestCardRangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates one or more test card ranges.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostCreateTestCardRanges(new PostCreateTestCardRangesRequest());
    // TODO: Handle 'response' of type CreateTestCardRangesResult
}
catch (ApiException<PostCreateTestCardRangesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCreateTestCardRangesRequest](src/Adyen/Requests/General/PostCreateTestCardRangesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateTestCardRangesResult](src/Adyen/Models/CreateTestCardRangesResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCreateTestCardRangesError](src/Adyen/Errors/PostCreateTestCardRangesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DebitAccountHolderResponse&gt; PostDebitAccountHolder(PostDebitAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a direct debit request to an account holder's bank account. If the direct debit is successful, the funds are settled in the accounts specified in the split instructions. Adyen sends the result of the direct debit in a [`DIRECT_DEBIT_INITIATED`](https://docs.adyen.com/api-explorer/#/NotificationService/latest/post/DIRECT_DEBIT_INITIATED) notification webhook.

 To learn more about direct debits, see [Top up accounts](https://docs.adyen.com/classic-platforms/top-up-accounts).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDebitAccountHolder(new PostDebitAccountHolderRequest
    {
        Body = new DebitAccountHolderRequest
        {
            AccountHolderCode = "ACCOUNT_HOLDER_CODE",
            Amount = new Amount { Currency = "USD", Value = 6200L },
            BankAccountUuid = "000b81aa-ae7e-4492-aa7e-72b2129dce0c",
            Description = "YOUR_DESCRIPTION",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Splits = [
                new Split1
                {
                    Account = "8535516988037431",
                    Amount = new SplitAmount { Value = 6000L },
                    Reference = "YOUR_SPLIT_REFERENCE_1",
                    Type = Type60.MarketPlace,
                },
                new Split1
                {
                    Amount = new SplitAmount { Value = 200L },
                    Reference = "YOUR_SPLIT_REFERENCE_2",
                    Type = Type60.Commission,
                },
            ],
        },
    });
    // TODO: Handle 'response' of type DebitAccountHolderResponse
}
catch (ApiException<PostDebitAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDebitAccountHolderRequest](src/Adyen/Requests/General/PostDebitAccountHolderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DebitAccountHolderResponse](src/Adyen/Models/DebitAccountHolderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDebitAccountHolderError](src/Adyen/Errors/PostDebitAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DefendDisputeResponse&gt; PostDefendDispute(PostDefendDisputeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Defends a specific dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDefendDispute(new PostDefendDisputeRequest
    {
        Body = new DefendDisputeRequest
        {
            DefenseReasonCode = "SupplyDefenseMaterial",
            DisputePspReference = "DZ4DPSHB4WD2WN82",
            MerchantAccountCode = "YOUR_MERCHANT_ACCOUNT",
        },
    });
    // TODO: Handle 'response' of type DefendDisputeResponse
}
catch (ApiException<PostDefendDisputeError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDefendDisputeRequest](src/Adyen/Requests/General/PostDefendDisputeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DefendDisputeResponse](src/Adyen/Models/DefendDisputeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDefendDisputeError](src/Adyen/Errors/PostDefendDisputeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteDefenseDocumentResponse&gt; PostDeleteDisputeDefenseDocument(PostDeleteDisputeDefenseDocumentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a specific dispute defense document that was supplied earlier.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDeleteDisputeDefenseDocument(new PostDeleteDisputeDefenseDocumentRequest
    {
        Body = new DeleteDefenseDocumentRequest
        {
            DefenseDocumentType = "DefenseMaterial",
            DisputePspReference = "DZ4DPSHB4WD2WN82",
            MerchantAccountCode = "YOUR_MERCHANT_ACCOUNT",
        },
    });
    // TODO: Handle 'response' of type DeleteDefenseDocumentResponse
}
catch (ApiException<PostDeleteDisputeDefenseDocumentError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDeleteDisputeDefenseDocumentRequest](src/Adyen/Requests/General/PostDeleteDisputeDefenseDocumentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteDefenseDocumentResponse](src/Adyen/Models/DeleteDefenseDocumentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDeleteDisputeDefenseDocumentError](src/Adyen/Errors/PostDeleteDisputeDefenseDocumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeleteNotificationConfigurations(PostDeleteNotificationConfigurationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an existing notification subscription configuration. After the subscription is deleted, no further event notifications will be sent to the URL defined in the subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDeleteNotificationConfigurations(
        new PostDeleteNotificationConfigurationsRequest
        {
            Body = new DeleteNotificationConfigurationRequest { NotificationIds = [27891L] },
        });
    // TODO: Handle 'response' of type GenericResponse
}
catch (ApiException<PostDeleteNotificationConfigurationsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDeleteNotificationConfigurationsRequest](src/Adyen/Requests/General/PostDeleteNotificationConfigurationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](src/Adyen/Models/GenericResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDeleteNotificationConfigurationsError](src/Adyen/Errors/PostDeleteNotificationConfigurationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisableResult&gt; PostDisable(PostDisableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disables stored payment details to stop charging a shopper with this particular recurring detail ID.

For more information, refer to [Disable stored details](https://docs.adyen.com/online-payments/classic-integrations/classic-api-integration/tokenization/disable-stored-details).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDisable(new PostDisableRequest
    {
        Body = new DisableRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            RecurringDetailReference = "8314442372419167",
            ShopperReference = "YOUR_SHOPPER_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type DisableResult
}
catch (ApiException<PostDisableError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDisableRequest](src/Adyen/Requests/General/PostDisableRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisableResult](src/Adyen/Models/DisableResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDisableError](src/Adyen/Errors/PostDisableError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisablePermitResult&gt; PostDisablePermit(PostDisablePermitRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disable a permit that was previously linked to a recurringDetailReference.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostDisablePermit(new PostDisablePermitRequest());
    // TODO: Handle 'response' of type DisablePermitResult
}
catch (ApiException<PostDisablePermitError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDisablePermitRequest](src/Adyen/Requests/General/PostDisablePermitRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisablePermitResult](src/Adyen/Models/DisablePermitResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDisablePermitError](src/Adyen/Errors/PostDisablePermitError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FindTerminalResponse&gt; PostFindTerminal(PostFindTerminalRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the company account, merchant account, or store that a payment terminal is assigned to.

>From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostFindTerminal(new PostFindTerminalRequest
    {
        Body = new FindTerminalRequest { Terminal = "M400-401972715" },
    });
    // TODO: Handle 'response' of type FindTerminalResponse
}
catch (ApiException<PostFindTerminalError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostFindTerminalRequest](src/Adyen/Requests/General/PostFindTerminalRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FindTerminalResponse](src/Adyen/Models/FindTerminalResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostFindTerminalError](src/Adyen/Errors/PostFindTerminalError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ThreeDsAvailabilityResponse&gt; PostGet3DsAvailability(PostGet3DsAvailabilityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Verifies whether 3D Secure is available for the specified BIN or card brand. For 3D Secure 2, this endpoint also returns device fingerprinting keys.

For more information, refer to [3D Secure 2](https://docs.adyen.com/online-payments/3d-secure/native-3ds2).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGet3DsAvailability(new PostGet3DsAvailabilityRequest
    {
        Body = new ThreeDsAvailabilityRequest
        {
            CardNumber = "4111111111111111",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
        },
    });
    // TODO: Handle 'response' of type ThreeDsAvailabilityResponse
}
catch (ApiException<PostGet3DsAvailabilityError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGet3DsAvailabilityRequest](src/Adyen/Requests/General/PostGet3DsAvailabilityRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ThreeDsAvailabilityResponse](src/Adyen/Models/ThreeDsAvailabilityResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGet3DsAvailabilityError](src/Adyen/Errors/PostGet3DsAvailabilityError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CostEstimateResponse&gt; PostGetCostEstimate(PostGetCostEstimateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

>This API is available only for merchants operating in Australia, the EU, and the UK.

Use the Adyen Cost Estimation API to pre-calculate interchange and scheme fee costs. Knowing these costs prior actual payment authorisation gives you an opportunity to charge those costs to the cardholder, if necessary.

To retrieve this information, make the call to the `/getCostEstimate` endpoint. The response to this call contains the amount of the interchange and scheme fees charged by the network for this transaction, and also which surcharging policy is possible (based on current regulations).

> Since not all information is known in advance (for example, if the cardholder will successfully authenticate via 3D Secure or if you also plan to provide additional Level 2/3 data), the returned amounts are based on a set of assumption criteria you define in the `assumptions` parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetCostEstimate(new PostGetCostEstimateRequest
    {
        Body = new CostEstimateRequest
        {
            Amount = new Amount { Currency = "EUR", Value = 1234L },
            Assumptions = new CostEstimateAssumptions1 { Assume3DSecureAuthenticated = true, AssumeLevel3Data = true },
            CardNumber = "5101180000000007",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            MerchantDetails = new MerchantDetails2 { CountryCode = "NL", EnrolledIn3DSecure = true, Mcc = "7411" },
            ShopperInteraction = ShopperInteraction.Ecommerce,
        },
    });
    // TODO: Handle 'response' of type CostEstimateResponse
}
catch (ApiException<PostGetCostEstimateError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetCostEstimateRequest](src/Adyen/Requests/General/PostGetCostEstimateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CostEstimateResponse](src/Adyen/Models/CostEstimateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetCostEstimateError](src/Adyen/Errors/PostGetCostEstimateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetNotificationConfigurationResponse&gt; PostGetNotificationConfiguration(PostGetNotificationConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the configuration of a notification subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetNotificationConfiguration(new PostGetNotificationConfigurationRequest
    {
        Body = new GetNotificationConfigurationRequest { NotificationId = 21259L },
    });
    // TODO: Handle 'response' of type GetNotificationConfigurationResponse
}
catch (ApiException<PostGetNotificationConfigurationError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetNotificationConfigurationRequest](src/Adyen/Requests/General/PostGetNotificationConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetNotificationConfigurationResponse](src/Adyen/Models/GetNotificationConfigurationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetNotificationConfigurationError](src/Adyen/Errors/PostGetNotificationConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetNotificationConfigurationListResponse&gt; PostGetNotificationConfigurationList(PostGetNotificationConfigurationListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the configurations of all of the notification subscriptions in the platform of the executing user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetNotificationConfigurationList(
        new PostGetNotificationConfigurationListRequest());
    // TODO: Handle 'response' of type GetNotificationConfigurationListResponse
}
catch (ApiException<PostGetNotificationConfigurationListError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetNotificationConfigurationListRequest](src/Adyen/Requests/General/PostGetNotificationConfigurationListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetNotificationConfigurationListResponse](src/Adyen/Models/GetNotificationConfigurationListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetNotificationConfigurationListError](src/Adyen/Errors/PostGetNotificationConfigurationListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetStoresUnderAccountResponse&gt; PostGetStoresUnderAccount(PostGetStoresUnderAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of stores associated with a company account or a merchant account, including the status of each store.

>From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetStoresUnderAccount(new PostGetStoresUnderAccountRequest
    {
        Body = new GetStoresUnderAccountRequest { CompanyAccount = "YOUR_COMPANY_ACCOUNT" },
    });
    // TODO: Handle 'response' of type GetStoresUnderAccountResponse
}
catch (ApiException<PostGetStoresUnderAccountError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetStoresUnderAccountRequest](src/Adyen/Requests/General/PostGetStoresUnderAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetStoresUnderAccountResponse](src/Adyen/Models/GetStoresUnderAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetStoresUnderAccountError](src/Adyen/Errors/PostGetStoresUnderAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTerminalDetailsResponse&gt; PostGetTerminalDetails(PostGetTerminalDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a payment terminal, including where the terminal is assigned to. The response returns the same details that are provided in the terminal list in your Customer Area and in the Terminal Fleet report.

>From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetTerminalDetails(new PostGetTerminalDetailsRequest
    {
        Body = new GetTerminalDetailsRequest { Terminal = "M400-401972715" },
    });
    // TODO: Handle 'response' of type GetTerminalDetailsResponse
}
catch (ApiException<PostGetTerminalDetailsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetTerminalDetailsRequest](src/Adyen/Requests/General/PostGetTerminalDetailsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTerminalDetailsResponse](src/Adyen/Models/GetTerminalDetailsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetTerminalDetailsError](src/Adyen/Errors/PostGetTerminalDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTerminalsUnderAccountResponse&gt; PostGetTerminalsUnderAccount(PostGetTerminalsUnderAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of payment terminals associated with a company account, merchant account, or store. The response shows whether the terminals are in the inventory, or in-store (ready for boarding or already boarded).

>From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostGetTerminalsUnderAccount(new PostGetTerminalsUnderAccountRequest
    {
        Body = new GetTerminalsUnderAccountRequest { CompanyAccount = "YOUR_COMPANY_ACCOUNT" },
    });
    // TODO: Handle 'response' of type GetTerminalsUnderAccountResponse
}
catch (ApiException<PostGetTerminalsUnderAccountError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetTerminalsUnderAccountRequest](src/Adyen/Requests/General/PostGetTerminalsUnderAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTerminalsUnderAccountResponse](src/Adyen/Models/GetTerminalsUnderAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetTerminalsUnderAccountError](src/Adyen/Errors/PostGetTerminalsUnderAccountError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueIssueResponse&gt; PostIssue(PostIssueRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Issues a new card of the given payment method.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostIssue(new PostIssueRequest());
    // TODO: Handle 'response' of type StoredValueIssueResponse
}
catch (ApiException<PostIssueError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostIssueRequest](src/Adyen/Requests/General/PostIssueRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueIssueResponse](src/Adyen/Models/StoredValueIssueResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostIssueError](src/Adyen/Errors/PostIssueError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringDetailsResult&gt; PostListRecurringDetails(PostListRecurringDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the stored payment details for a shopper, if there are any available. The recurring detail ID can be used with a regular authorisation request to charge the shopper. A summary of the payment detail is returned for presentation to the shopper.

For more information, refer to [Retrieve stored details](https://docs.adyen.com/classic-integration/recurring-payments/retrieve-stored-details/).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostListRecurringDetails(new PostListRecurringDetailsRequest
    {
        Body = new RecurringDetailsRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Recurring = new Recurring { Contract = Contract.Recurring },
            ShopperReference = "YOUR_SHOPPER_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type RecurringDetailsResult
}
catch (ApiException<PostListRecurringDetailsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostListRecurringDetailsRequest](src/Adyen/Requests/General/PostListRecurringDetailsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringDetailsResult](src/Adyen/Models/RecurringDetailsResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostListRecurringDetailsError](src/Adyen/Errors/PostListRecurringDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueLoadResponse&gt; PostLoad(PostLoadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Loads the payment method with the specified funds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostLoad(new PostLoadRequest());
    // TODO: Handle 'response' of type StoredValueLoadResponse
}
catch (ApiException<PostLoadError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLoadRequest](src/Adyen/Requests/General/PostLoadRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueLoadResponse](src/Adyen/Models/StoredValueLoadResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostLoadError](src/Adyen/Errors/PostLoadError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueBalanceMergeResponse&gt; PostMergeBalance(PostMergeBalanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Increases the balance of the paymentmethod by the full amount left on the source paymentmethod

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostMergeBalance(new PostMergeBalanceRequest());
    // TODO: Handle 'response' of type StoredValueBalanceMergeResponse
}
catch (ApiException<PostMergeBalanceError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMergeBalanceRequest](src/Adyen/Requests/General/PostMergeBalanceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueBalanceMergeResponse](src/Adyen/Models/StoredValueBalanceMergeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMergeBalanceError](src/Adyen/Errors/PostMergeBalanceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NotifyShopperResult&gt; PostNotifyShopper(PostNotifyShopperRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a request to the issuer so they can inform the shopper about the upcoming recurring payment. This endpoint is used only for local acquiring in India. For more information, refer to [Recurring card payments in India](https://docs.adyen.com/payment-methods/cards/cards-recurring-india).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostNotifyShopper(new PostNotifyShopperRequest
    {
        Body = new NotifyShopperRequest
        {
            Amount = new Amount { Currency = "INR", Value = 1000L },
            BillingDate = "2021-03-16",
            DisplayedReference = "exampleDisplayedReference",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "Example reference",
            ShopperReference = "YOUR_SHOPPER_REFERENCE",
            StoredPaymentMethodId = "8415995487234100",
        },
    });
    // TODO: Handle 'response' of type NotifyShopperResult
}
catch (ApiException<PostNotifyShopperError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostNotifyShopperRequest](src/Adyen/Requests/General/PostNotifyShopperRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NotifyShopperResult](src/Adyen/Models/NotifyShopperResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostNotifyShopperError](src/Adyen/Errors/PostNotifyShopperError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutAccountHolderResponse&gt; PostPayoutAccountHolder(PostPayoutAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pays out a specified amount from an account to the bank account of account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostPayoutAccountHolder(new PostPayoutAccountHolderRequest
    {
        Body = new PayoutAccountHolderRequest
        {
            AccountCode = "118731451",
            AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
            Amount = new Amount { Currency = "EUR", Value = 99792L },
            BankAccountUuid = "000b81aa-ae7e-4492-aa7e-72b2129dce0c",
            Description = "12345 – Test",
        },
    });
    // TODO: Handle 'response' of type PayoutAccountHolderResponse
}
catch (ApiException<PostPayoutAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPayoutAccountHolderRequest](src/Adyen/Requests/General/PostPayoutAccountHolderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutAccountHolderResponse](src/Adyen/Models/PayoutAccountHolderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPayoutAccountHolderError](src/Adyen/Errors/PostPayoutAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RefundFundsTransferResponse&gt; PostRefundFundsTransfer(PostRefundFundsTransferRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds funds transferred from one account to another. Both accounts must be in the same platform, but can have different account holders.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostRefundFundsTransfer(new PostRefundFundsTransferRequest
    {
        Body = new RefundFundsTransferRequest
        {
            Amount = new Amount { Currency = "EUR", Value = 1000L },
            MerchantReference = "YOUR_REFERENCE_ID",
            OriginalReference = "PSP_REFERENCE_OF_TRANSFER_TO_REFUND",
        },
    });
    // TODO: Handle 'response' of type RefundFundsTransferResponse
}
catch (ApiException<PostRefundFundsTransferError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostRefundFundsTransferRequest](src/Adyen/Requests/General/PostRefundFundsTransferRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RefundFundsTransferResponse](src/Adyen/Models/RefundFundsTransferResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostRefundFundsTransferError](src/Adyen/Errors/PostRefundFundsTransferError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostRefundNotPaidOutTransfers(PostRefundNotPaidOutTransfersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds all the transactions of an account that have taken place since the most recent payout. This request is on a account basis (as opposed to a payment basis), so only the portion of the payment that was made to the specified account is refunded. The commissions, fees, and payments to other accounts remain in the accounts to which they were sent as designated by the original payment's split details.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostRefundNotPaidOutTransfers(new PostRefundNotPaidOutTransfersRequest
    {
        Body = new RefundNotPaidOutTransfersRequest
        {
            AccountCode = "189184578",
            AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
        },
    });
    // TODO: Handle 'response' of type GenericResponse
}
catch (ApiException<PostRefundNotPaidOutTransfersError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostRefundNotPaidOutTransfersRequest](src/Adyen/Requests/General/PostRefundNotPaidOutTransfersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](src/Adyen/Models/GenericResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostRefundNotPaidOutTransfersError](src/Adyen/Errors/PostRefundNotPaidOutTransfersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubjectErasureResponse&gt; PostRequestSubjectErasure(PostRequestSubjectErasureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends the PSP reference containing the shopper data that should be deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostRequestSubjectErasure(new PostRequestSubjectErasureRequest());
    // TODO: Handle 'response' of type SubjectErasureResponse
}
catch (ApiException<PostRequestSubjectErasureError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostRequestSubjectErasureRequest](src/Adyen/Requests/General/PostRequestSubjectErasureRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubjectErasureResponse](src/Adyen/Models/SubjectErasureResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostRequestSubjectErasureError](src/Adyen/Errors/PostRequestSubjectErasureError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DefenseReasonsResponse&gt; PostRetrieveApplicableDefenseReasons(PostRetrieveApplicableDefenseReasonsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all applicable defense reasons to defend a specific dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostRetrieveApplicableDefenseReasons(
        new PostRetrieveApplicableDefenseReasonsRequest
        {
            Body = new DefenseReasonsRequest
            {
                DisputePspReference = "DZ4DPSHB4WD2WN82",
                MerchantAccountCode = "YOUR_MERCHANT_ACCOUNT",
            },
        });
    // TODO: Handle 'response' of type DefenseReasonsResponse
}
catch (ApiException<PostRetrieveApplicableDefenseReasonsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostRetrieveApplicableDefenseReasonsRequest](src/Adyen/Requests/General/PostRetrieveApplicableDefenseReasonsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DefenseReasonsResponse](src/Adyen/Models/DefenseReasonsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostRetrieveApplicableDefenseReasonsError](src/Adyen/Errors/PostRetrieveApplicableDefenseReasonsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ScheduleAccountUpdaterResult&gt; PostScheduleAccountUpdater(PostScheduleAccountUpdaterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

When making the API call, you can submit either the credit card information, or the recurring detail reference and the shopper reference:
* If the card information is provided, all the sub-fields for `card` are mandatory.
* If the recurring detail reference is provided, the fields for `shopperReference` and `selectedRecurringDetailReference` are mandatory.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostScheduleAccountUpdater(new PostScheduleAccountUpdaterRequest
    {
        Body = new ScheduleAccountUpdaterRequest
        {
            Card = new Card
            {
                ExpiryMonth = "03",
                ExpiryYear = "2030",
                HolderName = "Adyen Test",
                Number = "4111111111111111",
            },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type ScheduleAccountUpdaterResult
}
catch (ApiException<PostScheduleAccountUpdaterError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostScheduleAccountUpdaterRequest](src/Adyen/Requests/General/PostScheduleAccountUpdaterRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ScheduleAccountUpdaterResult](src/Adyen/Models/ScheduleAccountUpdaterResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostScheduleAccountUpdaterError](src/Adyen/Errors/PostScheduleAccountUpdaterError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CertificateLoadingResponse&gt; PostSessions3(PostSessions3Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Establishes a secure communications session between the POS Mobile SDK and the Adyen payments platform, through mutual authentication. 
The request sends a setup token that identifies the SDK and the device. The response returns a session token that the SDK can use to authenticate responses received from the Adyen payments platform.
>This request applies to **mobile in-person** transactions. You cannot use this request to create online payments sessions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostSessions3(new PostSessions3Request
    {
        Body = new CreateSessionRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            SetupToken = "SETUP_TOKEN",
            Store = "YOUR_STORE_ID",
        },
    });
    // TODO: Handle 'response' of type CertificateLoadingResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostSessions3Request](src/Adyen/Requests/General/PostSessions3Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CertificateLoadingResponse](src/Adyen/Models/CertificateLoadingResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostSetupBeneficiary(PostSetupBeneficiaryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Defines a benefactor and a beneficiary relationship between two accounts. At the time of benefactor/beneficiary setup, the funds in the benefactor account are transferred to the beneficiary account, and any further payments to the benefactor account are automatically sent to the beneficiary account. A series of benefactor/beneficiaries may not exceed four beneficiaries and may not have a cycle in it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostSetupBeneficiary(new PostSetupBeneficiaryRequest
    {
        Body = new SetupBeneficiaryRequest
        {
            DestinationAccountCode = "128952522",
            MerchantReference = "YOUR_REFERENCE_ID",
            SourceAccountCode = "134498192",
        },
    });
    // TODO: Handle 'response' of type GenericResponse
}
catch (ApiException<PostSetupBeneficiaryError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostSetupBeneficiaryRequest](src/Adyen/Requests/General/PostSetupBeneficiaryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](src/Adyen/Models/GenericResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostSetupBeneficiaryError](src/Adyen/Errors/PostSetupBeneficiaryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SupplyDefenseDocumentResponse&gt; PostSupplyDefenseDocument(PostSupplyDefenseDocumentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Supplies a specific dispute defense document.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostSupplyDefenseDocument(new PostSupplyDefenseDocumentRequest
    {
        Body = new SupplyDefenseDocumentRequest
        {
            DefenseDocuments = [
                new DefenseDocument
                {
                    Content = "JVBERi0xLjQKJcOkw7zDtsOfCjIgMCBv+f/ub0j6JPRX+E3EmC==",
                    ContentType = "application/pdf",
                    DefenseDocumentTypeCode = "DefenseMaterial",
                },
            ],
            DisputePspReference = "DZ4DPSHB4WD2WN82",
            MerchantAccountCode = "YOUR_MERCHANT_ACCOUNT",
        },
    });
    // TODO: Handle 'response' of type SupplyDefenseDocumentResponse
}
catch (ApiException<PostSupplyDefenseDocumentError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostSupplyDefenseDocumentRequest](src/Adyen/Requests/General/PostSupplyDefenseDocumentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SupplyDefenseDocumentResponse](src/Adyen/Models/SupplyDefenseDocumentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostSupplyDefenseDocumentError](src/Adyen/Errors/PostSupplyDefenseDocumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TestNotificationConfigurationResponse&gt; PostTestNotificationConfiguration(PostTestNotificationConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Tests an existing notification subscription configuration. For each event type specified, a test notification will be generated and sent to the URL configured in the subscription specified.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostTestNotificationConfiguration(new PostTestNotificationConfigurationRequest
    {
        Body = new TestNotificationConfigurationRequest
        {
            EventTypes = [EventType1.AccountHolderVerification],
            NotificationId = 25032L,
        },
    });
    // TODO: Handle 'response' of type TestNotificationConfigurationResponse
}
catch (ApiException<PostTestNotificationConfigurationError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTestNotificationConfigurationRequest](src/Adyen/Requests/General/PostTestNotificationConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TestNotificationConfigurationResponse](src/Adyen/Models/TestNotificationConfigurationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTestNotificationConfigurationError](src/Adyen/Errors/PostTestNotificationConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferFundsResponse&gt; PostTransferFunds(PostTransferFundsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Transfers funds from one account to another account. Both accounts must be in the same platform, but can have different account holders. The transfer must include a transfer code, which should be determined by the platform, in compliance with local regulations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostTransferFunds(new PostTransferFundsRequest
    {
        Body = new TransferFundsRequest
        {
            Amount = new Amount { Currency = "EUR", Value = 2000L },
            DestinationAccountCode = "190324759",
            SourceAccountCode = "100000000",
            TransferCode = "TransferCode_1",
        },
    });
    // TODO: Handle 'response' of type TransferFundsResponse
}
catch (ApiException<PostTransferFundsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTransferFundsRequest](src/Adyen/Requests/General/PostTransferFundsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferFundsResponse](src/Adyen/Models/TransferFundsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTransferFundsError](src/Adyen/Errors/PostTransferFundsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetNotificationConfigurationResponse&gt; PostUpdateNotificationConfiguration(PostUpdateNotificationConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing notification subscription configuration. If you are updating the event types, you must provide all event types, otherwise the previous event type configuration will be overwritten.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostUpdateNotificationConfiguration(
        new PostUpdateNotificationConfigurationRequest
        {
            Body = new UpdateNotificationConfigurationRequest
            {
                ConfigurationDetails = new NotificationConfigurationDetails3
                {
                    Active = false,
                    Description = "Test notif config 756",
                    EventConfigs = [
                        new NotificationEventConfiguration
                        {
                            EventType = EventType.AccountHolderCreated,
                            IncludeMode = IncludeMode.Exclude,
                        },
                        new NotificationEventConfiguration
                        {
                            EventType = EventType.AccountCreated,
                            IncludeMode = IncludeMode.Include,
                        },
                    ],
                    NotificationId = 21259L,
                    NotifyPassword = "testPassword2",
                    NotifyUrl = "https://www.adyen.com/notification-handler",
                    NotifyUsername = "testUserName2",
                    SslProtocol = SslProtocol.TlSv13,
                },
            },
        });
    // TODO: Handle 'response' of type GetNotificationConfigurationResponse
}
catch (ApiException<PostUpdateNotificationConfigurationError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostUpdateNotificationConfigurationRequest](src/Adyen/Requests/General/PostUpdateNotificationConfigurationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetNotificationConfigurationResponse](src/Adyen/Models/GetNotificationConfigurationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostUpdateNotificationConfigurationError](src/Adyen/Errors/PostUpdateNotificationConfigurationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredValueVoidResponse&gt; PostVoidTransaction(PostVoidTransactionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Voids the referenced stored value transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.General.PostVoidTransaction(new PostVoidTransactionRequest());
    // TODO: Handle 'response' of type StoredValueVoidResponse
}
catch (ApiException<PostVoidTransactionError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostVoidTransactionRequest](src/Adyen/Requests/General/PostVoidTransactionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredValueVoidResponse](src/Adyen/Models/StoredValueVoidResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostVoidTransactionError](src/Adyen/Errors/PostVoidTransactionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GrantAccounts

> Source: [GrantAccounts](src/Adyen/Api/GrantAccounts.cs)

<details>
<summary><code>Task&lt;CapitalGrantAccount&gt; GetGrantAccountsId(GetGrantAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the [grant account](https://docs.adyen.com/platforms/capital#grant-account).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantAccounts.GetGrantAccountsId(new GetGrantAccountsIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type CapitalGrantAccount
}
catch (ApiException<GetGrantAccountsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrantAccountsIdRequest](src/Adyen/Requests/GrantAccounts/GetGrantAccountsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CapitalGrantAccount](src/Adyen/Models/CapitalGrantAccount.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrantAccountsIdError](src/Adyen/Errors/GetGrantAccountsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GrantAccount&gt; GetGrantAccountsId1(GetGrantAccountsId1Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the specified grant account. This account tracks existing grants in your marketplace or platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantAccounts.GetGrantAccountsId1(new GetGrantAccountsId1Request
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type GrantAccount
}
catch (ApiException<GetGrantAccountsId1Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrantAccountsId1Request](src/Adyen/Requests/GrantAccounts/GetGrantAccountsId1Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantAccount](src/Adyen/Models/GrantAccount.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrantAccountsId1Error](src/Adyen/Errors/GetGrantAccountsId1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GrantOffersApi

> Source: [GrantOffersApi](src/Adyen/Api/GrantOffersApi.cs)

<details>
<summary><code>Task&lt;GrantOffers&gt; GetGrantOffers(GetGrantOffersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all [grant offers](https://docs.adyen.com/platforms/capital#grant-offers) available for `accountHolderId` specified as a query parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantOffersApi.GetGrantOffers(new GetGrantOffersRequest
    {
        AccountHolderId = "some example string",
    });
    // TODO: Handle 'response' of type GrantOffers
}
catch (ApiException<GetGrantOffersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrantOffersRequest](src/Adyen/Requests/GrantOffersApi/GetGrantOffersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantOffers](src/Adyen/Models/GrantOffers.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrantOffersError](src/Adyen/Errors/GetGrantOffersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GrantOffer&gt; GetGrantOffersGrantOfferId(GetGrantOffersGrantOfferIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a single grant offer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantOffersApi.GetGrantOffersGrantOfferId(new GetGrantOffersGrantOfferIdRequest
    {
        GrantOfferId = "some example string",
    });
    // TODO: Handle 'response' of type GrantOffer
}
catch (ApiException<GetGrantOffersGrantOfferIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrantOffersGrantOfferIdRequest](src/Adyen/Requests/GrantOffersApi/GetGrantOffersGrantOfferIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantOffer](src/Adyen/Models/GrantOffer.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrantOffersGrantOfferIdError](src/Adyen/Errors/GetGrantOffersGrantOfferIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GrantOffer1&gt; GetGrantOffersId(GetGrantOffersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the specified static offer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantOffersApi.GetGrantOffersId(new GetGrantOffersIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type GrantOffer1
}
catch (ApiException<GetGrantOffersIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrantOffersIdRequest](src/Adyen/Requests/GrantOffersApi/GetGrantOffersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantOffer1](src/Adyen/Models/GrantOffer1.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrantOffersIdError](src/Adyen/Errors/GetGrantOffersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GrantOffers&gt; GetGrantOffers1(GetGrantOffers1Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all [static offers](https://docs.adyen.com/capital/get-grant-offers/static-offers) available for `accountHolderId` specified as a query parameter. This also includes static offers created for financing amounts that the user selected from [dynamic offers](https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantOffersApi.GetGrantOffers1(new GetGrantOffers1Request
    {
        AccountHolderId = "some example string",
    });
    // TODO: Handle 'response' of type GrantOffers
}
catch (ApiException<GetGrantOffers1Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrantOffers1Request](src/Adyen/Requests/GrantOffersApi/GetGrantOffers1Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GrantOffers](src/Adyen/Models/GrantOffers.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrantOffers1Error](src/Adyen/Errors/GetGrantOffers1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GrantsApi

> Source: [GrantsApi](src/Adyen/Api/GrantsApi.cs)

<details>
<summary><code>Task&lt;Grant&gt; GetGrantsGrantId(GetGrantsGrantIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the specified grant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.GetGrantsGrantId(new GetGrantsGrantIdRequest
    {
        GrantId = "some example string",
    });
    // TODO: Handle 'response' of type Grant
}
catch (ApiException<GetGrantsGrantIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrantsGrantIdRequest](src/Adyen/Requests/GrantsApi/GetGrantsGrantIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Grant](src/Adyen/Models/Grant.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrantsGrantIdError](src/Adyen/Errors/GetGrantsGrantIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Disbursements&gt; GetGrantsGrantIdDisbursements(GetGrantsGrantIdDisbursementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the disbursements of a specified grant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.GetGrantsGrantIdDisbursements(new GetGrantsGrantIdDisbursementsRequest
    {
        GrantId = "some example string",
    });
    // TODO: Handle 'response' of type Disbursements
}
catch (ApiException<GetGrantsGrantIdDisbursementsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrantsGrantIdDisbursementsRequest](src/Adyen/Requests/GrantsApi/GetGrantsGrantIdDisbursementsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Disbursements](src/Adyen/Models/Disbursements.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrantsGrantIdDisbursementsError](src/Adyen/Errors/GetGrantsGrantIdDisbursementsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Disbursement&gt; GetGrantsGrantIdDisbursementsDisbursementId(GetGrantsGrantIdDisbursementsDisbursementIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a disbursement specified in the path.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.GetGrantsGrantIdDisbursementsDisbursementId(
        new GetGrantsGrantIdDisbursementsDisbursementIdRequest
        {
            GrantId = "some example string",
            DisbursementId = "some example string",
        });
    // TODO: Handle 'response' of type Disbursement
}
catch (ApiException<GetGrantsGrantIdDisbursementsDisbursementIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrantsGrantIdDisbursementsDisbursementIdRequest](src/Adyen/Requests/GrantsApi/GetGrantsGrantIdDisbursementsDisbursementIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Disbursement](src/Adyen/Models/Disbursement.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrantsGrantIdDisbursementsDisbursementIdError](src/Adyen/Errors/GetGrantsGrantIdDisbursementsDisbursementIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Grants&gt; GetGrants2(GetGrants2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all the grants of a specific account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.GetGrants2(new GetGrants2Request
    {
        CounterpartyAccountHolderId = "some example string",
    });
    // TODO: Handle 'response' of type Grants
}
catch (ApiException<GetGrants2Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetGrants2Request](src/Adyen/Requests/GrantsApi/GetGrants2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Grants](src/Adyen/Models/Grants.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetGrants2Error](src/Adyen/Errors/GetGrants2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Disbursement&gt; PatchGrantsGrantIdDisbursementsDisbursementId(PatchGrantsGrantIdDisbursementsDisbursementIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the percentage of your user's net income that is deducted for repaying the grant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.PatchGrantsGrantIdDisbursementsDisbursementId(
        new PatchGrantsGrantIdDisbursementsDisbursementIdRequest
        {
            GrantId = "some example string",
            DisbursementId = "some example string",
            Body = new DisbursementInfoUpdate(),
        });
    // TODO: Handle 'response' of type Disbursement
}
catch (ApiException<PatchGrantsGrantIdDisbursementsDisbursementIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchGrantsGrantIdDisbursementsDisbursementIdRequest](src/Adyen/Requests/GrantsApi/PatchGrantsGrantIdDisbursementsDisbursementIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Disbursement](src/Adyen/Models/Disbursement.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchGrantsGrantIdDisbursementsDisbursementIdError](src/Adyen/Errors/PatchGrantsGrantIdDisbursementsDisbursementIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Grant&gt; PostGrants2(PostGrants2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Make a request for a grant on behalf of an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GrantsApi.PostGrants2(new PostGrants2Request());
    // TODO: Handle 'response' of type Grant
}
catch (ApiException<PostGrants2Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGrants2Request](src/Adyen/Requests/GrantsApi/PostGrants2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Grant](src/Adyen/Models/Grant.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGrants2Error](src/Adyen/Errors/PostGrants2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## HostedOnboarding

> Source: [HostedOnboarding](src/Adyen/Api/HostedOnboarding.cs)

<details>
<summary><code>Task&lt;OnboardingThemes&gt; GetThemes(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of hosted onboarding page themes.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HostedOnboarding.GetThemes();
    // TODO: Handle 'response' of type OnboardingThemes
}
catch (ApiException<GetThemesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnboardingThemes](src/Adyen/Models/OnboardingThemes.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetThemesError](src/Adyen/Errors/GetThemesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnboardingTheme&gt; GetThemesId(GetThemesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the theme identified in the path.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HostedOnboarding.GetThemesId(new GetThemesIdRequest { Id = "some example string" });
    // TODO: Handle 'response' of type OnboardingTheme
}
catch (ApiException<GetThemesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetThemesIdRequest](src/Adyen/Requests/HostedOnboarding/GetThemesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnboardingTheme](src/Adyen/Models/OnboardingTheme.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetThemesIdError](src/Adyen/Errors/GetThemesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnboardingLink&gt; PostLegalEntitiesIdOnboardingLinks(PostLegalEntitiesIdOnboardingLinksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a link to an Adyen-hosted onboarding page where you need to redirect your user.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HostedOnboarding.PostLegalEntitiesIdOnboardingLinks(
        new PostLegalEntitiesIdOnboardingLinksRequest
        {
            Id = "some example string",
            Body = new OnboardingLinkInfo
            {
                Locale = "nl-NL",
                RedirectUrl = "https://your-company.example.com",
                ThemeId = "YOUR_THEME_ID",
            },
        });
    // TODO: Handle 'response' of type OnboardingLink
}
catch (ApiException<PostLegalEntitiesIdOnboardingLinksError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLegalEntitiesIdOnboardingLinksRequest](src/Adyen/Requests/HostedOnboarding/PostLegalEntitiesIdOnboardingLinksRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnboardingLink](src/Adyen/Models/OnboardingLink.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostLegalEntitiesIdOnboardingLinksError](src/Adyen/Errors/PostLegalEntitiesIdOnboardingLinksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## HostedOnboardingPage

> Source: [HostedOnboardingPage](src/Adyen/Api/HostedOnboardingPage.cs)

<details>
<summary><code>Task&lt;GetOnboardingUrlResponse&gt; PostGetOnboardingUrl(PostGetOnboardingUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a link to an Adyen-hosted onboarding page (HOP) that you can send to your account holder. For more information on how to use HOP, refer to [Hosted onboarding](https://docs.adyen.com/classic-platforms/onboard-users/hosted-onboarding-page).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HostedOnboardingPage.PostGetOnboardingUrl(new PostGetOnboardingUrlRequest
    {
        Body = new GetOnboardingUrlRequest
        {
            AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
            ReturnUrl = "https://your.return-url.com/?submerchant=123",
        },
    });
    // TODO: Handle 'response' of type GetOnboardingUrlResponse
}
catch (ApiException<PostGetOnboardingUrlError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetOnboardingUrlRequest](src/Adyen/Requests/HostedOnboardingPage/PostGetOnboardingUrlRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetOnboardingUrlResponse](src/Adyen/Models/GetOnboardingUrlResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetOnboardingUrlError](src/Adyen/Errors/PostGetOnboardingUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Initialization

> Source: [Initialization](src/Adyen/Api/Initialization.cs)

<details>
<summary><code>Task&lt;StoreDetailResponse&gt; PostStoreDetail(PostStoreDetailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the [Transfers API](https://docs.adyen.com/api-explorer/transfers/latest/overview) instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


Stores payment details under the `PAYOUT` recurring contract. These payment details can be used later to submit a payout via the `/submitThirdParty` call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Initialization.PostStoreDetail(new PostStoreDetailRequest());
    // TODO: Handle 'response' of type StoreDetailResponse
}
catch (ApiException<PostStoreDetailError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostStoreDetailRequest](src/Adyen/Requests/Initialization/PostStoreDetailRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoreDetailResponse](src/Adyen/Models/StoreDetailResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostStoreDetailError](src/Adyen/Errors/PostStoreDetailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoreDetailAndSubmitResponse&gt; PostStoreDetailAndSubmitThirdParty(PostStoreDetailAndSubmitThirdPartyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the POST [/transfers](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers) endpoint instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


Submits a payout and stores its details for subsequent payouts.

The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Initialization.PostStoreDetailAndSubmitThirdParty(
        new PostStoreDetailAndSubmitThirdPartyRequest());
    // TODO: Handle 'response' of type StoreDetailAndSubmitResponse
}
catch (ApiException<PostStoreDetailAndSubmitThirdPartyError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostStoreDetailAndSubmitThirdPartyRequest](src/Adyen/Requests/Initialization/PostStoreDetailAndSubmitThirdPartyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoreDetailAndSubmitResponse](src/Adyen/Models/StoreDetailAndSubmitResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostStoreDetailAndSubmitThirdPartyError](src/Adyen/Errors/PostStoreDetailAndSubmitThirdPartyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubmitResponse&gt; PostSubmitThirdParty(PostSubmitThirdPartyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the POST [/transfers](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers) endpoint instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


Submits a payout using the previously stored payment details. To store payment details, use the `/storeDetail` API call.

The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Initialization.PostSubmitThirdParty(new PostSubmitThirdPartyRequest());
    // TODO: Handle 'response' of type SubmitResponse
}
catch (ApiException<PostSubmitThirdPartyError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostSubmitThirdPartyRequest](src/Adyen/Requests/Initialization/PostSubmitThirdPartyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubmitResponse](src/Adyen/Models/SubmitResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostSubmitThirdPartyError](src/Adyen/Errors/PostSubmitThirdPartyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## InstantPayouts

> Source: [InstantPayouts](src/Adyen/Api/InstantPayouts.cs)

<details>
<summary><code>Task&lt;PayoutResponse&gt; PostPayout(PostPayoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the POST [/transfers](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers) endpoint instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


With this call, you can pay out to your customers, and funds will be made available within 30 minutes on the cardholder's bank account (this is dependent on whether the issuer supports this functionality). Instant card payouts are only supported for Visa and Mastercard cards.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstantPayouts.PostPayout(new PostPayoutRequest
    {
        Body = new PayoutRequest
        {
            Amount = new Amount { Currency = "USD", Value = 2500L },
            BillingAddress = new Address
            {
                City = "Beverly Hills",
                Country = "US",
                HouseNumberOrName = "121",
                PostalCode = "90210",
                StateOrProvince = "CA",
                Street = "Brannan Street",
            },
            Card = new Card
            {
                ExpiryMonth = "03",
                ExpiryYear = "2030",
                HolderName = "John Smith",
                Number = "4111111111111111",
            },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "P9999999999999999",
            ShopperName = new Name { FirstName = "John", LastName = "Smith" },
        },
    });
    // TODO: Handle 'response' of type PayoutResponse
}
catch (ApiException<PostPayoutError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPayoutRequest](src/Adyen/Requests/InstantPayouts/PostPayoutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutResponse](src/Adyen/Models/PayoutResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPayoutError](src/Adyen/Errors/PostPayoutError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LegalEntities

> Source: [LegalEntities](src/Adyen/Api/LegalEntities.cs)

<details>
<summary><code>Task&lt;LegalEntity3&gt; GetLegalEntitiesId(GetLegalEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.GetLegalEntitiesId(new GetLegalEntitiesIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type LegalEntity3
}
catch (ApiException<GetLegalEntitiesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLegalEntitiesIdRequest](src/Adyen/Requests/LegalEntities/GetLegalEntitiesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LegalEntity3](src/Adyen/Models/LegalEntity3.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetLegalEntitiesIdError](src/Adyen/Errors/GetLegalEntitiesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BusinessLines&gt; GetLegalEntitiesIdBusinessLines(GetLegalEntitiesIdBusinessLinesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the business lines owned by a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.GetLegalEntitiesIdBusinessLines(new GetLegalEntitiesIdBusinessLinesRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type BusinessLines
}
catch (ApiException<GetLegalEntitiesIdBusinessLinesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLegalEntitiesIdBusinessLinesRequest](src/Adyen/Requests/LegalEntities/GetLegalEntitiesIdBusinessLinesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BusinessLines](src/Adyen/Models/BusinessLines.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetLegalEntitiesIdBusinessLinesError](src/Adyen/Errors/GetLegalEntitiesIdBusinessLinesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LegalEntity3&gt; PatchLegalEntitiesId(PatchLegalEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a legal entity.

 >To change the legal entity type, include only the new `type` in your request.

If you need to update information for the legal entity, make a separate request. To update the `entityAssociations` array, you need to replace the entire array.For example, if the array has 3 entries and you want to remove 1 entry, you need to PATCH the resource with the remaining 2 entries.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.PatchLegalEntitiesId(new PatchLegalEntitiesIdRequest
    {
        Id = "some example string",
        XRequestedVerificationCode = "0_0001",
        Body = new LegalEntityInfo { Type = Type182.Individual },
    });
    // TODO: Handle 'response' of type LegalEntity3
}
catch (ApiException<PatchLegalEntitiesIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchLegalEntitiesIdRequest](src/Adyen/Requests/LegalEntities/PatchLegalEntitiesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LegalEntity3](src/Adyen/Models/LegalEntity3.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchLegalEntitiesIdError](src/Adyen/Errors/PatchLegalEntitiesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LegalEntity3&gt; PostLegalEntities(PostLegalEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a legal entity. 

This resource contains information about the user that will be onboarded in your platform. Adyen uses this information to perform verification checks as required by payment industry regulations. Adyen informs you of the verification results through webhooks or API responses.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.PostLegalEntities(new PostLegalEntitiesRequest
    {
        XRequestedVerificationCode = "1_3004",
        Body = new LegalEntityInfoRequiredType
        {
            Individual = new Individual1
            {
                BirthData = new BirthData1 { DateOfBirth = "1991-01-01" },
                Email = "s.hopper@example.com",
                IdentificationData = new IdentificationData1
                {
                    CardNumber = "112327",
                    IssuerState = "NSW",
                    Number = "1234567891",
                    Type = Type132.DriversLicense,
                },
                Name = new Name23 { FirstName = "Shelly", LastName = "Eller" },
                ResidentialAddress = new Address13
                {
                    City = "Sydney",
                    Country = "AU",
                    PostalCode = "1122",
                    StateOrProvince = "NSW",
                    Street = "Winfield Avenue",
                    Street2 = "12",
                },
            },
            Type = Type213.Individual,
        },
    });
    // TODO: Handle 'response' of type LegalEntity3
}
catch (ApiException<PostLegalEntitiesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLegalEntitiesRequest](src/Adyen/Requests/LegalEntities/PostLegalEntitiesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LegalEntity3](src/Adyen/Models/LegalEntity3.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostLegalEntitiesError](src/Adyen/Errors/PostLegalEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VerificationErrors&gt; PostLegalEntitiesIdCheckVerificationErrors(PostLegalEntitiesIdCheckVerificationErrorsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the verification errors for a legal entity and its supporting entities.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.PostLegalEntitiesIdCheckVerificationErrors(
        new PostLegalEntitiesIdCheckVerificationErrorsRequest { Id = "some example string" });
    // TODO: Handle 'response' of type VerificationErrors
}
catch (ApiException<PostLegalEntitiesIdCheckVerificationErrorsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLegalEntitiesIdCheckVerificationErrorsRequest](src/Adyen/Requests/LegalEntities/PostLegalEntitiesIdCheckVerificationErrorsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VerificationErrors](src/Adyen/Models/VerificationErrors.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostLegalEntitiesIdCheckVerificationErrorsError](src/Adyen/Errors/PostLegalEntitiesIdCheckVerificationErrorsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DataReviewConfirmationResponse&gt; PostLegalEntitiesIdConfirmDataReview(PostLegalEntitiesIdConfirmDataReviewRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Confirms that your user has reviewed the data for the legal entity specified in the path. Call this endpoint to inform Adyen that your user reviewed and verified that the data is up-to-date. The endpoint returns the timestamp of when Adyen received the request.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.PostLegalEntitiesIdConfirmDataReview(
        new PostLegalEntitiesIdConfirmDataReviewRequest { Id = "some example string" });
    // TODO: Handle 'response' of type DataReviewConfirmationResponse
}
catch (ApiException<PostLegalEntitiesIdConfirmDataReviewError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLegalEntitiesIdConfirmDataReviewRequest](src/Adyen/Requests/LegalEntities/PostLegalEntitiesIdConfirmDataReviewRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DataReviewConfirmationResponse](src/Adyen/Models/DataReviewConfirmationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostLegalEntitiesIdConfirmDataReviewError](src/Adyen/Errors/PostLegalEntitiesIdConfirmDataReviewError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;JsonElement&gt; PostLegalEntitiesIdRequestPeriodicReview(PostLegalEntitiesIdRequestPeriodicReviewRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Requests a periodic data review for the legal entity of the user specified in the path.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LegalEntities.PostLegalEntitiesIdRequestPeriodicReview(
        new PostLegalEntitiesIdRequestPeriodicReviewRequest { Id = "some example string" });
    // TODO: Handle 'response' of type JsonElement
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLegalEntitiesIdRequestPeriodicReviewRequest](src/Adyen/Requests/LegalEntities/PostLegalEntitiesIdRequestPeriodicReviewRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageScaDevices

> Source: [ManageScaDevices](src/Adyen/Api/ManageScaDevices.cs)

<details>
<summary><code>Task DeleteRegisteredDevicesId(DeleteRegisteredDevicesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an SCA device from the list of registered devices of a specific payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ManageScaDevices.DeleteRegisteredDevicesId(new DeleteRegisteredDevicesIdRequest
    {
        Id = "some example string",
        PaymentInstrumentId = "some example string",
    });
}
catch (ApiException<DeleteRegisteredDevicesIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteRegisteredDevicesIdRequest](src/Adyen/Requests/ManageScaDevices/DeleteRegisteredDevicesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteRegisteredDevicesIdError](src/Adyen/Errors/DeleteRegisteredDevicesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchRegisteredDevicesResponse&gt; GetRegisteredDevices(GetRegisteredDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a paginated list of the SCA devices you have currently registered for a specific payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageScaDevices.GetRegisteredDevices(new GetRegisteredDevicesRequest
    {
        PaymentInstrumentId = "some example string",
    });
    // TODO: Handle 'response' of type SearchRegisteredDevicesResponse
}
catch (ApiException<GetRegisteredDevicesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRegisteredDevicesRequest](src/Adyen/Requests/ManageScaDevices/GetRegisteredDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchRegisteredDevicesResponse](src/Adyen/Models/SearchRegisteredDevicesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetRegisteredDevicesError](src/Adyen/Errors/GetRegisteredDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssociationFinaliseResponse&gt; PatchRegisteredDevicesDeviceIdAssociations(PatchRegisteredDevicesDeviceIdAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Completes an association between a user's registered SCA device and an Adyen resource. For example, you can associate an SCA device with additional [business accounts](https://docs.adyen.com/platforms/business-accounts/sca/register-devices) or [Adyen-issued cards](https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices).

To complete the association, this endpoint validates the authentication data of the registered device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageScaDevices.PatchRegisteredDevicesDeviceIdAssociations(
        new PatchRegisteredDevicesDeviceIdAssociationsRequest { DeviceId = "some example string" });
    // TODO: Handle 'response' of type AssociationFinaliseResponse
}
catch (ApiException<PatchRegisteredDevicesDeviceIdAssociationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchRegisteredDevicesDeviceIdAssociationsRequest](src/Adyen/Requests/ManageScaDevices/PatchRegisteredDevicesDeviceIdAssociationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssociationFinaliseResponse](src/Adyen/Models/AssociationFinaliseResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchRegisteredDevicesDeviceIdAssociationsError](src/Adyen/Errors/PatchRegisteredDevicesDeviceIdAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RegisterScaFinalResponse&gt; PatchRegisteredDevicesId(PatchRegisteredDevicesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Completes the registration of an SCA device by validating the authentication data of the device. You can register SCA devices for [business accounts](https://docs.adyen.com/platforms/business-accounts/sca) or [Adyen-issued cards](https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageScaDevices.PatchRegisteredDevicesId(new PatchRegisteredDevicesIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type RegisterScaFinalResponse
}
catch (ApiException<PatchRegisteredDevicesIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchRegisteredDevicesIdRequest](src/Adyen/Requests/ManageScaDevices/PatchRegisteredDevicesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegisterScaFinalResponse](src/Adyen/Models/RegisterScaFinalResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchRegisteredDevicesIdError](src/Adyen/Errors/PatchRegisteredDevicesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RegisterScaResponse&gt; PostRegisteredDevices(PostRegisteredDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates the registration of a user's device for Strong Customer Authentication (SCA). You can register SCA devices for [business accounts](https://docs.adyen.com/platforms/business-accounts/sca/register-devices) or [Adyen-issued cards](https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices).

For a successful request, the device must be eligible for SCA.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageScaDevices.PostRegisteredDevices(new PostRegisteredDevicesRequest());
    // TODO: Handle 'response' of type RegisterScaResponse
}
catch (ApiException<PostRegisteredDevicesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostRegisteredDevicesRequest](src/Adyen/Requests/ManageScaDevices/PostRegisteredDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegisterScaResponse](src/Adyen/Models/RegisterScaResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostRegisteredDevicesError](src/Adyen/Errors/PostRegisteredDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssociationInitiateResponse&gt; PostRegisteredDevicesDeviceIdAssociations(PostRegisteredDevicesDeviceIdAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates an association between a user's registered SCA device and an Adyen resource. For example, you can associate an SCA device with additional [business accounts](https://docs.adyen.com/platforms/business-accounts/sca/register-devices) or [Adyen-issued cards](https://docs.adyen.com/issuing/3d-secure/oob-auth-sdk/register-devices).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageScaDevices.PostRegisteredDevicesDeviceIdAssociations(
        new PostRegisteredDevicesDeviceIdAssociationsRequest { DeviceId = "some example string" });
    // TODO: Handle 'response' of type AssociationInitiateResponse
}
catch (ApiException<PostRegisteredDevicesDeviceIdAssociationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostRegisteredDevicesDeviceIdAssociationsRequest](src/Adyen/Requests/ManageScaDevices/PostRegisteredDevicesDeviceIdAssociationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssociationInitiateResponse](src/Adyen/Models/AssociationInitiateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostRegisteredDevicesDeviceIdAssociationsError](src/Adyen/Errors/PostRegisteredDevicesDeviceIdAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManageCardPin

> Source: [ManageCardPin](src/Adyen/Api/ManageCardPin.cs)

<details>
<summary><code>Task&lt;PublicKeyResponse&gt; GetPublicKey(GetPublicKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get an [RSA](https://en.wikipedia.org/wiki/RSA_(cryptosystem)) public key to encrypt or decrypt card data.

 You need the RSA public key to generate the `encryptedKey` required to:
- [Change a PIN](https://docs.adyen.com/api-explorer/balanceplatform/2/post/pins/change).
- [Reveal a PIN](https://docs.adyen.com/api-explorer/balanceplatform/2/post/pins/reveal).
- [Reveal a PAN](https://docs.adyen.com/api-explorer/balanceplatform/2/post/paymentInstruments/reveal).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageCardPin.GetPublicKey(new GetPublicKeyRequest());
    // TODO: Handle 'response' of type PublicKeyResponse
}
catch (ApiException<GetPublicKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPublicKeyRequest](src/Adyen/Requests/ManageCardPin/GetPublicKeyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicKeyResponse](src/Adyen/Models/PublicKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetPublicKeyError](src/Adyen/Errors/GetPublicKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PinChangeResponse&gt; PostPinsChange(PostPinsChangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the personal identification number (PIN) of a specified card.

To make this request, your API credential must have the following role:
* Bank Issuing PIN Change Webservice role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageCardPin.PostPinsChange(new PostPinsChangeRequest
    {
        Body = new PinChangeRequest
        {
            EncryptedKey = "75989E8881284D10153ABACF022EEA09F5...",
            EncryptedPinBlock = "63E5060591EF65F48DD1D4FECD0FECD5",
            PaymentInstrumentId = "PI6789678967896789",
            Token = "5555341244441115",
        },
    });
    // TODO: Handle 'response' of type PinChangeResponse
}
catch (ApiException<PostPinsChangeError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPinsChangeRequest](src/Adyen/Requests/ManageCardPin/PostPinsChangeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PinChangeResponse](src/Adyen/Models/PinChangeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPinsChangeError](src/Adyen/Errors/PostPinsChangeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevealPinResponse&gt; PostPinsReveal(PostPinsRevealRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an encrypted PIN block that contains the PIN of a specified card. You can use the decrypted data to reveal the PIN in your user interface.

To make this request, your API credential must have the following role:
* Bank Issuing PIN Reveal Webservice role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManageCardPin.PostPinsReveal(new PostPinsRevealRequest
    {
        Body = new RevealPinRequest
        {
            EncryptedKey = "75989E8881284D10153ABACF022EEA09F5...",
            PaymentInstrumentId = "PI3227C223222B5BPCMFXD2XG",
        },
    });
    // TODO: Handle 'response' of type RevealPinResponse
}
catch (ApiException<PostPinsRevealError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPinsRevealRequest](src/Adyen/Requests/ManageCardPin/PostPinsRevealRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevealPinResponse](src/Adyen/Models/RevealPinResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPinsRevealError](src/Adyen/Errors/PostPinsRevealError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ManagedPayoutSchedules

> Source: [ManagedPayoutSchedules](src/Adyen/Api/ManagedPayoutSchedules.cs)

<details>
<summary><code>Task DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesId(DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a payout schedule applied to a balance account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ManagedPayoutSchedules.DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesId(
        new DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest
        {
            BalanceAccountId = "some example string",
            Id = "some example string",
        });
}
catch (ApiException<DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest](src/Adyen/Requests/ManagedPayoutSchedules/DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError](src/Adyen/Errors/DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccountConfigurations&gt; GetBalanceAccountsBalanceAccountIdPayoutSchedules(GetBalanceAccountsBalanceAccountIdPayoutSchedulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all managed payout schedules that are configured on a balance account. You can use query parameters to filter the elements that are returned in the list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.GetBalanceAccountsBalanceAccountIdPayoutSchedules(
        new GetBalanceAccountsBalanceAccountIdPayoutSchedulesRequest { BalanceAccountId = "some example string" });
    // TODO: Handle 'response' of type BalanceAccountConfigurations
}
catch (ApiException<GetBalanceAccountsBalanceAccountIdPayoutSchedulesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsBalanceAccountIdPayoutSchedulesRequest](src/Adyen/Requests/ManagedPayoutSchedules/GetBalanceAccountsBalanceAccountIdPayoutSchedulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccountConfigurations](src/Adyen/Models/BalanceAccountConfigurations.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsBalanceAccountIdPayoutSchedulesError](src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdPayoutSchedulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccountConfiguration&gt; GetBalanceAccountsBalanceAccountIdPayoutSchedulesId(GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the specified payout schedule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.GetBalanceAccountsBalanceAccountIdPayoutSchedulesId(
        new GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest
        {
            BalanceAccountId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type BalanceAccountConfiguration
}
catch (ApiException<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest](src/Adyen/Requests/ManagedPayoutSchedules/GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccountConfiguration](src/Adyen/Models/BalanceAccountConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError](src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutScheduleExecutions&gt; GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutions(GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

View information about the executions of a managed payout schedule on the specified balance account. An execution is an attempt to make a payout according to the payout schedule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutions(
        new GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsRequest
        {
            BalanceAccountId = "some example string",
            Id = "some example string",
            Offset = 1,
        });
    // TODO: Handle 'response' of type PayoutScheduleExecutions
}
catch (ApiException<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsRequest](src/Adyen/Requests/ManagedPayoutSchedules/GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutScheduleExecutions](src/Adyen/Models/PayoutScheduleExecutions.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError](src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalancePlatformConfigurations&gt; GetBalancePlatformsBalancePlatformIdPayoutSchedules(GetBalancePlatformsBalancePlatformIdPayoutSchedulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all the payout schedules that are configured for your balance platform. You can use query parameters to filter the elements that are returned in the list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.GetBalancePlatformsBalancePlatformIdPayoutSchedules(
        new GetBalancePlatformsBalancePlatformIdPayoutSchedulesRequest { BalancePlatformId = "some example string" });
    // TODO: Handle 'response' of type BalancePlatformConfigurations
}
catch (ApiException<GetBalancePlatformsBalancePlatformIdPayoutSchedulesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalancePlatformsBalancePlatformIdPayoutSchedulesRequest](src/Adyen/Requests/ManagedPayoutSchedules/GetBalancePlatformsBalancePlatformIdPayoutSchedulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalancePlatformConfigurations](src/Adyen/Models/BalancePlatformConfigurations.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalancePlatformsBalancePlatformIdPayoutSchedulesError](src/Adyen/Errors/GetBalancePlatformsBalancePlatformIdPayoutSchedulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalancePlatformConfiguration&gt; GetBalancePlatformsBalancePlatformIdPayoutSchedulesId(GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the specified managed payout schedule configured on your balance platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.GetBalancePlatformsBalancePlatformIdPayoutSchedulesId(
        new GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdRequest
        {
            BalancePlatformId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type BalancePlatformConfiguration
}
catch (ApiException<GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdRequest](src/Adyen/Requests/ManagedPayoutSchedules/GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalancePlatformConfiguration](src/Adyen/Models/BalancePlatformConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError](src/Adyen/Errors/GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccountConfiguration&gt; PatchBalanceAccountsBalanceAccountIdPayoutSchedulesId(PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a managed payout schedule applied to a balance account. If an optional parameter is not included in the request, it remains unchanged.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.PatchBalanceAccountsBalanceAccountIdPayoutSchedulesId(
        new PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest
        {
            BalanceAccountId = "some example string",
            Id = "some example string",
            Body = new BalanceAccountConfigurationUpdate
            {
                Description = "Updated payout description",
                Enabled = false,
                RetainedAmount = 20000L,
            },
        });
    // TODO: Handle 'response' of type BalanceAccountConfiguration
}
catch (ApiException<PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest](src/Adyen/Requests/ManagedPayoutSchedules/PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccountConfiguration](src/Adyen/Models/BalanceAccountConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError](src/Adyen/Errors/PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceAccountConfiguration&gt; PostBalanceAccountsBalanceAccountIdPayoutSchedules(PostBalanceAccountsBalanceAccountIdPayoutSchedulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Apply a managed payout schedule to a balance account. This payout schedule is based on an existing payout schedule in your balance platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ManagedPayoutSchedules.PostBalanceAccountsBalanceAccountIdPayoutSchedules(
        new PostBalanceAccountsBalanceAccountIdPayoutSchedulesRequest
        {
            BalanceAccountId = "some example string",
            Body = new BalanceAccountConfigurationRequest
            {
                BalancePlatformPayoutScheduleId = "PSPC00000000000000000000000001",
                Currency = "EUR",
                Description = "Scheduled payout to merchant bank account",
                Enabled = true,
                Frequency = Frequency1.Monthly,
                FrequencyValue = 1,
                MaxPayoutAmount = 100000000L,
                MinPayoutAmount = 1000L,
                Reference = "Monthly payout",
                ReferenceForBeneficiary = "PAYOUT-REF-001",
                RetainedAmount = 10000L,
                TransferInstrumentId = "SE00000000000000000000001",
            },
        });
    // TODO: Handle 'response' of type BalanceAccountConfiguration
}
catch (ApiException<PostBalanceAccountsBalanceAccountIdPayoutSchedulesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostBalanceAccountsBalanceAccountIdPayoutSchedulesRequest](src/Adyen/Requests/ManagedPayoutSchedules/PostBalanceAccountsBalanceAccountIdPayoutSchedulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceAccountConfiguration](src/Adyen/Models/BalanceAccountConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostBalanceAccountsBalanceAccountIdPayoutSchedulesError](src/Adyen/Errors/PostBalanceAccountsBalanceAccountIdPayoutSchedulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Modifications

> Source: [Modifications](src/Adyen/Api/Modifications.cs)

<details>
<summary><code>Task&lt;ModificationResult&gt; PostAdjustAuthorisation(PostAdjustAuthorisationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows you to increase or decrease the authorised amount after the initial authorisation has taken place. This functionality enables for example tipping, improving the chances your authorisation will be valid, or charging the shopper when they have already left the merchant premises.

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/{paymentPspReference}/amountUpdates`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference)/amountUpdates) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

>The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostAdjustAuthorisation(new PostAdjustAuthorisationRequest
    {
        Body = new AdjustAuthorisationRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            ModificationAmount = new Amount { Currency = "USD", Value = 1700L },
            OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
            Reference = "YourModificationReference",
        },
    });
    // TODO: Handle 'response' of type ModificationResult
}
catch (ApiException<PostAdjustAuthorisationError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAdjustAuthorisationRequest](src/Adyen/Requests/Modifications/PostAdjustAuthorisationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](src/Adyen/Models/ModificationResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostAdjustAuthorisationError](src/Adyen/Errors/PostAdjustAuthorisationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostCancel(PostCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the authorisation hold on a payment, returning a unique reference for this request. You can cancel payments after authorisation only for payment methods that support distinct authorisations and captures.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel).

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference)/cancels) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostCancel(new PostCancelRequest
    {
        Body = new CancelRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
            Reference = "YourModificationReference",
        },
    });
    // TODO: Handle 'response' of type ModificationResult
}
catch (ApiException<PostCancelError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCancelRequest](src/Adyen/Requests/Modifications/PostCancelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](src/Adyen/Models/ModificationResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCancelError](src/Adyen/Errors/PostCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostCancelOrRefund(PostCancelOrRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels a payment if it has not been captured yet, or refunds it if it has already been captured. This is useful when it is not certain if the payment has been captured or not (for example, when using auto-capture).

Do not use this endpoint for payments that involve:
 * [Multiple partial captures](https://docs.adyen.com/online-payments/capture).
 * [Split data](https://docs.adyen.com/classic-platforms/processing-payments#providing-split-information) either at time of payment or capture for Adyen for Platforms.

 Instead, check if the payment has been captured and make a corresponding [`/refund`](https://docs.adyen.com/api-explorer/#/Payment/refund) or [`/cancel`](https://docs.adyen.com/api-explorer/#/Payment/cancel) call.

For more information, refer to [Cancel or refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel-or-refund).

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference)/reversals) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostCancelOrRefund(new PostCancelOrRefundRequest
    {
        Body = new CancelOrRefundRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
            Reference = "YourModificationReference",
        },
    });
    // TODO: Handle 'response' of type ModificationResult
}
catch (ApiException<PostCancelOrRefundError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCancelOrRefundRequest](src/Adyen/Requests/Modifications/PostCancelOrRefundRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](src/Adyen/Models/ModificationResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCancelOrRefundError](src/Adyen/Errors/PostCancelOrRefundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StandalonePaymentCancelResponse&gt; PostCancels(PostCancelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**TECHNICAL_CANCEL** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).

If you want to cancel a payment using the [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference), use the [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) endpoint instead.

If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostCancels(new PostCancelsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new StandalonePaymentCancelRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PaymentReference = "YOUR_UNIQUE_REFERENCE_FOR_THE_PAYMENT",
            Reference = "YOUR_UNIQUE_REFERENCE_FOR_THE_CANCELLATION",
        },
    });
    // TODO: Handle 'response' of type StandalonePaymentCancelResponse
}
catch (ApiException<PostCancelsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCancelsRequest](src/Adyen/Requests/Modifications/PostCancelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StandalonePaymentCancelResponse](src/Adyen/Models/StandalonePaymentCancelResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCancelsError](src/Adyen/Errors/PostCancelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostCapture(PostCaptureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Captures the authorisation hold on a payment, returning a unique reference for this request. Usually the full authorisation amount is captured, however it's also possible to capture a smaller amount, which results in cancelling the remaining authorisation balance.

Payment methods that are captured automatically after authorisation don't need to be captured. However, submitting a capture request on these transactions will not result in double charges. If immediate or delayed auto-capture is enabled, calling the capture method is not necessary.

For more information refer to [Capture](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/capture).

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/{paymentPspReference}/captures`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference)/captures) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostCapture(new PostCaptureRequest
    {
        Body = new CaptureRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            ModificationAmount = new Amount { Currency = "EUR", Value = 500L },
            OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
            Reference = "YOUR_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type ModificationResult
}
catch (ApiException<PostCaptureError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCaptureRequest](src/Adyen/Requests/Modifications/PostCaptureRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](src/Adyen/Models/ModificationResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCaptureError](src/Adyen/Errors/PostCaptureError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostDonate(PostDonateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a new payment to be created (including a new authorisation request) for the specified donation using the payment details of the original payment.

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/donations`](https://docs.adyen.com/api-explorer/Checkout/latest/post/donations) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostDonate(new PostDonateRequest
    {
        Body = new DonationRequest
        {
            DonationAccount = "AdyenGivingDemo",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            ModificationAmount = new Amount { Currency = "EUR", Value = 500L },
            OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
            Reference = "YOUR_DONATION_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type ModificationResult
}
catch (ApiException<PostDonateError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDonateRequest](src/Adyen/Requests/Modifications/PostDonateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](src/Adyen/Models/ModificationResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDonateError](src/Adyen/Errors/PostDonateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentAmountUpdateResponse&gt; PostPaymentsPaymentPspReferenceAmountUpdates(PostPaymentsPaymentPspReferenceAmountUpdatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Increases or decreases the authorised payment amount and returns a unique reference for this request. You get the outcome of the request asynchronously, in an [**AUTHORISATION_ADJUSTMENT** webhook](https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes).

You can only update authorised amounts that have not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures).

The amount you specify in the request is the updated amount, which is larger or smaller than the initial authorised amount.

For more information, refer to [Authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#use-cases).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostPaymentsPaymentPspReferenceAmountUpdates(
        new PostPaymentsPaymentPspReferenceAmountUpdatesRequest
        {
            PaymentPspReference = "some example string",
            IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
            Body = new PaymentAmountUpdateRequest
            {
                Amount = new Amount29 { Currency = "EUR", Value = 2500L },
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Reference = "YOUR_UNIQUE_REFERENCE",
            },
        });
    // TODO: Handle 'response' of type PaymentAmountUpdateResponse
}
catch (ApiException<PostPaymentsPaymentPspReferenceAmountUpdatesError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentsPaymentPspReferenceAmountUpdatesRequest](src/Adyen/Requests/Modifications/PostPaymentsPaymentPspReferenceAmountUpdatesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentAmountUpdateResponse](src/Adyen/Models/PaymentAmountUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentsPaymentPspReferenceAmountUpdatesError](src/Adyen/Errors/PostPaymentsPaymentPspReferenceAmountUpdatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentCancelResponse&gt; PostPaymentsPaymentPspReferenceCancels(PostPaymentsPaymentPspReferenceCancelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCELLATION** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).

If you want to cancel a payment but don't have the [`pspReference`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference), use the [`/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cancels) endpoint instead.

If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostPaymentsPaymentPspReferenceCancels(
        new PostPaymentsPaymentPspReferenceCancelsRequest
        {
            PaymentPspReference = "some example string",
            IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
            Body = new PaymentCancelRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Reference = "YOUR_UNIQUE_REFERENCE",
            },
        });
    // TODO: Handle 'response' of type PaymentCancelResponse
}
catch (ApiException<PostPaymentsPaymentPspReferenceCancelsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentsPaymentPspReferenceCancelsRequest](src/Adyen/Requests/Modifications/PostPaymentsPaymentPspReferenceCancelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentCancelResponse](src/Adyen/Models/PaymentCancelResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentsPaymentPspReferenceCancelsError](src/Adyen/Errors/PostPaymentsPaymentPspReferenceCancelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentCaptureResponse&gt; PostPaymentsPaymentPspReferenceCaptures(PostPaymentsPaymentPspReferenceCapturesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Captures an authorised payment and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CAPTURE** webhook](https://docs.adyen.com/online-payments/capture#capture-notification).

You can capture either the full authorised amount or a part of the authorised amount. By default, any unclaimed amount after a partial capture gets cancelled. This does not apply if you enabled multiple partial captures on your account and the payment method supports multiple partial captures. 

[Automatic capture](https://docs.adyen.com/online-payments/capture#automatic-capture) is the default setting for most payment methods. In these cases, you don't need to make capture requests. However, making capture requests for payments that are captured automatically does not result in double charges.

For more information, refer to [Capture](https://docs.adyen.com/online-payments/capture).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostPaymentsPaymentPspReferenceCaptures(
        new PostPaymentsPaymentPspReferenceCapturesRequest
        {
            PaymentPspReference = "some example string",
            IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
            Body = new PaymentCaptureRequest
            {
                Amount = new Amount31 { Currency = "EUR", Value = 2000L },
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Reference = "YOUR_UNIQUE_REFERENCE",
            },
        });
    // TODO: Handle 'response' of type PaymentCaptureResponse
}
catch (ApiException<PostPaymentsPaymentPspReferenceCapturesError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentsPaymentPspReferenceCapturesRequest](src/Adyen/Requests/Modifications/PostPaymentsPaymentPspReferenceCapturesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentCaptureResponse](src/Adyen/Models/PaymentCaptureResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentsPaymentPspReferenceCapturesError](src/Adyen/Errors/PostPaymentsPaymentPspReferenceCapturesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentRefundResponse&gt; PostPaymentsPaymentPspReferenceRefunds(PostPaymentsPaymentPspReferenceRefundsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds a payment that has been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**REFUND** webhook](https://docs.adyen.com/online-payments/refund#refund-webhook).

You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.

> Some payment methods do not support partial refunds. To learn if a payment method supports partial refunds, refer to the payment method page such as [cards](https://docs.adyen.com/payment-methods/cards#supported-cards), [iDEAL](https://docs.adyen.com/payment-methods/ideal), or [Klarna](https://docs.adyen.com/payment-methods/klarna). 

If you want to refund a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Refund](https://docs.adyen.com/online-payments/refund).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostPaymentsPaymentPspReferenceRefunds(
        new PostPaymentsPaymentPspReferenceRefundsRequest
        {
            PaymentPspReference = "some example string",
            IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
            Body = new PaymentRefundRequest
            {
                Amount = new Amount38 { Currency = "EUR", Value = 2500L },
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Reference = "YOUR_UNIQUE_REFERENCE",
            },
        });
    // TODO: Handle 'response' of type PaymentRefundResponse
}
catch (ApiException<PostPaymentsPaymentPspReferenceRefundsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentsPaymentPspReferenceRefundsRequest](src/Adyen/Requests/Modifications/PostPaymentsPaymentPspReferenceRefundsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentRefundResponse](src/Adyen/Models/PaymentRefundResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentsPaymentPspReferenceRefundsError](src/Adyen/Errors/PostPaymentsPaymentPspReferenceRefundsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentReversalResponse&gt; PostPaymentsPaymentPspReferenceReversals(PostPaymentsPaymentPspReferenceReversalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

[Refunds](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/refunds) a payment if it has already been captured, and [cancels](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) a payment if it has not yet been captured. Returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCEL_OR_REFUND** webhook](https://docs.adyen.com/online-payments/reversal/#cancel-or-refund-webhook).

The reversed amount is always the full payment amount.
> Do not use this request for payments that involve multiple partial captures.

For more information, refer to [Reversal](https://docs.adyen.com/online-payments/reversal).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostPaymentsPaymentPspReferenceReversals(
        new PostPaymentsPaymentPspReferenceReversalsRequest
        {
            PaymentPspReference = "some example string",
            IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
            Body = new PaymentReversalRequest
            {
                MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
                Reference = "YOUR_UNIQUE_REFERENCE",
            },
        });
    // TODO: Handle 'response' of type PaymentReversalResponse
}
catch (ApiException<PostPaymentsPaymentPspReferenceReversalsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentsPaymentPspReferenceReversalsRequest](src/Adyen/Requests/Modifications/PostPaymentsPaymentPspReferenceReversalsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentReversalResponse](src/Adyen/Models/PaymentReversalResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentsPaymentPspReferenceReversalsError](src/Adyen/Errors/PostPaymentsPaymentPspReferenceReversalsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostRefund(PostRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds a payment that has previously been captured, returning a unique reference for this request. Refunding can be done on the full captured amount or a partial amount. Multiple (partial) refunds will be accepted as long as their sum doesn't exceed the captured amount. Payments which have been authorised, but not captured, cannot be refunded, use the /cancel method instead.

Some payment methods/gateways do not support partial/multiple refunds.
A margin above the captured limit can be configured to cover shipping/handling costs.

For more information, refer to [Refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/refund).

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/{paymentPspReference}/refunds`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference)/refunds) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostRefund(new PostRefundRequest
    {
        Body = new RefundRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            ModificationAmount = new Amount { Currency = "EUR", Value = 500L },
            OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
            Reference = "YOUR_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type ModificationResult
}
catch (ApiException<PostRefundError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostRefundRequest](src/Adyen/Requests/Modifications/PostRefundRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](src/Adyen/Models/ModificationResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostRefundError](src/Adyen/Errors/PostRefundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostTechnicalCancel(PostTechnicalCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to cancel a payment if you do not have the PSP reference of the original payment request available.

In your call, refer to the original payment by using the `reference` that you specified in your payment request.

For more information, see [Technical cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel#technical-cancel). 

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/cancels`](https://docs.adyen.com/api-explorer/Checkout/latest/post/cancels) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostTechnicalCancel(new PostTechnicalCancelRequest
    {
        Body = new TechnicalCancelRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            OriginalMerchantReference = "YOUR_MERCHANT_REFERENCE",
            Reference = "YOUR_MODIFICATION_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type ModificationResult
}
catch (ApiException<PostTechnicalCancelError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTechnicalCancelRequest](src/Adyen/Requests/Modifications/PostTechnicalCancelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](src/Adyen/Models/ModificationResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTechnicalCancelError](src/Adyen/Errors/PostTechnicalCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModificationResult&gt; PostVoidPendingRefund(PostVoidPendingRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to cancel an unreferenced refund request before it has been completed.

In your call, you can refer to the original refund request either by using the `tenderReference`, or the `pspReference`. We recommend implementing based on the `tenderReference`, as this is generated for both offline and online transactions.

For more information, refer to [Cancel an unreferenced refund](https://docs.adyen.com/point-of-sale/basic-tapi-integration/refund-payment/cancel-unreferenced).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Modifications.PostVoidPendingRefund(new PostVoidPendingRefundRequest
    {
        Body = new VoidPendingRefundRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            OriginalReference = "9914748988390044",
        },
    });
    // TODO: Handle 'response' of type ModificationResult
}
catch (ApiException<PostVoidPendingRefundError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostVoidPendingRefundRequest](src/Adyen/Requests/Modifications/PostVoidPendingRefundRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModificationResult](src/Adyen/Models/ModificationResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostVoidPendingRefundError](src/Adyen/Errors/PostVoidPendingRefundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MyApiCredential

> Source: [MyApiCredential](src/Adyen/Api/MyApiCredential.cs)

<details>
<summary><code>Task DeleteMeAllowedOriginsOriginId(DeleteMeAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) specified in the path.
The API key from the request is used to identify the [API credential](https://docs.adyen.com/development-resources/api-credentials).

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.MyApiCredential.DeleteMeAllowedOriginsOriginId(new DeleteMeAllowedOriginsOriginIdRequest
    {
        OriginId = "some example string",
    });
}
catch (ApiException<DeleteMeAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMeAllowedOriginsOriginIdRequest](src/Adyen/Requests/MyApiCredential/DeleteMeAllowedOriginsOriginIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteMeAllowedOriginsOriginIdError](src/Adyen/Errors/DeleteMeAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MeApiCredential&gt; GetMe(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns your [API credential](https://docs.adyen.com/development-resources/api-credentials) details based on the API Key you used in the request.

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.GetMe();
    // TODO: Handle 'response' of type MeApiCredential
}
catch (ApiException<GetMeError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MeApiCredential](src/Adyen/Models/MeApiCredential.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMeError](src/Adyen/Errors/GetMeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOriginsResponse&gt; GetMeAllowedOrigins(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) of your [API credential](https://docs.adyen.com/development-resources/api-credentials) based on the API key you used in the request.

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.GetMeAllowedOrigins();
    // TODO: Handle 'response' of type AllowedOriginsResponse
}
catch (ApiException<GetMeAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOriginsResponse](src/Adyen/Models/AllowedOriginsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMeAllowedOriginsError](src/Adyen/Errors/GetMeAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; GetMeAllowedOriginsOriginId(GetMeAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the [allowed origin](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) specified in the path.
The API key from the request is used to identify the [API credential](https://docs.adyen.com/development-resources/api-credentials).

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.GetMeAllowedOriginsOriginId(new GetMeAllowedOriginsOriginIdRequest
    {
        OriginId = "some example string",
    });
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<GetMeAllowedOriginsOriginIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMeAllowedOriginsOriginIdRequest](src/Adyen/Requests/MyApiCredential/GetMeAllowedOriginsOriginIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/Adyen/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMeAllowedOriginsOriginIdError](src/Adyen/Errors/GetMeAllowedOriginsOriginIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AllowedOrigin&gt; PostMeAllowedOrigins(PostMeAllowedOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds an allowed origin to the list of [allowed origins](https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins) of your API credential.
The API key from the request is used to identify the [API credential](https://docs.adyen.com/development-resources/api-credentials).

You can make this request with any of the Management API roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.PostMeAllowedOrigins(new PostMeAllowedOriginsRequest());
    // TODO: Handle 'response' of type AllowedOrigin
}
catch (ApiException<PostMeAllowedOriginsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMeAllowedOriginsRequest](src/Adyen/Requests/MyApiCredential/PostMeAllowedOriginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AllowedOrigin](src/Adyen/Models/AllowedOrigin.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMeAllowedOriginsError](src/Adyen/Errors/PostMeAllowedOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateClientKeyResponse&gt; PostMeGenerateClientKey(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates a new [client key](https://docs.adyen.com/development-resources/client-side-authentication/) used to authenticate requests from your payment environment.
You can use the new client key a few minutes after generating it.
The old client key stops working 24 hours after generating a new one.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—API credentials read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MyApiCredential.PostMeGenerateClientKey();
    // TODO: Handle 'response' of type GenerateClientKeyResponse
}
catch (ApiException<PostMeGenerateClientKeyError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateClientKeyResponse](src/Adyen/Models/GenerateClientKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMeGenerateClientKeyError](src/Adyen/Errors/PostMeGenerateClientKeyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## NetworkTokens

> Source: [NetworkTokens](src/Adyen/Api/NetworkTokens.cs)

<details>
<summary><code>Task&lt;GetNetworkTokenResponse&gt; GetNetworkTokensNetworkTokenId(GetNetworkTokensNetworkTokenIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a network token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.NetworkTokens.GetNetworkTokensNetworkTokenId(new GetNetworkTokensNetworkTokenIdRequest
    {
        NetworkTokenId = "some example string",
    });
    // TODO: Handle 'response' of type GetNetworkTokenResponse
}
catch (ApiException<GetNetworkTokensNetworkTokenIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetNetworkTokensNetworkTokenIdRequest](src/Adyen/Requests/NetworkTokens/GetNetworkTokensNetworkTokenIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetNetworkTokenResponse](src/Adyen/Models/GetNetworkTokenResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetNetworkTokensNetworkTokenIdError](src/Adyen/Errors/GetNetworkTokensNetworkTokenIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PatchNetworkTokensNetworkTokenId(PatchNetworkTokensNetworkTokenIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the status of the network token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.NetworkTokens.PatchNetworkTokensNetworkTokenId(new PatchNetworkTokensNetworkTokenIdRequest
    {
        NetworkTokenId = "some example string",
    });
}
catch (ApiException<PatchNetworkTokensNetworkTokenIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchNetworkTokensNetworkTokenIdRequest](src/Adyen/Requests/NetworkTokens/PatchNetworkTokensNetworkTokenIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchNetworkTokensNetworkTokenIdError](src/Adyen/Errors/PatchNetworkTokensNetworkTokenIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Orders

> Source: [Orders](src/Adyen/Api/Orders.cs)

<details>
<summary><code>Task&lt;CreateOrderResponse&gt; PostOrders(PostOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an order to be used for partial payments. Make a POST `/orders` call before making a `/payments` call when processing payments with different payment methods.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.PostOrders(new PostOrdersRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CreateOrderRequest
        {
            Amount = new Amount21 { Currency = "EUR", Value = 2500L },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_ORDER_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type CreateOrderResponse
}
catch (ApiException<PostOrdersError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostOrdersRequest](src/Adyen/Requests/Orders/PostOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateOrderResponse](src/Adyen/Models/CreateOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostOrdersError](src/Adyen/Errors/PostOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelOrderResponse&gt; PostOrdersCancel(PostOrdersCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels an order. Cancellation of an order results in an automatic rollback of all payments made in the order, either by canceling or refunding the payment, depending on the type of payment method.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.PostOrdersCancel(new PostOrdersCancelRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CancelOrderRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Order = new EncryptedOrderData4
            {
                OrderData = "823fh892f8f18f4...148f13f9f3f",
                PspReference = "8815517812932012",
            },
        },
    });
    // TODO: Handle 'response' of type CancelOrderResponse
}
catch (ApiException<PostOrdersCancelError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostOrdersCancelRequest](src/Adyen/Requests/Orders/PostOrdersCancelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelOrderResponse](src/Adyen/Models/CancelOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostOrdersCancelError](src/Adyen/Errors/PostOrdersCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BalanceCheckResponse&gt; PostPaymentMethodsBalance(PostPaymentMethodsBalanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the balance remaining on a shopper's gift card. To check a gift card's balance, make a POST `/paymentMethods/balance` call and include the gift card's details inside a `paymentMethod` object.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.PostPaymentMethodsBalance(new PostPaymentMethodsBalanceRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new BalanceCheckRequest
        {
            Amount = new Amount2 { Currency = "EUR", Value = 1000L },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PaymentMethod = new Dictionary<string, string>
            {
                ["type"] = "givex",
                ["number"] = "4126491073027401",
                ["cvc"] = "737",
            },
        },
    });
    // TODO: Handle 'response' of type BalanceCheckResponse
}
catch (ApiException<PostPaymentMethodsBalanceError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentMethodsBalanceRequest](src/Adyen/Requests/Orders/PostPaymentMethodsBalanceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalanceCheckResponse](src/Adyen/Models/BalanceCheckResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentMethodsBalanceError](src/Adyen/Errors/PostPaymentMethodsBalanceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PciComplianceQuestionnairePage

> Source: [PciComplianceQuestionnairePage](src/Adyen/Api/PciComplianceQuestionnairePage.cs)

<details>
<summary><code>Task&lt;GetPciUrlResponse&gt; PostGetPciQuestionnaireUrl(PostGetPciQuestionnaireUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a link to a PCI compliance questionnaire that you can send to your account holder.
 > You should only use this endpoint if you have a [partner platform setup](https://docs.adyen.com/classic-platforms/platforms-for-partners).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciComplianceQuestionnairePage.PostGetPciQuestionnaireUrl(
        new PostGetPciQuestionnaireUrlRequest
        {
            Body = new GetPciUrlRequest
            {
                AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
                ReturnUrl = "https://your.return-url.com/?submerchant=123",
            },
        });
    // TODO: Handle 'response' of type GetPciUrlResponse
}
catch (ApiException<PostGetPciQuestionnaireUrlError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetPciQuestionnaireUrlRequest](src/Adyen/Requests/PciComplianceQuestionnairePage/PostGetPciQuestionnaireUrlRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPciUrlResponse](src/Adyen/Models/GetPciUrlResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetPciQuestionnaireUrlError](src/Adyen/Errors/PostGetPciQuestionnaireUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PciQuestionnaires

> Source: [PciQuestionnaires](src/Adyen/Api/PciQuestionnaires.cs)

<details>
<summary><code>Task&lt;GetPciQuestionnaireInfosResponse&gt; GetLegalEntitiesIdPciQuestionnaires(GetLegalEntitiesIdPciQuestionnairesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a list of signed PCI questionnaires.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciQuestionnaires.GetLegalEntitiesIdPciQuestionnaires(
        new GetLegalEntitiesIdPciQuestionnairesRequest { Id = "some example string" });
    // TODO: Handle 'response' of type GetPciQuestionnaireInfosResponse
}
catch (ApiException<GetLegalEntitiesIdPciQuestionnairesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLegalEntitiesIdPciQuestionnairesRequest](src/Adyen/Requests/PciQuestionnaires/GetLegalEntitiesIdPciQuestionnairesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPciQuestionnaireInfosResponse](src/Adyen/Models/GetPciQuestionnaireInfosResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetLegalEntitiesIdPciQuestionnairesError](src/Adyen/Errors/GetLegalEntitiesIdPciQuestionnairesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetPciQuestionnaireResponse&gt; GetLegalEntitiesIdPciQuestionnairesPciid(GetLegalEntitiesIdPciQuestionnairesPciidRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the signed PCI questionnaire.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciQuestionnaires.GetLegalEntitiesIdPciQuestionnairesPciid(
        new GetLegalEntitiesIdPciQuestionnairesPciidRequest
        {
            Id = "some example string",
            Pciid = "some example string",
        });
    // TODO: Handle 'response' of type GetPciQuestionnaireResponse
}
catch (ApiException<GetLegalEntitiesIdPciQuestionnairesPciidError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLegalEntitiesIdPciQuestionnairesPciidRequest](src/Adyen/Requests/PciQuestionnaires/GetLegalEntitiesIdPciQuestionnairesPciidRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPciQuestionnaireResponse](src/Adyen/Models/GetPciQuestionnaireResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetLegalEntitiesIdPciQuestionnairesPciidError](src/Adyen/Errors/GetLegalEntitiesIdPciQuestionnairesPciidError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GeneratePciDescriptionResponse&gt; PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplates(PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates the required PCI questionnaires based on the user's [salesChannel](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/businessLines__reqParam_salesChannels).

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciQuestionnaires.PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplates(
        new PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesRequest
        {
            Id = "some example string",
            Body = new GeneratePciDescriptionRequest { Language = "fr" },
        });
    // TODO: Handle 'response' of type GeneratePciDescriptionResponse
}
catch (ApiException<PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesRequest](src/Adyen/Requests/PciQuestionnaires/PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GeneratePciDescriptionResponse](src/Adyen/Models/GeneratePciDescriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError](src/Adyen/Errors/PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PciSigningResponse&gt; PostLegalEntitiesIdPciQuestionnairesSignPciTemplates(PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Signs the required PCI questionnaire.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciQuestionnaires.PostLegalEntitiesIdPciQuestionnairesSignPciTemplates(
        new PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesRequest
        {
            Id = "some example string",
            Body = new PciSigningRequest
            {
                PciTemplateReferences = ["PCIT-T7KC6VGL", "PCIT-PKB6DKS4"],
                SignedBy = "LE00000000000000000000002",
            },
        });
    // TODO: Handle 'response' of type PciSigningResponse
}
catch (ApiException<PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesRequest](src/Adyen/Requests/PciQuestionnaires/PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PciSigningResponse](src/Adyen/Models/PciSigningResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError](src/Adyen/Errors/PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalculatePciStatusResponse&gt; PostLegalEntitiesIdPciQuestionnairesSigningRequired(PostLegalEntitiesIdPciQuestionnairesSigningRequiredRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Calculate PCI status of a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PciQuestionnaires.PostLegalEntitiesIdPciQuestionnairesSigningRequired(
        new PostLegalEntitiesIdPciQuestionnairesSigningRequiredRequest { Id = "some example string" });
    // TODO: Handle 'response' of type CalculatePciStatusResponse
}
catch (ApiException<PostLegalEntitiesIdPciQuestionnairesSigningRequiredError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLegalEntitiesIdPciQuestionnairesSigningRequiredRequest](src/Adyen/Requests/PciQuestionnaires/PostLegalEntitiesIdPciQuestionnairesSigningRequiredRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculatePciStatusResponse](src/Adyen/Models/CalculatePciStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostLegalEntitiesIdPciQuestionnairesSigningRequiredError](src/Adyen/Errors/PostLegalEntitiesIdPciQuestionnairesSigningRequiredError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentInstrumentGroups

> Source: [PaymentInstrumentGroups](src/Adyen/Api/PaymentInstrumentGroups.cs)

<details>
<summary><code>Task&lt;PaymentInstrumentGroup&gt; GetPaymentInstrumentGroupsId(GetPaymentInstrumentGroupsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a payment instrument group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstrumentGroups.GetPaymentInstrumentGroupsId(
        new GetPaymentInstrumentGroupsIdRequest { Id = "some example string" });
    // TODO: Handle 'response' of type PaymentInstrumentGroup
}
catch (ApiException<GetPaymentInstrumentGroupsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentInstrumentGroupsIdRequest](src/Adyen/Requests/PaymentInstrumentGroups/GetPaymentInstrumentGroupsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrumentGroup](src/Adyen/Models/PaymentInstrumentGroup.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetPaymentInstrumentGroupsIdError](src/Adyen/Errors/GetPaymentInstrumentGroupsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRulesResponse&gt; GetPaymentInstrumentGroupsIdTransactionRules(GetPaymentInstrumentGroupsIdTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all the transaction rules associated with a payment instrument group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstrumentGroups.GetPaymentInstrumentGroupsIdTransactionRules(
        new GetPaymentInstrumentGroupsIdTransactionRulesRequest { Id = "some example string" });
    // TODO: Handle 'response' of type TransactionRulesResponse
}
catch (ApiException<GetPaymentInstrumentGroupsIdTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentInstrumentGroupsIdTransactionRulesRequest](src/Adyen/Requests/PaymentInstrumentGroups/GetPaymentInstrumentGroupsIdTransactionRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRulesResponse](src/Adyen/Models/TransactionRulesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetPaymentInstrumentGroupsIdTransactionRulesError](src/Adyen/Errors/GetPaymentInstrumentGroupsIdTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrumentGroup&gt; PostPaymentInstrumentGroups(PostPaymentInstrumentGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment instrument group to associate and group payment instrument resources together. You can apply a transaction rule to a payment instrument group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstrumentGroups.PostPaymentInstrumentGroups(
        new PostPaymentInstrumentGroupsRequest
        {
            Body = new PaymentInstrumentGroupInfo { BalancePlatform = "YOUR_BALANCE_PLATFORM", TxVariant = "mc" },
        });
    // TODO: Handle 'response' of type PaymentInstrumentGroup
}
catch (ApiException<PostPaymentInstrumentGroupsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentInstrumentGroupsRequest](src/Adyen/Requests/PaymentInstrumentGroups/PostPaymentInstrumentGroupsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrumentGroup](src/Adyen/Models/PaymentInstrumentGroup.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentInstrumentGroupsError](src/Adyen/Errors/PostPaymentInstrumentGroupsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentInstruments

> Source: [PaymentInstruments](src/Adyen/Api/PaymentInstruments.cs)

<details>
<summary><code>Task&lt;PaymentInstrument1&gt; GetPaymentInstrumentsId(GetPaymentInstrumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.GetPaymentInstrumentsId(new GetPaymentInstrumentsIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type PaymentInstrument1
}
catch (ApiException<GetPaymentInstrumentsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentInstrumentsIdRequest](src/Adyen/Requests/PaymentInstruments/GetPaymentInstrumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrument1](src/Adyen/Models/PaymentInstrument1.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetPaymentInstrumentsIdError](src/Adyen/Errors/GetPaymentInstrumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NetworkTokenActivationDataResponse&gt; GetPaymentInstrumentsIdNetworkTokenActivationData(GetPaymentInstrumentsIdNetworkTokenActivationDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the network token activation data for a payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.GetPaymentInstrumentsIdNetworkTokenActivationData(
        new GetPaymentInstrumentsIdNetworkTokenActivationDataRequest { Id = "some example string" });
    // TODO: Handle 'response' of type NetworkTokenActivationDataResponse
}
catch (ApiException<GetPaymentInstrumentsIdNetworkTokenActivationDataError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentInstrumentsIdNetworkTokenActivationDataRequest](src/Adyen/Requests/PaymentInstruments/GetPaymentInstrumentsIdNetworkTokenActivationDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NetworkTokenActivationDataResponse](src/Adyen/Models/NetworkTokenActivationDataResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetPaymentInstrumentsIdNetworkTokenActivationDataError](src/Adyen/Errors/GetPaymentInstrumentsIdNetworkTokenActivationDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListNetworkTokensResponse&gt; GetPaymentInstrumentsIdNetworkTokens(GetPaymentInstrumentsIdNetworkTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List the network tokens connected to a payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.GetPaymentInstrumentsIdNetworkTokens(
        new GetPaymentInstrumentsIdNetworkTokensRequest { Id = "some example string" });
    // TODO: Handle 'response' of type ListNetworkTokensResponse
}
catch (ApiException<GetPaymentInstrumentsIdNetworkTokensError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentInstrumentsIdNetworkTokensRequest](src/Adyen/Requests/PaymentInstruments/GetPaymentInstrumentsIdNetworkTokensRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListNetworkTokensResponse](src/Adyen/Models/ListNetworkTokensResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetPaymentInstrumentsIdNetworkTokensError](src/Adyen/Errors/GetPaymentInstrumentsIdNetworkTokensError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrumentRevealInfo&gt; GetPaymentInstrumentsIdReveal(GetPaymentInstrumentsIdRevealRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the primary account number (PAN) of a payment instrument.

To make this request, your API credential must have the following [role](https://docs.adyen.com/issuing/manage-access/api-credentials-web-service#api-permissions):

* Balance Platform BCL PCI role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.GetPaymentInstrumentsIdReveal(
        new GetPaymentInstrumentsIdRevealRequest { Id = "some example string" });
    // TODO: Handle 'response' of type PaymentInstrumentRevealInfo
}
catch (ApiException<GetPaymentInstrumentsIdRevealError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentInstrumentsIdRevealRequest](src/Adyen/Requests/PaymentInstruments/GetPaymentInstrumentsIdRevealRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrumentRevealInfo](src/Adyen/Models/PaymentInstrumentRevealInfo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetPaymentInstrumentsIdRevealError](src/Adyen/Errors/GetPaymentInstrumentsIdRevealError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRulesResponse&gt; GetPaymentInstrumentsIdTransactionRules(GetPaymentInstrumentsIdTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of transaction rules associated with a payment instrument.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.GetPaymentInstrumentsIdTransactionRules(
        new GetPaymentInstrumentsIdTransactionRulesRequest { Id = "some example string" });
    // TODO: Handle 'response' of type TransactionRulesResponse
}
catch (ApiException<GetPaymentInstrumentsIdTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentInstrumentsIdTransactionRulesRequest](src/Adyen/Requests/PaymentInstruments/GetPaymentInstrumentsIdTransactionRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRulesResponse](src/Adyen/Models/TransactionRulesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetPaymentInstrumentsIdTransactionRulesError](src/Adyen/Errors/GetPaymentInstrumentsIdTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdatePaymentInstrument&gt; PatchPaymentInstrumentsId(PatchPaymentInstrumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a payment instrument. Once a payment instrument is already active, you can only update its status. However, for cards created with **inactive** status, you can still update the balance account associated with the card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.PatchPaymentInstrumentsId(new PatchPaymentInstrumentsIdRequest
    {
        Id = "some example string",
        Body = new PaymentInstrumentUpdateRequest { BalanceAccountId = "BA32272223222B5CM82WL892M" },
    });
    // TODO: Handle 'response' of type UpdatePaymentInstrument
}
catch (ApiException<PatchPaymentInstrumentsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchPaymentInstrumentsIdRequest](src/Adyen/Requests/PaymentInstruments/PatchPaymentInstrumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdatePaymentInstrument](src/Adyen/Models/UpdatePaymentInstrument.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchPaymentInstrumentsIdError](src/Adyen/Errors/PatchPaymentInstrumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrument1&gt; PostPaymentInstruments(PostPaymentInstrumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment instrument to issue a physical card, a virtual card, or a business account to your user.

 For more information, refer to [Issue cards](https://docs.adyen.com/issuing/create-cards) or [Issue business accounts](https://docs.adyen.com/platforms/business-accounts).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.PostPaymentInstruments(new PostPaymentInstrumentsRequest
    {
        Body = new PaymentInstrumentInfo
        {
            BalanceAccountId = "BA3227C223222B5CTBLR8BWJB",
            Description = "YOUR_DESCRIPTION",
            IssuingCountryCode = "NL",
            Type = Type111.BankAccount,
        },
    });
    // TODO: Handle 'response' of type PaymentInstrument1
}
catch (ApiException<PostPaymentInstrumentsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentInstrumentsRequest](src/Adyen/Requests/PaymentInstruments/PostPaymentInstrumentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrument1](src/Adyen/Models/PaymentInstrument1.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentInstrumentsError](src/Adyen/Errors/PostPaymentInstrumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NetworkTokenActivationDataResponse&gt; PostPaymentInstrumentsIdNetworkTokenActivationData(PostPaymentInstrumentsIdNetworkTokenActivationDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create provisioning data for a network token. Use the provisioning data to add a user's payment instrument to their digital wallet.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.PostPaymentInstrumentsIdNetworkTokenActivationData(
        new PostPaymentInstrumentsIdNetworkTokenActivationDataRequest { Id = "some example string" });
    // TODO: Handle 'response' of type NetworkTokenActivationDataResponse
}
catch (ApiException<PostPaymentInstrumentsIdNetworkTokenActivationDataError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentInstrumentsIdNetworkTokenActivationDataRequest](src/Adyen/Requests/PaymentInstruments/PostPaymentInstrumentsIdNetworkTokenActivationDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NetworkTokenActivationDataResponse](src/Adyen/Models/NetworkTokenActivationDataResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentInstrumentsIdNetworkTokenActivationDataError](src/Adyen/Errors/PostPaymentInstrumentsIdNetworkTokenActivationDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrumentRevealResponse&gt; PostPaymentInstrumentsReveal(PostPaymentInstrumentsRevealRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the encrypted data of a specified payment instrument. These data include:

- The primary account number (PAN)
- The card verification code (CVC)
- The expiry date

You can decrypt the data to reveal it in your user interface.

To make this request, your API credential must have the following role:
* Bank Issuing PAN Reveal Webservice role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstruments.PostPaymentInstrumentsReveal(
        new PostPaymentInstrumentsRevealRequest());
    // TODO: Handle 'response' of type PaymentInstrumentRevealResponse
}
catch (ApiException<PostPaymentInstrumentsRevealError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentInstrumentsRevealRequest](src/Adyen/Requests/PaymentInstruments/PostPaymentInstrumentsRevealRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrumentRevealResponse](src/Adyen/Models/PaymentInstrumentRevealResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentInstrumentsRevealError](src/Adyen/Errors/PostPaymentInstrumentsRevealError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentLinks

> Source: [PaymentLinks](src/Adyen/Api/PaymentLinks.cs)

<details>
<summary><code>Task&lt;PaymentLinkResponse&gt; GetPaymentLinksLinkId(GetPaymentLinksLinkIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the payment link details using the payment link `id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentLinks.GetPaymentLinksLinkId(new GetPaymentLinksLinkIdRequest
    {
        LinkId = "some example string",
    });
    // TODO: Handle 'response' of type PaymentLinkResponse
}
catch (ApiException<GetPaymentLinksLinkIdError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentLinksLinkIdRequest](src/Adyen/Requests/PaymentLinks/GetPaymentLinksLinkIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentLinkResponse](src/Adyen/Models/PaymentLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetPaymentLinksLinkIdError](src/Adyen/Errors/GetPaymentLinksLinkIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentLinkResponse&gt; PatchPaymentLinksLinkId(PatchPaymentLinksLinkIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the status of a payment link. Use this endpoint to [force the expiry of a payment link](https://docs.adyen.com/online-payments/pay-by-link#update-payment-link-status).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentLinks.PatchPaymentLinksLinkId(new PatchPaymentLinksLinkIdRequest
    {
        LinkId = "some example string",
        Body = new UpdatePaymentLinkRequest(),
    });
    // TODO: Handle 'response' of type PaymentLinkResponse
}
catch (ApiException<PatchPaymentLinksLinkIdError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchPaymentLinksLinkIdRequest](src/Adyen/Requests/PaymentLinks/PatchPaymentLinksLinkIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentLinkResponse](src/Adyen/Models/PaymentLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchPaymentLinksLinkIdError](src/Adyen/Errors/PatchPaymentLinksLinkIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentLinkResponse&gt; PostPaymentLinks(PostPaymentLinksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment link to a [Pay by Link](https://docs.adyen.com/unified-commerce/pay-by-link/) page where the shopper can pay. The list of payment methods presented to the shopper depends on the `currency` and `country` parameters sent in the request.

For more information, refer to [Pay by Link documentation](https://docs.adyen.com/online-payments/pay-by-link#create-payment-links-through-api).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentLinks.PostPaymentLinks(new PostPaymentLinksRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentLinkRequest
        {
            Amount = new Amount35 { Currency = "BRL", Value = 1250L },
            BillingAddress = new Address3
            {
                City = "São Paulo",
                Country = "BR",
                HouseNumberOrName = "999",
                PostalCode = "59000060",
                StateOrProvince = "SP",
                Street = "Roque Petroni Jr",
            },
            CountryCode = "BR",
            DeliveryAddress = new Address2
            {
                City = "São Paulo",
                Country = "BR",
                HouseNumberOrName = "999",
                PostalCode = "59000060",
                StateOrProvince = "SP",
                Street = "Roque Petroni Jr",
            },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_ORDER_NUMBER",
            ShopperEmail = "test@email.com",
            ShopperLocale = "pt-BR",
            ShopperReference = "YOUR_SHOPPER_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type PaymentLinkResponse
}
catch (ApiException<PostPaymentLinksError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentLinksRequest](src/Adyen/Requests/PaymentLinks/PostPaymentLinksRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentLinkResponse](src/Adyen/Models/PaymentLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentLinksError](src/Adyen/Errors/PostPaymentLinksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentMethodsMerchantLevel

> Source: [PaymentMethodsMerchantLevel](src/Adyen/Api/PaymentMethodsMerchantLevel.cs)

<details>
<summary><code>Task&lt;PaymentMethodResponse&gt; GetMerchantsMerchantIdPaymentMethodSettings(GetMerchantsMerchantIdPaymentMethodSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details for all payment methods of the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.GetMerchantsMerchantIdPaymentMethodSettings(
        new GetMerchantsMerchantIdPaymentMethodSettingsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type PaymentMethodResponse
}
catch (ApiException<GetMerchantsMerchantIdPaymentMethodSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdPaymentMethodSettingsRequest](src/Adyen/Requests/PaymentMethodsMerchantLevel/GetMerchantsMerchantIdPaymentMethodSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentMethodResponse](src/Adyen/Models/PaymentMethodResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdPaymentMethodSettingsError](src/Adyen/Errors/GetMerchantsMerchantIdPaymentMethodSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagementPaymentMethod&gt; GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details for the merchant account and the payment method identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(
        new GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest
        {
            MerchantId = "some example string",
            PaymentMethodId = "some example string",
        });
    // TODO: Handle 'response' of type ManagementPaymentMethod
}
catch (ApiException<GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest](src/Adyen/Requests/PaymentMethodsMerchantLevel/GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagementPaymentMethod](src/Adyen/Models/ManagementPaymentMethod.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError](src/Adyen/Errors/GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApplePayResponseInfo&gt; GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomains(GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/enable-apple-pay#register-merchant-domain).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomains(
        new GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsRequest
        {
            MerchantId = "some example string",
            PaymentMethodId = "some example string",
        });
    // TODO: Handle 'response' of type ApplePayResponseInfo
}
catch (ApiException<GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsRequest](src/Adyen/Requests/PaymentMethodsMerchantLevel/GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApplePayResponseInfo](src/Adyen/Models/ApplePayResponseInfo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError](src/Adyen/Errors/GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagementPaymentMethod&gt; PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment method details for the merchant account and the payment method identified in the path.
Depending the payment method [`type`](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/_merchantId_/paymentMethodSettings#request-type), you may need to send an additional object required for the payment method.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(
        new PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest
        {
            MerchantId = "some example string",
            PaymentMethodId = "some example string",
            Body = new UpdatePaymentMethodInfo { Countries = ["NL"], Currencies = ["EUR"] },
        });
    // TODO: Handle 'response' of type ManagementPaymentMethod
}
catch (ApiException<PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest](src/Adyen/Requests/PaymentMethodsMerchantLevel/PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagementPaymentMethod](src/Adyen/Models/ManagementPaymentMethod.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError](src/Adyen/Errors/PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ManagementPaymentMethod&gt; PostMerchantsMerchantIdPaymentMethodSettings(PostMerchantsMerchantIdPaymentMethodSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a request to add a new payment method to the merchant account identified in the path.
Depending the payment method [`type`](https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/paymentMethodSettings#request-type), you may need to send an additional object required for the payment method.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentMethodsMerchantLevel.PostMerchantsMerchantIdPaymentMethodSettings(
        new PostMerchantsMerchantIdPaymentMethodSettingsRequest
        {
            MerchantId = "some example string",
            Body = new PaymentMethodSetupInfo { Countries = ["US"], Currencies = ["USD"], Type = Type59.Visa },
        });
    // TODO: Handle 'response' of type ManagementPaymentMethod
}
catch (ApiException<PostMerchantsMerchantIdPaymentMethodSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdPaymentMethodSettingsRequest](src/Adyen/Requests/PaymentMethodsMerchantLevel/PostMerchantsMerchantIdPaymentMethodSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ManagementPaymentMethod](src/Adyen/Models/ManagementPaymentMethod.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdPaymentMethodSettingsError](src/Adyen/Errors/PostMerchantsMerchantIdPaymentMethodSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomains(PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds the new domain to the list of Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see [Apple Pay documentation](https://docs.adyen.com/payment-methods/apple-pay/web-drop-in/?tab=adyen-certificate-live_1#going-live).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payment methods read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PaymentMethodsMerchantLevel.PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomains(
        new PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsRequest
        {
            MerchantId = "some example string",
            PaymentMethodId = "some example string",
            Body = new ApplePayInfo { Domains = ["https://example.com"] },
        });
}
catch (ApiException<PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsRequest](src/Adyen/Requests/PaymentMethodsMerchantLevel/PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError](src/Adyen/Errors/PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Payments

> Source: [Payments](src/Adyen/Api/Payments.cs)

<details>
<summary><code>Task&lt;SessionResultResponse&gt; GetSessionsSessionId(GetSessionsSessionIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the status of the payment session with the `sessionId` and `sessionResult` specified in the path.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.GetSessionsSessionId(new GetSessionsSessionIdRequest
    {
        SessionId = "some example string",
        SessionResult = "some example string",
    });
    // TODO: Handle 'response' of type SessionResultResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSessionsSessionIdRequest](src/Adyen/Requests/Payments/GetSessionsSessionIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionResultResponse](src/Adyen/Models/SessionResultResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentResult&gt; PostAuthorise(PostAuthoriseRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment with a unique reference (`pspReference`) and attempts to obtain an authorisation hold. For cards, this amount can be captured or cancelled later. Non-card payment methods typically don't support this and will automatically capture as part of the authorisation.

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

>The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostAuthorise(new PostAuthoriseRequest
    {
        Body = new PaymentRequest1
        {
            AccountInfo = new AccountInfo { AccountCreationDate = DateTimeOffset.Parse("2019-01-17T12:42:40Z") },
            Amount = new Amount { Currency = "USD", Value = 1500L },
            BillingAddress = new Address
            {
                City = "New York",
                Country = "US",
                HouseNumberOrName = "37C",
                PostalCode = "10039",
                StateOrProvince = "NY",
                Street = "Redwood Block",
            },
            BrowserInfo = new BrowserInfo
            {
                AcceptHeader = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8",
                ColorDepth = 24,
                JavaEnabled = false,
                Language = "en",
                ScreenHeight = 723,
                ScreenWidth = 1536,
                TimeZoneOffset = 0,
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.110 Safari/537.36",
            },
            Card = new Card3
            {
                Cvc = "737",
                ExpiryMonth = "03",
                ExpiryYear = "2030",
                HolderName = "John Smith",
                Number = "4917610000000000",
            },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_REFERENCE_NUMBER",
            ShopperEmail = "s.hopper@test.com",
            ShopperIp = "192.0.2.1",
            ThreeDs2RequestData = new ThreeDs2RequestData11
            {
                DeviceChannel = "browser",
                NotificationUrl = "https://www.example.com/YOUR_3DS_NOTIFICATION_URL",
            },
        },
    });
    // TODO: Handle 'response' of type PaymentResult
}
catch (ApiException<PostAuthoriseError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAuthoriseRequest](src/Adyen/Requests/Payments/PostAuthoriseRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentResult](src/Adyen/Models/PaymentResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostAuthoriseError](src/Adyen/Errors/PostAuthoriseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentResult&gt; PostAuthorise3D(PostAuthorise3DRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

For an authenticated 3D Secure session, completes the payment authorisation. This endpoint must receive the `md` and `paResponse` parameters that you get from the card issuer after a shopper pays via 3D Secure.

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/details`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/details) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

> The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostAuthorise3D(new PostAuthorise3DRequest
    {
        Body = new PaymentRequest3D
        {
            Md = "31h..........vOXek7w",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PaResponse = "eNqtmF........wGVA4Ch",
            ShopperIp = "61.294.12.12",
        },
    });
    // TODO: Handle 'response' of type PaymentResult
}
catch (ApiException<PostAuthorise3DError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAuthorise3DRequest](src/Adyen/Requests/Payments/PostAuthorise3DRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentResult](src/Adyen/Models/PaymentResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostAuthorise3DError](src/Adyen/Errors/PostAuthorise3DError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentResult&gt; PostAuthorise3Ds2(PostAuthorise3Ds2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

For an authenticated 3D Secure 2 session, completes the payment authorisation. This endpoint must receive the `threeDS2Token` and `threeDS2Result` parameters.

> This endpoint is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle) and is no longer supported for new integrations.
> * If you are building a new integration, use the Checkout API [`/payments/details`](https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/details) endpoint instead.
> * If you have an existing integration using this endpoint, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).

>The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostAuthorise3Ds2(new PostAuthorise3Ds2Request
    {
        Body = new PaymentRequest3Ds2
        {
            Amount = new Amount { Currency = "EUR", Value = 1000L },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_ORDER_NUMBER",
            ThreeDs2RequestData = new ThreeDs2RequestData11 { DeviceChannel = "app", ThreeDsCompInd = "Y" },
            ThreeDs2Token = "— - BINARY DATA - -",
        },
    });
    // TODO: Handle 'response' of type PaymentResult
}
catch (ApiException<PostAuthorise3Ds2Error> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAuthorise3Ds2Request](src/Adyen/Requests/Payments/PostAuthorise3Ds2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentResult](src/Adyen/Models/PaymentResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostAuthorise3Ds2Error](src/Adyen/Errors/PostAuthorise3Ds2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CardDetailsResponse&gt; PostCardDetails(PostCardDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this endpoint to get information about the card or network token that enables you to decide on the routing of the transaction and the eligibility of the card for the type of transaction.

If you include [your supported brands](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cardDetails__reqParam_supportedBrands) in the request, the response also tells you if you support each [brand that was identified on the card](https://docs.adyen.com/api-explorer/Checkout/latest/post/cardDetails#responses-200-brands).

If you have an API-only integration and collect card data, use this endpoint to find out if the shopper's card is co-bad. For co-badged cards, you must let the shopper choose the brand to pay with  if you support both brands.

## Server-side API libraries
We provide open-source [server-side API libraries](https://docs.adyen.com/development-resources/libraries/) in several languages: 
- PHP
- Java
- Node.js
- .NET
- Go
- Python
- Ruby
- Apex (beta)

See our [integration examples](https://github.com/adyen-examples#%EF%B8%8F-official-integration-examples) for example uses of the libraries.

## Developer resources
BIN Lookup API is available through a Postman collection. Click the button below to create a fork, then set the environment variables at **Environments**&nbsp;>&nbsp;**Adyen&nbsp;APIs**. 

[![Run in Postman](https://run.pstmn.io/button.svg)](https://god.gw.postman.com/run-collection/25716737-677c7679-a695-4ebb-91da-68b4e7c9228a?action=collection%2Ffork&source=rip_markdown&collection-url=entityId%3D25716737-677c7679-a695-4ebb-91da-68b4e7c9228a%26entityType%3Dcollection%26workspaceId%3Da8d63f9f-cfc7-4810-90c5-9e0c60030d3e#?env%5BAdyen%20APIs%5D=W3sia2V5IjoiWC1BUEktS2V5IiwidmFsdWUiOiIiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0In0seyJrZXkiOiJZT1VSX01FUkNIQU5UX0FDQ09VTlQiLCJ2YWx1ZSI6IiIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In0seyJrZXkiOiJZT1VSX0NPTVBBTllfQUNDT1VOVCIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifSx7ImtleSI6IllPVVJfQkFMQU5DRV9QTEFURk9STSIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifV0=)

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostCardDetails(new PostCardDetailsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CardDetailsRequest { CardNumber = "411111", MerchantAccount = "YOUR_MERCHANT_ACCOUNT" },
    });
    // TODO: Handle 'response' of type CardDetailsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCardDetailsRequest](src/Adyen/Requests/Payments/PostCardDetailsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CardDetailsResponse](src/Adyen/Models/CardDetailsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthenticationResultResponse&gt; PostGetAuthenticationResult(PostGetAuthenticationResultRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Return the authentication result after doing a 3D Secure authentication only.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostGetAuthenticationResult(new PostGetAuthenticationResultRequest
    {
        Body = new AuthenticationResultRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PspReference = "9935272408535455",
        },
    });
    // TODO: Handle 'response' of type AuthenticationResultResponse
}
catch (ApiException<PostGetAuthenticationResultError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetAuthenticationResultRequest](src/Adyen/Requests/Payments/PostGetAuthenticationResultRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthenticationResultResponse](src/Adyen/Models/AuthenticationResultResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetAuthenticationResultError](src/Adyen/Errors/PostGetAuthenticationResultError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentMethodsResponse&gt; PostPaymentMethods(PostPaymentMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the list of available payment methods for the transaction, based on the transaction information like amount, country, and currency.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPaymentMethods(new PostPaymentMethodsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentMethodsRequest { MerchantAccount = "YOUR_MERCHANT_ACCOUNT" },
    });
    // TODO: Handle 'response' of type PaymentMethodsResponse
}
catch (ApiException<PostPaymentMethodsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentMethodsRequest](src/Adyen/Requests/Payments/PostPaymentMethodsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentMethodsResponse](src/Adyen/Models/PaymentMethodsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentMethodsError](src/Adyen/Errors/PostPaymentMethodsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentResponse&gt; PostPayments(PostPaymentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends payment parameters (like amount, country, and currency) together with other required input details collected from the shopper. To know more about required parameters for specific payment methods, refer to our [payment method guides](https://docs.adyen.com/payment-methods). 
The response depends on the [payment flow](https://docs.adyen.com/payment-methods#payment-flow):
* For a direct flow, the response includes a `pspReference` and a `resultCode` with the payment result, for example **Authorised** or **Refused**. 
* For a redirect or additional action, the response contains an `action` object.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPayments(new PostPaymentsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentRequest
        {
            Amount = new Amount2 { Currency = "USD", Value = 1000L },
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PaymentMethod = new ApplePayDetails
            {
                ApplePayToken = "VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...",
                Type = Type7.Applepay,
            },
            Reference = "Your order number",
            ReturnUrl = "https://your-company.example.com/...",
        },
    });
    // TODO: Handle 'response' of type PaymentResponse
}
catch (ApiException<PostPaymentsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentsRequest](src/Adyen/Requests/Payments/PostPaymentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentResponse](src/Adyen/Models/PaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentsError](src/Adyen/Errors/PostPaymentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelPaymentResponse&gt; PostPaymentsCancel(PostPaymentsCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the payment. Returns a URL for user redirection.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPaymentsCancel(new PostPaymentsCancelRequest
    {
        Body = new CancelPaymentRequest { Token = "TOKEN_PLACEHOLDER" },
    });
    // TODO: Handle 'response' of type CancelPaymentResponse
}
catch (ApiException<PostPaymentsCancelError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentsCancelRequest](src/Adyen/Requests/Payments/PostPaymentsCancelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelPaymentResponse](src/Adyen/Models/CancelPaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentsCancelError](src/Adyen/Errors/PostPaymentsCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConfirmPaymentResponse&gt; PostPaymentsConfirm(PostPaymentsConfirmRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Confirms the payment using Strong Customer Authentication (SCA).

    To confirm a payment you must make this request two times:

    1. Make this request to initiate SCA and receive the WWW-Authenticate header.
    2. After the user completes the SCA challenge, make this request again, including the updated WWW-Authenticate header.

    The second response provides a redirection URL that guides the user to a payment success or failure page.
For more information, see our [documentation](https://docs.adyen.com/business-accounts/send-funds-ideal-integration).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPaymentsConfirm(new PostPaymentsConfirmRequest
    {
        WwwAuthenticate = "SCA realm=\"Transfer\" auth-param1=\"eyJjaGFsbGVuZ2UiOiJiVlV6ZW5wek0waFNl...\"",
        Body = new ConfirmPaymentRequest
        {
            BalanceAccountId = "BA00000000000000000000000",
            Token = "TOKEN_PLACEHOLDER",
        },
    });
    // TODO: Handle 'response' of type ConfirmPaymentResponse
}
catch (ApiException<PostPaymentsConfirmError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentsConfirmRequest](src/Adyen/Requests/Payments/PostPaymentsConfirmRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConfirmPaymentResponse](src/Adyen/Models/ConfirmPaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentsConfirmError](src/Adyen/Errors/PostPaymentsConfirmError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentDetailsResponse&gt; PostPaymentsDetails(PostPaymentsDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits details for a payment created using `/payments`. This step is only needed when no final state has been reached on the `/payments` request, for example when the shopper was redirected to another page to complete the payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPaymentsDetails(new PostPaymentsDetailsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaymentDetailsRequest
        {
            Details = new PaymentCompletionDetails1 { RedirectResult = "X6XtfGC3!Y..." },
        },
    });
    // TODO: Handle 'response' of type PaymentDetailsResponse
}
catch (ApiException<PostPaymentsDetailsError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentsDetailsRequest](src/Adyen/Requests/Payments/PostPaymentsDetailsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentDetailsResponse](src/Adyen/Models/PaymentDetailsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentsDetailsError](src/Adyen/Errors/PostPaymentsDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentDetailsResponse1&gt; PostPaymentsDetails1(PostPaymentsDetails1Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of an open payment, which you must show to the user. Also provides a token required to [confirm](https://docs.adyen.com/api-explorer/a2a-payments/latest/post/payments/confirm) or [cancel](https://docs.adyen.com/api-explorer/a2a-payments/latest/post/payments/cancel) the payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostPaymentsDetails1(new PostPaymentsDetails1Request
    {
        Body = new IdealPaymentDetailsRequest
        {
            PaymentDetailsRequest1 = new PaymentDetailsRequest1 { Method = "ideal" },
            IdealPaymentDetailsRequestProperties = new IdealPaymentDetailsRequestProperties
            {
                Payload = "https://ext.tx.ideal.nl/2/AXE4R72TLPRCRN6Y4FDZX7MZHJQ?sig=BGBCQEIIA2F3CF7KR2SVLSJEDUJABL62V7TI4Y2LJPJIJBZEP6HXCHXPQCLTAEIB2FNUD3COVRNIT27TT7NFKYD5UJCUY4NMPS4NUCTKA6KIBHSRXWI",
                Source = PaymentSource2.Redirect,
            },
        },
    });
    // TODO: Handle 'response' of type PaymentDetailsResponse1
}
catch (ApiException<PostPaymentsDetails1Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaymentsDetails1Request](src/Adyen/Requests/Payments/PostPaymentsDetails1Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentDetailsResponse1](src/Adyen/Models/PaymentDetailsResponse1.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaymentsDetails1Error](src/Adyen/Errors/PostPaymentsDetails1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ThreeDs2ResultResponse&gt; PostRetrieve3Ds2Result(PostRetrieve3Ds2ResultRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the `threeDS2Result` after doing a 3D Secure 2 authentication only.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostRetrieve3Ds2Result(new PostRetrieve3Ds2ResultRequest
    {
        Body = new ThreeDs2ResultRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PspReference = "9935272408535455",
        },
    });
    // TODO: Handle 'response' of type ThreeDs2ResultResponse
}
catch (ApiException<PostRetrieve3Ds2ResultError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostRetrieve3Ds2ResultRequest](src/Adyen/Requests/Payments/PostRetrieve3Ds2ResultRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ThreeDs2ResultResponse](src/Adyen/Models/ThreeDs2ResultResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostRetrieve3Ds2ResultError](src/Adyen/Errors/PostRetrieve3Ds2ResultError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCheckoutSessionResponse&gt; PostSessions(PostSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment session for [Drop-in](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Drop-in), [Components](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Components), and [Hosted Checkout](https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&integration=Hosted+Checkout) integrations.

The response contains encrypted payment session data. The front end then uses the session data to make any required server-side calls for the payment flow.

You get the payment outcome asynchronously, in an [AUTHORISATION](https://docs.adyen.com/api-explorer/#/Webhooks/latest/post/AUTHORISATION) webhook.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.PostSessions(new PostSessionsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CreateCheckoutSessionRequest
        {
            Amount = new Amount18 { Currency = "EUR", Value = 100L },
            CountryCode = "NL",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Reference = "YOUR_PAYMENT_REFERENCE",
            ReturnUrl = "https://your-company.example.com/checkout?shopperOrder=12xy..",
        },
    });
    // TODO: Handle 'response' of type CreateCheckoutSessionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostSessionsRequest](src/Adyen/Requests/Payments/PostSessionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCheckoutSessionResponse](src/Adyen/Models/CreateCheckoutSessionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentsApp

> Source: [PaymentsApp](src/Adyen/Api/PaymentsApp.cs)

<details>
<summary><code>Task&lt;PaymentsAppResponse&gt; GetMerchantsMerchantIdPaymentsApps(GetMerchantsMerchantIdPaymentsAppsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of Payments App instances for the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Adyen Payments App role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsApp.GetMerchantsMerchantIdPaymentsApps(
        new GetMerchantsMerchantIdPaymentsAppsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type PaymentsAppResponse
}
catch (ApiException<GetMerchantsMerchantIdPaymentsAppsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdPaymentsAppsRequest](src/Adyen/Requests/PaymentsApp/GetMerchantsMerchantIdPaymentsAppsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentsAppResponse](src/Adyen/Models/PaymentsAppResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdPaymentsAppsError](src/Adyen/Errors/GetMerchantsMerchantIdPaymentsAppsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentsAppResponse&gt; GetMerchantsMerchantIdStoresStoreIdPaymentsApps(GetMerchantsMerchantIdStoresStoreIdPaymentsAppsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of Payments App instances for the store identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Adyen Payments App role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsApp.GetMerchantsMerchantIdStoresStoreIdPaymentsApps(
        new GetMerchantsMerchantIdStoresStoreIdPaymentsAppsRequest
        {
            MerchantId = "some example string",
            StoreId = "some example string",
        });
    // TODO: Handle 'response' of type PaymentsAppResponse
}
catch (ApiException<GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdStoresStoreIdPaymentsAppsRequest](src/Adyen/Requests/PaymentsApp/GetMerchantsMerchantIdStoresStoreIdPaymentsAppsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentsAppResponse](src/Adyen/Models/PaymentsAppResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError](src/Adyen/Errors/GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BoardingTokenResponse&gt; PostMerchantsMerchantIdGeneratePaymentsAppBoardingToken(PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a boarding token used to authenticate the installation of a Payments App instance on an Android device. The boarding token is created for the `boardingRequestToken` of the Payments App for the merchant account identified in the path. 

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Adyen Payments App role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsApp.PostMerchantsMerchantIdGeneratePaymentsAppBoardingToken(
        new PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenRequest
        {
            MerchantId = "some example string",
            Body = new BoardingTokenRequest { BoardingRequestToken = "some example string" },
        });
    // TODO: Handle 'response' of type BoardingTokenResponse
}
catch (ApiException<PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenRequest](src/Adyen/Requests/PaymentsApp/PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BoardingTokenResponse](src/Adyen/Models/BoardingTokenResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError](src/Adyen/Errors/PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;JsonElement&gt; PostMerchantsMerchantIdPaymentsAppsInstallationIdRevoke(PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Revokes the authentication of the Payments App instance for the `installationId` and merchant account identified in the path. This call revokes the authentication of the Payments App instance with the `installationId` identified in the path for both merchant accounts and stores.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Adyen Payments App role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsApp.PostMerchantsMerchantIdPaymentsAppsInstallationIdRevoke(
        new PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeRequest
        {
            MerchantId = "some example string",
            InstallationId = "some example string",
        });
    // TODO: Handle 'response' of type JsonElement
}
catch (ApiException<PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeRequest](src/Adyen/Requests/PaymentsApp/PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError](src/Adyen/Errors/PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BoardingTokenResponse&gt; PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingToken(PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a boarding token used to authenticate the installation of a Payments App instance on an Android device. The boarding token is created for the `boardingRequestToken` of the Payments App for the store identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Adyen Payments App role

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsApp.PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingToken(
        new PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenRequest
        {
            MerchantId = "some example string",
            StoreId = "some example string",
            Body = new BoardingTokenRequest { BoardingRequestToken = "some example string" },
        });
    // TODO: Handle 'response' of type BoardingTokenResponse
}
catch (ApiException<PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenRequest](src/Adyen/Requests/PaymentsApp/PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BoardingTokenResponse](src/Adyen/Models/BoardingTokenResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError](src/Adyen/Errors/PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PayoutSettingsMerchantLevel

> Source: [PayoutSettingsMerchantLevel](src/Adyen/Api/PayoutSettingsMerchantLevel.cs)

<details>
<summary><code>Task DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsId(DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the payout setting identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PayoutSettingsMerchantLevel.DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsId(
        new DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest
        {
            MerchantId = "some example string",
            PayoutSettingsId = "some example string",
        });
}
catch (ApiException<DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest](src/Adyen/Requests/PayoutSettingsMerchantLevel/DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError](src/Adyen/Errors/DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutSettingsResponse&gt; GetMerchantsMerchantIdPayoutSettings(GetMerchantsMerchantIdPayoutSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of payout settings for the merchant account identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payout account settings read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.GetMerchantsMerchantIdPayoutSettings(
        new GetMerchantsMerchantIdPayoutSettingsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type PayoutSettingsResponse
}
catch (ApiException<GetMerchantsMerchantIdPayoutSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdPayoutSettingsRequest](src/Adyen/Requests/PayoutSettingsMerchantLevel/GetMerchantsMerchantIdPayoutSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettingsResponse](src/Adyen/Models/PayoutSettingsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdPayoutSettingsError](src/Adyen/Errors/GetMerchantsMerchantIdPayoutSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutSettings&gt; GetMerchantsMerchantIdPayoutSettingsPayoutSettingsId(GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payout setting identified in the path.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Payout account settings read

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.GetMerchantsMerchantIdPayoutSettingsPayoutSettingsId(
        new GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest
        {
            MerchantId = "some example string",
            PayoutSettingsId = "some example string",
        });
    // TODO: Handle 'response' of type PayoutSettings
}
catch (ApiException<GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest](src/Adyen/Requests/PayoutSettingsMerchantLevel/GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettings](src/Adyen/Models/PayoutSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError](src/Adyen/Errors/GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutSettings&gt; PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsId(PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the payout setting identified in the path. You can enable or disable the payout setting.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsId(
        new PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest
        {
            MerchantId = "some example string",
            PayoutSettingsId = "some example string",
        });
    // TODO: Handle 'response' of type PayoutSettings
}
catch (ApiException<PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest](src/Adyen/Requests/PayoutSettingsMerchantLevel/PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettings](src/Adyen/Models/PayoutSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError](src/Adyen/Errors/PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutSettings&gt; PostMerchantsMerchantIdPayoutSettings(PostMerchantsMerchantIdPayoutSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends a request to add a payout setting for the merchant account specified in the path. A payout setting links the merchant account to the [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments) that contains the details of the payout bank account. Adyen verifies the bank account before allowing and enabling the payout setting.

If you're accepting payments in multiple currencies, you may add multiple payout settings for the merchant account.

Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):

* Management API—Payout account settings read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PayoutSettingsMerchantLevel.PostMerchantsMerchantIdPayoutSettings(
        new PostMerchantsMerchantIdPayoutSettingsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type PayoutSettings
}
catch (ApiException<PostMerchantsMerchantIdPayoutSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdPayoutSettingsRequest](src/Adyen/Requests/PayoutSettingsMerchantLevel/PostMerchantsMerchantIdPayoutSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutSettings](src/Adyen/Models/PayoutSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdPayoutSettingsError](src/Adyen/Errors/PostMerchantsMerchantIdPayoutSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Platform

> Source: [Platform](src/Adyen/Api/Platform.cs)

<details>
<summary><code>Task&lt;BalancePlatform&gt; GetBalancePlatformsId(GetBalancePlatformsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a balance platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Platform.GetBalancePlatformsId(new GetBalancePlatformsIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type BalancePlatform
}
catch (ApiException<GetBalancePlatformsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalancePlatformsIdRequest](src/Adyen/Requests/Platform/GetBalancePlatformsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalancePlatform](src/Adyen/Models/BalancePlatform.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalancePlatformsIdError](src/Adyen/Errors/GetBalancePlatformsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaginatedAccountHoldersResponse&gt; GetBalancePlatformsIdAccountHolders(GetBalancePlatformsIdAccountHoldersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of all the account holders that belong to the balance platform. To fetch multiple pages, use the query parameters. 

For example, to limit the page to 5 account holders and to skip the first 20, use `/balancePlatforms/{id}/accountHolders?limit=5&offset=20`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Platform.GetBalancePlatformsIdAccountHolders(
        new GetBalancePlatformsIdAccountHoldersRequest { Id = "some example string" });
    // TODO: Handle 'response' of type PaginatedAccountHoldersResponse
}
catch (ApiException<GetBalancePlatformsIdAccountHoldersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalancePlatformsIdAccountHoldersRequest](src/Adyen/Requests/Platform/GetBalancePlatformsIdAccountHoldersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaginatedAccountHoldersResponse](src/Adyen/Models/PaginatedAccountHoldersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalancePlatformsIdAccountHoldersError](src/Adyen/Errors/GetBalancePlatformsIdAccountHoldersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRulesResponse&gt; GetBalancePlatformsIdTransactionRules(GetBalancePlatformsIdTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of transaction rules associated with a balance platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Platform.GetBalancePlatformsIdTransactionRules(
        new GetBalancePlatformsIdTransactionRulesRequest { Id = "some example string" });
    // TODO: Handle 'response' of type TransactionRulesResponse
}
catch (ApiException<GetBalancePlatformsIdTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalancePlatformsIdTransactionRulesRequest](src/Adyen/Requests/Platform/GetBalancePlatformsIdTransactionRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRulesResponse](src/Adyen/Models/TransactionRulesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalancePlatformsIdTransactionRulesError](src/Adyen/Errors/GetBalancePlatformsIdTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RaiseDisputes

> Source: [RaiseDisputes](src/Adyen/Api/RaiseDisputes.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;IReadOnlyList&lt;DisputeResponse&gt;&gt;&gt; GetDisputes(GetDisputesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of raised disputes that match the query parameters.

This endpoint supports cursor-based pagination. The response returns the first page of results, and returns links to the next page when applicable. You can use the links to page through the results. The response also returns links to the previous page when applicable.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RaiseDisputes.GetDisputes(new GetDisputesRequest());
    // TODO: Handle 'response' of type IReadOnlyList<IReadOnlyList<DisputeResponse>>
}
catch (ApiException<GetDisputesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDisputesRequest](src/Adyen/Requests/RaiseDisputes/GetDisputesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;[DisputeResponse](src/Adyen/Models/DisputeResponse.cs)&gt;&gt;</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetDisputesError](src/Adyen/Errors/GetDisputesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisputeResponse&gt; GetDisputesId(GetDisputesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a raised dispute by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RaiseDisputes.GetDisputesId(new GetDisputesIdRequest { Id = "some example string" });
    // TODO: Handle 'response' of type DisputeResponse
}
catch (ApiException<GetDisputesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDisputesIdRequest](src/Adyen/Requests/RaiseDisputes/GetDisputesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisputeResponse](src/Adyen/Models/DisputeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetDisputesIdError](src/Adyen/Errors/GetDisputesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisputeResponse&gt; PatchDisputesId(PatchDisputesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update information related to a raised dispute, or change a dispute's status from **draft** to **submitted** or **closed**.

**Note:** Changing the status of a dispute to **submitted** or **closed** is a final action. You cannot make updates to a **submitted** or **closed** dispute. Make sure to upload all supporting attachments using the `POST /disputes/{id}/attachments` endpoint before you submit a dispute. When you update a dispute to **submitted**, Adyen sends the raised dispute to the card scheme for review and acquirer defense. When you update a raised dispute to **closed**, Adyen closes the dispute, and the dispute is no longer eligible for review by the card scheme.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RaiseDisputes.PatchDisputesId(new PatchDisputesIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DisputeResponse
}
catch (ApiException<PatchDisputesIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchDisputesIdRequest](src/Adyen/Requests/RaiseDisputes/PatchDisputesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisputeResponse](src/Adyen/Models/DisputeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchDisputesIdError](src/Adyen/Errors/PatchDisputesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisputeResponse&gt; PostDisputes(PostDisputesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Raise a dispute for an underlying transaction, providing a dispute type and the amount you want to dispute.

Raising a dispute returns a dispute ID, which you can use to update details about the dispute, provide supporting documentation, close the dispute, or submit the dispute for a chargeback. You can also use the dispute ID to view the status of the dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RaiseDisputes.PostDisputes(new PostDisputesRequest
    {
        Body = new DisputeRequest { TransactionId = "some example string", Type = "some example string" },
    });
    // TODO: Handle 'response' of type DisputeResponse
}
catch (ApiException<PostDisputesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDisputesRequest](src/Adyen/Requests/RaiseDisputes/PostDisputesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisputeResponse](src/Adyen/Models/DisputeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDisputesError](src/Adyen/Errors/PostDisputesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Rates

> Source: [Rates](src/Adyen/Api/Rates.cs)

<details>
<summary><code>Task&lt;CalculateRateResponse&gt; PostRatesCalculate(PostRatesCalculateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the calculated amounts and rates required to convert the currency of a transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rates.PostRatesCalculate(new PostRatesCalculateRequest
    {
        Body = new CalculateRateRequest
        {
            ExchangeCalculations = [
                new CalculateRateRequestItem
                {
                    ExchangeSide = ExchangeSide2.Buy,
                    SourceAmount = new Amount19 { Currency = "CZK", Value = 112300L },
                    TargetCurrency = "EUR",
                    Type = RateType2.SplitPayment,
                },
                new CalculateRateRequestItem
                {
                    ExchangeSide = ExchangeSide2.Sell,
                    SourceAmount = new Amount19 { Currency = "CZK", Value = 24000L },
                    TargetCurrency = "USD",
                    Type = RateType2.SplitRefund,
                },
            ],
        },
    });
    // TODO: Handle 'response' of type CalculateRateResponse
}
catch (ApiException<PostRatesCalculateError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostRatesCalculateRequest](src/Adyen/Requests/Rates/PostRatesCalculateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculateRateResponse](src/Adyen/Models/CalculateRateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostRatesCalculateError](src/Adyen/Errors/PostRatesCalculateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RecurringApi

> Source: [RecurringApi](src/Adyen/Api/RecurringApi.cs)

<details>
<summary><code>Task DeleteStoredPaymentMethodsStoredPaymentMethodId(DeleteStoredPaymentMethodsStoredPaymentMethodIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the token identified in the path. The token can no longer be used with payment requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.RecurringApi.DeleteStoredPaymentMethodsStoredPaymentMethodId(
        new DeleteStoredPaymentMethodsStoredPaymentMethodIdRequest
        {
            StoredPaymentMethodId = "some example string",
            ShopperReference = "some example string",
            MerchantAccount = "some example string",
        });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteStoredPaymentMethodsStoredPaymentMethodIdRequest](src/Adyen/Requests/RecurringApi/DeleteStoredPaymentMethodsStoredPaymentMethodIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListStoredPaymentMethodsResponse&gt; GetStoredPaymentMethods(GetStoredPaymentMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the tokens for stored payment details for the shopper identified in the path, if there are any available. The token ID can be used with payment requests for the shopper's payment. A summary of the stored details is included.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringApi.GetStoredPaymentMethods(new GetStoredPaymentMethodsRequest());
    // TODO: Handle 'response' of type ListStoredPaymentMethodsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStoredPaymentMethodsRequest](src/Adyen/Requests/RecurringApi/GetStoredPaymentMethodsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListStoredPaymentMethodsResponse](src/Adyen/Models/ListStoredPaymentMethodsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CheckoutForwardResponse&gt; PostForward(PostForwardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Forwards the payment details you stored with Adyen to a third-party that you specify and returns the response from the third-party. Supports forwarding stored card details or [network tokens](https://docs.adyen.com/online-payments/network-tokenization). For more information, see [Forward stored payment details](https://docs.adyen.com/online-payments/tokenization/forward-payment-details).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringApi.PostForward(new PostForwardRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CheckoutForwardRequest
        {
            BaseUrl = "http://thirdparty.example.com",
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            Request = new CheckoutOutgoingForwardRequest2
            {
                Body = "{\"amount\":{\"value\":100,\"currency\":\"USD\"},\"paymentMethod\":{\"creditCard\":{\"holderName\":\"{{holderName}}\",\"number\":\"{{number}}\",\"expiryMonth\":\"{{expiryMonth}}\",\"expiryYear\":\"{{expiryYear}}\"}}}",
                Credentials = "YOUR_CREDENTIALS_FOR_THE_THIRD_PARTY",
                Headers = new Dictionary<string, string> { ["Authorization"] = "Basic {{credentials}}" },
                HttpMethod = HttpMethodEnum.Post,
                UrlSuffix = "/payments",
            },
            ShopperReference = "YOUR_SHOPPER_REFERENCE",
            StoredPaymentMethodId = "M5N7TQ4TG5PFWR50",
        },
    });
    // TODO: Handle 'response' of type CheckoutForwardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostForwardRequest](src/Adyen/Requests/RecurringApi/PostForwardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CheckoutForwardResponse](src/Adyen/Models/CheckoutForwardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StoredPaymentMethodResource&gt; PostStoredPaymentMethods(PostStoredPaymentMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a token to store the shopper's payment details. This token can be used for the shopper's future payments.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringApi.PostStoredPaymentMethods(new PostStoredPaymentMethodsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new StoredPaymentMethodRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            PaymentMethod = new PaymentMethodToStore1
            {
                EncryptedCardNumber = "test_4111111111111111",
                EncryptedExpiryMonth = "test_03",
                EncryptedExpiryYear = "test_2030",
                EncryptedSecurityCode = "test_737",
                HolderName = "John Smith",
                Type = "scheme",
            },
            RecurringProcessingModel = RecurringProcessingModel1.Subscription,
            ShopperEmail = "s.hopper@test.com",
            ShopperIp = "192.0.2.1",
            ShopperReference = "YOUR_SHOPPER_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type StoredPaymentMethodResource
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostStoredPaymentMethodsRequest](src/Adyen/Requests/RecurringApi/PostStoredPaymentMethodsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StoredPaymentMethodResource](src/Adyen/Models/StoredPaymentMethodResource.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RecurringTopUps

> Source: [RecurringTopUps](src/Adyen/Api/RecurringTopUps.cs)

<details>
<summary><code>Task&lt;JsonElement&gt; DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a recurring top up configuration by `topUpId`.

For more information, refer to [Manage recurring top-ups](https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringTopUps.DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(
        new DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest
        {
            BalanceAccountId = "some example string",
            TopUpId = "some example string",
        });
    // TODO: Handle 'response' of type JsonElement
}
catch (ApiException<DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest](src/Adyen/Requests/RecurringTopUps/DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError](src/Adyen/Errors/DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringTopUpsResult&gt; GetBalanceAccountsBalanceAccountIdRecurringTopUps(GetBalanceAccountsBalanceAccountIdRecurringTopUpsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

View all recurring top ups configured for a specific `balanceAccountId`.

For more information, refer to [Manage recurring top-ups](https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringTopUps.GetBalanceAccountsBalanceAccountIdRecurringTopUps(
        new GetBalanceAccountsBalanceAccountIdRecurringTopUpsRequest { BalanceAccountId = "some example string" });
    // TODO: Handle 'response' of type RecurringTopUpsResult
}
catch (ApiException<GetBalanceAccountsBalanceAccountIdRecurringTopUpsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsBalanceAccountIdRecurringTopUpsRequest](src/Adyen/Requests/RecurringTopUps/GetBalanceAccountsBalanceAccountIdRecurringTopUpsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringTopUpsResult](src/Adyen/Models/RecurringTopUpsResult.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsBalanceAccountIdRecurringTopUpsError](src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdRecurringTopUpsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringTopUp&gt; PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the configuration of an existing recurring top up.

For more information, refer to [Manage recurring top-ups](https://docs.adyen.com/issuing/add-manage-funds/top-ups/manage-recurring-top-ups).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringTopUps.PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(
        new PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest
        {
            BalanceAccountId = "some example string",
            TopUpId = "some example string",
            Body = new PatchableCreateRecurringTopUp { Description = "new description" },
        });
    // TODO: Handle 'response' of type RecurringTopUp
}
catch (ApiException<PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest](src/Adyen/Requests/RecurringTopUps/PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringTopUp](src/Adyen/Models/RecurringTopUp.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError](src/Adyen/Errors/PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringTopUp&gt; PostBalanceAccountsBalanceAccountIdRecurringTopUps(PostBalanceAccountsBalanceAccountIdRecurringTopUpsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a recurring top up configuration.

For more information, refer to [Create recurring top-ups](https://docs.adyen.com/issuing/add-manage-funds/top-ups/create-recurring-top-ups).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RecurringTopUps.PostBalanceAccountsBalanceAccountIdRecurringTopUps(
        new PostBalanceAccountsBalanceAccountIdRecurringTopUpsRequest
        {
            BalanceAccountId = "some example string",
            Body = new CreateRecurringTopUp
            {
                Counterparty = new TopUpCounterparty1 { TransferInstrumentId = "SE000000000000000000000001" },
                Description = "My description",
                TopUpAmount = new TopUpAmount1 { Fixed = new Amount17 { Currency = "EUR", Value = 1000L } },
                Trigger = new Trigger1
                {
                    Schedule = new Schedule21 { Type = ScheduleType1.Weekdays },
                    Threshold = new Amount17 { Currency = "EUR", Value = 100L },
                },
            },
        });
    // TODO: Handle 'response' of type RecurringTopUp
}
catch (ApiException<PostBalanceAccountsBalanceAccountIdRecurringTopUpsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostBalanceAccountsBalanceAccountIdRecurringTopUpsRequest](src/Adyen/Requests/RecurringTopUps/PostBalanceAccountsBalanceAccountIdRecurringTopUpsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringTopUp](src/Adyen/Models/RecurringTopUp.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostBalanceAccountsBalanceAccountIdRecurringTopUpsError](src/Adyen/Errors/PostBalanceAccountsBalanceAccountIdRecurringTopUpsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Reviewing

> Source: [Reviewing](src/Adyen/Api/Reviewing.cs)

<details>
<summary><code>Task&lt;ModifyResponse&gt; PostConfirmThirdParty(PostConfirmThirdPartyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the [Transfers API](https://docs.adyen.com/api-explorer/transfers/latest/overview) instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


Confirms a previously submitted payout.

To cancel a payout, use the `/declineThirdParty` endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reviewing.PostConfirmThirdParty(new PostConfirmThirdPartyRequest
    {
        Body = new ModifyRequest { MerchantAccount = "YOUR_MERCHANT_ACCOUNT", OriginalReference = "9913140798220028" },
    });
    // TODO: Handle 'response' of type ModifyResponse
}
catch (ApiException<PostConfirmThirdPartyError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostConfirmThirdPartyRequest](src/Adyen/Requests/Reviewing/PostConfirmThirdPartyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModifyResponse](src/Adyen/Models/ModifyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostConfirmThirdPartyError](src/Adyen/Errors/PostConfirmThirdPartyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModifyResponse&gt; PostDeclineThirdParty(PostDeclineThirdPartyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

> This endpoint is **deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the [Transfers API](https://docs.adyen.com/api-explorer/transfers/latest/overview) instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


Cancels a previously submitted payout.

To confirm and send a payout, use the `/confirmThirdParty` endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Reviewing.PostDeclineThirdParty(new PostDeclineThirdPartyRequest
    {
        Body = new ModifyRequest { MerchantAccount = "YOUR_MERCHANT_ACCOUNT", OriginalReference = "9913140798220028" },
    });
    // TODO: Handle 'response' of type ModifyResponse
}
catch (ApiException<PostDeclineThirdPartyError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDeclineThirdPartyRequest](src/Adyen/Requests/Reviewing/PostDeclineThirdPartyRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModifyResponse](src/Adyen/Models/ModifyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDeclineThirdPartyError](src/Adyen/Errors/PostDeclineThirdPartyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ScaAssociationManagement

> Source: [ScaAssociationManagement](src/Adyen/Api/ScaAssociationManagement.cs)

<details>
<summary><code>Task DeleteScaAssociations(DeleteScaAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes one or more SCA associations for a device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ScaAssociationManagement.DeleteScaAssociations(new DeleteScaAssociationsRequest
    {
        WwwAuthenticate = "some example string",
        Body = new RemoveAssociationRequest
        {
            EntityId = "AH00000000000000000000001",
            EntityType = ScaEntityType3.AccountHolder,
            ScaDeviceIds = ["BSDR42XV3223223S5N6CDQDGH53M8H"],
        },
    });
}
catch (ApiException<DeleteScaAssociationsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteScaAssociationsRequest](src/Adyen/Requests/ScaAssociationManagement/DeleteScaAssociationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteScaAssociationsError](src/Adyen/Errors/DeleteScaAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListAssociationsResponse&gt; GetScaAssociations(GetScaAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of the SCA devices associated with a specific entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ScaAssociationManagement.GetScaAssociations(new GetScaAssociationsRequest
    {
        EntityType = ScaEntityType.AccountHolder,
        EntityId = "some example string",
        PageSize = 1,
        PageNumber = 1,
    });
    // TODO: Handle 'response' of type ListAssociationsResponse
}
catch (ApiException<GetScaAssociationsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetScaAssociationsRequest](src/Adyen/Requests/ScaAssociationManagement/GetScaAssociationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListAssociationsResponse](src/Adyen/Models/ListAssociationsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetScaAssociationsError](src/Adyen/Errors/GetScaAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApproveAssociationResponse&gt; PatchScaAssociations(PatchScaAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approves a previously created association that is in a pending state.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ScaAssociationManagement.PatchScaAssociations(new PatchScaAssociationsRequest
    {
        WwwAuthenticate = "some example string",
        Body = new ApproveAssociationRequest
        {
            EntityId = "AH00000000000000000000001",
            EntityType = ScaEntityType2.AccountHolder,
            ScaDeviceIds = ["BSDR42XV3223223S5N6CDQDGH53M8H"],
            Status = AssociationStatus1.Active,
        },
    });
    // TODO: Handle 'response' of type ApproveAssociationResponse
}
catch (ApiException<PatchScaAssociationsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchScaAssociationsRequest](src/Adyen/Requests/ScaAssociationManagement/PatchScaAssociationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApproveAssociationResponse](src/Adyen/Models/ApproveAssociationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchScaAssociationsError](src/Adyen/Errors/PatchScaAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ScaDeviceManagement

> Source: [ScaDeviceManagement](src/Adyen/Api/ScaDeviceManagement.cs)

<details>
<summary><code>Task DeleteScaDevicesDeviceId(DeleteScaDevicesDeviceIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a Strong Customer Authentication (SCA) device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ScaDeviceManagement.DeleteScaDevicesDeviceId(new DeleteScaDevicesDeviceIdRequest
    {
        DeviceId = "some example string",
    });
}
catch (ApiException<DeleteScaDevicesDeviceIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteScaDevicesDeviceIdRequest](src/Adyen/Requests/ScaDeviceManagement/DeleteScaDevicesDeviceIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteScaDevicesDeviceIdError](src/Adyen/Errors/DeleteScaDevicesDeviceIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FinishScaDeviceRegistrationResponse&gt; PatchScaDevicesDeviceId(PatchScaDevicesDeviceIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Finishes the registration process for a new Strong Customer Authentication (SCA) device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ScaDeviceManagement.PatchScaDevicesDeviceId(new PatchScaDevicesDeviceIdRequest
    {
        DeviceId = "some example string",
        Body = new FinishScaDeviceRegistrationRequest
        {
            SdkOutput = "eyJjaGFsbGVuZ2UiOiJVWEZaTURONGNXWjZUVFExUlhWV2JuaEJPVzVzTm05cVVEUktUbFZtZGtrPSJ9",
        },
    });
    // TODO: Handle 'response' of type FinishScaDeviceRegistrationResponse
}
catch (ApiException<PatchScaDevicesDeviceIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchScaDevicesDeviceIdRequest](src/Adyen/Requests/ScaDeviceManagement/PatchScaDevicesDeviceIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FinishScaDeviceRegistrationResponse](src/Adyen/Models/FinishScaDeviceRegistrationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchScaDevicesDeviceIdError](src/Adyen/Errors/PatchScaDevicesDeviceIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeginScaDeviceRegistrationResponse&gt; PostScaDevices(PostScaDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Begins the registration process for a new Strong Customer Authentication (SCA) device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ScaDeviceManagement.PostScaDevices(new PostScaDevicesRequest
    {
        Body = new BeginScaDeviceRegistrationRequest
        {
            Name = "My Device",
            SdkOutput = "eyJjaGFsbGVuZ2UiOiJVWEZaTURONGNXWjZUVFExUlhWV2JuaEJPVzVzTm05cVVEUktUbFZtZGtrPSJ9",
        },
    });
    // TODO: Handle 'response' of type BeginScaDeviceRegistrationResponse
}
catch (ApiException<PostScaDevicesError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostScaDevicesRequest](src/Adyen/Requests/ScaDeviceManagement/PostScaDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeginScaDeviceRegistrationResponse](src/Adyen/Models/BeginScaDeviceRegistrationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostScaDevicesError](src/Adyen/Errors/PostScaDevicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubmitScaAssociationResponse&gt; PostScaDevicesDeviceIdScaAssociations(PostScaDevicesDeviceIdScaAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an association between an SCA-enabled device and an entity, such as an account holder. This action does not guarantee the association is immediately ready for use; its status may be `pendingApproval` if the account holder has existing devices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ScaDeviceManagement.PostScaDevicesDeviceIdScaAssociations(
        new PostScaDevicesDeviceIdScaAssociationsRequest
        {
            DeviceId = "some example string",
            Body = new SubmitScaAssociationRequest
            {
                Entities = [new ScaEntity { Id = "AH00000000000000000000001", Type = ScaEntityType4.AccountHolder }],
            },
        });
    // TODO: Handle 'response' of type SubmitScaAssociationResponse
}
catch (ApiException<PostScaDevicesDeviceIdScaAssociationsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostScaDevicesDeviceIdScaAssociationsRequest](src/Adyen/Requests/ScaDeviceManagement/PostScaDevicesDeviceIdScaAssociationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubmitScaAssociationResponse](src/Adyen/Models/SubmitScaAssociationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostScaDevicesDeviceIdScaAssociationsError](src/Adyen/Errors/PostScaDevicesDeviceIdScaAssociationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SessionAuthentication

> Source: [SessionAuthentication](src/Adyen/Api/SessionAuthentication.cs)

<details>
<summary><code>Task&lt;CertificateLoadingResponse&gt; PostAuthCertificate(PostAuthCertificateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Establishes a secure communication session between the Mobile SDK and the Adyen payments platform, through mutual authentication. The request sends a setup token that identifies the SDK and the device. The response returns a session token that the SDK can use to authenticate responses received from the Adyen payments platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SessionAuthentication.PostAuthCertificate(new PostAuthCertificateRequest
    {
        Body = new CertificateLoadingRequest
        {
            MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
            SetupToken = "SETUP_TOKEN",
            Store = "YOUR_STORE_REFERENCE",
        },
    });
    // TODO: Handle 'response' of type CertificateLoadingResponse
}
catch (ApiException<PostAuthCertificateError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAuthCertificateRequest](src/Adyen/Requests/SessionAuthentication/PostAuthCertificateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CertificateLoadingResponse](src/Adyen/Models/CertificateLoadingResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostAuthCertificateError](src/Adyen/Errors/PostAuthCertificateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthenticationSessionResponse&gt; PostSessions2(PostSessions2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a session token that is required to integrate [components](https://docs.adyen.com/platforms/components-overview).

The response contains encrypted session data. The front end then uses the session data to make the required server-side calls for the component.

To create a token, you must meet specific requirements. These requirements vary depending on the type of component. For more information, see the documentation for [Onboarding](https://docs.adyen.com/platforms/onboard-users/components) and [Platform Experience](https://docs.adyen.com/platforms/build-user-dashboards) components.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SessionAuthentication.PostSessions2(new PostSessions2Request
    {
        Body = new AuthenticationSessionRequest
        {
            AllowOrigin = "https://www.your-website.com",
            Policy = new Policy2
            {
                Resources = [new Resource { Type = "legalEntity" }],
                Roles = ["createTransferInstrumentComponent", "manageTransferInstrumentComponent"],
            },
            Product = ProductType2.Onboarding,
        },
    });
    // TODO: Handle 'response' of type AuthenticationSessionResponse
}
catch (ApiException<PostSessions2Error> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostSessions2Request](src/Adyen/Requests/SessionAuthentication/PostSessions2Request.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthenticationSessionResponse](src/Adyen/Models/AuthenticationSessionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostSessions2Error](src/Adyen/Errors/PostSessions2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SplitConfigurationMerchantLevel

> Source: [SplitConfigurationMerchantLevel](src/Adyen/Api/SplitConfigurationMerchantLevel.cs)

<details>
<summary><code>Task&lt;SplitConfiguration&gt; DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(
        new DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest](src/Adyen/Requests/SplitConfigurationMerchantLevel/DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/Adyen/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError](src/Adyen/Errors/DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the rule specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(
        new DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
            RuleId = "some example string",
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest](src/Adyen/Requests/SplitConfigurationMerchantLevel/DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/Adyen/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError](src/Adyen/Errors/DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfigurationList&gt; GetMerchantsMerchantIdSplitConfigurations(GetMerchantsMerchantIdSplitConfigurationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of split configuration profiles for the merchant account.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.GetMerchantsMerchantIdSplitConfigurations(
        new GetMerchantsMerchantIdSplitConfigurationsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type SplitConfigurationList
}
catch (ApiException<GetMerchantsMerchantIdSplitConfigurationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdSplitConfigurationsRequest](src/Adyen/Requests/SplitConfigurationMerchantLevel/GetMerchantsMerchantIdSplitConfigurationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfigurationList](src/Adyen/Models/SplitConfigurationList.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdSplitConfigurationsError](src/Adyen/Errors/GetMerchantsMerchantIdSplitConfigurationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(
        new GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest](src/Adyen/Requests/SplitConfigurationMerchantLevel/GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/Adyen/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError](src/Adyen/Errors/GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the description of the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(
        new PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
            Body = new UpdateSplitConfigurationRequest
            {
                Description = "Updated description for the split configuration",
            },
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest](src/Adyen/Requests/SplitConfigurationMerchantLevel/PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/Adyen/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError](src/Adyen/Errors/PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [split conditions of the rule](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-condition) specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(
        new PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
            RuleId = "some example string",
            Body = new UpdateSplitConfigurationRuleRequest
            {
                Currency = "EUR",
                FundingSource = "ANY",
                PaymentMethod = "visa",
                ShopperInteraction = "ANY",
            },
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest](src/Adyen/Requests/SplitConfigurationMerchantLevel/PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/Adyen/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError](src/Adyen/Errors/PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; PatchMerchantsSplitConfigurationsRulesSplitLogic(PatchMerchantsSplitConfigurationsRulesSplitLogicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [split logic](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-split-logic) specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.PatchMerchantsSplitConfigurationsRulesSplitLogic(
        new PatchMerchantsSplitConfigurationsRulesSplitLogicRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
            RuleId = "some example string",
            SplitLogicId = "some example string",
            Body = new UpdateSplitConfigurationLogicRequest
            {
                AdditionalCommission = new AdditionalCommission1
                {
                    BalanceAccountId = "BA3227C223222H5HQ2XX77VVH",
                    FixedAmount = 100L,
                    VariablePercentage = 0L,
                },
                Chargeback = Behavior.DeductFromLiableAccount,
                Commission = new Commission1 { FixedAmount = 100L, VariablePercentage = 100L },
                PaymentFee = PaymentFee.DeductFromLiableAccount,
                Remainder = Remainder.AddToLiableAccount,
                Tip = Tip.AddToLiableAccount,
            },
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<PatchMerchantsSplitConfigurationsRulesSplitLogicError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsSplitConfigurationsRulesSplitLogicRequest](src/Adyen/Requests/SplitConfigurationMerchantLevel/PatchMerchantsSplitConfigurationsRulesSplitLogicRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/Adyen/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsSplitConfigurationsRulesSplitLogicError](src/Adyen/Errors/PatchMerchantsSplitConfigurationsRulesSplitLogicError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; PostMerchantsMerchantIdSplitConfigurations(PostMerchantsMerchantIdSplitConfigurationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a split configuration profile to [split payments automatically](https://docs.adyen.com/platforms/automatic-split-configuration/). After you [associate it with a store](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId)/stores/(storeId)#request-splitConfiguration) in your merchant account, it splits the funds of all transactions processed through that store between your liable balance account and [your user's balance account](https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId)/stores/(storeId)#request-splitConfiguration-balanceAccountId).

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.PostMerchantsMerchantIdSplitConfigurations(
        new PostMerchantsMerchantIdSplitConfigurationsRequest
        {
            MerchantId = "some example string",
            Body = new SplitConfiguration
            {
                Description = "Your description for the split configuration",
                Rules = [
                    new SplitConfigurationRule
                    {
                        Currency = "ANY",
                        FundingSource = FundingSource1.Any,
                        PaymentMethod = "ANY",
                        ShopperInteraction = ShopperInteraction11.Any,
                        SplitLogic = new SplitConfigurationLogic2
                        {
                            AdditionalCommission = new AdditionalCommission1(),
                            Chargeback = Behavior.DeductFromLiableAccount,
                            Commission = new Commission1(),
                            PaymentFee = PaymentFee.DeductFromLiableAccount,
                            Remainder = Remainder.AddToOneBalanceAccount,
                            Tip = Tip.AddToOneBalanceAccount,
                        },
                    },
                ],
            },
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<PostMerchantsMerchantIdSplitConfigurationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdSplitConfigurationsRequest](src/Adyen/Requests/SplitConfigurationMerchantLevel/PostMerchantsMerchantIdSplitConfigurationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/Adyen/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdSplitConfigurationsError](src/Adyen/Errors/PostMerchantsMerchantIdSplitConfigurationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SplitConfiguration&gt; PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

[Creates a rule](https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#create-rule) in the split configuration profile specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API - SplitConfiguration read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SplitConfigurationMerchantLevel.PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(
        new PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest
        {
            MerchantId = "some example string",
            SplitConfigurationId = "some example string",
            Body = new SplitConfigurationRule
            {
                Currency = "USD",
                FundingSource = FundingSource1.Any,
                PaymentMethod = "visa",
                ShopperInteraction = ShopperInteraction11.Pos,
                SplitLogic = new SplitConfigurationLogic2
                {
                    AdditionalCommission = new AdditionalCommission1
                    {
                        BalanceAccountId = "BA3227C223222H5HQ2XX77VVH",
                        FixedAmount = 10L,
                        VariablePercentage = 50L,
                    },
                    Chargeback = Behavior.DeductFromLiableAccount,
                    Commission = new Commission1 { FixedAmount = 10L, VariablePercentage = 100L },
                    PaymentFee = PaymentFee.DeductFromLiableAccount,
                    Remainder = Remainder.AddToLiableAccount,
                    Tip = Tip.AddToOneBalanceAccount,
                },
            },
        });
    // TODO: Handle 'response' of type SplitConfiguration
}
catch (ApiException<PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest](src/Adyen/Requests/SplitConfigurationMerchantLevel/PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SplitConfiguration](src/Adyen/Models/SplitConfiguration.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError](src/Adyen/Errors/PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TaxEDeliveryConsent

> Source: [TaxEDeliveryConsent](src/Adyen/Api/TaxEDeliveryConsent.cs)

<details>
<summary><code>Task&lt;CheckTaxElectronicDeliveryConsentResponse&gt; PostLegalEntitiesIdCheckTaxElectronicDeliveryConsent(PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the consent status for electronic delivery of tax forms.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TaxEDeliveryConsent.PostLegalEntitiesIdCheckTaxElectronicDeliveryConsent(
        new PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentRequest { Id = "some example string" });
    // TODO: Handle 'response' of type CheckTaxElectronicDeliveryConsentResponse
}
catch (ApiException<PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentRequest](src/Adyen/Requests/TaxEDeliveryConsent/PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CheckTaxElectronicDeliveryConsentResponse](src/Adyen/Models/CheckTaxElectronicDeliveryConsentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError](src/Adyen/Errors/PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostLegalEntitiesIdSetTaxElectronicDeliveryConsent(PostLegalEntitiesIdSetTaxElectronicDeliveryConsentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Set the consent status for electronic delivery of tax forms.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TaxEDeliveryConsent.PostLegalEntitiesIdSetTaxElectronicDeliveryConsent(
        new PostLegalEntitiesIdSetTaxElectronicDeliveryConsentRequest { Id = "some example string" });
}
catch (ApiException<PostLegalEntitiesIdSetTaxElectronicDeliveryConsentError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLegalEntitiesIdSetTaxElectronicDeliveryConsentRequest](src/Adyen/Requests/TaxEDeliveryConsent/PostLegalEntitiesIdSetTaxElectronicDeliveryConsentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostLegalEntitiesIdSetTaxElectronicDeliveryConsentError](src/Adyen/Errors/PostLegalEntitiesIdSetTaxElectronicDeliveryConsentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalActionsCompanyLevel

> Source: [TerminalActionsCompanyLevel](src/Adyen/Api/TerminalActionsCompanyLevel.cs)

<details>
<summary><code>Task&lt;ListExternalTerminalActionsResponse&gt; GetCompaniesCompanyIdTerminalActions(GetCompaniesCompanyIdTerminalActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [terminal actions](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api) that have been scheduled for the company identified in the path.The response doesn't include actions that are scheduled by Adyen.
To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalActionsCompanyLevel.GetCompaniesCompanyIdTerminalActions(
        new GetCompaniesCompanyIdTerminalActionsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type ListExternalTerminalActionsResponse
}
catch (ApiException<GetCompaniesCompanyIdTerminalActionsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdTerminalActionsRequest](src/Adyen/Requests/TerminalActionsCompanyLevel/GetCompaniesCompanyIdTerminalActionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListExternalTerminalActionsResponse](src/Adyen/Models/ListExternalTerminalActionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdTerminalActionsError](src/Adyen/Errors/GetCompaniesCompanyIdTerminalActionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ExternalTerminalAction&gt; GetCompaniesCompanyIdTerminalActionsActionId(GetCompaniesCompanyIdTerminalActionsActionIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the [terminal action](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api) identified in the path.
To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal actions read
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalActionsCompanyLevel.GetCompaniesCompanyIdTerminalActionsActionId(
        new GetCompaniesCompanyIdTerminalActionsActionIdRequest
        {
            CompanyId = "some example string",
            ActionId = "some example string",
        });
    // TODO: Handle 'response' of type ExternalTerminalAction
}
catch (ApiException<GetCompaniesCompanyIdTerminalActionsActionIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdTerminalActionsActionIdRequest](src/Adyen/Requests/TerminalActionsCompanyLevel/GetCompaniesCompanyIdTerminalActionsActionIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ExternalTerminalAction](src/Adyen/Models/ExternalTerminalAction.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdTerminalActionsActionIdError](src/Adyen/Errors/GetCompaniesCompanyIdTerminalActionsActionIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalActionsTerminalLevel

> Source: [TerminalActionsTerminalLevel](src/Adyen/Api/TerminalActionsTerminalLevel.cs)

<details>
<summary><code>Task&lt;ScheduleTerminalActionsResponse&gt; PostTerminalsScheduleActions(PostTerminalsScheduleActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a [terminal action](https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api) by specifying the action and the terminals that the action must be applied to. 

The following restrictions apply:
* You can schedule only one action at a time. For example, to install a new app version and remove an old app version, you have to make two API requests. 
* The maximum number of terminals in a request is **100**. For example, to apply an action to 250 terminals, you have to divide the terminals over three API requests. 
* If there is an error with one or more terminal IDs in the request, the action is scheduled for none of the terminals. You need to fix the error and try again. 

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal actions read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalActionsTerminalLevel.PostTerminalsScheduleActions(
        new PostTerminalsScheduleActionsRequest());
    // TODO: Handle 'response' of type ScheduleTerminalActionsResponse
}
catch (ApiException<PostTerminalsScheduleActionsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTerminalsScheduleActionsRequest](src/Adyen/Requests/TerminalActionsTerminalLevel/PostTerminalsScheduleActionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ScheduleTerminalActionsResponse](src/Adyen/Models/ScheduleTerminalActionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTerminalsScheduleActionsError](src/Adyen/Errors/PostTerminalsScheduleActionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalOrdersCompanyLevel

> Source: [TerminalOrdersCompanyLevel](src/Adyen/Api/TerminalOrdersCompanyLevel.cs)

<details>
<summary><code>Task&lt;BillingEntitiesResponse&gt; GetCompaniesCompanyIdBillingEntities(GetCompaniesCompanyIdBillingEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the billing entities of the company identified in the path and all merchant accounts belonging to the company.
A billing entity is a legal entity where we charge orders to. An order for terminal products must contain the ID of a billing entity.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdBillingEntities(
        new GetCompaniesCompanyIdBillingEntitiesRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type BillingEntitiesResponse
}
catch (ApiException<GetCompaniesCompanyIdBillingEntitiesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdBillingEntitiesRequest](src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdBillingEntitiesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BillingEntitiesResponse](src/Adyen/Models/BillingEntitiesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdBillingEntitiesError](src/Adyen/Errors/GetCompaniesCompanyIdBillingEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocationsResponse&gt; GetCompaniesCompanyIdShippingLocations(GetCompaniesCompanyIdShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the shipping locations for the company identified in the path and all merchant accounts belonging to the company.
A shipping location includes the address where orders can be delivered, and an ID which you need to specify when ordering terminal products.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdShippingLocations(
        new GetCompaniesCompanyIdShippingLocationsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type ShippingLocationsResponse
}
catch (ApiException<GetCompaniesCompanyIdShippingLocationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdShippingLocationsRequest](src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdShippingLocationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocationsResponse](src/Adyen/Models/ShippingLocationsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdShippingLocationsError](src/Adyen/Errors/GetCompaniesCompanyIdShippingLocationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalModelsResponse&gt; GetCompaniesCompanyIdTerminalModels(GetCompaniesCompanyIdTerminalModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of payment terminal models that the company identified in the path has access to.
The response includes the terminal model ID, which can be used as a query parameter when getting a list of terminals or a list of products for ordering.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdTerminalModels(
        new GetCompaniesCompanyIdTerminalModelsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type TerminalModelsResponse
}
catch (ApiException<GetCompaniesCompanyIdTerminalModelsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdTerminalModelsRequest](src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdTerminalModelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalModelsResponse](src/Adyen/Models/TerminalModelsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdTerminalModelsError](src/Adyen/Errors/GetCompaniesCompanyIdTerminalModelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrdersResponse&gt; GetCompaniesCompanyIdTerminalOrders(GetCompaniesCompanyIdTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a lists of terminal products orders for the company identified in the path.
To filter the list, use one or more of the query parameters.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdTerminalOrders(
        new GetCompaniesCompanyIdTerminalOrdersRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type TerminalOrdersResponse
}
catch (ApiException<GetCompaniesCompanyIdTerminalOrdersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdTerminalOrdersRequest](src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdTerminalOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrdersResponse](src/Adyen/Models/TerminalOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdTerminalOrdersError](src/Adyen/Errors/GetCompaniesCompanyIdTerminalOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; GetCompaniesCompanyIdTerminalOrdersOrderId(GetCompaniesCompanyIdTerminalOrdersOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the terminal products order identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdTerminalOrdersOrderId(
        new GetCompaniesCompanyIdTerminalOrdersOrderIdRequest
        {
            CompanyId = "some example string",
            OrderId = "some example string",
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<GetCompaniesCompanyIdTerminalOrdersOrderIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdTerminalOrdersOrderIdRequest](src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdTerminalOrdersOrderIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/Adyen/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdTerminalOrdersOrderIdError](src/Adyen/Errors/GetCompaniesCompanyIdTerminalOrdersOrderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalProductsResponse&gt; GetCompaniesCompanyIdTerminalProducts(GetCompaniesCompanyIdTerminalProductsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a country-specific list of payment terminal packages and parts that the company identified in the path has access to.
 
To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.GetCompaniesCompanyIdTerminalProducts(
        new GetCompaniesCompanyIdTerminalProductsRequest
        {
            CompanyId = "some example string",
            Country = "some example string",
        });
    // TODO: Handle 'response' of type TerminalProductsResponse
}
catch (ApiException<GetCompaniesCompanyIdTerminalProductsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdTerminalProductsRequest](src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdTerminalProductsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalProductsResponse](src/Adyen/Models/TerminalProductsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdTerminalProductsError](src/Adyen/Errors/GetCompaniesCompanyIdTerminalProductsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PatchCompaniesCompanyIdTerminalOrdersOrderId(PatchCompaniesCompanyIdTerminalOrdersOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the terminal products order identified in the path.
Updating is only possible while the order has the status **Placed**.

The request body only needs to contain what you want to change. 
However, to update the products in the `items` array, you must provide the entire array. For example, if the array has three items:
 To remove one item, the array must include the remaining two items. Or to add one item, the array must include all four items.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.PatchCompaniesCompanyIdTerminalOrdersOrderId(
        new PatchCompaniesCompanyIdTerminalOrdersOrderIdRequest
        {
            CompanyId = "some example string",
            OrderId = "some example string",
            Body = new TerminalOrderRequest
            {
                Items = [
                    new OrderItem { Id = "TBOX-V400m-684-EU", Name = "V400m Package", Quantity = 1 },
                    new OrderItem { Id = "PART-175746-EU", Name = "Adyen Test Card", Quantity = 1 },
                    new OrderItem { Id = "PART-620222-EU", Name = "Receipt Roll", Quantity = 5 },
                ],
            },
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<PatchCompaniesCompanyIdTerminalOrdersOrderIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchCompaniesCompanyIdTerminalOrdersOrderIdRequest](src/Adyen/Requests/TerminalOrdersCompanyLevel/PatchCompaniesCompanyIdTerminalOrdersOrderIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/Adyen/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchCompaniesCompanyIdTerminalOrdersOrderIdError](src/Adyen/Errors/PatchCompaniesCompanyIdTerminalOrdersOrderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocation&gt; PostCompaniesCompanyIdShippingLocations(PostCompaniesCompanyIdShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a shipping location for the company identified in the path. A shipping location defines an address where orders can be delivered.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.PostCompaniesCompanyIdShippingLocations(
        new PostCompaniesCompanyIdShippingLocationsRequest
        {
            CompanyId = "some example string",
            Body = new ShippingLocation
            {
                Address = new Address21
                {
                    City = "Amsterdam",
                    CompanyName = "YOUR_COMPANY",
                    Country = "NL",
                    PostalCode = "1012 KS",
                    StateOrProvince = "",
                    StreetAddress = "Rokin 21",
                },
                Contact = new Contact1
                {
                    Email = "Paul.Green@company.com",
                    FirstName = "Paul",
                    LastName = "Green",
                    PhoneNumber = "+31 020 1234567",
                },
                Name = "YOUR_COMPANY Rokin depot",
            },
        });
    // TODO: Handle 'response' of type ShippingLocation
}
catch (ApiException<PostCompaniesCompanyIdShippingLocationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdShippingLocationsRequest](src/Adyen/Requests/TerminalOrdersCompanyLevel/PostCompaniesCompanyIdShippingLocationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocation](src/Adyen/Models/ShippingLocation.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdShippingLocationsError](src/Adyen/Errors/PostCompaniesCompanyIdShippingLocationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PostCompaniesCompanyIdTerminalOrders(PostCompaniesCompanyIdTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an order for payment terminal products for the company identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write
>Requests to the Management API test endpoint do not create actual orders for test terminals. To order test terminals, you need to [submit a sales order](https://docs.adyen.com/point-of-sale/managing-terminals/order-terminals/#sales-order-steps) in your Customer Area.

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.PostCompaniesCompanyIdTerminalOrders(
        new PostCompaniesCompanyIdTerminalOrdersRequest
        {
            CompanyId = "some example string",
            Body = new TerminalOrderRequest
            {
                BillingEntityId = "Company.YOUR_COMPANY",
                CustomerOrderReference = "YOUR_REFERENCE",
                Items = [
                    new OrderItem { Id = "TBOX-V400m-684-EU", Name = "V400m Package", Quantity = 1 },
                    new OrderItem { Id = "PART-175746-EU", Name = "Adyen Test Card", Quantity = 1 },
                ],
                ShippingLocationId = "S2-6A6C2E3432747D4F2F2C3455485E3836457D",
            },
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<PostCompaniesCompanyIdTerminalOrdersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdTerminalOrdersRequest](src/Adyen/Requests/TerminalOrdersCompanyLevel/PostCompaniesCompanyIdTerminalOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/Adyen/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdTerminalOrdersError](src/Adyen/Errors/PostCompaniesCompanyIdTerminalOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PostCompaniesCompanyIdTerminalOrdersOrderIdCancel(PostCompaniesCompanyIdTerminalOrdersOrderIdCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the terminal products order identified in the path.
Cancelling is only possible while the order has the status **Placed**.
To cancel an order, make a POST call without a request body. The response returns the full order details, but with the status changed to **Cancelled**.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersCompanyLevel.PostCompaniesCompanyIdTerminalOrdersOrderIdCancel(
        new PostCompaniesCompanyIdTerminalOrdersOrderIdCancelRequest
        {
            CompanyId = "some example string",
            OrderId = "some example string",
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<PostCompaniesCompanyIdTerminalOrdersOrderIdCancelError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdTerminalOrdersOrderIdCancelRequest](src/Adyen/Requests/TerminalOrdersCompanyLevel/PostCompaniesCompanyIdTerminalOrdersOrderIdCancelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/Adyen/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdTerminalOrdersOrderIdCancelError](src/Adyen/Errors/PostCompaniesCompanyIdTerminalOrdersOrderIdCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalOrdersMerchantLevel

> Source: [TerminalOrdersMerchantLevel](src/Adyen/Api/TerminalOrdersMerchantLevel.cs)

<details>
<summary><code>Task&lt;BillingEntitiesResponse&gt; GetMerchantsMerchantIdBillingEntities(GetMerchantsMerchantIdBillingEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the billing entities of the merchant account identified in the path.
A billing entity is a legal entity where we charge orders to. An order for terminal products must contain the ID of a billing entity.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdBillingEntities(
        new GetMerchantsMerchantIdBillingEntitiesRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type BillingEntitiesResponse
}
catch (ApiException<GetMerchantsMerchantIdBillingEntitiesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdBillingEntitiesRequest](src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdBillingEntitiesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BillingEntitiesResponse](src/Adyen/Models/BillingEntitiesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdBillingEntitiesError](src/Adyen/Errors/GetMerchantsMerchantIdBillingEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocationsResponse&gt; GetMerchantsMerchantIdShippingLocations(GetMerchantsMerchantIdShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the shipping locations for the merchant account identified in the path.
A shipping location includes the address where orders can be delivered, and an ID which you need to specify when ordering terminal products.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdShippingLocations(
        new GetMerchantsMerchantIdShippingLocationsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type ShippingLocationsResponse
}
catch (ApiException<GetMerchantsMerchantIdShippingLocationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdShippingLocationsRequest](src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdShippingLocationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocationsResponse](src/Adyen/Models/ShippingLocationsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdShippingLocationsError](src/Adyen/Errors/GetMerchantsMerchantIdShippingLocationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalModelsResponse&gt; GetMerchantsMerchantIdTerminalModels(GetMerchantsMerchantIdTerminalModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal models that the merchant account identified in the path has access to. The response includes the terminal model ID, which can be used as a query parameter when getting a list of terminals or a list of products for ordering.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdTerminalModels(
        new GetMerchantsMerchantIdTerminalModelsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type TerminalModelsResponse
}
catch (ApiException<GetMerchantsMerchantIdTerminalModelsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdTerminalModelsRequest](src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdTerminalModelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalModelsResponse](src/Adyen/Models/TerminalModelsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdTerminalModelsError](src/Adyen/Errors/GetMerchantsMerchantIdTerminalModelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrdersResponse&gt; GetMerchantsMerchantIdTerminalOrders(GetMerchantsMerchantIdTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of terminal products orders for the merchant account identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdTerminalOrders(
        new GetMerchantsMerchantIdTerminalOrdersRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type TerminalOrdersResponse
}
catch (ApiException<GetMerchantsMerchantIdTerminalOrdersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdTerminalOrdersRequest](src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdTerminalOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrdersResponse](src/Adyen/Models/TerminalOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdTerminalOrdersError](src/Adyen/Errors/GetMerchantsMerchantIdTerminalOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; GetMerchantsMerchantIdTerminalOrdersOrderId(GetMerchantsMerchantIdTerminalOrdersOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of the terminal products order identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdTerminalOrdersOrderId(
        new GetMerchantsMerchantIdTerminalOrdersOrderIdRequest
        {
            MerchantId = "some example string",
            OrderId = "some example string",
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<GetMerchantsMerchantIdTerminalOrdersOrderIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdTerminalOrdersOrderIdRequest](src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdTerminalOrdersOrderIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/Adyen/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdTerminalOrdersOrderIdError](src/Adyen/Errors/GetMerchantsMerchantIdTerminalOrdersOrderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalProductsResponse&gt; GetMerchantsMerchantIdTerminalProducts(GetMerchantsMerchantIdTerminalProductsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a country-specific list of payment terminal packages and parts that the merchant account identified in the path has access to.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.GetMerchantsMerchantIdTerminalProducts(
        new GetMerchantsMerchantIdTerminalProductsRequest
        {
            MerchantId = "some example string",
            Country = "some example string",
        });
    // TODO: Handle 'response' of type TerminalProductsResponse
}
catch (ApiException<GetMerchantsMerchantIdTerminalProductsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdTerminalProductsRequest](src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdTerminalProductsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalProductsResponse](src/Adyen/Models/TerminalProductsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdTerminalProductsError](src/Adyen/Errors/GetMerchantsMerchantIdTerminalProductsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PatchMerchantsMerchantIdTerminalOrdersOrderId(PatchMerchantsMerchantIdTerminalOrdersOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the terminal products order identified in the path.
Updating is only possible while the order has the status **Placed**.

The request body only needs to contain what you want to change. 
However, to update the products in the `items` array, you must provide the entire array. For example, if the array has three items:
 To remove one item, the array must include the remaining two items. Or to add one item, the array must include all four items.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.PatchMerchantsMerchantIdTerminalOrdersOrderId(
        new PatchMerchantsMerchantIdTerminalOrdersOrderIdRequest
        {
            MerchantId = "some example string",
            OrderId = "some example string",
            Body = new TerminalOrderRequest
            {
                Items = [
                    new OrderItem { Id = "TBOX-V400m-684-EU", Name = "V400m Package", Quantity = 1 },
                    new OrderItem { Id = "PART-287001-EU", Name = "Bluetooth Charging Base - V400m", Quantity = 2 },
                    new OrderItem { Id = "PART-620222-EU", Name = "Receipt Roll", Quantity = 20 },
                ],
            },
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<PatchMerchantsMerchantIdTerminalOrdersOrderIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdTerminalOrdersOrderIdRequest](src/Adyen/Requests/TerminalOrdersMerchantLevel/PatchMerchantsMerchantIdTerminalOrdersOrderIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/Adyen/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdTerminalOrdersOrderIdError](src/Adyen/Errors/PatchMerchantsMerchantIdTerminalOrdersOrderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingLocation&gt; PostMerchantsMerchantIdShippingLocations(PostMerchantsMerchantIdShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a shipping location for the merchant account identified in the path. A shipping location defines an address where orders can be shipped to. 

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.PostMerchantsMerchantIdShippingLocations(
        new PostMerchantsMerchantIdShippingLocationsRequest
        {
            MerchantId = "some example string",
            Body = new ShippingLocation
            {
                Address = new Address21
                {
                    City = "Barcelona",
                    CompanyName = "YOUR_COMPANY",
                    Country = "ES",
                    PostalCode = "08012",
                    StateOrProvince = "",
                    StreetAddress = "El quinto pino 42",
                },
                Contact = new Contact1
                {
                    Email = "Rita.Perengano@company.com",
                    FirstName = "Rita",
                    LastName = "Perengano",
                    PhoneNumber = "+34 93 1234567",
                },
                Name = "YOUR_MERCHANT_ACCOUNT Barcelona depot",
            },
        });
    // TODO: Handle 'response' of type ShippingLocation
}
catch (ApiException<PostMerchantsMerchantIdShippingLocationsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdShippingLocationsRequest](src/Adyen/Requests/TerminalOrdersMerchantLevel/PostMerchantsMerchantIdShippingLocationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingLocation](src/Adyen/Models/ShippingLocation.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdShippingLocationsError](src/Adyen/Errors/PostMerchantsMerchantIdShippingLocationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PostMerchantsMerchantIdTerminalOrders(PostMerchantsMerchantIdTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an order for payment terminal products for the merchant account identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write
>Requests to the Management API test endpoint do not create actual orders for test terminals. To order test terminals, you need to [submit a sales order](https://docs.adyen.com/point-of-sale/managing-terminals/order-terminals/#sales-order-steps) in your Customer Area.

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.PostMerchantsMerchantIdTerminalOrders(
        new PostMerchantsMerchantIdTerminalOrdersRequest
        {
            MerchantId = "some example string",
            Body = new TerminalOrderRequest
            {
                BillingEntityId = "MerchantAccount.YOUR_MERCHANT_ACCOUNT",
                CustomerOrderReference = "YOUR_REFERENCE",
                Items = [
                    new OrderItem { Id = "PART-287001-EU", Name = "Bluetooth Charging Base - V400m", Quantity = 2 },
                    new OrderItem { Id = "PART-620222-EU", Name = "Receipt Roll", Quantity = 20 },
                ],
                ShippingLocationId = "S2-6A6C2E3432747D4F2F2C3455485E3836457D",
            },
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<PostMerchantsMerchantIdTerminalOrdersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdTerminalOrdersRequest](src/Adyen/Requests/TerminalOrdersMerchantLevel/PostMerchantsMerchantIdTerminalOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/Adyen/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdTerminalOrdersError](src/Adyen/Errors/PostMerchantsMerchantIdTerminalOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalOrder&gt; PostMerchantsMerchantIdTerminalOrdersOrderIdCancel(PostMerchantsMerchantIdTerminalOrdersOrderIdCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the terminal products order identified in the path.
Cancelling is only possible while the order has the status **Placed**.
To cancel an order, make a POST call without a request body. The response returns the full order details, but with the status changed to **Cancelled**.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal ordering read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalOrdersMerchantLevel.PostMerchantsMerchantIdTerminalOrdersOrderIdCancel(
        new PostMerchantsMerchantIdTerminalOrdersOrderIdCancelRequest
        {
            MerchantId = "some example string",
            OrderId = "some example string",
        });
    // TODO: Handle 'response' of type TerminalOrder
}
catch (ApiException<PostMerchantsMerchantIdTerminalOrdersOrderIdCancelError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdTerminalOrdersOrderIdCancelRequest](src/Adyen/Requests/TerminalOrdersMerchantLevel/PostMerchantsMerchantIdTerminalOrdersOrderIdCancelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalOrder](src/Adyen/Models/TerminalOrder.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdTerminalOrdersOrderIdCancelError](src/Adyen/Errors/PostMerchantsMerchantIdTerminalOrdersOrderIdCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsCompanyLevel

> Source: [TerminalSettingsCompanyLevel](src/Adyen/Api/TerminalSettingsCompanyLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetCompaniesCompanyIdTerminalLogos(GetCompaniesCompanyIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the company identified in the path. 

The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of the specified model under the company, unless a different logo is configured at a lower level (merchant account, store, or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.GetCompaniesCompanyIdTerminalLogos(
        new GetCompaniesCompanyIdTerminalLogosRequest
        {
            CompanyId = "some example string",
            Model = "some example string",
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<GetCompaniesCompanyIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdTerminalLogosRequest](src/Adyen/Requests/TerminalSettingsCompanyLevel/GetCompaniesCompanyIdTerminalLogosRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/Adyen/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdTerminalLogosError](src/Adyen/Errors/GetCompaniesCompanyIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetCompaniesCompanyIdTerminalSettings(GetCompaniesCompanyIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the company identified in the path. These settings apply to all terminals under the company, unless different values are configured at a lower level (merchant account, store, or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.GetCompaniesCompanyIdTerminalSettings(
        new GetCompaniesCompanyIdTerminalSettingsRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<GetCompaniesCompanyIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdTerminalSettingsRequest](src/Adyen/Requests/TerminalSettingsCompanyLevel/GetCompaniesCompanyIdTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/Adyen/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdTerminalSettingsError](src/Adyen/Errors/GetCompaniesCompanyIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; PatchCompaniesCompanyIdTerminalLogos(PatchCompaniesCompanyIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo that is configured for a specific payment terminal model at the company identified in the path. You can update the logo for only one terminal model at a time.
This logo applies to all terminals of the specified model under the company, unless a different logo is configured at a lower level (merchant account, store, or individual terminal). 
* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from the Adyen PSP level, specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.PatchCompaniesCompanyIdTerminalLogos(
        new PatchCompaniesCompanyIdTerminalLogosRequest
        {
            CompanyId = "some example string",
            Model = "some example string",
            Body = new Logo { Data = "" },
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<PatchCompaniesCompanyIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchCompaniesCompanyIdTerminalLogosRequest](src/Adyen/Requests/TerminalSettingsCompanyLevel/PatchCompaniesCompanyIdTerminalLogosRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/Adyen/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchCompaniesCompanyIdTerminalLogosError](src/Adyen/Errors/PatchCompaniesCompanyIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; PatchCompaniesCompanyIdTerminalSettings(PatchCompaniesCompanyIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the company identified in the path. These settings apply to all terminals under the company, unless different values are configured at a lower level (merchant account, store, or individual terminal).

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from the Adyen PSP level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsCompanyLevel.PatchCompaniesCompanyIdTerminalSettings(
        new PatchCompaniesCompanyIdTerminalSettingsRequest
        {
            CompanyId = "some example string",
            Body = new TerminalSettings
            {
                WifiProfiles = new WifiProfiles2
                {
                    Profiles = [
                        new Profile
                        {
                            AuthType = "wpa-eap",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = true,
                            Eap = "peap",
                            EapCaCert = new File1 { Data = data, Name = name },
                            EapIdentity = "admin",
                            EapIntermediateCert = new File4 { Data = data, Name = name },
                            EapPwd = "EAP_PEAP_PASSWORD",
                            HiddenSsid = false,
                            Name = "Profile-eap-peap-1",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                        new Profile
                        {
                            AuthType = "wpa-psk",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = false,
                            HiddenSsid = false,
                            Name = "Profile-guest-wifi",
                            Psk = "WIFI_PASSWORD",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                    ],
                    Settings = new Settings1 { Band = "2.4GHz", Roaming = true, Timeout = 5 },
                },
            },
        });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<PatchCompaniesCompanyIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchCompaniesCompanyIdTerminalSettingsRequest](src/Adyen/Requests/TerminalSettingsCompanyLevel/PatchCompaniesCompanyIdTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/Adyen/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchCompaniesCompanyIdTerminalSettingsError](src/Adyen/Errors/PatchCompaniesCompanyIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsMerchantLevel

> Source: [TerminalSettingsMerchantLevel](src/Adyen/Api/TerminalSettingsMerchantLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetMerchantsMerchantIdTerminalLogos(GetMerchantsMerchantIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the merchant account identified in the path. 
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of the specified model under the merchant account, unless a different logo is configured at a lower level (store or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.GetMerchantsMerchantIdTerminalLogos(
        new GetMerchantsMerchantIdTerminalLogosRequest
        {
            MerchantId = "some example string",
            Model = "some example string",
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<GetMerchantsMerchantIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdTerminalLogosRequest](src/Adyen/Requests/TerminalSettingsMerchantLevel/GetMerchantsMerchantIdTerminalLogosRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/Adyen/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdTerminalLogosError](src/Adyen/Errors/GetMerchantsMerchantIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetMerchantsMerchantIdTerminalSettings(GetMerchantsMerchantIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the merchant account identified in the path. These settings apply to all terminals under the merchant account unless different values are configured at a lower level (store or individual terminal).

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.GetMerchantsMerchantIdTerminalSettings(
        new GetMerchantsMerchantIdTerminalSettingsRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<GetMerchantsMerchantIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdTerminalSettingsRequest](src/Adyen/Requests/TerminalSettingsMerchantLevel/GetMerchantsMerchantIdTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/Adyen/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdTerminalSettingsError](src/Adyen/Errors/GetMerchantsMerchantIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; PatchMerchantsMerchantIdTerminalLogos(PatchMerchantsMerchantIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo for a specific payment terminal model at the merchant account identified in the path. You can update the logo for only one terminal model at a time. 
This logo applies to all terminals of the specified model under the merchant account, unless a different logo is configured at a lower level (store or individual terminal).

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from the company account, specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.PatchMerchantsMerchantIdTerminalLogos(
        new PatchMerchantsMerchantIdTerminalLogosRequest
        {
            MerchantId = "some example string",
            Model = "some example string",
            Body = new Logo { Data = "" },
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<PatchMerchantsMerchantIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdTerminalLogosRequest](src/Adyen/Requests/TerminalSettingsMerchantLevel/PatchMerchantsMerchantIdTerminalLogosRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/Adyen/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdTerminalLogosError](src/Adyen/Errors/PatchMerchantsMerchantIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; PatchMerchantsMerchantIdTerminalSettings(PatchMerchantsMerchantIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the merchant account identified in the path.
These settings apply to all terminals under the merchant account, unless different values are configured at a lower level (store or individual terminal).

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write



For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsMerchantLevel.PatchMerchantsMerchantIdTerminalSettings(
        new PatchMerchantsMerchantIdTerminalSettingsRequest
        {
            MerchantId = "some example string",
            Body = new TerminalSettings
            {
                WifiProfiles = new WifiProfiles2
                {
                    Profiles = [
                        new Profile
                        {
                            AuthType = "wpa-eap",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = true,
                            Eap = "peap",
                            EapCaCert = new File1 { Data = data, Name = name },
                            EapIdentity = "admin",
                            EapIntermediateCert = new File4 { Data = data, Name = name },
                            EapPwd = "EAP_PEAP_PASSWORD",
                            HiddenSsid = false,
                            Name = "Profile-eap-peap-1",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                        new Profile
                        {
                            AuthType = "wpa-psk",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = false,
                            HiddenSsid = false,
                            Name = "Profile-guest-wifi",
                            Psk = "WIFI_PASSWORD",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                    ],
                    Settings = new Settings1 { Band = "2.4GHz", Roaming = true, Timeout = 5 },
                },
            },
        });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<PatchMerchantsMerchantIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdTerminalSettingsRequest](src/Adyen/Requests/TerminalSettingsMerchantLevel/PatchMerchantsMerchantIdTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/Adyen/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdTerminalSettingsError](src/Adyen/Errors/PatchMerchantsMerchantIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsStoreLevel

> Source: [TerminalSettingsStoreLevel](src/Adyen/Api/TerminalSettingsStoreLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetMerchantsMerchantIdStoresReferenceTerminalLogos(GetMerchantsMerchantIdStoresReferenceTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the store identified in the path. 
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetMerchantsMerchantIdStoresReferenceTerminalLogos(
        new GetMerchantsMerchantIdStoresReferenceTerminalLogosRequest
        {
            MerchantId = "some example string",
            Reference = "some example string",
            Model = "some example string",
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<GetMerchantsMerchantIdStoresReferenceTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdStoresReferenceTerminalLogosRequest](src/Adyen/Requests/TerminalSettingsStoreLevel/GetMerchantsMerchantIdStoresReferenceTerminalLogosRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/Adyen/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdStoresReferenceTerminalLogosError](src/Adyen/Errors/GetMerchantsMerchantIdStoresReferenceTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetMerchantsMerchantIdStoresReferenceTerminalSettings(GetMerchantsMerchantIdStoresReferenceTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetMerchantsMerchantIdStoresReferenceTerminalSettings(
        new GetMerchantsMerchantIdStoresReferenceTerminalSettingsRequest
        {
            MerchantId = "some example string",
            Reference = "some example string",
        });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<GetMerchantsMerchantIdStoresReferenceTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdStoresReferenceTerminalSettingsRequest](src/Adyen/Requests/TerminalSettingsStoreLevel/GetMerchantsMerchantIdStoresReferenceTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/Adyen/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdStoresReferenceTerminalSettingsError](src/Adyen/Errors/GetMerchantsMerchantIdStoresReferenceTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; GetStoresStoreIdTerminalLogos(GetStoresStoreIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for a specific payment terminal model at the store identified in the path. 
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file. 
This logo applies to all terminals of that model under the store unless a different logo is configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetStoresStoreIdTerminalLogos(
        new GetStoresStoreIdTerminalLogosRequest { StoreId = "some example string", Model = "some example string" });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<GetStoresStoreIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStoresStoreIdTerminalLogosRequest](src/Adyen/Requests/TerminalSettingsStoreLevel/GetStoresStoreIdTerminalLogosRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/Adyen/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetStoresStoreIdTerminalLogosError](src/Adyen/Errors/GetStoresStoreIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetStoresStoreIdTerminalSettings(GetStoresStoreIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.GetStoresStoreIdTerminalSettings(
        new GetStoresStoreIdTerminalSettingsRequest { StoreId = "some example string" });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<GetStoresStoreIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStoresStoreIdTerminalSettingsRequest](src/Adyen/Requests/TerminalSettingsStoreLevel/GetStoresStoreIdTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/Adyen/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetStoresStoreIdTerminalSettingsError](src/Adyen/Errors/GetStoresStoreIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; PatchMerchantsMerchantIdStoresReferenceTerminalLogos(PatchMerchantsMerchantIdStoresReferenceTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You can update the logo for only one terminal model at a time.
This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal. 

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.PatchMerchantsMerchantIdStoresReferenceTerminalLogos(
        new PatchMerchantsMerchantIdStoresReferenceTerminalLogosRequest
        {
            MerchantId = "some example string",
            Reference = "some example string",
            Model = "some example string",
            Body = new Logo { Data = "" },
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<PatchMerchantsMerchantIdStoresReferenceTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdStoresReferenceTerminalLogosRequest](src/Adyen/Requests/TerminalSettingsStoreLevel/PatchMerchantsMerchantIdStoresReferenceTerminalLogosRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/Adyen/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdStoresReferenceTerminalLogosError](src/Adyen/Errors/PatchMerchantsMerchantIdStoresReferenceTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; PatchMerchantsMerchantIdStoresReferenceTerminalSettings(PatchMerchantsMerchantIdStoresReferenceTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.PatchMerchantsMerchantIdStoresReferenceTerminalSettings(
        new PatchMerchantsMerchantIdStoresReferenceTerminalSettingsRequest
        {
            MerchantId = "some example string",
            Reference = "some example string",
            Body = new TerminalSettings
            {
                WifiProfiles = new WifiProfiles2
                {
                    Profiles = [
                        new Profile
                        {
                            AuthType = "wpa-eap",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = true,
                            Eap = "peap",
                            EapCaCert = new File1 { Data = data, Name = name },
                            EapIdentity = "admin",
                            EapIntermediateCert = new File4 { Data = data, Name = name },
                            EapPwd = "EAP_PEAP_PASSWORD",
                            Name = "Profile-eap-peap-1",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                        new Profile
                        {
                            AuthType = "wpa-psk",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = false,
                            Name = "Profile-guest-wifi",
                            Psk = "WIFI_PASSWORD",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                    ],
                    Settings = new Settings1 { Band = "2.4GHz", Roaming = true, Timeout = 5 },
                },
            },
        });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdStoresReferenceTerminalSettingsRequest](src/Adyen/Requests/TerminalSettingsStoreLevel/PatchMerchantsMerchantIdStoresReferenceTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/Adyen/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError](src/Adyen/Errors/PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; PatchStoresStoreIdTerminalLogos(PatchStoresStoreIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You can update the logo for only one terminal model at a time.
This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal. 

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.PatchStoresStoreIdTerminalLogos(
        new PatchStoresStoreIdTerminalLogosRequest
        {
            StoreId = "some example string",
            Model = "some example string",
            Body = new Logo { Data = "" },
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<PatchStoresStoreIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchStoresStoreIdTerminalLogosRequest](src/Adyen/Requests/TerminalSettingsStoreLevel/PatchStoresStoreIdTerminalLogosRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/Adyen/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchStoresStoreIdTerminalLogosError](src/Adyen/Errors/PatchStoresStoreIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; PatchStoresStoreIdTerminalSettings(PatchStoresStoreIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsStoreLevel.PatchStoresStoreIdTerminalSettings(
        new PatchStoresStoreIdTerminalSettingsRequest
        {
            StoreId = "some example string",
            Body = new TerminalSettings
            {
                WifiProfiles = new WifiProfiles2
                {
                    Profiles = [
                        new Profile
                        {
                            AuthType = "wpa-eap",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = true,
                            Eap = "peap",
                            EapCaCert = new File1 { Data = data, Name = name },
                            EapIdentity = "admin",
                            EapIntermediateCert = new File4 { Data = data, Name = name },
                            EapPwd = "EAP_PEAP_PASSWORD",
                            HiddenSsid = false,
                            Name = "Profile-eap-peap-1",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                        new Profile
                        {
                            AuthType = "wpa-psk",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = false,
                            HiddenSsid = false,
                            Name = "Profile-guest-wifi",
                            Psk = "WIFI_PASSWORD",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                    ],
                    Settings = new Settings1 { Band = "2.4GHz", Roaming = true, Timeout = 5 },
                },
            },
        });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<PatchStoresStoreIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchStoresStoreIdTerminalSettingsRequest](src/Adyen/Requests/TerminalSettingsStoreLevel/PatchStoresStoreIdTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/Adyen/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchStoresStoreIdTerminalSettingsError](src/Adyen/Errors/PatchStoresStoreIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalSettingsTerminalLevel

> Source: [TerminalSettingsTerminalLevel](src/Adyen/Api/TerminalSettingsTerminalLevel.cs)

<details>
<summary><code>Task&lt;Logo&gt; GetTerminalsTerminalIdTerminalLogos(GetTerminalsTerminalIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the logo that is configured for the payment terminal identified in the path.
The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.GetTerminalsTerminalIdTerminalLogos(
        new GetTerminalsTerminalIdTerminalLogosRequest { TerminalId = "some example string" });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<GetTerminalsTerminalIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalsTerminalIdTerminalLogosRequest](src/Adyen/Requests/TerminalSettingsTerminalLevel/GetTerminalsTerminalIdTerminalLogosRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/Adyen/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetTerminalsTerminalIdTerminalLogosError](src/Adyen/Errors/GetTerminalsTerminalIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; GetTerminalsTerminalIdTerminalSettings(GetTerminalsTerminalIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the settings that are configured for the payment terminal identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.GetTerminalsTerminalIdTerminalSettings(
        new GetTerminalsTerminalIdTerminalSettingsRequest { TerminalId = "some example string" });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<GetTerminalsTerminalIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalsTerminalIdTerminalSettingsRequest](src/Adyen/Requests/TerminalSettingsTerminalLevel/GetTerminalsTerminalIdTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/Adyen/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetTerminalsTerminalIdTerminalSettingsError](src/Adyen/Errors/GetTerminalsTerminalIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Logo&gt; PatchTerminalsTerminalIdTerminalLogos(PatchTerminalsTerminalIdTerminalLogosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the logo for the payment terminal identified in the path.

* To change the logo, specify the image file as a Base64-encoded string.
* To restore the logo inherited from a higher level (store, merchant account, or company account), specify an empty logo value.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.PatchTerminalsTerminalIdTerminalLogos(
        new PatchTerminalsTerminalIdTerminalLogosRequest
        {
            TerminalId = "some example string",
            Body = new Logo { Data = "" },
        });
    // TODO: Handle 'response' of type Logo
}
catch (ApiException<PatchTerminalsTerminalIdTerminalLogosError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchTerminalsTerminalIdTerminalLogosRequest](src/Adyen/Requests/TerminalSettingsTerminalLevel/PatchTerminalsTerminalIdTerminalLogosRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Logo](src/Adyen/Models/Logo.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchTerminalsTerminalIdTerminalLogosError](src/Adyen/Errors/PatchTerminalsTerminalIdTerminalLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalSettings&gt; PatchTerminalsTerminalIdTerminalSettings(PatchTerminalsTerminalIdTerminalSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the settings that are configured for the payment terminal identified in the path.

* To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.
* To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.
* Objects that are not included in the request are not updated.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Terminal settings read and write

For [sensitive terminal settings](https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings), your API credential must have the following role:
* Management API—Terminal settings Advanced read and write

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalSettingsTerminalLevel.PatchTerminalsTerminalIdTerminalSettings(
        new PatchTerminalsTerminalIdTerminalSettingsRequest
        {
            TerminalId = "some example string",
            Body = new TerminalSettings
            {
                WifiProfiles = new WifiProfiles2
                {
                    Profiles = [
                        new Profile
                        {
                            AuthType = "wpa-eap",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = true,
                            Eap = "peap",
                            EapCaCert = new File1 { Data = data, Name = name },
                            EapIdentity = "admin",
                            EapIntermediateCert = new File4 { Data = data, Name = name },
                            EapPwd = "EAP_PEAP_PASSWORD",
                            HiddenSsid = false,
                            Name = "Profile-eap-peap-1",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                        new Profile
                        {
                            AuthType = "wpa-psk",
                            AutoWifi = false,
                            BssType = "infra",
                            Channel = 0,
                            DefaultProfile = false,
                            HiddenSsid = false,
                            Name = "Profile-guest-wifi",
                            Psk = "WIFI_PASSWORD",
                            Ssid = "your-network",
                            Wsec = "ccmp",
                        },
                    ],
                    Settings = new Settings1 { Band = "2.4GHz", Roaming = true, Timeout = 5 },
                },
            },
        });
    // TODO: Handle 'response' of type TerminalSettings
}
catch (ApiException<PatchTerminalsTerminalIdTerminalSettingsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchTerminalsTerminalIdTerminalSettingsRequest](src/Adyen/Requests/TerminalSettingsTerminalLevel/PatchTerminalsTerminalIdTerminalSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalSettings](src/Adyen/Models/TerminalSettings.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchTerminalsTerminalIdTerminalSettingsError](src/Adyen/Errors/PatchTerminalsTerminalIdTerminalSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalsTerminalLevel

> Source: [TerminalsTerminalLevel](src/Adyen/Api/TerminalsTerminalLevel.cs)

<details>
<summary><code>Task&lt;ListTerminalsResponse&gt; GetTerminals(GetTerminalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the payment terminals that the API credential has access to and that match the query parameters. 
To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API — Terminal actions read

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalsTerminalLevel.GetTerminals(new GetTerminalsRequest());
    // TODO: Handle 'response' of type ListTerminalsResponse
}
catch (ApiException<GetTerminalsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalsRequest](src/Adyen/Requests/TerminalsTerminalLevel/GetTerminalsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListTerminalsResponse](src/Adyen/Models/ListTerminalsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetTerminalsError](src/Adyen/Errors/GetTerminalsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostTerminalsTerminalIdReassign(PostTerminalsTerminalIdReassignRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reassigns a payment terminal to a company account, merchant account, merchant account inventory, or a store.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Assign Terminal

In the live environment, requests to this endpoint are subject to [rate limits](https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TerminalsTerminalLevel.PostTerminalsTerminalIdReassign(new PostTerminalsTerminalIdReassignRequest
    {
        TerminalId = "some example string",
        Body = new TerminalReassignmentRequest { Inventory = false, MerchantId = "YOUR_MERCHANT_ID" },
    });
}
catch (ApiException<PostTerminalsTerminalIdReassignError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTerminalsTerminalIdReassignRequest](src/Adyen/Requests/TerminalsTerminalLevel/PostTerminalsTerminalIdReassignRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTerminalsTerminalIdReassignError](src/Adyen/Errors/PostTerminalsTerminalIdReassignError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TermsOfService

> Source: [TermsOfService](src/Adyen/Api/TermsOfService.cs)

<details>
<summary><code>Task&lt;GetAcceptedTermsOfServiceDocumentResponse&gt; GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereference(GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the accepted Terms of Service document for a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TermsOfService.GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereference(
        new GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceRequest
        {
            Id = "some example string",
            Termsofserviceacceptancereference = "some example string",
        });
    // TODO: Handle 'response' of type GetAcceptedTermsOfServiceDocumentResponse
}
catch (ApiException<GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceRequest](src/Adyen/Requests/TermsOfService/GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAcceptedTermsOfServiceDocumentResponse](src/Adyen/Models/GetAcceptedTermsOfServiceDocumentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError](src/Adyen/Errors/GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTermsOfServiceAcceptanceInfosResponse&gt; GetLegalEntitiesIdTermsOfServiceAcceptanceInfos(GetLegalEntitiesIdTermsOfServiceAcceptanceInfosRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns Terms of Service information for a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TermsOfService.GetLegalEntitiesIdTermsOfServiceAcceptanceInfos(
        new GetLegalEntitiesIdTermsOfServiceAcceptanceInfosRequest { Id = "some example string" });
    // TODO: Handle 'response' of type GetTermsOfServiceAcceptanceInfosResponse
}
catch (ApiException<GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLegalEntitiesIdTermsOfServiceAcceptanceInfosRequest](src/Adyen/Requests/TermsOfService/GetLegalEntitiesIdTermsOfServiceAcceptanceInfosRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTermsOfServiceAcceptanceInfosResponse](src/Adyen/Models/GetTermsOfServiceAcceptanceInfosResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError](src/Adyen/Errors/GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalculateTermsOfServiceStatusResponse&gt; GetLegalEntitiesIdTermsOfServiceStatus(GetLegalEntitiesIdTermsOfServiceStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the required types of Terms of Service that need to be accepted by a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TermsOfService.GetLegalEntitiesIdTermsOfServiceStatus(
        new GetLegalEntitiesIdTermsOfServiceStatusRequest { Id = "some example string" });
    // TODO: Handle 'response' of type CalculateTermsOfServiceStatusResponse
}
catch (ApiException<GetLegalEntitiesIdTermsOfServiceStatusError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLegalEntitiesIdTermsOfServiceStatusRequest](src/Adyen/Requests/TermsOfService/GetLegalEntitiesIdTermsOfServiceStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculateTermsOfServiceStatusResponse](src/Adyen/Models/CalculateTermsOfServiceStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetLegalEntitiesIdTermsOfServiceStatusError](src/Adyen/Errors/GetLegalEntitiesIdTermsOfServiceStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AcceptTermsOfServiceResponse&gt; PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentid(PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Accepts Terms of Service.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TermsOfService.PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentid(
        new PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidRequest
        {
            Id = "some example string",
            Termsofservicedocumentid = "some example string",
            Body = new AcceptTermsOfServiceRequest { AcceptedBy = "LE00000000000000000000002" },
        });
    // TODO: Handle 'response' of type AcceptTermsOfServiceResponse
}
catch (ApiException<PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidRequest](src/Adyen/Requests/TermsOfService/PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AcceptTermsOfServiceResponse](src/Adyen/Models/AcceptTermsOfServiceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError](src/Adyen/Errors/PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTermsOfServiceDocumentResponse&gt; PostLegalEntitiesIdTermsOfService(PostLegalEntitiesIdTermsOfServiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the Terms of Service document for a legal entity.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TermsOfService.PostLegalEntitiesIdTermsOfService(
        new PostLegalEntitiesIdTermsOfServiceRequest
        {
            Id = "some example string",
            Body = new GetTermsOfServiceDocumentRequest { Language = "en", Type = Type64.AdyenIssuing },
        });
    // TODO: Handle 'response' of type GetTermsOfServiceDocumentResponse
}
catch (ApiException<PostLegalEntitiesIdTermsOfServiceError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLegalEntitiesIdTermsOfServiceRequest](src/Adyen/Requests/TermsOfService/PostLegalEntitiesIdTermsOfServiceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTermsOfServiceDocumentResponse](src/Adyen/Models/GetTermsOfServiceDocumentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostLegalEntitiesIdTermsOfServiceError](src/Adyen/Errors/PostLegalEntitiesIdTermsOfServiceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransactionRules

> Source: [TransactionRules](src/Adyen/Api/TransactionRules.cs)

<details>
<summary><code>Task&lt;TransactionRule&gt; DeleteTransactionRulesTransactionRuleId(DeleteTransactionRulesTransactionRuleIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a transaction rule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionRules.DeleteTransactionRulesTransactionRuleId(
        new DeleteTransactionRulesTransactionRuleIdRequest { TransactionRuleId = "some example string" });
    // TODO: Handle 'response' of type TransactionRule
}
catch (ApiException<DeleteTransactionRulesTransactionRuleIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTransactionRulesTransactionRuleIdRequest](src/Adyen/Requests/TransactionRules/DeleteTransactionRulesTransactionRuleIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRule](src/Adyen/Models/TransactionRule.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteTransactionRulesTransactionRuleIdError](src/Adyen/Errors/DeleteTransactionRulesTransactionRuleIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRuleResponse&gt; GetTransactionRulesTransactionRuleId(GetTransactionRulesTransactionRuleIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a transaction rule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionRules.GetTransactionRulesTransactionRuleId(
        new GetTransactionRulesTransactionRuleIdRequest { TransactionRuleId = "some example string" });
    // TODO: Handle 'response' of type TransactionRuleResponse
}
catch (ApiException<GetTransactionRulesTransactionRuleIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTransactionRulesTransactionRuleIdRequest](src/Adyen/Requests/TransactionRules/GetTransactionRulesTransactionRuleIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRuleResponse](src/Adyen/Models/TransactionRuleResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetTransactionRulesTransactionRuleIdError](src/Adyen/Errors/GetTransactionRulesTransactionRuleIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRule&gt; PatchTransactionRulesTransactionRuleId(PatchTransactionRulesTransactionRuleIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a transaction rule. 

* To update only the status of a transaction rule, send only the `status` parameter. All other parameters not provided in the request are left unchanged.

* When updating any other parameter, you need to send all existing resource parameters. If you omit a parameter in the request, that parameter is removed from the resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionRules.PatchTransactionRulesTransactionRuleId(
        new PatchTransactionRulesTransactionRuleIdRequest
        {
            TransactionRuleId = "some example string",
            Body = new TransactionRuleInfo
            {
                Description = "Allow only point-of-sale transactions",
                EntityKey = new TransactionRuleEntityKey2
                {
                    EntityReference = "PI3227C223222B5FG88SB8BHR",
                    EntityType = "paymentInstrument",
                },
                Interval = new TransactionRuleInterval1 { Type = Type131.Weekly },
                Reference = "YOUR_REFERENCE_4F7346",
                RuleRestrictions = new TransactionRuleRestrictions1
                {
                    ProcessingTypes = new ProcessingTypesRestriction1 { Operation = "noneMatch", Value = [Value4.Pos] },
                },
                Status = Status6.Inactive,
                Type = Type141.BlockList,
            },
        });
    // TODO: Handle 'response' of type TransactionRule
}
catch (ApiException<PatchTransactionRulesTransactionRuleIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchTransactionRulesTransactionRuleIdRequest](src/Adyen/Requests/TransactionRules/PatchTransactionRulesTransactionRuleIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRule](src/Adyen/Models/TransactionRule.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchTransactionRulesTransactionRuleIdError](src/Adyen/Errors/PatchTransactionRulesTransactionRuleIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionRule&gt; PostTransactionRules(PostTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a [transaction rule](https://docs.adyen.com/issuing/transaction-rules). When your user makes a transaction with their Adyen-issued card, the transaction is allowed or declined based on the conditions and outcome defined in the transaction rule. You can apply the transaction rule to several cards, such as all the cards in your platform, or to a specific card. For use cases, see [examples](https://docs.adyen.com/issuing/transaction-rules/examples).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionRules.PostTransactionRules(new PostTransactionRulesRequest
    {
        Body = new TransactionRuleInfo
        {
            Description = "Allow only point-of-sale transactions",
            EntityKey = new TransactionRuleEntityKey2
            {
                EntityReference = "PI3227C223222B5FG88SB8BHR",
                EntityType = "paymentInstrument",
            },
            Interval = new TransactionRuleInterval1 { Type = Type131.PerTransaction },
            Reference = "YOUR_REFERENCE_4F7346",
            RuleRestrictions = new TransactionRuleRestrictions1
            {
                ProcessingTypes = new ProcessingTypesRestriction1 { Operation = "noneMatch", Value = [Value4.Pos] },
            },
            Status = Status6.Active,
            Type = Type141.BlockList,
        },
    });
    // TODO: Handle 'response' of type TransactionRule
}
catch (ApiException<PostTransactionRulesError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTransactionRulesRequest](src/Adyen/Requests/TransactionRules/PostTransactionRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionRule](src/Adyen/Models/TransactionRule.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTransactionRulesError](src/Adyen/Errors/PostTransactionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Transactions

> Source: [Transactions](src/Adyen/Api/Transactions.cs)

<details>
<summary><code>Task&lt;TransactionSearchResponse&gt; GetTransactions(GetTransactionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

>Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.

Returns all the transactions related to a balance account, account holder, or balance platform.

When making this request, you must include at least one of the following:
- `balanceAccountId`
- `accountHolderId`
- `balancePlatform`.

This endpoint supports cursor-based pagination. The response returns the first page of results, and returns links to the next and previous pages when applicable. You can use the links to page through the results.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.GetTransactions(new GetTransactionsRequest
    {
        CreatedSince = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
        CreatedUntil = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
    });
    // TODO: Handle 'response' of type TransactionSearchResponse
}
catch (ApiException<GetTransactionsError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTransactionsRequest](src/Adyen/Requests/Transactions/GetTransactionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionSearchResponse](src/Adyen/Models/TransactionSearchResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetTransactionsError](src/Adyen/Errors/GetTransactionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Transaction&gt; GetTransactionsId(GetTransactionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

>Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.

Returns a transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.GetTransactionsId(new GetTransactionsIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type Transaction
}
catch (ApiException<GetTransactionsIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTransactionsIdRequest](src/Adyen/Requests/Transactions/GetTransactionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Transaction](src/Adyen/Models/Transaction.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetTransactionsIdError](src/Adyen/Errors/GetTransactionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransferInstruments

> Source: [TransferInstruments](src/Adyen/Api/TransferInstruments.cs)

<details>
<summary><code>Task DeleteTransferInstrumentsId(DeleteTransferInstrumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a transfer instrument.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransferInstruments.DeleteTransferInstrumentsId(new DeleteTransferInstrumentsIdRequest
    {
        Id = "some example string",
    });
}
catch (ApiException<DeleteTransferInstrumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTransferInstrumentsIdRequest](src/Adyen/Requests/TransferInstruments/DeleteTransferInstrumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteTransferInstrumentsIdError](src/Adyen/Errors/DeleteTransferInstrumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferInstrument&gt; GetTransferInstrumentsId(GetTransferInstrumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a transfer instrument.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferInstruments.GetTransferInstrumentsId(new GetTransferInstrumentsIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type TransferInstrument
}
catch (ApiException<GetTransferInstrumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTransferInstrumentsIdRequest](src/Adyen/Requests/TransferInstruments/GetTransferInstrumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferInstrument](src/Adyen/Models/TransferInstrument.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetTransferInstrumentsIdError](src/Adyen/Errors/GetTransferInstrumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferInstrument&gt; PatchTransferInstrumentsId(PatchTransferInstrumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a transfer instrument.

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferInstruments.PatchTransferInstrumentsId(new PatchTransferInstrumentsIdRequest
    {
        Id = "some example string",
        XRequestedVerificationCode = "0_0001",
        Body = new TransferInstrumentInfo
        {
            BankAccount = new BankAccountInfo1
            {
                AccountIdentification = new IbanAccountIdentification { Iban = "NL02ABNA0123456789" },
            },
            LegalEntityId = "LE00000000000000000000001",
            Type = Type221.BankAccount,
        },
    });
    // TODO: Handle 'response' of type TransferInstrument
}
catch (ApiException<PatchTransferInstrumentsIdError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchTransferInstrumentsIdRequest](src/Adyen/Requests/TransferInstruments/PatchTransferInstrumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferInstrument](src/Adyen/Models/TransferInstrument.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchTransferInstrumentsIdError](src/Adyen/Errors/PatchTransferInstrumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferInstrument&gt; PostTransferInstruments(PostTransferInstrumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a transfer instrument. 

A transfer instrument is a bank account that a legal entity owns. Adyen performs verification checks on the transfer instrument as required by payment industry regulations. We inform you of the verification results through webhooks or API responses.

When the transfer instrument passes the verification checks, you can start sending funds from the balance platform to the transfer instrument (such as payouts).

Requests to this endpoint are subject to rate limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferInstruments.PostTransferInstruments(new PostTransferInstrumentsRequest
    {
        XRequestedVerificationCode = "1_7002",
        Body = new TransferInstrumentInfo
        {
            BankAccount = new BankAccountInfo1
            {
                AccountIdentification = new IbanAccountIdentification { Iban = "NL62ABNA0000000123" },
            },
            LegalEntityId = "LE00000000000000000000001",
            Type = Type221.BankAccount,
        },
    });
    // TODO: Handle 'response' of type TransferInstrument
}
catch (ApiException<PostTransferInstrumentsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTransferInstrumentsRequest](src/Adyen/Requests/TransferInstruments/PostTransferInstrumentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferInstrument](src/Adyen/Models/TransferInstrument.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTransferInstrumentsError](src/Adyen/Errors/PostTransferInstrumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransferLimitsBalanceAccountLevel

> Source: [TransferLimitsBalanceAccountLevel](src/Adyen/Api/TransferLimitsBalanceAccountLevel.cs)

<details>
<summary><code>Task DeleteBalanceAccountsIdTransferLimitsTransferLimitId(DeleteBalanceAccountsIdTransferLimitsTransferLimitIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a scheduled or pending transfer limit using its unique `transferLimitId`. You cannot delete an active limit.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransferLimitsBalanceAccountLevel.DeleteBalanceAccountsIdTransferLimitsTransferLimitId(
        new DeleteBalanceAccountsIdTransferLimitsTransferLimitIdRequest
        {
            Id = "some example string",
            TransferLimitId = "some example string",
        });
}
catch (ApiException<DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteBalanceAccountsIdTransferLimitsTransferLimitIdRequest](src/Adyen/Requests/TransferLimitsBalanceAccountLevel/DeleteBalanceAccountsIdTransferLimitsTransferLimitIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError](src/Adyen/Errors/DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimitListResponse&gt; GetBalanceAccountsIdTransferLimits(GetBalanceAccountsIdTransferLimitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Filter and view the transfer limits configured for a balance account using the balance account's unique `id` and the available query parameters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalanceAccountLevel.GetBalanceAccountsIdTransferLimits(
        new GetBalanceAccountsIdTransferLimitsRequest { Id = "some example string" });
    // TODO: Handle 'response' of type TransferLimitListResponse
}
catch (ApiException<GetBalanceAccountsIdTransferLimitsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsIdTransferLimitsRequest](src/Adyen/Requests/TransferLimitsBalanceAccountLevel/GetBalanceAccountsIdTransferLimitsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimitListResponse](src/Adyen/Models/TransferLimitListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsIdTransferLimitsError](src/Adyen/Errors/GetBalanceAccountsIdTransferLimitsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimitListResponse&gt; GetBalanceAccountsIdTransferLimitsCurrent(GetBalanceAccountsIdTransferLimitsCurrentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all transfer limits that currently apply to a balance account using the unique `id` of the balance account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalanceAccountLevel.GetBalanceAccountsIdTransferLimitsCurrent(
        new GetBalanceAccountsIdTransferLimitsCurrentRequest { Id = "some example string" });
    // TODO: Handle 'response' of type TransferLimitListResponse
}
catch (ApiException<GetBalanceAccountsIdTransferLimitsCurrentError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsIdTransferLimitsCurrentRequest](src/Adyen/Requests/TransferLimitsBalanceAccountLevel/GetBalanceAccountsIdTransferLimitsCurrentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimitListResponse](src/Adyen/Models/TransferLimitListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsIdTransferLimitsCurrentError](src/Adyen/Errors/GetBalanceAccountsIdTransferLimitsCurrentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimit&gt; GetBalanceAccountsIdTransferLimitsTransferLimitId(GetBalanceAccountsIdTransferLimitsTransferLimitIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the details of a transfer limit using its unique `transferLimitId`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalanceAccountLevel.GetBalanceAccountsIdTransferLimitsTransferLimitId(
        new GetBalanceAccountsIdTransferLimitsTransferLimitIdRequest
        {
            Id = "some example string",
            TransferLimitId = "some example string",
        });
    // TODO: Handle 'response' of type TransferLimit
}
catch (ApiException<GetBalanceAccountsIdTransferLimitsTransferLimitIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalanceAccountsIdTransferLimitsTransferLimitIdRequest](src/Adyen/Requests/TransferLimitsBalanceAccountLevel/GetBalanceAccountsIdTransferLimitsTransferLimitIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimit](src/Adyen/Models/TransferLimit.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalanceAccountsIdTransferLimitsTransferLimitIdError](src/Adyen/Errors/GetBalanceAccountsIdTransferLimitsTransferLimitIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimit&gt; PostBalanceAccountsIdTransferLimits(PostBalanceAccountsIdTransferLimitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a transfer limit for your balance account using the unique `id` of your balance account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalanceAccountLevel.PostBalanceAccountsIdTransferLimits(
        new PostBalanceAccountsIdTransferLimitsRequest
        {
            Id = "some example string",
            WwwAuthenticate = "SCA realm=\"TransferLimit\" auth-param1=\"eyJjaGFsbGVuZ2UiOiJiVlV6ZW5wek0waFNl...\"",
            Body = new CreateTransferLimitRequest
            {
                Amount = new Amount17 { Currency = "EUR", Value = 10000L },
                EndsAt = DateTimeOffset.Parse("2026-08-13T23:00:00Z"),
                Reference = "Your reference for the transfer limit",
                ScaInformation = new CreateScaInformation1 { ScaOnApproval = true },
                Scope = Scope.PerTransaction,
                StartsAt = DateTimeOffset.Parse("2025-08-15T05:36:20Z"),
                TransferType = TransferType.All,
            },
        });
    // TODO: Handle 'response' of type TransferLimit
}
catch (ApiException<PostBalanceAccountsIdTransferLimitsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostBalanceAccountsIdTransferLimitsRequest](src/Adyen/Requests/TransferLimitsBalanceAccountLevel/PostBalanceAccountsIdTransferLimitsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimit](src/Adyen/Models/TransferLimit.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostBalanceAccountsIdTransferLimitsError](src/Adyen/Errors/PostBalanceAccountsIdTransferLimitsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostBalanceAccountsIdTransferLimitsApprove(PostBalanceAccountsIdTransferLimitsApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approve transfer limits that are pending SCA authentication.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransferLimitsBalanceAccountLevel.PostBalanceAccountsIdTransferLimitsApprove(
        new PostBalanceAccountsIdTransferLimitsApproveRequest
        {
            Id = "some example string",
            WwwAuthenticate = "SCA realm=\"TransferLimit\" auth-param1=\"eyJjaGFsbGVuZ2UiOiJiVlV6ZW5wek0waFNl...\"",
            Body = new ApproveTransferLimitRequest
            {
                TransferLimitIds = ["TRLI00000000000000000000000001", "TRLI00000000000000000000000002"],
            },
        });
}
catch (ApiException<PostBalanceAccountsIdTransferLimitsApproveError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostBalanceAccountsIdTransferLimitsApproveRequest](src/Adyen/Requests/TransferLimitsBalanceAccountLevel/PostBalanceAccountsIdTransferLimitsApproveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostBalanceAccountsIdTransferLimitsApproveError](src/Adyen/Errors/PostBalanceAccountsIdTransferLimitsApproveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransferLimitsBalancePlatformLevel

> Source: [TransferLimitsBalancePlatformLevel](src/Adyen/Api/TransferLimitsBalancePlatformLevel.cs)

<details>
<summary><code>Task DeleteBalancePlatformsIdTransferLimitsTransferLimitId(DeleteBalancePlatformsIdTransferLimitsTransferLimitIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a scheduled or pending transfer limit using its unique `transferLimitId`. You cannot delete an active limit.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransferLimitsBalancePlatformLevel.DeleteBalancePlatformsIdTransferLimitsTransferLimitId(
        new DeleteBalancePlatformsIdTransferLimitsTransferLimitIdRequest
        {
            Id = "some example string",
            TransferLimitId = "some example string",
        });
}
catch (ApiException<DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteBalancePlatformsIdTransferLimitsTransferLimitIdRequest](src/Adyen/Requests/TransferLimitsBalancePlatformLevel/DeleteBalancePlatformsIdTransferLimitsTransferLimitIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError](src/Adyen/Errors/DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimitListResponse&gt; GetBalancePlatformsIdTransferLimits(GetBalancePlatformsIdTransferLimitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Filter and view the transfer limits configured for your balance platform using the balance platform's unique `id` and the available query parameters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalancePlatformLevel.GetBalancePlatformsIdTransferLimits(
        new GetBalancePlatformsIdTransferLimitsRequest { Id = "some example string" });
    // TODO: Handle 'response' of type TransferLimitListResponse
}
catch (ApiException<GetBalancePlatformsIdTransferLimitsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalancePlatformsIdTransferLimitsRequest](src/Adyen/Requests/TransferLimitsBalancePlatformLevel/GetBalancePlatformsIdTransferLimitsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimitListResponse](src/Adyen/Models/TransferLimitListResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalancePlatformsIdTransferLimitsError](src/Adyen/Errors/GetBalancePlatformsIdTransferLimitsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimit&gt; GetBalancePlatformsIdTransferLimitsTransferLimitId(GetBalancePlatformsIdTransferLimitsTransferLimitIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the details of a transfer limit using its unique `transferLimitId`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalancePlatformLevel.GetBalancePlatformsIdTransferLimitsTransferLimitId(
        new GetBalancePlatformsIdTransferLimitsTransferLimitIdRequest
        {
            Id = "some example string",
            TransferLimitId = "some example string",
        });
    // TODO: Handle 'response' of type TransferLimit
}
catch (ApiException<GetBalancePlatformsIdTransferLimitsTransferLimitIdError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBalancePlatformsIdTransferLimitsTransferLimitIdRequest](src/Adyen/Requests/TransferLimitsBalancePlatformLevel/GetBalancePlatformsIdTransferLimitsTransferLimitIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimit](src/Adyen/Models/TransferLimit.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetBalancePlatformsIdTransferLimitsTransferLimitIdError](src/Adyen/Errors/GetBalancePlatformsIdTransferLimitsTransferLimitIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLimit&gt; PostBalancePlatformsIdTransferLimits(PostBalancePlatformsIdTransferLimitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a transfer limit for your balance platform using the unique `id` of your balance platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLimitsBalancePlatformLevel.PostBalancePlatformsIdTransferLimits(
        new PostBalancePlatformsIdTransferLimitsRequest
        {
            Id = "some example string",
            Body = new CreateTransferLimitRequest
            {
                Amount = new Amount17 { Currency = "EUR", Value = 10000L },
                EndsAt = DateTimeOffset.Parse("2026-08-13T23:00:00Z"),
                Reference = "Your reference for the transfer limit",
                ScaInformation = new CreateScaInformation1 { ScaOnApproval = true },
                Scope = Scope.PerTransaction,
                StartsAt = DateTimeOffset.Parse("2025-08-15T05:36:20Z"),
                TransferType = TransferType.All,
            },
        });
    // TODO: Handle 'response' of type TransferLimit
}
catch (ApiException<PostBalancePlatformsIdTransferLimitsError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostBalancePlatformsIdTransferLimitsRequest](src/Adyen/Requests/TransferLimitsBalancePlatformLevel/PostBalancePlatformsIdTransferLimitsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLimit](src/Adyen/Models/TransferLimit.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostBalancePlatformsIdTransferLimitsError](src/Adyen/Errors/PostBalancePlatformsIdTransferLimitsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransferRoutes

> Source: [TransferRoutes](src/Adyen/Api/TransferRoutes.cs)

<details>
<summary><code>Task&lt;TransferRouteResponse&gt; PostTransferRoutesCalculate(PostTransferRoutesCalculateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns available transfer routes based on a combination of transfer `country`, `currency`, `counterparty`, and `priorities`. Use this endpoint to find optimal transfer priorities and associated requirements before you [make a transfer](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferRoutes.PostTransferRoutesCalculate(new PostTransferRoutesCalculateRequest
    {
        Body = new TransferRouteRequest
        {
            BalancePlatform = "YOUR_BALANCE_PLATFORM",
            Counterparty = new Counterparty1
            {
                BankAccount = new BankAccount11
                {
                    AccountIdentification = new IbanAccountIdentification { Iban = iban },
                },
            },
            Currency = "USD",
        },
    });
    // TODO: Handle 'response' of type TransferRouteResponse
}
catch (ApiException<PostTransferRoutesCalculateError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTransferRoutesCalculateRequest](src/Adyen/Requests/TransferRoutes/PostTransferRoutesCalculateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferRouteResponse](src/Adyen/Models/TransferRouteResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTransferRoutesCalculateError](src/Adyen/Errors/PostTransferRoutesCalculateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Transfers

> Source: [Transfers](src/Adyen/Api/Transfers.cs)

<details>
<summary><code>Task&lt;FindTransfersResponse&gt; GetTransfers(GetTransfersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all the transfers related to a balance account, account holder, or balance platform.

When making this request, you must include at least one of the following:
- `balanceAccountId`
- `accountHolderId`
- `balancePlatform`.

This endpoint supports cursor-based pagination. The response returns the first page of results, and returns links to the next and previous pages when applicable. You can use the links to page through the results.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.GetTransfers(new GetTransfersRequest
    {
        CreatedSince = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
        CreatedUntil = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
    });
    // TODO: Handle 'response' of type FindTransfersResponse
}
catch (ApiException<GetTransfersError> ex)
{
    if (ex.Error.TryGetTransferServiceRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type TransferServiceRestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTransfersRequest](src/Adyen/Requests/Transfers/GetTransfersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FindTransfersResponse](src/Adyen/Models/FindTransfersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetTransfersError](src/Adyen/Errors/GetTransfersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferData&gt; GetTransfersId(GetTransfersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the details of a specified transfer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.GetTransfersId(new GetTransfersIdRequest { Id = "some example string" });
    // TODO: Handle 'response' of type TransferData
}
catch (ApiException<GetTransfersIdError> ex)
{
    if (ex.Error.TryGetTransferServiceRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type TransferServiceRestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTransfersIdRequest](src/Adyen/Requests/Transfers/GetTransfersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferData](src/Adyen/Models/TransferData.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetTransfersIdError](src/Adyen/Errors/GetTransfersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Transfer&gt; PostTransfers(PostTransfersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

>Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.

Starts a request to transfer funds to:
- [Balance accounts](https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts)
- [Transfer instruments](https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments)
- [Third-party bank accounts](https://docs.adyen.com/payouts/payout-service/pay-out-to-bank-accounts)
- [Third-party cards](https://docs.adyen.com/payouts/payout-service/pay-out-to-cards)

Adyen sends the outcome of the transfer request through webhooks.

To use this endpoint:
- Your API credential must have the **TransferService Webservice Initiate** [role](https://docs.adyen.com/platforms/manage-access/webservice-roles/?tab=transfers_3).
- The account holder must have the required [capabilities](https://docs.adyen.com/platforms/verification-overview/capabilities).

Reach out to your Adyen contact to set up these permissions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.PostTransfers(new PostTransfersRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        WwwAuthenticate = "SCA realm=\"Transfer\" auth-param1=\"eyJjaGFsbGVuZ2UiOiJiVlV6ZW5wek0waFNl...\"",
        Body = new TransferInfo
        {
            Amount = new Amount17 { Currency = "EUR", Value = 110000L },
            BalanceAccountId = "BAB8B2C3D4E5F6G7H8D9J6GD4",
            Category = Category3.Bank,
            Counterparty = new CounterpartyInfoV31
            {
                BankAccount = new BankAccountV31
                {
                    AccountHolder = new PartyIdentification3(),
                    AccountIdentification = new NumberAndBicAccountIdentification
                    {
                        AccountNumber = accountNumber,
                        Bic = bic,
                    },
                },
            },
            Description = "Your description for the transfer",
            Priority = Priority1.CrossBorder,
            Reference = "Your internal reference for the transfer",
            ReferenceForBeneficiary = "Your-reference-sent-to-the-beneficiary",
        },
    });
    // TODO: Handle 'response' of type Transfer
}
catch (ApiException<PostTransfersError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTransfersRequest](src/Adyen/Requests/Transfers/PostTransfersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Transfer](src/Adyen/Models/Transfer.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTransfersError](src/Adyen/Errors/PostTransfersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;JsonElement&gt; PostTransfersApprove(PostTransfersApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates the approval of a list of transfers that triggered an additional [review](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers#request-review). Adyen sends the outcome of the approval request through webhooks.

To use this endpoint:
- Your API credential must have the **TransferService Approve** [role](https://docs.adyen.com/platforms/manage-access/webservice-roles/?tab=transfers_3).
- The account holder must have the required [capabilities](https://docs.adyen.com/platforms/verification-overview/capabilities).

Reach out to your Adyen contact to set up these permissions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.PostTransfersApprove(new PostTransfersApproveRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        WwwAuthenticate = "SCA realm=\"ApproveTransfers\" auth-param1=\"eyJjaGFsbGVuZ2UiOiJiVlV6ZW5wek0waFNl...\"",
        Body = new ApproveTransfersRequest { TransferIds = ["APUFHASUDF4AS", "407ASFPUAHSFA"] },
    });
    // TODO: Handle 'response' of type JsonElement
}
catch (ApiException<PostTransfersApproveError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTransfersApproveRequest](src/Adyen/Requests/Transfers/PostTransfersApproveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTransfersApproveError](src/Adyen/Errors/PostTransfersApproveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;JsonElement&gt; PostTransfersCancel(PostTransfersCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates the cancellation of a list of transfers that triggered an additional [review](https://docs.adyen.com/api-explorer/transfers/latest/post/transfers#request-review). Adyen sends the outcome of the cancel request through webhooks.

To use this endpoint:
- Your API credential must have the **TransferService Approve** [role](https://docs.adyen.com/platforms/manage-access/webservice-roles/?tab=transfers_3).
- The account holder must have the required [capabilities](https://docs.adyen.com/platforms/verification-overview/capabilities).

Reach out to your Adyen contact to set up these permissions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.PostTransfersCancel(new PostTransfersCancelRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new CancelTransfersRequest { TransferIds = ["APUFHASUDF4AS", "407ASFPUAHSFA"] },
    });
    // TODO: Handle 'response' of type JsonElement
}
catch (ApiException<PostTransfersCancelError> ex)
{
    if (ex.Error.TryGetTransferServiceRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type TransferServiceRestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTransfersCancelRequest](src/Adyen/Requests/Transfers/PostTransfersCancelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>JsonElement</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTransfersCancelError](src/Adyen/Errors/PostTransfersCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReturnTransferResponse&gt; PostTransfersTransferIdReturns(PostTransfersTransferIdReturnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Initiates the return of previously transferred funds without creating a new `transferId`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transfers.PostTransfersTransferIdReturns(new PostTransfersTransferIdReturnsRequest
    {
        TransferId = "some example string",
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new ReturnTransferRequest
        {
            Amount = new Amount17 { Currency = "EUR", Value = 189L },
            Reference = "Your internal reference for the return",
        },
    });
    // TODO: Handle 'response' of type ReturnTransferResponse
}
catch (ApiException<PostTransfersTransferIdReturnsError> ex)
{
    if (ex.Error.TryGetTransferServiceRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type TransferServiceRestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTransfersTransferIdReturnsRequest](src/Adyen/Requests/Transfers/PostTransfersTransferIdReturnsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReturnTransferResponse](src/Adyen/Models/ReturnTransferResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostTransfersTransferIdReturnsError](src/Adyen/Errors/PostTransfersTransferIdReturnsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersCompanyLevel

> Source: [UsersCompanyLevel](src/Adyen/Api/UsersCompanyLevel.cs)

<details>
<summary><code>Task&lt;ListCompanyUsersResponse&gt; GetCompaniesCompanyIdUsers(GetCompaniesCompanyIdUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of users for the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.GetCompaniesCompanyIdUsers(new GetCompaniesCompanyIdUsersRequest
    {
        CompanyId = "some example string",
    });
    // TODO: Handle 'response' of type ListCompanyUsersResponse
}
catch (ApiException<GetCompaniesCompanyIdUsersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdUsersRequest](src/Adyen/Requests/UsersCompanyLevel/GetCompaniesCompanyIdUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCompanyUsersResponse](src/Adyen/Models/ListCompanyUsersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdUsersError](src/Adyen/Errors/GetCompaniesCompanyIdUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyUser&gt; GetCompaniesCompanyIdUsersUserId(GetCompaniesCompanyIdUsersUserIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns user details for the `userId` and the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.GetCompaniesCompanyIdUsersUserId(
        new GetCompaniesCompanyIdUsersUserIdRequest
        {
            CompanyId = "some example string",
            UserId = "some example string",
        });
    // TODO: Handle 'response' of type CompanyUser
}
catch (ApiException<GetCompaniesCompanyIdUsersUserIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdUsersUserIdRequest](src/Adyen/Requests/UsersCompanyLevel/GetCompaniesCompanyIdUsersUserIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyUser](src/Adyen/Models/CompanyUser.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdUsersUserIdError](src/Adyen/Errors/GetCompaniesCompanyIdUsersUserIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompanyUser&gt; PatchCompaniesCompanyIdUsersUserId(PatchCompaniesCompanyIdUsersUserIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates user details for the `userId` and the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.PatchCompaniesCompanyIdUsersUserId(
        new PatchCompaniesCompanyIdUsersUserIdRequest
        {
            CompanyId = "some example string",
            UserId = "some example string",
        });
    // TODO: Handle 'response' of type CompanyUser
}
catch (ApiException<PatchCompaniesCompanyIdUsersUserIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchCompaniesCompanyIdUsersUserIdRequest](src/Adyen/Requests/UsersCompanyLevel/PatchCompaniesCompanyIdUsersUserIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompanyUser](src/Adyen/Models/CompanyUser.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchCompaniesCompanyIdUsersUserIdError](src/Adyen/Errors/PatchCompaniesCompanyIdUsersUserIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCompanyUserResponse&gt; PostCompaniesCompanyIdUsers(PostCompaniesCompanyIdUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates the user for the `companyId` identified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersCompanyLevel.PostCompaniesCompanyIdUsers(new PostCompaniesCompanyIdUsersRequest
    {
        CompanyId = "some example string",
        Body = new CreateCompanyUserRequest
        {
            AssociatedMerchantAccounts = ["YOUR_MERCHANT_ACCOUNT"],
            Email = "john.smith@example.com",
            LoginMethod = "Email",
            Name = new Name { FirstName = "John", LastName = "Smith" },
            Roles = ["Merchant standard role", "Merchant admin"],
            TimeZoneCode = "Europe/Amsterdam",
            Username = "johnsmith",
        },
    });
    // TODO: Handle 'response' of type CreateCompanyUserResponse
}
catch (ApiException<PostCompaniesCompanyIdUsersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdUsersRequest](src/Adyen/Requests/UsersCompanyLevel/PostCompaniesCompanyIdUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCompanyUserResponse](src/Adyen/Models/CreateCompanyUserResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdUsersError](src/Adyen/Errors/PostCompaniesCompanyIdUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersMerchantLevel

> Source: [UsersMerchantLevel](src/Adyen/Api/UsersMerchantLevel.cs)

<details>
<summary><code>Task&lt;ListMerchantUsersResponse&gt; GetMerchantsMerchantIdUsers(GetMerchantsMerchantIdUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of users associated with the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.GetMerchantsMerchantIdUsers(new GetMerchantsMerchantIdUsersRequest
    {
        MerchantId = "some example string",
    });
    // TODO: Handle 'response' of type ListMerchantUsersResponse
}
catch (ApiException<GetMerchantsMerchantIdUsersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdUsersRequest](src/Adyen/Requests/UsersMerchantLevel/GetMerchantsMerchantIdUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantUsersResponse](src/Adyen/Models/ListMerchantUsersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdUsersError](src/Adyen/Errors/GetMerchantsMerchantIdUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; GetMerchantsMerchantIdUsersUserId(GetMerchantsMerchantIdUsersUserIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns user details for the `userId` and the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.GetMerchantsMerchantIdUsersUserId(
        new GetMerchantsMerchantIdUsersUserIdRequest
        {
            MerchantId = "some example string",
            UserId = "some example string",
        });
    // TODO: Handle 'response' of type User
}
catch (ApiException<GetMerchantsMerchantIdUsersUserIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdUsersUserIdRequest](src/Adyen/Requests/UsersMerchantLevel/GetMerchantsMerchantIdUsersUserIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](src/Adyen/Models/User.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdUsersUserIdError](src/Adyen/Errors/GetMerchantsMerchantIdUsersUserIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; PatchMerchantsMerchantIdUsersUserId(PatchMerchantsMerchantIdUsersUserIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates user details for the `userId` and the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.PatchMerchantsMerchantIdUsersUserId(
        new PatchMerchantsMerchantIdUsersUserIdRequest
        {
            MerchantId = "some example string",
            UserId = "some example string",
        });
    // TODO: Handle 'response' of type User
}
catch (ApiException<PatchMerchantsMerchantIdUsersUserIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdUsersUserIdRequest](src/Adyen/Requests/UsersMerchantLevel/PatchMerchantsMerchantIdUsersUserIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](src/Adyen/Models/User.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdUsersUserIdError](src/Adyen/Errors/PatchMerchantsMerchantIdUsersUserIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateUserResponse&gt; PostMerchantsMerchantIdUsers(PostMerchantsMerchantIdUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a user for the `merchantId` specified in the path.

To make this request, your API credential must have the following [role](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Users read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersMerchantLevel.PostMerchantsMerchantIdUsers(new PostMerchantsMerchantIdUsersRequest
    {
        MerchantId = "some example string",
        Body = new CreateMerchantUserRequest
        {
            Email = "john.smith@example.com",
            LoginMethod = "Email",
            Name = new Name { FirstName = "John", LastName = "Smith" },
            Roles = ["Merchant standard role"],
            TimeZoneCode = "Europe/Amsterdam",
            Username = "johnsmith",
        },
    });
    // TODO: Handle 'response' of type CreateUserResponse
}
catch (ApiException<PostMerchantsMerchantIdUsersError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdUsersRequest](src/Adyen/Requests/UsersMerchantLevel/PostMerchantsMerchantIdUsersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateUserResponse](src/Adyen/Models/CreateUserResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdUsersError](src/Adyen/Errors/PostMerchantsMerchantIdUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Utility

> Source: [Utility](src/Adyen/Api/Utility.cs)

<details>
<summary><code>Task&lt;ApplePaySessionResponse&gt; PostApplePaySessions(PostApplePaySessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You need to use this endpoint if you have an API-only integration with Apple Pay which uses Adyen's Apple Pay certificate.

The endpoint returns the Apple Pay session data which you need to complete the [Apple Pay session validation](https://docs.adyen.com/payment-methods/apple-pay/api-only?tab=adyen-certificate-validation_1#complete-apple-pay-session-validation).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.PostApplePaySessions(new PostApplePaySessionsRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new ApplePaySessionRequest
        {
            DisplayName = "YOUR_MERCHANT_NAME",
            DomainName = "YOUR_DOMAIN_NAME",
            MerchantIdentifier = "YOUR_MERCHANT_ID",
        },
    });
    // TODO: Handle 'response' of type ApplePaySessionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostApplePaySessionsRequest](src/Adyen/Requests/Utility/PostApplePaySessionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApplePaySessionResponse](src/Adyen/Models/ApplePaySessionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Adyen/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UtilityResponse&gt; PostOriginKeys(PostOriginKeysRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains. 
> If you're still using origin key for your Web Drop-in or Components integration, we recommend [switching to client key](https://docs.adyen.com/development-resources/client-side-authentication/migrate-from-origin-key-to-client-key). This allows you to use a single key for all origins, add or remove origins without generating a new key, and detect the card type from the number entered in your payment form.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.PostOriginKeys(new PostOriginKeysRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new UtilityRequest
        {
            OriginDomains = [
                "https://www.your-domain1.com",
                "https://www.your-domain2.com",
                "https://www.your-domain3.com",
            ],
        },
    });
    // TODO: Handle 'response' of type UtilityResponse
}
catch (ApiException<PostOriginKeysError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostOriginKeysRequest](src/Adyen/Requests/Utility/PostOriginKeysRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UtilityResponse](src/Adyen/Models/UtilityResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostOriginKeysError](src/Adyen/Errors/PostOriginKeysError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaypalUpdateOrderResponse&gt; PostPaypalUpdateOrder(PostPaypalUpdateOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the order for PayPal Express Checkout. This can be used to update the PayPal lightbox with an updated amount and delivery methods based on the delivery address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.PostPaypalUpdateOrder(new PostPaypalUpdateOrderRequest
    {
        IdempotencyKey = "37ca9c97-d1d1-4c62-89e8-706891a563ed",
        Body = new PaypalUpdateOrderRequest
        {
            Amount = new Amount44 { Currency = "EUR", Value = 12000L },
            DeliveryMethods = [
                new DeliveryMethod
                {
                    Amount = new Amount24 { Currency = "EUR", Value = 1000L },
                    Description = "Express Shipping",
                    Reference = "1",
                    Selected = true,
                    Type = Type21.Shipping,
                },
                new DeliveryMethod
                {
                    Amount = new Amount24 { Currency = "EUR", Value = 500L },
                    Description = "Standard Ground",
                    Reference = "2",
                    Selected = false,
                    Type = Type21.Shipping,
                },
            ],
            PaymentData = "po7XZ...",
            PspReference = "DZ4DPSHB4WD2WN82",
        },
    });
    // TODO: Handle 'response' of type PaypalUpdateOrderResponse
}
catch (ApiException<PostPaypalUpdateOrderError> ex)
{
    if (ex.Error.TryGetServiceError(out var error))
    {
        // TODO: Handle 'error' of type ServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPaypalUpdateOrderRequest](src/Adyen/Requests/Utility/PostPaypalUpdateOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaypalUpdateOrderResponse](src/Adyen/Models/PaypalUpdateOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostPaypalUpdateOrderError](src/Adyen/Errors/PostPaypalUpdateOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ValidateShopperIdResponse&gt; PostValidateShopperId(PostValidateShopperIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Validates the shopperId.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Utility.PostValidateShopperId(new PostValidateShopperIdRequest
    {
        Body = new ValidateShopperIdRequest
        {
            MerchantAccount = "some example string",
            PaymentMethod = new ShopperIdPaymentMethod1(),
        },
    });
    // TODO: Handle 'response' of type ValidateShopperIdResponse
}
catch (ApiException<PostValidateShopperIdError> ex)
{
    if (ex.Error.TryGetCheckoutErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type CheckoutErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostValidateShopperIdRequest](src/Adyen/Requests/Utility/PostValidateShopperIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ValidateShopperIdResponse](src/Adyen/Models/ValidateShopperIdResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostValidateShopperIdError](src/Adyen/Errors/PostValidateShopperIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Verification

> Source: [Verification](src/Adyen/Api/Verification.cs)

<details>
<summary><code>Task&lt;GenericResponse&gt; PostCheckAccountHolder(PostCheckAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Triggers the verification of an account holder even if the checks are not yet required for the volume that they are currently processing.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostCheckAccountHolder(new PostCheckAccountHolderRequest
    {
        Body = new PerformVerificationRequest
        {
            AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
            AccountStateType = AccountStateType.Processing,
            Tier = 2,
        },
    });
    // TODO: Handle 'response' of type GenericResponse
}
catch (ApiException<PostCheckAccountHolderError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCheckAccountHolderRequest](src/Adyen/Requests/Verification/PostCheckAccountHolderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](src/Adyen/Models/GenericResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCheckAccountHolderError](src/Adyen/Errors/PostCheckAccountHolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeleteBankAccounts(PostDeleteBankAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes bank accounts associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostDeleteBankAccounts(new PostDeleteBankAccountsRequest
    {
        Body = new DeleteBankAccountRequest
        {
            AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
            BankAccountUuiDs = ["eeb6ed22-3bae-483c-83b9-bc2097a75d40"],
        },
    });
    // TODO: Handle 'response' of type GenericResponse
}
catch (ApiException<PostDeleteBankAccountsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDeleteBankAccountsRequest](src/Adyen/Requests/Verification/PostDeleteBankAccountsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](src/Adyen/Models/GenericResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDeleteBankAccountsError](src/Adyen/Errors/PostDeleteBankAccountsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeleteLegalArrangements(PostDeleteLegalArrangementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes legal arrangements and/or legal arrangement entities associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostDeleteLegalArrangements(new PostDeleteLegalArrangementsRequest
    {
        Body = new DeleteLegalArrangementRequest
        {
            AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
            LegalArrangements = [
                new LegalArrangementRequest { LegalArrangementCode = "cdf92f5a-a114-4ce6-8f19-c3f6ec83141c" },
            ],
        },
    });
    // TODO: Handle 'response' of type GenericResponse
}
catch (ApiException<PostDeleteLegalArrangementsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDeleteLegalArrangementsRequest](src/Adyen/Requests/Verification/PostDeleteLegalArrangementsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](src/Adyen/Models/GenericResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDeleteLegalArrangementsError](src/Adyen/Errors/PostDeleteLegalArrangementsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeletePayoutMethods(PostDeletePayoutMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes payout methods associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostDeletePayoutMethods(new PostDeletePayoutMethodsRequest
    {
        Body = new DeletePayoutMethodRequest
        {
            AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
            PayoutMethodCodes = ["34b6ed22-3bae-483c-83b9-bc2097a75d40"],
        },
    });
    // TODO: Handle 'response' of type GenericResponse
}
catch (ApiException<PostDeletePayoutMethodsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDeletePayoutMethodsRequest](src/Adyen/Requests/Verification/PostDeletePayoutMethodsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](src/Adyen/Models/GenericResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDeletePayoutMethodsError](src/Adyen/Errors/PostDeletePayoutMethodsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeleteShareholders(PostDeleteShareholdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes shareholders associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostDeleteShareholders(new PostDeleteShareholdersRequest
    {
        Body = new DeleteShareholderRequest
        {
            AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
            ShareholderCodes = ["9188218c-576e-4cbe-8e86-72722f453920"],
        },
    });
    // TODO: Handle 'response' of type GenericResponse
}
catch (ApiException<PostDeleteShareholdersError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDeleteShareholdersRequest](src/Adyen/Requests/Verification/PostDeleteShareholdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](src/Adyen/Models/GenericResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDeleteShareholdersError](src/Adyen/Errors/PostDeleteShareholdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenericResponse&gt; PostDeleteSignatories(PostDeleteSignatoriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes signatories associated with an account holder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostDeleteSignatories(new PostDeleteSignatoriesRequest());
    // TODO: Handle 'response' of type GenericResponse
}
catch (ApiException<PostDeleteSignatoriesError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDeleteSignatoriesRequest](src/Adyen/Requests/Verification/PostDeleteSignatoriesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenericResponse](src/Adyen/Models/GenericResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostDeleteSignatoriesError](src/Adyen/Errors/PostDeleteSignatoriesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetUploadedDocumentsResponse&gt; PostGetUploadedDocuments(PostGetUploadedDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns documents that were previously uploaded for an account holder. Adyen uses the documents during the [verification process](https://docs.adyen.com/classic-platforms/verification-process).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostGetUploadedDocuments(new PostGetUploadedDocumentsRequest
    {
        Body = new GetUploadedDocumentsRequest
        {
            AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
            BankAccountUuid = "EXAMPLE_UUID",
        },
    });
    // TODO: Handle 'response' of type GetUploadedDocumentsResponse
}
catch (ApiException<PostGetUploadedDocumentsError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostGetUploadedDocumentsRequest](src/Adyen/Requests/Verification/PostGetUploadedDocumentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetUploadedDocumentsResponse](src/Adyen/Models/GetUploadedDocumentsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostGetUploadedDocumentsError](src/Adyen/Errors/PostGetUploadedDocumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateAccountHolderResponse&gt; PostUploadDocument(PostUploadDocumentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads a document for an account holder. Adyen uses the documents during the [verification process](https://docs.adyen.com/classic-platforms/verification-process).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Verification.PostUploadDocument(new PostUploadDocumentRequest
    {
        Body = new UploadDocumentRequest
        {
            DocumentContent = "dGVzdCBkb2N1bWVudCBjb250ZW50",
            DocumentDetail = new DocumentDetail1
            {
                AccountHolderCode = "CODE_OF_ACCOUNT_HOLDER",
                Description = "test passport description",
                DocumentType = DocumentType.Passport,
                Filename = "passport.png",
            },
        },
    });
    // TODO: Handle 'response' of type UpdateAccountHolderResponse
}
catch (ApiException<PostUploadDocumentError> ex)
{
    if (ex.Error.TryGetServiceError1(out var error))
    {
        // TODO: Handle 'error' of type ServiceError1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostUploadDocumentRequest](src/Adyen/Requests/Verification/PostUploadDocumentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateAccountHolderResponse](src/Adyen/Models/UpdateAccountHolderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostUploadDocumentError](src/Adyen/Errors/PostUploadDocumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## WebhooksCompanyLevel

> Source: [WebhooksCompanyLevel](src/Adyen/Api/WebhooksCompanyLevel.cs)

<details>
<summary><code>Task DeleteCompaniesCompanyIdWebhooksWebhookId(DeleteCompaniesCompanyIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove the configuration for the webhook identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.WebhooksCompanyLevel.DeleteCompaniesCompanyIdWebhooksWebhookId(
        new DeleteCompaniesCompanyIdWebhooksWebhookIdRequest
        {
            CompanyId = "some example string",
            WebhookId = "some example string",
        });
}
catch (ApiException<DeleteCompaniesCompanyIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCompaniesCompanyIdWebhooksWebhookIdRequest](src/Adyen/Requests/WebhooksCompanyLevel/DeleteCompaniesCompanyIdWebhooksWebhookIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteCompaniesCompanyIdWebhooksWebhookIdError](src/Adyen/Errors/DeleteCompaniesCompanyIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListWebhooksResponse&gt; GetCompaniesCompanyIdWebhooks(GetCompaniesCompanyIdWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all webhook configurations for the company account.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.GetCompaniesCompanyIdWebhooks(
        new GetCompaniesCompanyIdWebhooksRequest { CompanyId = "some example string" });
    // TODO: Handle 'response' of type ListWebhooksResponse
}
catch (ApiException<GetCompaniesCompanyIdWebhooksError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdWebhooksRequest](src/Adyen/Requests/WebhooksCompanyLevel/GetCompaniesCompanyIdWebhooksRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListWebhooksResponse](src/Adyen/Models/ListWebhooksResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdWebhooksError](src/Adyen/Errors/GetCompaniesCompanyIdWebhooksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; GetCompaniesCompanyIdWebhooksWebhookId(GetCompaniesCompanyIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the configuration for the webhook identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.GetCompaniesCompanyIdWebhooksWebhookId(
        new GetCompaniesCompanyIdWebhooksWebhookIdRequest
        {
            CompanyId = "some example string",
            WebhookId = "some example string",
        });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<GetCompaniesCompanyIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCompaniesCompanyIdWebhooksWebhookIdRequest](src/Adyen/Requests/WebhooksCompanyLevel/GetCompaniesCompanyIdWebhooksWebhookIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/Adyen/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetCompaniesCompanyIdWebhooksWebhookIdError](src/Adyen/Errors/GetCompaniesCompanyIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; PatchCompaniesCompanyIdWebhooksWebhookId(PatchCompaniesCompanyIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Make changes to the configuration of the webhook identified in the path. The request contains the new values you want to have in the webhook configuration. The response contains the full configuration for the webhook, which includes the new values from the request.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.PatchCompaniesCompanyIdWebhooksWebhookId(
        new PatchCompaniesCompanyIdWebhooksWebhookIdRequest
        {
            CompanyId = "some example string",
            WebhookId = "some example string",
            Body = new UpdateCompanyWebhookRequest { Active = true },
        });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<PatchCompaniesCompanyIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchCompaniesCompanyIdWebhooksWebhookIdRequest](src/Adyen/Requests/WebhooksCompanyLevel/PatchCompaniesCompanyIdWebhooksWebhookIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/Adyen/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchCompaniesCompanyIdWebhooksWebhookIdError](src/Adyen/Errors/PatchCompaniesCompanyIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; PostCompaniesCompanyIdWebhooks(PostCompaniesCompanyIdWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Subscribe to receive webhook notifications about events related to your company account. You can add basic authentication to make sure the data is secure.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.PostCompaniesCompanyIdWebhooks(
        new PostCompaniesCompanyIdWebhooksRequest
        {
            CompanyId = "some example string",
            Body = new CreateCompanyWebhookRequest
            {
                AcceptsExpiredCertificate = false,
                AcceptsSelfSignedCertificate = true,
                AcceptsUntrustedRootCertificate = true,
                Active = true,
                CommunicationFormat = CommunicationFormat.Soap,
                FilterMerchantAccountType = FilterMerchantAccountType.IncludeAccounts,
                FilterMerchantAccounts = ["YOUR_MERCHANT_ACCOUNT"],
                Password = "YOUR_PASSWORD",
                PopulateSoapActionHeader = false,
                Type = "standard",
                Url = "YOUR_WEBHOOK_URL",
                Username = "YOUR_USER",
            },
        });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<PostCompaniesCompanyIdWebhooksError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdWebhooksRequest](src/Adyen/Requests/WebhooksCompanyLevel/PostCompaniesCompanyIdWebhooksRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/Adyen/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdWebhooksError](src/Adyen/Errors/PostCompaniesCompanyIdWebhooksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateHmacKeyResponse&gt; PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmac(PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an [HMAC key](https://en.wikipedia.org/wiki/HMAC) for the webhook identified in the path. This key allows you to check the integrity and the origin of the notifications you receive.By creating an HMAC key, you start receiving [HMAC-signed notifications](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures#enable-hmac-signatures) from Adyen. Find out more about how to [verify HMAC signatures](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmac(
        new PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacRequest
        {
            CompanyId = "some example string",
            WebhookId = "some example string",
        });
    // TODO: Handle 'response' of type GenerateHmacKeyResponse
}
catch (ApiException<PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacRequest](src/Adyen/Requests/WebhooksCompanyLevel/PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateHmacKeyResponse](src/Adyen/Models/GenerateHmacKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacError](src/Adyen/Errors/PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TestWebhookResponse&gt; PostCompaniesCompanyIdWebhooksWebhookIdTest(PostCompaniesCompanyIdWebhooksWebhookIdTestRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends sample notifications to test if the webhook is set up correctly.

We send sample notifications for maximum 20 of the merchant accounts that the webhook is configured for. If the webhook is configured for more than 20 merchant accounts, use the `merchantIds` array to specify a subset of the merchant accounts for which to send test notifications.

We send four test notifications for each event code you choose. They cover success and failure scenarios for the hard-coded currencies EUR and GBP, regardless of the currencies configured in the merchant accounts. For custom notifications, we only send the specified custom notification.

The response describes the result of the test. The `status` field tells you if the test was successful or not. You can use the other response fields to troubleshoot unsuccessful tests.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksCompanyLevel.PostCompaniesCompanyIdWebhooksWebhookIdTest(
        new PostCompaniesCompanyIdWebhooksWebhookIdTestRequest
        {
            CompanyId = "some example string",
            WebhookId = "some example string",
            Body = new TestCompanyWebhookRequest { MerchantIds = ["YOUR_MERCHANT_ACCOUNT"], Types = ["AUTHORISATION"] },
        });
    // TODO: Handle 'response' of type TestWebhookResponse
}
catch (ApiException<PostCompaniesCompanyIdWebhooksWebhookIdTestError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCompaniesCompanyIdWebhooksWebhookIdTestRequest](src/Adyen/Requests/WebhooksCompanyLevel/PostCompaniesCompanyIdWebhooksWebhookIdTestRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TestWebhookResponse](src/Adyen/Models/TestWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostCompaniesCompanyIdWebhooksWebhookIdTestError](src/Adyen/Errors/PostCompaniesCompanyIdWebhooksWebhookIdTestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## WebhooksMerchantLevel

> Source: [WebhooksMerchantLevel](src/Adyen/Api/WebhooksMerchantLevel.cs)

<details>
<summary><code>Task DeleteMerchantsMerchantIdWebhooksWebhookId(DeleteMerchantsMerchantIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Remove the configuration for the webhook identified in the path.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.WebhooksMerchantLevel.DeleteMerchantsMerchantIdWebhooksWebhookId(
        new DeleteMerchantsMerchantIdWebhooksWebhookIdRequest
        {
            MerchantId = "some example string",
            WebhookId = "some example string",
        });
}
catch (ApiException<DeleteMerchantsMerchantIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMerchantsMerchantIdWebhooksWebhookIdRequest](src/Adyen/Requests/WebhooksMerchantLevel/DeleteMerchantsMerchantIdWebhooksWebhookIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[DeleteMerchantsMerchantIdWebhooksWebhookIdError](src/Adyen/Errors/DeleteMerchantsMerchantIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListWebhooksResponse&gt; GetMerchantsMerchantIdWebhooks(GetMerchantsMerchantIdWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all webhook configurations for the merchant account.

> This call does not return webhook configurations for the company account to which the specified merchant account belongs. You can see these in your Customer Area under **Developers** > **Webhooks**.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.GetMerchantsMerchantIdWebhooks(
        new GetMerchantsMerchantIdWebhooksRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type ListWebhooksResponse
}
catch (ApiException<GetMerchantsMerchantIdWebhooksError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdWebhooksRequest](src/Adyen/Requests/WebhooksMerchantLevel/GetMerchantsMerchantIdWebhooksRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListWebhooksResponse](src/Adyen/Models/ListWebhooksResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdWebhooksError](src/Adyen/Errors/GetMerchantsMerchantIdWebhooksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; GetMerchantsMerchantIdWebhooksWebhookId(GetMerchantsMerchantIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the configuration for the webhook identified in the path.

To make this request, your API credential must have one of the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.GetMerchantsMerchantIdWebhooksWebhookId(
        new GetMerchantsMerchantIdWebhooksWebhookIdRequest
        {
            MerchantId = "some example string",
            WebhookId = "some example string",
        });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<GetMerchantsMerchantIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsMerchantIdWebhooksWebhookIdRequest](src/Adyen/Requests/WebhooksMerchantLevel/GetMerchantsMerchantIdWebhooksWebhookIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/Adyen/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[GetMerchantsMerchantIdWebhooksWebhookIdError](src/Adyen/Errors/GetMerchantsMerchantIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; PatchMerchantsMerchantIdWebhooksWebhookId(PatchMerchantsMerchantIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Make changes to the configuration of the webhook identified in the path. The request contains the new values you want to have in the webhook configuration. The response contains the full configuration for the webhook, which includes the new values from the request.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.PatchMerchantsMerchantIdWebhooksWebhookId(
        new PatchMerchantsMerchantIdWebhooksWebhookIdRequest
        {
            MerchantId = "some example string",
            WebhookId = "some example string",
            Body = new UpdateMerchantWebhookRequest { Active = true },
        });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<PatchMerchantsMerchantIdWebhooksWebhookIdError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchMerchantsMerchantIdWebhooksWebhookIdRequest](src/Adyen/Requests/WebhooksMerchantLevel/PatchMerchantsMerchantIdWebhooksWebhookIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/Adyen/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PatchMerchantsMerchantIdWebhooksWebhookIdError](src/Adyen/Errors/PatchMerchantsMerchantIdWebhooksWebhookIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Webhook&gt; PostMerchantsMerchantIdWebhooks(PostMerchantsMerchantIdWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Subscribe to receive webhook notifications about events related to your merchant account. You can add basic authentication to make sure the data is secure.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.PostMerchantsMerchantIdWebhooks(
        new PostMerchantsMerchantIdWebhooksRequest
        {
            MerchantId = "some example string",
            Body = new CreateMerchantWebhookRequest
            {
                AcceptsExpiredCertificate = false,
                AcceptsSelfSignedCertificate = true,
                AcceptsUntrustedRootCertificate = true,
                Active = true,
                CommunicationFormat = CommunicationFormat.Json,
                Password = "YOUR_PASSWORD",
                PopulateSoapActionHeader = false,
                Type = "standard",
                Url = "YOUR_WEBHOOK_URL",
                Username = "YOUR_USER",
            },
        });
    // TODO: Handle 'response' of type Webhook
}
catch (ApiException<PostMerchantsMerchantIdWebhooksError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdWebhooksRequest](src/Adyen/Requests/WebhooksMerchantLevel/PostMerchantsMerchantIdWebhooksRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Webhook](src/Adyen/Models/Webhook.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdWebhooksError](src/Adyen/Errors/PostMerchantsMerchantIdWebhooksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GenerateHmacKeyResponse&gt; PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmac(PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an [HMAC key](https://en.wikipedia.org/wiki/HMAC) for the webhook identified in the path. This key allows you to check the integrity and the origin of the notifications you receive.By creating an HMAC key, you start receiving [HMAC-signed notifications](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures#enable-hmac-signatures) from Adyen. Find out more about how to [verify HMAC signatures](https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures).

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmac(
        new PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacRequest
        {
            MerchantId = "some example string",
            WebhookId = "some example string",
        });
    // TODO: Handle 'response' of type GenerateHmacKeyResponse
}
catch (ApiException<PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacRequest](src/Adyen/Requests/WebhooksMerchantLevel/PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GenerateHmacKeyResponse](src/Adyen/Models/GenerateHmacKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacError](src/Adyen/Errors/PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TestWebhookResponse&gt; PostMerchantsMerchantIdWebhooksWebhookIdTest(PostMerchantsMerchantIdWebhooksWebhookIdTestRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends sample notifications to test if the webhook is set up correctly.

We send four test notifications for each event code you choose. They cover success and failure scenarios for the hard-coded currencies EUR and GBP, regardless of the currencies configured in the merchant accounts. For custom notifications, we only send the specified custom notification.

The response describes the result of the test. The `status` field tells you if the test was successful or not. You can use the other fields to troubleshoot unsuccessful tests.

To make this request, your API credential must have the following [roles](https://docs.adyen.com/development-resources/api-credentials#api-permissions):
* Management API—Webhooks read and write

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhooksMerchantLevel.PostMerchantsMerchantIdWebhooksWebhookIdTest(
        new PostMerchantsMerchantIdWebhooksWebhookIdTestRequest
        {
            MerchantId = "some example string",
            WebhookId = "some example string",
            Body = new TestWebhookRequest { Types = ["AUTHORISATION"] },
        });
    // TODO: Handle 'response' of type TestWebhookResponse
}
catch (ApiException<PostMerchantsMerchantIdWebhooksWebhookIdTestError> ex)
{
    if (ex.Error.TryGetRestServiceError(out var error))
    {
        // TODO: Handle 'error' of type RestServiceError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMerchantsMerchantIdWebhooksWebhookIdTestRequest](src/Adyen/Requests/WebhooksMerchantLevel/PostMerchantsMerchantIdWebhooksWebhookIdTestRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TestWebhookResponse](src/Adyen/Models/TestWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostMerchantsMerchantIdWebhooksWebhookIdTestError](src/Adyen/Errors/PostMerchantsMerchantIdWebhooksWebhookIdTestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## IDealProfiles

> Source: [IDealProfiles](src/Adyen/Api/IDealProfiles.cs)

<details>
<summary><code>Task&lt;IdealAuthLinkResponse&gt; PostIdealProfileAuthLink(PostIdealProfileAuthLinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Manage an already registered iDEAL profile. Generates a redirection URL to manage the iDEAL profile linked to the account holder from the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IDealProfiles.PostIdealProfileAuthLink(new PostIdealProfileAuthLinkRequest
    {
        Body = new IdealAuthLinkRequest { AccountHolderId = "AH00000000000000000000000" },
    });
    // TODO: Handle 'response' of type IdealAuthLinkResponse
}
catch (ApiException<PostIdealProfileAuthLinkError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostIdealProfileAuthLinkRequest](src/Adyen/Requests/IDealProfiles/PostIdealProfileAuthLinkRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdealAuthLinkResponse](src/Adyen/Models/IdealAuthLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostIdealProfileAuthLinkError](src/Adyen/Errors/PostIdealProfileAuthLinkError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IdealAuthenticateResponse&gt; PostIdealProfileAuthenticate(PostIdealProfileAuthenticateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generates an redirection URL to finish the authentication flow when requested by iDEAL. Before calling this endpoint, make sure that your user has completed multi-factor authentication.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IDealProfiles.PostIdealProfileAuthenticate(new PostIdealProfileAuthenticateRequest
    {
        Body = new IdealAuthenticateRequest
        {
            AccountHolderId = "AH00000000000000000000000",
            Payload = "https://ideal.auth/somePayload",
        },
    });
    // TODO: Handle 'response' of type IdealAuthenticateResponse
}
catch (ApiException<PostIdealProfileAuthenticateError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostIdealProfileAuthenticateRequest](src/Adyen/Requests/IDealProfiles/PostIdealProfileAuthenticateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdealAuthenticateResponse](src/Adyen/Models/IdealAuthenticateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostIdealProfileAuthenticateError](src/Adyen/Errors/PostIdealProfileAuthenticateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProfileRegistrationResponse&gt; PostIdealProfileRegister(PostIdealProfileRegisterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Register a new iDEAL profile. The profile is linked to the account holder and payment instruments included in the request. The user must be redirected to the URL in the response to finish their IDEAL profile registration.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IDealProfiles.PostIdealProfileRegister(new PostIdealProfileRegisterRequest
    {
        Body = new ProfileRegistrationRequest
        {
            AccountHolderId = "AH00000000000000000000000",
            PaymentInstrumentIds = ["PI00000000000000000000000", "PI11111111111111111111111"],
        },
    });
    // TODO: Handle 'response' of type ProfileRegistrationResponse
}
catch (ApiException<PostIdealProfileRegisterError> ex)
{
    if (ex.Error.TryGetDefaultErrorResponseEntity(out var error))
    {
        // TODO: Handle 'error' of type DefaultErrorResponseEntity
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostIdealProfileRegisterRequest](src/Adyen/Requests/IDealProfiles/PostIdealProfileRegisterRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProfileRegistrationResponse](src/Adyen/Models/ProfileRegistrationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Adyen/Core/Exceptions/ApiException.cs)&lt;[PostIdealProfileRegisterError](src/Adyen/Errors/PostIdealProfileRegisterError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

