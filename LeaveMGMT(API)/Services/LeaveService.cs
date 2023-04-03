using LeaveMGMT_API_.Models;
using LeaveMGMT_API_.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveMGMT_API_.Services
{
    public class LeaveServices : ILeaveService
    {
        private readonly ILeaveRepository _leaveRepository;
        public LeaveServices(ILeaveRepository leaveRepository)
        {
            _leaveRepository = leaveRepository;
        }
        public async Task<List<LeaveEntity>> EmpDetailsByEmpCode(int EmpCode)
        {
            return await _leaveRepository.EmpDetailsByEmpCode(EmpCode);
        }

        public async Task<List<LeaveEntity>> GetEmployeeCode()
        {
            return await _leaveRepository.GetEmployeeCode();
        }

        public async Task<int> InsertLeave(LeaveEntity LE)
        {
            return await _leaveRepository.InsertLeave(LE);
        }
    }
}
