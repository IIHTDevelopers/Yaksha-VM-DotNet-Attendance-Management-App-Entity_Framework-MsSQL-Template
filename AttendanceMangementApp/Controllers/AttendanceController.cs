using AttendanceManagement.Models;
using AttendanceManagementApp.DAL.Interrfaces;
using AttendanceManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AttendanceManagementApp.Controllers
{
    public class AttendanceController : ApiController
    {
        private readonly IAttendanceService _service;
        public AttendanceController(IAttendanceService service)
        {
            _service = service;
        }
        public AttendanceController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Attendance/CreateAttendance")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateAttendance([FromBody] Attendance model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Attendance/UpdateAttendance")]
        public async Task<IHttpActionResult> UpdateAttendance([FromBody] Attendance model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Attendance/DeleteAttendance")]
        public async Task<IHttpActionResult> DeleteAttendance(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Attendance/GetAttendanceById")]
        public async Task<IHttpActionResult> GetAttendanceById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Attendance/GetAllAttendances")]
        public async Task<IEnumerable<Attendance>> GetAllAttendances()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
