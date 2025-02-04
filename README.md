# EntityFrameworkQueries

## Getting Started
- Visual Studio
- .NET
- [AP database](create_ap.sql) installed

You may need to change the DB connection string located in the APContext class
By default it points to msssqllocaldb.
If your AP script is not installed on mssqllocaldb, update the string
```csharp
optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AP");
```
### Useful Website
[MS Docs - Scaffolding (Reverse Engineering)](https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=vs)
