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
        [HttpGet("GetUser")]
        public ActionResult<IEnumerable<User>> Get()
        {
            var rzltUsers = _dataService.GetAllUsers().ToList();

            return rzltUsers;
        }

        [HttpPost("LogIn")]
        public ActionResult<User> LogIn([FromBody] LogIn logInInput)
        {
            var rzltUsers = _dataService.GetAllUsers().ToList().Where(x=>x.LoginName== logInInput.UserName && x.Password == logInInput.Password).FirstOrDefault();

            if (rzltUsers!= null)
            {
                return rzltUsers;
            }
            else {
                return null;
            }
            
        }

        [HttpPost("AddUser")]
        public ActionResult<IEnumerable<User>> AddUser([FromBody] User input)
        {
            Random rnd = new Random();
            input.Id= rnd.Next(9, 93);
            var outUser = _dataService.AddUser(input);
            var rzltUsers = _dataService.GetAllUsers().ToList();
            return rzltUsers;
        }
    }
}