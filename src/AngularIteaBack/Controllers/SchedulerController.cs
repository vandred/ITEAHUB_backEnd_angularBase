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
    public class SchedulerController : ControllerBase
    {
        private IDataService _dataService;

        public SchedulerController(IDataService dataService)
        {
            _dataService = dataService;
        }


        [HttpGet("GetAllGroups")]
        public ActionResult<IEnumerable<string>> GetAllGroups()
        {
            _dataService.AllGetSchedule();
            return _dataService.AllGetSchedule();
        }

        [HttpGet("GetGroup")]
        public ActionResult<CalendarForGroup> GetGroup(string inputstr)
        {
            try
            {
                var sheduler = _dataService.GetSchedule(inputstr);
                return sheduler;
            }
            catch (Exception)
            {

                return new CalendarForGroup(); ;
            }
            
        }

        [HttpPost("AddNewGroup")]
        public ActionResult<CalendarForGroup> CreateGroups(CalendarForGroup input)
        {
            try
            {
                var nGroup = _dataService.CreateUpdateSchedule(input);
                return nGroup;

            }
            catch (Exception ex)
            {

                return new CalendarForGroup(); 
            }
         
        }

        [HttpDelete("deleteGroup")]
        public ActionResult<bool> DeleteGroups(string input)
        {
            try
            {
                var nGroup = _dataService.DeleteSchedule(input);
                return nGroup;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
        [HttpPost("UpdateGroup")]
        public ActionResult<CalendarForGroup> UpdateGroups(CalendarForGroup input)
        {
            try
            {
                var nGroup = _dataService.CreateUpdateSchedule(input);
                return nGroup;

            }
            catch (Exception ex)
            {

                return new CalendarForGroup();
            }
        }
    }
}