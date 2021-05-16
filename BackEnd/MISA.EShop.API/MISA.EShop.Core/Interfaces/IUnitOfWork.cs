using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Interfaces
{
    /// <summary>
    /// Interface chứa các việc xử lý nghiệp vụ chung của các đối tượng.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Đối tượng cửa hàng
        /// </summary>
        IStoreRepository StoreTask { get; }

        /// <summary>
        /// Đối tượng quốc gia
        /// </summary>
        ICountryRepository CountryTask { get; }

        /// <summary>
        /// Đối tượng tỉnh/thành phố
        /// </summary>
        IProvinceRepository ProvinceTask { get; }

        /// <summary>
        /// Đối tượng quận/huyện
        /// </summary>
        IDistrictRepository DistrictTask { get; }

        /// <summary>
        /// Đối tượng phường/xã
        /// </summary>
        IWardRepository WardTask { get; }
    }
}
