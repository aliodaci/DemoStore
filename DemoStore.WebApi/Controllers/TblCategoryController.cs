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
    public class TblCategoryController : ControllerBase
    {
        private readonly ITblCategoryService _service;

        public TblCategoryController(ITblCategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<TblCategory?> GetAsync([FromQuery] int categoryId)
        {
            return _service.GetAsync(categoryId, HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<IEnumerable<TblCategory>> GetListAsync()
        {
            return _service.GetListAsync(HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<PagedResult<TblCategory>> GetPageAsync([FromQuery] PageParameter page)
        {
            return _service.GetPageAsync(page, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddAsync([FromBody] TblCategory tblCategory)
        {
            return _service.AddAsync(tblCategory, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddRangeAsync([FromBody] IEnumerable<TblCategory> tblCategories)
        {
            return _service.AddRangeAsync(tblCategories, HttpContext.RequestAborted);
        }

        [HttpPut]
        public Task<bool> UpdateAsync([FromBody] TblCategory tblCategory)
        {
            return _service.UpdateAsync(tblCategory, HttpContext.RequestAborted);
        }

        [HttpDelete]
        public Task<bool> DeleteAsync([FromQuery] int categoryId)
        {
            return _service.DeleteAsync(categoryId, HttpContext.RequestAborted);
        }
    }
}
