using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using los_api.Model;

namespace los_api.Controllers
{
    [ApiController]
    [Route("[controller]")]


    public class GetStockController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<List<ListStock>> Get(int id)
        {
            List<ListStock> listStocks = new List<ListStock>();
            return listStocks;
        }

        [HttpPost]
        public ActionResult<string> Post(Product product)
        {
            return "Issert Complete";
        }
    }
}
