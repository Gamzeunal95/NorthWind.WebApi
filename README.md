# NorthWind.WebApi
- ASP.NET Core Web API projesi açıldı.

# Project 1 - NorthWind.WebApi
- Aşağıdaki paketler indirildi.
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Design
- Northwind Database'ini kullanacağımız için scaffold yaparak northwind'in Entitieslerini aldık. 
`dotnet ef dbcontext scaffold "Server(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True" Microsoft.EntityFrameWorkCore.SqlServer -o Entities`

