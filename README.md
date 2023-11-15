# ASPNETCoreMVCSQLite
/*Steps for setting up ASP.NET Core Web App (Model-View-Controller) for SQLite*/

1. Create a new project selecting ASP.Net Web App (Model-View-Controller) as the type of application.
This has been followed with individual accounts settings for Authentication.
2. Create a new class in Models and then add scaffolded item to project (MVC Controller with views, using EF).
3. Install NuGet for SQLite (Manage NuGet Packages).
4. Replace UsqSqlServer with UseSqlite in Program.cs.
5. Replace value in ConnectionsStrings.DefaultConnection with "Data Source = REPLACEWITHDATABASENAME.db".
6. Remove existing migrations (Remove-Migration in Package Manager Consolethis) This step avoids getting the error sqlite error 1 'near max syntax error' - due to nvarchar(max) included for existing migrations for SQLServer database).
7. Add a migration called Initial (Add-Migration REPLACEWITHMIGRATIONNAME in Package Manager Console).
8. Update the database (Update-Database in Package Manager Console).
