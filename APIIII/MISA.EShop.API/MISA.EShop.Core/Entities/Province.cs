using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Entities
{
    /// <summary>
    /// Lớp lưu trữ thông tin các tỉnh/ thành phố
    /// </summary>
    public class Province:BaseEntity
    {
        /// <summary>
        /// ID tỉnh/thành phố (khóa chính)
        /// </summary>
        [Key]
        public Guid ProvinceId { get; set; }

        /// <summary>
        /// Tên tỉnh/thành phố
        /// </summary>
        public string ProvinceName { get; set; }

        /// <summary>
        /// ID quốc gia mà tỉnh/thành phố trực thuộc (Khóa ngoại - FK)
        /// </summary>
        public Guid CountryId { get; set; }
    }
}
