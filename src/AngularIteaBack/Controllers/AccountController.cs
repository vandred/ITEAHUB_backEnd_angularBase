using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularIteaBack.Models;
using AngularIteaBack.Services;
using Microsoft.AspNetCore.Mvc;

namespace AngularIteaBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IDataService _dataService;

        public AccountController(IDataService dataService)
        {
            _dataService = dataService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var rzltUsers = _dataService.GetAllUsers().ToList();
            return rzltUsers;
        }

        [HttpPost]
        public ActionResult<User> LogIn([FromBody] string userName, string password)
        {

            if (userName=="admin")
            {
                return new User();
            }
            else {
                throw new Exception("!!!! No such User");
            }
            
        }
    }
}