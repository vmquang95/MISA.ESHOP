using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.EShop.Core.Entities
{
    /// <summary>
    /// Class chứa các thông tin dùng chung.
    /// </summary>
    /// CreatedBy: vmquang(13/5/2021)
    public  class BaseEntity
    {
        #region Properties
        /// <summary>
        /// Ngày tạo , được phép null
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày sửa đổi , được phép null
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Người sửa đổi
        /// </summary>
        /// CreatedBy: vmquang(13/5/2021)
        public string ModifiedBy { get; set; }
        #endregion
    }
}
