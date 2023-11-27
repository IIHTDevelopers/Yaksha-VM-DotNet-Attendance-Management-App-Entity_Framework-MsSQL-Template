using AttendanceManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AttendanceManagementApp.DAL.Services.Repository
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly DatabaseContext _dbContext;
        public AttendanceRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Attendance> CreateAttendance(Attendance expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAttendanceById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Attendance> GetAllAttendances()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Attendance> GetAttendanceById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        } 
        

        public async Task<Attendance> UpdateAttendance(Attendance model)
        {
            //write your code here
            throw new NotImplementedException();

        }
    }
}