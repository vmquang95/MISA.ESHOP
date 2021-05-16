using MISA.EShop.Core.Entities;
using MISA.EShop.Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Interfaces
{
    public interface IProvinceService : IBaseService<Province>
    {
        /// <summary>
        /// Lấy thông tin tỉnh thành theo id quốc gia
        /// </summary>
        /// <param name="countryId">ID quốc gia</param>
        /// <returns>Danh sách tỉnh thành trực thuộc</returns>
        ResponseResult GetProvinceWithCountry(Guid? countryId);
    }
}
