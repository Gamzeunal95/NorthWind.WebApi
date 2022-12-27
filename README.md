# NorthWind.WebApi
- ASP.NET Core Web API solution açıldı.
- Http Durum kodlarıda bu kısımda önemli test ederken ilmek önem sağlar.

# Project 1 - NorthWind.WebApi
- Aşağıdaki paketler indirildi.
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Design
- Northwind Database'ini kullanacağımız için scaffold yaparak northwind'in Entitieslerini aldık. 
`dotnet ef dbcontext scaffold "Server(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True" Microsoft.EntityFrameWorkCore.SqlServer -o Entities`
- Test etmek için [Postman](https://www.postman.com/downloads/) kullanabiliriz. 
- appsettings.json ve program.cs içinde connection string tanımlanması gerekli. 
