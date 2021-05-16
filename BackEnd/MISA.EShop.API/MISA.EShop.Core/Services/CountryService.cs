using MISA.EShop.Core.Entities;
using MISA.EShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Services
{
    /// <summary>
    /// Các nghiệp vụ  của Country.
    /// Kế thừa từ lớp cở sở IbaseService.
    /// </summary>
    /// CreatedBy: vmquang(14/5/2021).
    public class CountryService : BaseService<Country>, ICountryService
    {
        #region Methods
        public CountryService(IBaseRepository<Country> baseRepository) : base(baseRepository)
        {
            //_unitOfWork = unitOfWork;
        }
        #endregion
    }
}
