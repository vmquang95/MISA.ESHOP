using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Requests
{
    /// <summary>
    /// Lớp lưu trữ thông tin 1 trang khi request
    /// </summary>
    public class PageRequestBase
    {
        /// <summary>
        /// Chỉ số trang
        /// </summary>
        public int PageIndex { set; get; }

        /// <summary>
        /// số bản ghi/trang
        /// </summary>
        public int PageSize { set; get; }

        public PageRequestBase(int pageIndex = 1, int pageSize = 15)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
        }
    }
}
