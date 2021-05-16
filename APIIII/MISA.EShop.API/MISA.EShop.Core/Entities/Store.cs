using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Entities
{
    /// <summary>
    /// Lớp lưu trữ thông tin của các cửa hàng
    /// </summary>
    public class Store:BaseEntity
    {
        /// <summary>
        /// ID cửa hàng (khóa chính)
        /// </summary>
        [Key]
        public Guid StoreId { get; set; }

        /// <summary>
        /// Mã cửa hàng
        /// </summary>
        [Unique]
        [Required]
        [Display(Name ="Mã cửa hàng")]
        public string StoreCode { get; set; }

        /// <summary>
        /// Tên cửa hàng
        /// </summary>
        [Required]
        [Display(Name = "Tên cửa hàng")]
        public string StoreName { get; set; }

        /// <summary>
        /// Địa chỉ của cửa hàng
        /// </summary>
        [Required]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Mã số thuế
        /// </summary>
        [Display(Name ="Mã số thuế")]
        public string StoreTaxCode { get; set; }

        /// <summary>
        /// ID quốc gia (khóa ngoại với Country)
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// ID tỉnh/thành phố (khóa ngoại với Province)
        /// </summary>
        public Guid? ProvinceId { get; set; }

        /// <summary>
        /// ID quận/huyện (khóa ngoại với District)
        /// </summary>
        public Guid? DistrictId { get; set; }

        /// <summary>
        /// ID phường/xã (khóa ngoại với Ward)
        /// </summary>
        public Guid? WardId { get; set; }

        /// <summary>
        /// Đường phố
        /// </summary>
        [Display(Name ="Đường phố")]
        public string Street { get; set; }

        /// <summary>
        /// Trạng thái hoạt động (0 - Đang hoạt động, 1 - Đang đóng cửa)
        /// </summary>
        [Display(Name ="Trạng thái")]
        public int? Status { get; set; }
    }
}
