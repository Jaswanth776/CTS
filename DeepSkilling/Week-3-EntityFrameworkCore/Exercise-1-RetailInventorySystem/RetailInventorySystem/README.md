## Database Configuration

This project uses SQL Server with Entity Framework Core.

Before running the application, update the SQL Server connection string in `ApplicationDbContext.cs` with your local SQL Server credentials.

Example:

Server=localhost,1433;
Database=RetailInventoryDB;
User Id=sa;
Password=<YOUR_SQL_SERVER_PASSWORD>;
TrustServerCertificate=True;
