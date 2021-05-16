using MISA.EShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Interfaces
{
    public interface IWardRepository:IBaseRepository<Ward>
    {
        /// <summary>
        /// Lấy danh sách các phường/xã theo quận/huyện
        /// </summary>
        /// <param name="DistrictId">ID quận huyện</param>
        /// <returns>Danh sách các phường xã trực thuộc quận/huyện có id truyền vào</returns>
        IEnumerable<Ward> GetWardWithDistrict(Guid? districtId);
    }
}
