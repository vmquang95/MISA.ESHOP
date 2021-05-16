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
    public class CountryController : BaseEntityController<Country>
    {
        private ICountryService _countryService;
        public CountryController(ICountryService countryService) : base(countryService)
        {
            _countryService = countryService;
        }
    }

}
