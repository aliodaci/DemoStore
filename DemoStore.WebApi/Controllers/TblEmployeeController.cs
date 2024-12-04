using DemoStore.WebApi;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoStore.WebApi
{
    [ApiController]
    [EntityValidation]
    [Route("api/[controller]/[action]")]
    public class TblEmployeeController : ControllerBase
    {
        private readonly ITblEmployeeService _service;

        public TblEmployeeController(ITblEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<TblEmployee?> GetAsync([FromQuery] int employeeId)
        {
            return _service.GetAsync(employeeId, HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<IEnumerable<TblEmployee>> GetListAsync()
        {
            return _service.GetListAsync(HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<PagedResult<TblEmployee>> GetPageAsync([FromQuery] PageParameter page)
        {
            return _service.GetPageAsync(page, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddAsync([FromBody] TblEmployee tblEmployee)
        {
            return _service.AddAsync(tblEmployee, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddRangeAsync([FromBody] IEnumerable<TblEmployee> tblEmployees)
        {
            return _service.AddRangeAsync(tblEmployees, HttpContext.RequestAborted);
        }

        [HttpPut]
        public Task<bool> UpdateAsync([FromBody] TblEmployee tblEmployee)
        {
            return _service.UpdateAsync(tblEmployee, HttpContext.RequestAborted);
        }

        [HttpDelete]
        public Task<bool> DeleteAsync([FromQuery] int employeeId)
        {
            return _service.DeleteAsync(employeeId, HttpContext.RequestAborted);
        }
    }
}
