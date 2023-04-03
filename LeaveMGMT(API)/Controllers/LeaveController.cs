using LeaveMGMT_API_.Models;
using LeaveMGMT_API_.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveMGMT_API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveController : ControllerBase
    {
        private readonly ILeaveService _leaveService;
        public LeaveController(ILeaveService leaveService)
        {
            _leaveService = leaveService;
        }
        [HttpGet]
        public async Task<List<LeaveEntity>> GetEmployeeCode()
        {
            return await _leaveService.GetEmployeeCode();
        }

        [HttpGet("{EmpCode}")]
        public async Task<List<LeaveEntity>> EmpDetailsByEmpCode(int EmpCode)
        {
            return await _leaveService.EmpDetailsByEmpCode(EmpCode);
        }

        [HttpPut]
        public async Task<int> InsertOrUpdate(LeaveEntity CE)
        {
            return await _leaveService.InsertLeave(CE);
        }

    }
}
