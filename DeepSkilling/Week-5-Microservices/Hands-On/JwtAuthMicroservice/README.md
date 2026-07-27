# JWT Authentication Microservice

## Objective

Implement Authentication and Authorization in ASP.NET Core Web API using JWT Tokens.

This project is based on the Cognizant Digital Nurture DeepSkilling Microservices Hands-on.

---

## Technologies

- ASP.NET Core 8 Web API
- JWT Bearer Authentication
- Swagger
- C#

---

## NuGet Packages

- Microsoft.AspNetCore.Authentication.JwtBearer
- Swashbuckle.AspNetCore

---

## Features

- JWT Login Authentication
- Protected API using JWT
- Role-Based Authorization
- JWT Expiry Handling
- Swagger Integration

---

## API Endpoints

### Login

POST

```
/api/Auth/login
```

### Protected Endpoint

GET

```
/api/Secure/data
```

### Admin Endpoint

GET

```
/api/Admin/dashboard
```

---

## Test Credentials

Username

```
admin
```

Password

```
password123
```

---

## Testing

- JWT generated successfully
- Unauthorized request returns 401
- Authorized request returns 200
- Admin endpoint secured using role-based authorization
- Expired JWT returns `Token-Expired: true`

---

## Build

```
dotnet build
```

Build Status

```
Build succeeded.
0 Warning(s)
0 Error(s)
```

---

## Folder Structure

```
JwtAuthMicroservice
│
├── Controllers
├── Models
├── Evidence
├── Program.cs
├── appsettings.json
└── README.md
```
