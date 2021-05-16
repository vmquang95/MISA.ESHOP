using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.EShop.WebAPI
{
    public class FilterStoreParams
    {
        /// <summary>
        /// Mã cửa hàng cần lọc
        /// </summary>
        public string storeCode { get; set; }

        /// <summary>
        /// Tên cửa hàng cần lọc
        /// </summary>
        public string storeName { get; set; }

        /// <summary>
        /// Địa chỉ cửa hàng cần lọc
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Số điện thoại cần lọc
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// Tình trạng của cửa hàng
        /// </summary>
        public int? status { get; set; }
    }
}
