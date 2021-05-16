using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MISA.EShop.Core.Entities
{
    /// <summary>
    /// Lớp chưa thông tin của Tỉnh/Thành phố.
    /// Có kế thừa BaseEntity
    /// </summary>
    /// CreatedBy: vmquang(13/5/2021)
    public class Province :BaseEntity
    {
        #region Properties
        /// <summary>
        /// Khóa chính tỉnh/thành phố.
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        [Key]
        public Guid ProvinceId { get; set; }

        /// <summary>
        /// Tên tỉnh/thành phố
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public string ProvinceName { get; set; }

        /// <summary>
        /// ID quốc gia mà tỉnh/thành phố trực thuộc (Khóa ngoại - FK)
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public Guid CountryId { get; set; }
        #endregion
    }


}
