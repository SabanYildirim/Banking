# About The Project

**Online Banking API**

| End-Pointler | Explanation |
| ------ | ------ |
| HttpGet api/customer | New Customer Endpoint |
| HttpPost api/Account | New Account Endpoint. |
| HttpGet api/Account/{id} | View the account details |
| HttpGet api/transcation/{accountId} | List transactions of an account |
| HttpGet api/transcation/{startDate}/{endDate} |  View all transactions of the customer between a time period |
| HttpPut api/withdraw |  New Account Transaction Endpoint for adding and withdrawing money. This action needs to updatethe balance of the account. |

## Tech

- .NET CORE
- MSSQL SERVER
- DOCKER
- SWAGGER
- FluenValidation
- Xunit

## Docker



```sh
cd banking
docker-compose buil.
docker-compose up
```

Server Address

```sh
https://localhost:8081/swagger
```

## Database

![N|Solid](https://i.ibb.co/3fMGRVD/bankingschema.png)


```sh
Package Manager Console
Defult Project: src/Banking.Api
PM> update-database
```




