using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Results
{
    /// <summary>
    /// Lớp lưu trữ thông tin phân trang
    /// </summary>
    /// <typeparam name="T">Đối tượng </typeparam>
    /// 
    public class EntittiesPaging<T>
    {
        /// <summary>
        /// Tổng số trang
        /// </summary>
        public int TotalPage { get; set; }
        /// <summary>
        /// Tổng số bản ghi
        /// </summary>
        public int TotalRecord { get; set; }

        /// <summary>
        /// Danh sách dữ liệu trả về của 1 trang
        /// </summary>
        public List<T> Data { get; set; }
    }
}
