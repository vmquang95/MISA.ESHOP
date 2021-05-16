using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MISA.EShop.Core.Entities
{
    /// <summary>
    /// Lớp County chứa các tông tin của quốc gia.
    /// Có kế thừa các thuộc tính của BaseEntity
    /// </summary>
    /// CreatedBy: vmquang(13/5/2021)
    public class Country : BaseEntity
    {
        #region Properties
        /// <summary>
        /// Khóa chính cho từng quốc gia.
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        [Key]
        public Guid CountryId { get; set; }

        /// <summary>
        /// Tên quốc gia
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public string CountryName { get; set; }
        #endregion
    }
}
