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
    public class DistrictController : BaseEntityController<District>
    {
        private IDistrictService _districtService;
        public DistrictController(IDistrictService districtService) : base(districtService)
        {
            _districtService = districtService;
        }

        [HttpGet("WithProvince/{provinceId}")]
        public IActionResult Get(Guid? provinceId)
        {
            var responseResult = _districtService.GetDistrictWithProvince(provinceId);

            return Ok(responseResult);
        }
    }
}
