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
    public class ProvinceController : BaseEntityController<Province>
    {
        private IProvinceService _provinceService;
        public ProvinceController(IProvinceService provinceService) : base(provinceService)
        {
            _provinceService = provinceService;
        }

        [HttpGet("WithCountry/{countryId}")]
        public IActionResult Get(Guid? countryId)
        {
            var responseResult = _provinceService.GetProvinceWithCountry(countryId);

            return Ok(responseResult);
        }
    }

}
