using MISA.EShop.Core.Entities;
using MISA.EShop.Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Interfaces
{
    public interface IStoreService : IBaseService<Store>
    {
        /// <summary>
        /// Lấy ra số lượng cửa hàng
        /// </summary>
        /// <returns>tổng số cửa hàng</returns>
        ResponseResult GetCountStores();

        /// <summary>
        /// Lấy thông tin cửa hàng theo mã cửa hàng
        /// </summary>
        /// <param name="storeCode">Mã cửa hàng</param>
        /// <returns>Thông tin cửa hàng có mã là tham số truyền vào</returns>
        ResponseResult GetStoreByStoreCode(string storeCode);

        /// <summary>
        /// Lọc thông tin theo các tiêu chí
        /// </summary>
        /// <param name="storeCode">Mã cửa hàng</param>
        /// <param name="storeName">Tên cửa hàng</param>
        /// <param name="address">Địa chỉ</param>
        /// <param name="phoneNumber">Số điện thoại</param>
        /// <param name="status">Trạng thái hoạt động</param>
        /// <returns>Danh sách cửa hàng tìm thấy</returns>
        ResponseResult GetStoreFilter(string storeCode, string storeName, string address, string phoneNumber, int? status);

        
    }
}
