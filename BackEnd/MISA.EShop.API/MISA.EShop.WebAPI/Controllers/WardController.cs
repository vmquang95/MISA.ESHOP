using Microsoft.AspNetCore.Mvc;
using MISA.EShop.Core.Entities;
using MISA.EShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.EShop.WebAPI.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class WardController : BaseEntityController<Ward>
    {
        private IWardService _wardService;
        public WardController(IWardService wardService) : base(wardService)
        {
            _wardService = wardService;
        }

        [HttpGet("WithDistrict/{districtId}")]
        public IActionResult Get(Guid? districtId)
        {
            var responseResult = _wardService.GetWardWithDistrict(districtId);

            return Ok(responseResult);
        }
    }
}
