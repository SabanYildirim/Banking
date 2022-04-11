# About The Project

**Online Banking API**

| End-Pointler | Özellikler |
| ------ | ------ |
| api/customer | New Customer Endpoint |
| api/Account | New Account Endpoint. |
| api/Account/{id} | View the account details |
| api/transcation/{accountId} | List transactions of an account |
| api/transcation/{startDate}/{endDate} |  View all transactions of the customer between a time period |
| api/withdraw |  New Account Transaction Endpoint for adding and withdrawing money. This action needs to updatethe balance of the account. |

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




