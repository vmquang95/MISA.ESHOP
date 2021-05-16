using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Interfaces
{
    /// <summary>
    /// Interface chứa các việc xử lý nghiệp vụ chung của các đối tượng
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Đối tượng cửa hàng
        /// </summary>
        IStoreRepository Store { get; }

        /// <summary>
        /// Đối tượng quốc gia
        /// </summary>
        ICountryRepository Country { get; }

        /// <summary>
        /// Đối tượng tỉnh/thành phố
        /// </summary>
        IProvinceRepository Province { get; }

        /// <summary>
        /// Đối tượng quận/huyện
        /// </summary>
        IDistrictRepository District { get; }

        /// <summary>
        /// Đối tượng phường/xã
        /// </summary>
        IWardRepository Ward { get; }
    }
}
