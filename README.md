# Adyen

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The Adyen SDK for .NET provides access to the Adyen REST APIs from .NET applications.

> [!TIP]
> **Looking for a specific signature, model, enum, or error type?** This SDK ships a generated,
> machine-readable **[SDK map](sdk-map.md)** — a lookup index of the SDK's entire C# surface. Consult it
> **before** grepping or scanning the source tree; it answers most contract questions directly and,
> when a source file is genuinely needed, names the exact one to open. Details under [SDK map](#sdk-map).

Adyen Checkout API provides a simple and flexible way to initiate and authorise online payments. You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).

This API reference provides information on available endpoints and how to interact with them. To learn more about the API, visit [online payments documentation](https://docs.adyen.com/online-payments).

## Authentication
Each request to Checkout API must be signed with an API key. For this, [get your API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key) from your Customer Area, and set this key to the `X-API-Key` header value, for example:

```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```
## Versioning
Checkout API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://checkout-test.adyen.com/v72/payments
```

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
Checkout API is available through a Postman collection. Click the button below to create a fork, then set the environment variables at **Environments**&nbsp;>&nbsp;**Adyen&nbsp;APIs**. 

[![Run in Postman](https://run.pstmn.io/button.svg)](https://god.gw.postman.com/run-collection/25716737-46ad970e-dc9e-4246-bac2-769c6083e7b5?action=collection%2Ffork&source=rip_markdown&collection-url=entityId%3D25716737-46ad970e-dc9e-4246-bac2-769c6083e7b5%26entityType%3Dcollection%26workspaceId%3Da8d63f9f-cfc7-4810-90c5-9e0c60030d3e#?env%5BAdyen%20APIs%5D=W3sia2V5IjoiWC1BUEktS2V5IiwidmFsdWUiOiIiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0In0seyJrZXkiOiJZT1VSX01FUkNIQU5UX0FDQ09VTlQiLCJ2YWx1ZSI6IiIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In0seyJrZXkiOiJZT1VSX0NPTVBBTllfQUNDT1VOVCIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifSx7ImtleSI6IllPVVJfQkFMQU5DRV9QTEFURk9STSIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifV0=)


## Going live

To access the live endpoints, you need an API key from your live Customer Area.

The live endpoint URLs contain a prefix which is unique to your company account, for example:
```
https://{PREFIX}-checkout-live.adyenpayments.com/checkout/v72/payments
```

Get your `{PREFIX}` from your live Customer Area under **Developers** > **API URLs** > **Prefix**.

When preparing to do live transactions with Checkout API, follow the [go-live checklist](https://docs.adyen.com/online-payments/go-live-checklist) to make sure you've got all the required configuration in place.

## Release notes
Have a look at the [release notes](https://docs.adyen.com/online-payments/release-notes?integration_type=api&version=72) to find out what changed in this version!, A set of API endpoints that allow you to initiate, settle, and modify payments on the Adyen payments platform. You can use the API to accept card payments (including One-Click and 3D Secure), bank transfers, ewallets, and many other payment methods.

> This API is [inactive](https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle).
> * If you are building a new integration, use the [Checkout API](https://docs.adyen.com/api-explorer/Checkout/latest/overview) instead.
> * If you have an existing integration using this API, reach out to your Adyen contact and [migrate to the Checkout API](https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api).
>The Checkout API enables your [online payments](https://docs.adyen.com/online-payments) integration to accept all supported payment methods, use the latest features, and access more benefits.

To learn more about the API, visit [Classic integration](https://docs.adyen.com/classic-integration).

## Authentication
You need an [API credential](https://docs.adyen.com/development-resources/api-credentials) to authenticate to the API.

If using an API key, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

Alternatively, you can use the username and password to connect to the API using basic authentication, for example:

```
curl
-u "ws@Company.YOUR_COMPANY_ACCOUNT":"YOUR_BASIC_AUTHENTICATION_PASSWORD" \
-H "Content-Type: application/json" \
...
```

## Versioning
Payments API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://pal-test.adyen.com/pal/servlet/Payment/v68/authorise
```

## Going live

To authenticate to the live endpoints, you need an [API credential](https://docs.adyen.com/development-resources/api-credentials) from your live Customer Area.

The live endpoint URLs contain a prefix which is unique to your company account:
```

https://{PREFIX}-pal-live.adyenpayments.com/pal/servlet/Payment/v68/authorise
```

Get your `{PREFIX}` from your live Customer Area under **Developers** > **API URLs** > **Prefix**., > The Recurring API is a legacy API for managing tokens. We strongly recommend to use [Checkout API recurring endpoints](https://docs.adyen.com/api-explorer/Checkout/71/post/storedPaymentMethods) instead when possible.

The Recurring API allows you to manage and remove your tokens or stored payment details. Tokens should be created with validation during a payment request.

For more information, refer to our [Tokenization documentation](https://docs.adyen.com/online-payments/tokenization).
## Authentication
You need an [API credential](https://docs.adyen.com/development-resources/api-credentials) to authenticate to the API.

If using an API key, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

Alternatively, you can use the username and password to connect to the API using basic authentication, for example:

```
curl
-u "ws@Company.YOUR_COMPANY_ACCOUNT":"YOUR_BASIC_AUTHENTICATION_PASSWORD" \
-H "Content-Type: application/json" \
...
```

## Versioning
Recurring API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://pal-test.adyen.com/pal/servlet/Recurring/v68/disable
```

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
Recurring API is available through a Postman collection. Click the button below to create a fork, then set the environment variables at **Environments**&nbsp;>&nbsp;**Adyen&nbsp;APIs**. 

[![Run in Postman](https://run.pstmn.io/button.svg)](https://god.gw.postman.com/run-collection/25716737-0d1ef0da-f5a1-4004-b24a-c5152c51dc7b?action=collection%2Ffork&source=rip_markdown&collection-url=entityId%3D25716737-0d1ef0da-f5a1-4004-b24a-c5152c51dc7b%26entityType%3Dcollection%26workspaceId%3Da8d63f9f-cfc7-4810-90c5-9e0c60030d3e#?env%5BAdyen%20APIs%5D=W3sia2V5IjoiWC1BUEktS2V5IiwidmFsdWUiOiIiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0In0seyJrZXkiOiJZT1VSX01FUkNIQU5UX0FDQ09VTlQiLCJ2YWx1ZSI6IiIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In0seyJrZXkiOiJZT1VSX0NPTVBBTllfQUNDT1VOVCIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifSx7ImtleSI6IllPVVJfQkFMQU5DRV9QTEFURk9STSIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifV0=)


## Going live

To authenticate to the live endpoints, you need an [API credential](https://docs.adyen.com/development-resources/api-credentials) from your live Customer Area.

The live endpoint URLs contain a prefix which is unique to your company account:
```

https://{PREFIX}-pal-live.adyenpayments.com/pal/servlet/Recurring/v68/disable
```

Get your `{PREFIX}` from your live Customer Area under **Developers** > **API URLs** > **Prefix**., > The **Payout API is deprecated** and no longer supports new integrations. Do one of the following:
>- If you are building a new integration, use the [Transfers API](https://docs.adyen.com/api-explorer/transfers/latest/overview) instead.
> - If you are already using the Payout API, reach out to your Adyen contact to learn how to migrate to the Transfers API.
>
> With the Transfers API, you can:
> - Handle multiple payout use cases with a single API.
> - Use new payout functionalities, such as instant payouts to bank accounts.
> - Receive webhooks with more details and defined transfer states.
>
> For more information about the payout features of the Transfers API, see our [Payouts](https://docs.adyen.com/payouts/payout-service) documentation.


A set of API endpoints that allow you to store payout details, confirm, or decline a payout.

For more information, refer to [Online payouts](https://docs.adyen.com/online-payments/online-payouts).
## Authentication
To use the Payout API, you need to have [two API credentials](https://docs.adyen.com/online-payments/online-payouts#payouts-to-bank-accounts-and-wallets): one for storing payout details and submitting payouts, and another one for confirming or declining payouts. If you don't have the required API credentials, contact our [Support Team](https://www.adyen.help/hc/en-us/requests/new).

If using an API key, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

Alternatively, you can use the username and password to connect to the API using [basic authentication](https://docs.adyen.com/development-resources/api-credentials#basic-authentication).

The following example shows how to authenticate your request with basic authentication when submitting a payout:

```
curl
-u "storePayout@Company.YOUR_COMPANY_ACCOUNT":"YOUR_BASIC_AUTHENTICATION_PASSWORD" \
-H "Content-Type: application/json" \
...
```

## Versioning
Payout API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://pal-test.adyen.com/pal/servlet/Payout/v68/payout
```

## Going live

To authenticate to the live endpoints, you need [API credentials](https://docs.adyen.com/development-resources/api-credentials) from your live Customer Area.

The live endpoint URLs contain a prefix which is unique to your company account:
```

https://{PREFIX}-pal-live.adyenpayments.com/pal/servlet/Payout/v68/payout
```

Get your `{PREFIX}` from your live Customer Area under **Developers** > **API URLs** > **Prefix**., The BIN Lookup API provides endpoints for retrieving information, such as cost estimates, and 3D Secure supported version based on a given BIN.

## Authentication
You need an [API credential](https://docs.adyen.com/development-resources/api-credentials) to authenticate to the API.

If using an API key, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

Alternatively, you can use the username and password to connect to the API using basic authentication, for example:

```
curl
-u "ws@Company.YOUR_COMPANY_ACCOUNT":"YOUR_BASIC_AUTHENTICATION_PASSWORD" \
-H "Content-Type: application/json" \
...
```

## Versioning
The BinLookup API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://pal-test.adyen.com/pal/servlet/BinLookup/v54/get3dsAvailability
```

## Going live

To authenticate to the live endpoints, you need an [API credential](https://docs.adyen.com/development-resources/api-credentials) from your live Customer Area.

The live endpoint URLs contain a prefix which is unique to your company account:
```

https://{PREFIX}-pal-live.adyenpayments.com/pal/servlet/BinLookup/v54/get3dsAvailability
```

Get your `{PREFIX}` from your live Customer Area under **Developers** > **API URLs** > **Prefix**., A set of API endpoints to manage stored value products., Adyen Data Protection API provides a way for you to process [Subject Erasure Requests](https://gdpr-info.eu/art-17-gdpr/) as mandated in GDPR.

Use our API to submit a request to delete shopper's data, including payment details and other related information (for example, delivery address or shopper email).## Authentication
Each request to the Data Protection API must be signed with an API key. Get your API Key from your Customer Area, as described in [How to get the API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key). Then set this key to the `X-API-Key` header value, for example:

```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: Your_API_key" \
...
```
Note that when going live, you need to generate a new API Key to access the [live endpoints](https://docs.adyen.com/development-resources/live-endpoints).

## Versioning
Data Protection Service API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://ca-test.adyen.com/ca/services/DataProtectionService/v1/requestSubjectErasure
```, The Foreign Exchange API allows you to manage and convert the currencies that are enabled for your integration.
## Authentication
We recommend that you use an API key to connect to the Foreign Exchange API. You can generate an API key in your Customer Area. If you have an Adyen Issuing integration, generate an API key in your Balance Platform Customer Area.
### Credential format
* For the `rates/calculate` endpoint: Generate an API key for the credential with the format **ws@BalancePlatform.[YourBalancePlatform]**.

### Header format
To connect to the Foreign Exchange API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H 'Content-Type: application/json' \
-H 'X-API-Key: ADYEN_API_KEY' \
...
```

## Versioning

The Foreign Exchange API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:

https://balanceplatform-api-test.adyen.com/fx/v1/rates/calculate

## Going live
When going live, generate an API key in your [live Customer Area](https://ca-live.adyen.com/ca/). If you have an Adyen Issuing integration, [generate an API key](https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key) in your [live Balance Platform Customer Area](https://balanceplatform-live.adyen.com/balanceplatform/). You can then use the API key to send requests to `https://balanceplatform-api-test.adyen.com/fx/v1`., The Test Cards API provides endpoints for generating custom test card numbers. For more information, refer to [Custom test cards](https://docs.adyen.com/development-resources/testing/create-test-cards) documentation., Configure and manage your Adyen company and merchant accounts, stores, and payment terminals.
## Authentication
Each request to the Management API must be signed with an API key. [Generate your API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key) in the Customer Area and then set this key to the `X-API-Key` header value.

To access the live endpoints, you need to generate a new API key in your live Customer Area.
## Versioning

Management API handles versioning as part of the endpoint URL. For example, to send a request to this version of the `/companies/{companyId}/webhooks` endpoint, use:

```text
https://management-test.adyen.com/v3/companies/{companyId}/webhooks
```

## Going live

To access the live endpoints, you need an API key from your live Customer Area. Use this API key to make requests to:

```text
https://management-live.adyen.com/v3
```

## Release notes
Have a look at the [release notes](https://docs.adyen.com/release-notes/management-api) to find out what changed in this version!, This API is used for the classic integration. If you are just starting your implementation, refer to our [new integration guide](https://docs.adyen.com/adyen-for-platforms-model) instead.

The Account API provides endpoints for managing account-related entities on your platform. These related entities include account holders, accounts, bank accounts, shareholders, and verification-related documents. The management operations include actions such as creation, retrieval, updating, and deletion of them.

For more information, refer to our [documentation](https://docs.adyen.com/classic-platforms).
## Authentication
Your Adyen contact will provide your API credential and an API key. To connect to the API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

Alternatively, you can use the username and password to connect to the API using basic authentication. For example:

```
curl
-U "ws@MarketPlace.YOUR_PLATFORM_ACCOUNT":"YOUR_WS_PASSWORD" \
-H "Content-Type: application/json" \
...
```
When going live, you need to generate new web service user credentials to access the [live endpoints](https://docs.adyen.com/development-resources/live-endpoints).

## Versioning
The Account API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://cal-test.adyen.com/cal/services/Account/v6/createAccountHolder
```, The Balance Control API allows you to view and manage the balances in your company and merchant accounts.
## Authentication
We recommend that you use an API key to connect to the Balance Control API. You can [generate an API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key) in your Customer Area.
### Header format
To connect to the Balance Control API, add an `X-API-Key` header with the API key as the value. For example:

 ```
curl
-H 'Content-Type: application/json' \
-H 'X-API-Key: ADYEN_API_KEY' \
...
```

## Versioning

The Balance Control API handles versioning as part of the endpoint URL. For example, to send a request to version 2 of the `/balanceOverview/companies/{companyId}/balances` endpoint, use:

https://balance-control-test.adyen.com/balance-control/api/v2/balanceOverview/companies/{companyId}/balances

## Going live
When going live, generate an API key in your [live Customer Area](https://ca-live.adyen.com/ca/). You can then use the API key to send requests to `https://balance-control-live.adyen.com/api/v2`., This API is used for the classic integration. If you are just starting your implementation, refer to our [new integration guide](https://docs.adyen.com/adyen-for-platforms-model) instead.

The Notification Configuration API provides endpoints for setting up and testing notifications that inform you of events on your platform, for example when a verification check or a payout has been completed.

For more information, refer to our [documentation](https://docs.adyen.com/classic-platforms/notifications).
## Authentication
Your Adyen contact will provide your API credential and an API key. To connect to the API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

Alternatively, you can use the username and password to connect to the API using basic authentication. For example:

```
curl
-U "ws@MarketPlace.YOUR_PLATFORM_ACCOUNT":"YOUR_WS_PASSWORD" \
-H "Content-Type: application/json" \
...
```
When going live, you need to generate new web service user credentials to access the [live endpoints](https://docs.adyen.com/development-resources/live-endpoints).

## Versioning
The Notification Configuration API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://cal-test.adyen.com/cal/services/Notification/v6/createNotificationConfiguration
```, The Configuration API allows you to manage your balance platform where you can create account holders, balance accounts, cards, and business accounts.

## Authentication
Each request to the Configuration API must be signed with an API key. Generate an API key in your Customer Area if you have a [platform setup](https://docs.adyen.com/platforms/manage-access/api-credentials-web-service/#generate-api-key) or [marketplace setup](https://docs.adyen.com/marketplaces/manage-access/api-credentials-web-service/#generate-api-key).

 If you have an Adyen Issuing integration, [generate an API key](https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key) in your Balance Platform Customer Area.

To connect to the API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

## Versioning
The Configuration API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://balanceplatform-api-test.adyen.com/bcl/v2/accountHolders
```
## Going live
When going live, generate an API key in your [live Customer Area](https://ca-live.adyen.com/ca/) if you have an Adyen for Platforms integration or [live Balance Platform Customer Area](https://balanceplatform-live.adyen.com/balanceplatform/) if you have an Adyen Issuing integration.You can then use the API key to send requests to `https://balanceplatform-api-live.adyen.com/bcl/v2`., >Versions 1 and 2 of the Transfers API are deprecated. If you are just starting your implementation, use the latest version.

The Transfers API provides endpoints that you can use to transfer funds, whether when paying out to a transfer instrument for [marketplaces](https://docs.adyen.com/marketplaces/payout-to-users/on-demand-payouts) or [platforms](https://docs.adyen.com/platforms/payout-to-users/on-demand-payouts), [sending funds to third parties](https://docs.adyen.com/platforms/business-accounts/send-receive-funds) for users with business bank accounts, or to [request a payout for a grant offer](https://docs.adyen.com/platforms/capital). The API also supports use cases for [getting transactions for business bank accounts](https://docs.adyen.com/platforms/business-accounts/transactions-api) and getting [outstanding balances](https://docs.adyen.com/platforms/capital#get-balances) for one or more grants on your platform. 

## Authentication
Each request to the Transfers API must be signed with an API key. Generate an API key in your Customer Area if you have a [platform setup](https://docs.adyen.com/platforms/manage-access/api-credentials-web-service/#generate-api-key) or [marketplace setup](https://docs.adyen.com/marketplaces/manage-access/api-credentials-web-service/#generate-api-key).

If you have an Adyen Issuing integration, [generate an API key](https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key) in your Balance Platform Customer Area.

To connect to the API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

## Roles and permissions
To use the Transfers API, you need an additional role for your API credential. Transfers must also be enabled for the source balance account. Your Adyen contact will set up the roles and permissions for you.
## Versioning
The Transfers API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://balanceplatform-api-test.adyen.com/btl/v4/transfers
```
## Going live
When going live, generate an API key in your [live Customer Area](https://ca-live.adyen.com/ca/) if you have an Adyen for Platforms integration or [live Balance Platform Customer Area](https://balanceplatform-live.adyen.com/balanceplatform/) if you have an Adyen Issuing integration. You can then use the API key to send requests to `https://balanceplatform-api-live.adyen.com/btl/v4`., The Capital API provides endpoints for embedding [Adyen Capital](https://docs.adyen.com/capital) into your marketplace or platform. With Capital, you can offer business financing to your users as grants. When a user receives a grant, they must repay the grant amount in a specified term, in addition to paying a fee for using this service.

With these endpoints, you can:
- **Get available financing offers**: You can get a list of offers with fixed amounts or a range of available financing for your users. Adyen configures the financing amount, the fee, and the repayment conditions for each offer. These configurations are based on proactive risk analyses that Adyen performs on your users.
- **Make requests for grants**: When a user selects a financing offer, you can make a request for the grant on their behalf.
- **Get information about your grant account**: Your grant account tracks the information of all grants in your marketplace or platform.

## Authentication
Each request made to the Capital API must be signed with an API key. Generate an API key in your Customer Area.

To connect to the API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

## Roles and permissions
To use the Capital API, your API credential must have the following roles:
- **Balance_Platform_Capital_Configuration_Role**
- **Balance_Platform_Capital_Grant_Initiation_Role**

Reach out to your Adyen contact to set up these roles.
## Going live
When going live, generate an API key in your [live Customer Area](https://ca-live.adyen.com/ca). You can then use the API key to send requests to `https://balanceplatform-api-live.adyen.com/capital/v{version}`., This API is used for the classic integration. If you are just starting your implementation, refer to our [new integration guide](https://docs.adyen.com/adyen-for-platforms-model) instead.

The Fund API provides endpoints for managing the funds in the accounts on your platform. These management operations include, for example, the transfer of funds from one account to another, the payout of funds to an account holder, and the retrieval of balances in an account.

For more information, refer to our [documentation](https://docs.adyen.com/classic-platforms).
## Authentication
Your Adyen contact will provide your API credential and an API key. To connect to the API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

Alternatively, you can use the username and password to connect to the API using basic authentication. For example:

```
curl
-U "ws@MarketPlace.YOUR_PLATFORM_ACCOUNT":"YOUR_WS_PASSWORD" \
-H "Content-Type: application/json" \
...
```
When going live, you need to generate new web service user credentials to access the [live endpoints](https://docs.adyen.com/development-resources/live-endpoints).

## Versioning
The Fund API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://cal-test.adyen.com/cal/services/Fund/v6/accountHolderBalance
```, The Session authentication API enables you to create and manage the JSON Web Tokens (JWT) required for integrating [components](https://docs.adyen.com/platforms/components-overview).
## Authentication
We recommend that you use an API key to connect to the Session authentication API. Generate an API key in your Customer Area if you have a [platform setup](https://docs.adyen.com/platforms/manage-access/api-credentials-web-service/#generate-api-key) or [marketplace setup](https://docs.adyen.com/marketplaces/manage-access/api-credentials-web-service/#generate-api-key). If you have an Adyen Issuing integration, [generate an API key](https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key) in your Balance Platform Customer Area.

To connect to the Session authentication API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H 'Content-Type: application/json' \
-H 'X-API-Key: YOUR_API_KEY' \
...
```

## Roles and permissions
To create a token, you must meet specific requirements. These requirements vary depending on the type of component. For more information, see the documentation for [Onboarding](https://docs.adyen.com/platforms/onboard-users/components) and [Platform Experience](https://docs.adyen.com/platforms/build-user-dashboards) components.

## Going live
To access the live endpoint, generate an API key in your live Customer Area if you have a [platform](https://docs.adyen.com/platforms/) or [marketplace setup](https://docs.adyen.com/marketplaces/). If you have an Adyen Issuing integration, [generate an API key](https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key) in your Balance Platform Customer Area. You can then use the API key to send requests to `https://authe-live.adyen.com/authe/api/v1`., The Legal Entity Management API enables you to manage legal entities that contain information required for verification.

## Authentication
Each request to the Legal Entity Management API must be signed with an API key. Generate an API key in your Customer Area if you have a [platform setup](https://docs.adyen.com/platforms/manage-access/api-credentials-web-service/#generate-api-key) or [marketplace setup](https://docs.adyen.com/marketplaces/manage-access/api-credentials-web-service/#generate-api-key).

 If you have an Adyen Issuing integration, [generate an API key](https://docs.adyen.com/issuing/manage-access/api-credentials-web-service/#generate-api-key) in your Balance Platform Customer Area.

To connect to the API, add an `X-API-Key` header with the API key as the value. For example:

```
curl
-H "X-API-Key: YOUR_API_KEY" \
-H "Content-Type: application/json" \
...
```
## Versioning
The Legal Entity Management API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://kyc-test.adyen.com/lem/v4/legalEntities
```
## Rate limits
We enforce rate limits on Legal Entity Management API endpoints. When the number of requests you send exceeds a threshold within a time frame, additional requests are blocked until the time frame ends. Current limits:

- Live environments: 700 requests per 5 seconds.

- Test environments: 200 requests per 5 seconds.

- Failed requests are subject to a limit of 5 failures per 10 seconds.

## Going live
When going live, generate an API key in your [live Customer Area](https://ca-live.adyen.com/ca/) if you have an Adyen for Platforms integration or [live Balance Platform Customer Area](https://balanceplatform-live.adyen.com/balanceplatform/) if you have an Adyen Issuing integration.You can then use the API key to send requests to `https://kyc-live.adyen.com/lem/v4`., This API is used for the classic integration. If you are just starting your implementation, refer to our [new integration guide](https://docs.adyen.com/adyen-for-platforms-model) instead.

The Hosted onboarding API provides endpoints that you can use to generate links to Adyen-hosted pages, such as an [onboarding page](https://docs.adyen.com/classic-platforms/hosted-onboarding-page) or a [PCI compliance questionnaire](https://docs.adyen.com/classic-platforms/platforms-for-partners). You can provide these links to your account holders so that they can complete their onboarding.

## Authentication
Your Adyen contact will provide your API credential and an API key. To connect to the API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

Alternatively, you can use the username and password to connect to the API using basic authentication. For example:

```
curl
-U "ws@MarketPlace.YOUR_PLATFORM_ACCOUNT":"YOUR_WS_PASSWORD" \
-H "Content-Type: application/json" \
...
```
When going live, you need to generate new web service user credentials to access the [live endpoints](https://docs.adyen.com/development-resources/live-endpoints).

## Versioning
The Hosted onboarding API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://cal-test.adyen.com/cal/services/Hop/v6/getOnboardingUrl
```, The A2A payments API provides endpoints for A2A payment flows, enabling issuers to facilitate direct payments through Adyen for users with an Adyen business account.

With these endpoints, you can:
- **Retrieve payment details**: Retrieve transaction information for specific payments.
- **Confirm payments**: Confirm payments with Strong Customer Authentication (SCA).
- **Cancel payments**: Cancel pending transactions.

## Authentication
Each request made to the A2A Payments API must be signed with an API key. Generate an API key in your Customer Area.

To connect to the API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

## Roles and permissions
To use the A2A Payments API, your API credential must have the following roles:
- **Role for A2A Issuer payments - API**

Reach out to your Adyen contact to set up these roles.
## Going live
When going live, generate an API key in your [live Customer Area](https://ca-live.adyen.com/ca). You can then use the API key to send requests to `https://balanceplatform-api-live.adyen.com/a2aissuer-api/v{version}/payments`., The Open Banking API provides secure endpoints to share financial data and services with third parties. This API offers quick and reliable user verification.

With these endpoints, you can:

- **Create a list of available account verification routes**: Create a list of Account Information Service Providers (AISPs) for third-party individual account verification. Successful connections generate a unique code used for requesting bank reports and verifying identity.
- **Verify bank account ownership**: Get the account verification report using the unique code from a successful open banking connection. This report provides identity verification and bank account details.
## Authentication
Each request made to the Open Banking API must be signed with an API key. Generate an API key in your Customer Area.

To connect to the API, add an X-API-Keyheader with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" 
-H "X-API-Key: YOUR_API_KEY" 
...
```

## Roles and permissions
To use the Open Banking API, your API credential must have the following roles:
- **Role for OpenBanking account verification use case: EXTERNAL**

Reach out to your Adyen contact to set up these roles., You can use the [Disputes API](https://docs.adyen.com/risk-management/disputes-api) to automate the dispute handling process so that you can respond to disputes and chargebacks as soon as they are initiated. The Disputes API lets you retrieve defense reasons, supply and delete defense documents, and accept or defend disputes.

## Authentication
Each request to the Disputes API must be signed with an API key. For this, obtain an API Key from your Customer Area, as described in [How to get the API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key). Then set this key to the `X-API-Key` header value, for example:

```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: Your_API_key" \
...
```
Note that when going live, you need to generate new web service user credentials to access the [live endpoints](https://docs.adyen.com/development-resources/live-endpoints).

## Versioning
Disputes API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://ca-test.adyen.com/ca/services/DisputeService/v30/defendDispute
```, Disputes API for Issuing that you can use to raise disputes on transactions made with an Adyen-issued card, or to report instances of fraud. You can also add attachments as supporting information for a raised dispute, update information about the dispute, submit the dispute for a chargeback, or close the dispute.

## Authentication
Your Adyen contact will provide your API credential and an API key. To connect to the API, add an `X-API-Key` header with the API key as the value, for example:

 ```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

Alternatively, you can use the username and password to connect to the API using basic authentication. For example:

```
curl
-H "Content-Type: application/json" \
-U "ws@BalancePlatform.YOUR_BALANCE_PLATFORM":"YOUR_WS_PASSWORD" \
...
```
## Roles and permissions
To use the Disputes API, you need an additional role for your API credential. Your Adyen contact will set up the roles and permissions for you.
## Versioning
The Disputes API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://balanceplatform-api-test.adyen.com/btl/api/v{version}/disputes
```
## Going live
When going live, your Adyen contact will provide your API credential for the live environment. You can then use the username and password to send requests to `https://balanceplatform-api-live.adyen.com/btl/api/v{version}`., The Adyen [Terminal API](https://docs.adyen.com/point-of-sale/design-your-integration/terminal-api/) lets you make payments, issue refunds, collect shopper information, and perform other shopper-device interactions using a payment terminal supplied by Adyen. The Terminal API is also used for transactions in [Adyen Mobile solutions](https://docs.adyen.com/point-of-sale/ipp-mobile/).

## API structure
The architecture of Terminal API is determined by the [nexo Sale to POI Protocol Specifications](https://www.nexo-standards.org/standards/nexo-retailer-protocol).

A Terminal API request is a JSON message consisting of a `SaleToPOIRequest` object with:
- [`MessageHeader`](https://docs.adyen.com/point-of-sale/design-your-integration/terminal-api/#request-message-header): identifies the type of transaction, the terminal or Mobile SDK instance being used, and unique transaction identifiers.
- **Request body**: content depending on the type of transaction or operation, for example, a `PaymentRequest`.

A Terminal API response is a JSON message consisting of a `SaletoPOIResponse`with:
* [`MessageHeader`](https://docs.adyen.com/point-of-sale/design-your-integration/terminal-api/#response-message-header): echoes the values provided in the request, except for `MessageType`, which is always **Response**.
* Response body: content depending on the type of transaction or operation, for example, a `PaymentResponse`.

## Sending and receiving
In an integration with Ayden payment terminals, you can send and receive Terminal API messages in the following ways:
- [Local communications](https://docs.adyen.com/point-of-sale/design-your-integration/choose-your-architecture/local/): using your local network, your POS system sends the request directly to the IP address of the terminal, and receives the result synchronously.
- [Cloud communications](https://docs.adyen.com/point-of-sale/design-your-integration/choose-your-architecture/cloud/): using the internet to access the cloud, your POS system sends the request to an Adyen endpoint, and Adyen forwards the request to the terminal. Your POS system either keeps the connection open and receives the response synchronously, or closes the connection and receives the response asynchronously in an event notification.

## Using local communications
To learn how to set up and protect local communications, refer to [Building a local integration](https://docs.adyen.com/point-of-sale/design-your-integration/choose-your-architecture/local/).

## Endpoints for cloud communications
If your POS system is cloud-based, you POST your Terminal API requests to a **Cloud device API** endpoint, using path and query parameters to identify the device that you want to send the request to.
- If your POS system is designed to keep the connection open to wait for the response, use the endpoints ending in `/sync`.
- If your POS system is designed to close the connection so that it can initiate a new request, use the endpoints ending in `/async`.

### Test endpoints
- `https://device-api-test.adyen.com/v1/merchants/{merchantAccount}/devices/{deviceId}/sync`
- `https://device-api-test.adyen.com/v1/merchants/{merchantAccount}/devices/{deviceId}/async`

### Live endpoints
The live endpoints differ per region. In addition to using a regional endpoint, you must select the geographically closest data center in your live Customer Area.

**Australia**
- `https://device-api-live-au.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/sync`
- `https://device-api-live-au.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/async`

**East Asia**
- `https://device-api-live-apse.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/sync`
- `https://device-api-live-apse.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/async`

**Europe**
- `https://device-api-live.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/sync`
- `https://device-api-live.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/async`

**United States**
- `https://device-api-live-us.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/sync`
- `https://device-api-live-us.adyen.com/v1/merchants/{merchantId}/devices/{deviceId}/async`

 ### Old endpoints
If you currently use endpoints with a base URL that includes `terminal-api`, we strongly recommend migrating to Cloud device API endpoints, for the following reasons:
- When using Cloud device API, the API logs in the Customer Area include the Terminal API requests and responses.
- Cloud device API endpoints offer technical advantages such as versioning and better routing.
- Future enhancements and features will be based on Cloud device API.

There will be no future development on the old endpoints, but we continue to support them.

**Old test endpoints**:
- `https://terminal-api-test.adyen.com/sync` and `https://terminal-api-test.adyen.com/async`

**Old live endpoints Australia**:
- `https://terminal-api-live-au.adyen.com/sync` and `https://terminal-api-live-au.adyen.com/async`

**Old live endpoints East Asia**:
- `https://terminal-api-live-apse.adyen.com/sync` and `https://terminal-api-live-apse.adyen.com/async`

**Old live endpoints Europe**:
- `https://terminal-api-live.adyen.com/sync` and `https://terminal-api-live.adyen.com/async`

**Old live endpoints United States**:
- `https://terminal-api-live-us.adyen.com/sync` and `https://terminal-api-live-us.adyen.com/async`

## Authentication for cloud communications
Each request to a **Cloud device API** endpoint must be signed with an API key that has the **Cloud Device API role**. [Generate your API Key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key) in the Customer Area and set this key to the `X-API-Key` header value of the Cloud device API request.

When going live, generate a new API key in the live Customer Area.

## Available Terminal API requests, The SoftPOS configuration API is used in the mutual authentication flow between an Adyen Android or iOS [Mobile SDK](https://docs.adyen.com/point-of-sale/ipp-mobile/) and the Adyen payments platform.
The Mobile SDK for Android or iOS devices enables businesses to accept in-person payments using a commercial off-the-shelf (COTS) device like a phone. 
For example, Tap to Pay transactions, or transactions on a mobile device in combination with a card reader.

## Authentication
Each request to the POS Mobile API must be signed with an API key. [Generate your API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key) in the Customer Area and then set this key to the `X-API-Key` header value.
You also need to have a [client key](https://docs.adyen.com/development-resources/client-side-authentication/). The client key is part of the setup but you will not need to use it in your integration later. Therefore, when you set up the client key, you do not need to specify allowed origins, and you do not need to store the key in your system. 
To access the live endpoints, you need to generate a new API key and client key in your live Customer Area.
## Versioning

The POS Mobile API handles versioning as part of the endpoint URL.

For example:
```
https://softposconfig-test.adyen.com/softposconfig/v{version}/auth/certificate
```

## Going live
To access the live endpoints, you need an API key and client key from your live Customer Area, and switch to the live endpoint that is geographically closest to your location.
### Australia:
https://softposconfig-live-au.adyen.com/softposconfig/v{version}/auth/certificate
### Asia Pacific South East:
https://softposconfig-live-apse.adyen.com/softposconfig/v{version}/auth/certificate
### Europe:
https://softposconfig-live.adyen.com/softposconfig/v{version}/auth/certificate
### North East Asia:
https://softposconfig-live-nea.adyen.com/softposconfig/v{version}/auth/certificate
### United States:
https://softposconfig-live-us.adyen.com/softposconfig/v3/auth/certificate
## Methods, Board and manage the Adyen Payments App on your Android mobile devices.
## Authentication
Each request to the Payments App API must be signed with an API key. [Generate your API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key) in the Customer Area and then set this key to the `X-API-Key` header value.

## Versioning

Payments App API handles versioning as part of the endpoint URL. For example, to send a request to this version of the `/merchants/{merchantId}/generatePaymentsAppBoardingToken` endpoint, use:

```text
https://management-test.adyen.com/v1/merchants/{merchantId}/generatePaymentsAppBoardingToken
```

## Going live

To access the live endpoints, you need an API key from your live Customer Area. Use this API key to make requests to:

```text
https://management-live.adyen.com/v{version}
```, >This API is deprecated. Use the [SoftPOS configuration API](https://docs.adyen.com/api-explorer/softpos-configuration-api/latest/overview) instead.

The POS Mobile API is used in the mutual authentication flow between an Adyen Android or iOS [POS Mobile SDK](https://docs.adyen.com/point-of-sale/ipp-mobile/) and the Adyen payments platform.
The POS Mobile SDK for Android or iOS devices enables businesses to accept in-person payments using a commercial off-the-shelf (COTS) device like a phone. For example, Tap to Pay transactions, or transactions on a mobile device in combination with a card reader.

## Authentication
Each request to the POS Mobile API must be signed with an API key. [Generate your API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key) in the Customer Area and then set this key to the `X-API-Key` header value.
You also need to have a [client key](https://docs.adyen.com/development-resources/client-side-authentication/). The client key is part of the setup but you won't need to use it in your integration later. Therefore, you don't need to specify allowed origins, and you don't need to store the key in your system. 
To access the live endpoints, you need to generate a new API key and client key in your live Customer Area.
## Versioning

The POS Mobile API handles versioning as part of the endpoint URL.

For example:
```
https://checkout-test.adyen.com/checkout/possdk/v68/sessions
```

## Going live

To access the live endpoints, you need an API key and client key from your live Customer Area.

The live endpoint URLs contain a prefix which is unique to your company account, for example:
```
https://{PREFIX}-checkout-live.adyenpayments.com/checkout/possdk/v68/sessions
```, This API provides endpoints for managing your point-of-sale (POS) payment terminals. You can use the API to obtain information about a specific terminal, retrieve overviews of your terminals and stores, and assign terminals to a merchant account or store.

For more information, refer to [Classic assign terminals](https://docs.adyen.com/point-of-sale/automating-terminal-management/assign-terminals-api/classic-assign-terminals-api/).

>From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our [Management API](https://docs.adyen.com/api-explorer/Management/latest/overview).

## Authentication
Each request to the Terminal Management API must be signed with an API key. For this, obtain an API Key from your Customer Area, as described in [How to get the API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key). Then set this key to the `X-API-Key` header value, for example:

```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: Your_API_key" \
...
```
Note that when going live, you need to generate new web service user credentials to access the [live endpoints](https://docs.adyen.com/development-resources/live-endpoints).

## Roles and permissions
To use the POS Terminal Management API, you need the **POS Terminal Management API role** added to your API credential. Your Adyen contact will set up the roles for you.
## Versioning
Terminal Management API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:
```
https://postfmapi-test.adyen.com/postfmapi/terminal/v1/getTerminalsUnderAccount
```
When using versioned endpoints, Boolean response values are returned in string format: `"true"` or `"false"`.
If you omit the version from the endpoint URL, Boolean response values are returned like this: `true` or `false`.
## Going live
To access the live endpoints, you need an API key from your live Customer Area.
Use this API key to make requests to:

```text
https://postfmapi-live.adyen.com/postfmapi/terminal/v1
```

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/Adyen.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [AdyenClientOptions](AdyenClientOptions.cs).

```csharp
services.AddAdyenClient(options =>
    {
        options.BasicAuth =
            new BasicAuthCredentials
            {
                Username = "YOUR_USERNAME",
                Password = "YOUR_PASSWORD",
            };
        options.ApiKeyAuth = "YOUR_API_KEY";
        options.ClientKey = "YOUR_API_KEY";
        options.Environment = ServerEnvironment.Test;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [AdyenClientOptions](AdyenClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new AdyenClientOptions
    {
        BasicAuth = new BasicAuthCredentials
        {
            Username = "YOUR_USERNAME",
            Password = "YOUR_PASSWORD",
        },
        ApiKeyAuth = "YOUR_API_KEY",
        ClientKey = "YOUR_API_KEY",
        Environment = ServerEnvironment.Test,
    };
var client = new AdyenClient(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## SDK map

This SDK ships a generated **SDK map** — [`sdk-map.md`](sdk-map.md) plus the [`map/`](map/) pages — a deterministic, lookup-oriented table of contents of the SDK's C# surface, generated by APIMatic alongside this SDK.

**Read it before scanning the source.** Whether you are an AI coding assistant or searching by hand, the map answers "what is the exact …" by lookup for every call-level contract, and for anything it does not carry it names the one file that does — so you never have to search the source tree:

- **[`sdk-map.md`](sdk-map.md)** — the index: client construction, servers/auth, the options/retry reference, the SDK-wide defaults the operation rows rely on, and link tables into [`map/`](map/).
- **[`map/operations/`](map/operations/)** — one page per controller: the exact C# signature, the return type, the error type with its typed `TryGet…` accessors, and pagination — plus, per operation, a **Type sources** table naming the file that declares every type that operation mentions.

Model shapes — record fields with their JSON wire names, enum member names and wire values, `OneOf`/`AnyOf` union variants — are **not** duplicated in the map. Take the path from the operation's Type sources table and read the declaring file; it is the single source of truth and cannot go stale against the code.

**Each operation row states what is specific to that operation.** The SDK-wide defaults are stated once in [`sdk-map.md`](sdk-map.md) — throw-only (no `Result`-style no-throw variants), no pagination, the four fixed `RawError` accessors, the `Default` server group — and a row appears only where its operation departs from one. A row silent on pagination is telling you that operation has none.

The **HTTP verb and route**, and the endpoint's **behavioural prose**, live on the operation itself, in the source file named at the top of its operations page. Read them there when something needs them — wiring a mock, reading a provider log, or settling a rule about what you must pass.

**Workflow:** look the fact up in the map → where the map leaves something ambiguous, open the **one** source file the row names → the compiler is the backstop (a name that isn't in the map won't build). Don't scan or grep the tree to find things — the map is the locator.

### Which one to reach for

The map and the [API Reference](api-reference.md) answer different questions, and the map is generated from this SDK's source so it stays in lockstep with the code it describes.

| Use | For |
| --- | --- |
| **[`sdk-map.md`](sdk-map.md) + [`map/`](map/)** | Traversing the SDK and working out its surface — locating the operation you need (this SDK exposes **449 operations**), its exact signature and parameter order, the shape and JSON wire names of the models it takes and returns, which error type it throws and how to read it, and the source file behind any of it. This is the index to consume the SDK from, and the one to reach for first. |
| **[`api-reference.md`](api-reference.md)** | Usage guidance for a single operation once you know which one you want — a runnable code sample, per-parameter descriptions, and the error responses it can return. |

## Best Practices

> [!TIP]
> Use a **single `AdyenClient` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
