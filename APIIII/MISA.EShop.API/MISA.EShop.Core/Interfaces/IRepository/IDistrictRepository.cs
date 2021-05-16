using MISA.EShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Interfaces
{
    public interface IDistrictRepository:IBaseRepository<District>
    {
        /// <summary>
        /// Lấy danh sách các quận/huyện theo tỉnh/thành phố
        /// </summary>
        /// <param name="ProvinceId">ID của tỉnh/thành phố</param>
        /// <returns>Danh sách quận huyện có id tỉnh thành phố tương ứng truyền vào</returns>
        IEnumerable<District> GetDistrictWithProvince(Guid? provinceId);
    }
}
