using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularIteaBack.Services;
using Microsoft.AspNetCore.Mvc;

namespace AngularIteaBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookShopController : ControllerBase
    {
        private IDataService _dataService;

        public BookShopController(IDataService dataService)
        {
            _dataService = dataService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2", "value3", "value4", "value5", "value6" };
        }
    }
}