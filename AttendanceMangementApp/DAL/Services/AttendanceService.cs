using AttendanceManagementApp.DAL.Interrfaces;
using AttendanceManagementApp.DAL.Services.Repository;
using AttendanceManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AttendanceManagementApp.DAL.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _repository;

        public AttendanceService(IAttendanceRepository repository)
        {
            _repository = repository;
        }

        public Task<Attendance> CreateAttendance(Attendance expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAttendanceById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Attendance> GetAllAttendances()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Attendance> GetAttendanceById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Attendance> UpdateAttendance(Attendance model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}