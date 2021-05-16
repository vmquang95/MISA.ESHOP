using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MISA.EShop.Core.Entities
{
    /// <summary>
    /// Class chứa các thuộc tính của cửa hàng.
    /// Có kế thừa thuộc tính từ BaseEntity
    /// </summary>
    /// CreatedBy: vmquang(13/5/2021)
    public class Store:BaseEntity
    {
        #region Properties
        /// <summary>
        /// Khóa chính, Id của cửa hàng
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        [Key]
        public Guid StoreId { get; set; }

        /// <summary>
        /// Mã của cửa hàng , không được để  trống , không trùng lặp
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        [Required]
        [Unique]
        public string StoreCode { get; set; }

        /// <summary>
        /// Tên cửa hàng, không được để  trống
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        [Required]
        public string StoreName { get; set; }

        /// <summary>
        /// Địa chỉ cửa hàng, không được để  trống.
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        [Required]
        public string StoreAddress { get; set; }

        /// <summary>
        /// Số điện thoại cửa hàng.
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public string StorePhoneNumber { get; set; }

        /// <summary>
        /// Mã số thuế cửa hàng.
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public string StoreTaxCode { get; set; }

        /// <summary>
        /// Trạng thái cửa hàng , được null (0-đang hoạt động , 1-Đã đóng cửa)
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public int? Status { get; set; }

        /// <summary>
        /// ID quốc gia, được null.
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public Guid? CountryId { get; set; }

        /// <summary>
        /// ID tỉnh/thành phố , được null.
        /// </summary>
        public Guid? ProvinceId { get; set; }

        /// <summary>
        /// ID quận/huyện , được null.
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public Guid? DistrictId { get; set; }

        /// <summary>
        /// ID phường/xã , được null.
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public Guid? WardId { get; set; }

        /// <summary>
        /// Đường phố
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public string Street { get; set; }

        #endregion
    }
}
