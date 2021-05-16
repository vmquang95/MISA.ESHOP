using MISA.EShop.Core.Entities;
using MISA.EShop.Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Interfaces
{
    public interface IWardService : IBaseService<Ward>
    {
        /// <summary>
        /// Lấy danh sách các phường/xã theo quận/huyện
        /// </summary>
        /// <param name="DistrictId">ID quận huyện</param>
        /// <returns>Danh sách các phường xã trực thuộc quận/huyện có id truyền vào</returns>
        ResponseResult GetWardWithDistrict(Guid? districtId);
    }
}
