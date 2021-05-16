using MISA.EShop.Core.Entities;
using MISA.EShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Services
{
    public class CountryService : BaseService<Country>, ICountryService
    {
        public CountryService(IBaseRepository<Country> baseRepository) : base(baseRepository)
        {
            //_unitOfWork = unitOfWork;
        }
    }
}
