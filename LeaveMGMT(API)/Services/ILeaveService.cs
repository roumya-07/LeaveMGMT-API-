using LeaveMGMT_API_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveMGMT_API_.Services
{
    public interface ILeaveService
    {
        public Task<List<LeaveEntity>> EmpDetailsByEmpCode(int EmpCode);
        public Task<int> InsertLeave(LeaveEntity LE);
        public Task<List<LeaveEntity>> GetEmployeeCode();
    }
}
