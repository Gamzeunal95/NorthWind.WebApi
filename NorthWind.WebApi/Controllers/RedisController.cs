using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Northwind.WebApi.Models;
using NorthWind.WebApi.Entities;
using StackExchange.Redis;
using System.Text;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisController : ControllerBase
    {
        private readonly RedisManager redisManager;
        private readonly NorthwindContext context;

        public RedisController(RedisManager redisManager, NorthwindContext context)
        {
            this.redisManager = redisManager;
            this.context = context;
            redisManager.Connect();
        }
        [HttpGet]
        public IActionResult GetShippers()
        {
            List<Shipper> shippers = new List<Shipper>();
            IDatabase database = redisManager.GetDb(0);
            if (!database.KeyExists("Shippers"))
            {
                shippers = context.Shippers.ToList();
                var data = JsonConvert.SerializeObject(shippers);
                var databyte = Encoding.UTF8.GetBytes(data.ToString());
                database.StringSet("Shippers", databyte);
            }
            var databyte1 = database.StringGet("Shippers");
            var datastring = Encoding.UTF8.GetString(databyte1);
            shippers = JsonConvert.DeserializeObject<List<Shipper>>(datastring);
            if (shippers != null)
            {
                return Ok(shippers);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
