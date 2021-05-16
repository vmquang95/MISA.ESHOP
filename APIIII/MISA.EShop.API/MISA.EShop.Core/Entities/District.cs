using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Entities
{
    /// <summary>
    /// Lớp lưu trữ thông tin các quận/huyện
    /// </summary>
    public class District:BaseEntity
    {
        /// <summary>
        /// ID quận/huyện (khóa chính)
        /// </summary>
        [Key]
        public Guid DistrictId { get; set; }

        /// <summary>
        /// Tên quận/ huyện
        /// </summary>
        public string DistrictName { get; set; }

        /// <summary>
        /// ID tỉnh/thành phố mà quận/huyện trực thuộc (Khóa ngoại - FK)
        /// </summary>
        public Guid ProvinceId { get; set; }
    }
}
