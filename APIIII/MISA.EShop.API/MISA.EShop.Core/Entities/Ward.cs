using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Entities
{
    /// <summary>
    /// Lớp lưu trữ thông tin các phường/ xã
    /// </summary>
    public class Ward:BaseEntity
    {
        /// <summary>
        /// ID phường xã (khóa chính)
        /// </summary>
        [Key]
        public Guid WardId { get; set; }

        /// <summary>
        /// Tên phường/ xã
        /// </summary>
        public string WardName { get; set; }

        /// <summary>
        /// ID quận/huyện mà phường/xã trực thuộc (khóa ngoại - FK)
        /// </summary>
        public Guid DistrictId { get; set; }
    }
}
