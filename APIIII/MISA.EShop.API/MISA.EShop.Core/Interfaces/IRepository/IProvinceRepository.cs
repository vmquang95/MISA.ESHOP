using MISA.EShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Interfaces
{
    public interface IProvinceRepository:IBaseRepository<Province>
    {
        /// <summary>
        /// Lấy thông tin tỉnh thành theo id quốc gia
        /// </summary>
        /// <param name="countryId">ID quốc gia</param>
        /// <returns>Danh sách tỉnh thành trực thuộc</returns>
        IEnumerable<Province> GetProvinceWithCountry(Guid? countryId);
    }
}
