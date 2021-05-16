using Microsoft.AspNetCore.Mvc;
using MISA.EShop.Core.Interfaces;
using MISA.EShop.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.EShop.WebAPI.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class BaseEntityController<T> : ControllerBase
    {
        private IBaseService<T> _baseService;

        public BaseEntityController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }

        // GET: api/<BaseController>
        [HttpGet]
        public IActionResult Get()
        {
            var responseResult = _baseService.GetEntities();
            return Ok(responseResult);
        }


        // GET api/<BaseController>/5
        [HttpGet("{entityId}")]
        public IActionResult Get(Guid entityId)
        {
            var responseResult = _baseService.GetById(entityId);
            return Ok(responseResult);
        }

        // POST api/<BaseController>
        [HttpPost]
        public IActionResult Post([FromBody] T entity)
        {
      
            var responseResult = _baseService.Insert(entity);
            return Created(ResourceMessage.Insert_Success,responseResult);
        }

        // PUT api/<BaseController>/5
        [HttpPut("{entityId}")]
        public IActionResult Put(Guid entityId, [FromBody] T entity)
        {
            var responseResult = _baseService.Update(entity, entityId);
            return Ok(responseResult);
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{entityId}")]
        public IActionResult Delete(Guid entityId)
        {
            var responseResult = _baseService.Delete(entityId);
            return Ok(responseResult);
        }
    }

}
