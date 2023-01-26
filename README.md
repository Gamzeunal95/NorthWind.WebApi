# NorthWind.WebApi
- ASP.NET Core Web API solution açıldı.
- Http Durum kodlarıda bu kısımda önemli, test ederken bilmek önem sağlar.

# Project 1 - NorthWind.WebApi
- Aşağıdaki paketler indirildi.
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Design
  - Newtonsoft.Json
  - StackExchange.Redis
- Northwind Database'i kullanılacağı için scaffold yaparak northwind'in Entitiesleri alındı.
`dotnet ef dbcontext scaffold "Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True" Microsoft.EntityFrameWorkCore.SqlServer -o Entities`
- Test etmek için [Postman](https://www.postman.com/downloads/) kullanabiliriz. 
- appsettings.json ve program.cs içinde connection string tanımlanması gerekli. Tanımlandıç 
- **ModelsFOlder**
- Redis
#### Controller Açarken 
- Controller Sağ Click -> Add -> Controller -> (Açılan Sayfada) -> API -> (o kısımda) -> API Controller with actions, using Entity FrameWork -> Seçimleri yap. 

- [Northwind Vercel](https://northwind.vercel.app/)
- [JsonToC# Convert](https://json2csharp.com/)
- [JWT.io](https://jwt.io/)

# Project 2 - NorthwindConsole.TestApi
- Console Projesi
- Bu kısımda client API olarak çalışıldı.
- Newtonsoft.Json paketi kullanıldı.
- Redis 
