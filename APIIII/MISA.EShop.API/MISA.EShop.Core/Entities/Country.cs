using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Entities
{
    /// <summary>
    /// Lớp lưu trữ thông tin các quốc gia
    /// </summary>
    public class Country: BaseEntity
    {
        /// <summary>
        /// ID quốc gia
        /// </summary>
        [Key]
        public Guid CountryId { get; set; }

        /// <summary>
        /// Tên quốc gia
        /// </summary>
        public string CountryName { get; set; }
    }
}
