using MISA.EShop.Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Core.Interfaces
{
    /// <summary>
    /// Base Service
    /// </summary>
    /// <typeparam name="T">Kiểu của thực thể</typeparam>
    public interface IBaseService<T>
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu của bảng trong database
        /// </summary>
        /// <returns>Danh sách các đối tượng</returns>
        ResponseResult GetEntities();

        /// <summary>
        /// Lấy thông tin của thực thể theo khóa chính
        /// </summary>
        /// <param name="entityId">ID của đối tượng</param>
        /// <returns>1 thực thể duy nhất có ID tương ứng truyền vào</returns>
        ResponseResult GetById(Guid entityId);

        /// <summary>
        /// Thêm mới một thực thể
        /// </summary>
        /// <param name="entity">Thực thể cần thêm mới</param>
        /// <returns>Số bản ghi thêm mới được vào DB</returns>
        ResponseResult Insert(T entity);

        /// <summary>
        /// Sửa thông tin của một đối tượng
        /// </summary>
        /// <param name="entity">Thực thể cần thêm mới</param>
        /// <param name="entityId">ID của thực thể</param>
        /// <returns>Số bản ghi đã được cập nhật nội dụng trong DB</returns>
        ResponseResult Update(T entity, Guid entityId);

        /// <summary>
        /// Xóa một bản ghi theo ID
        /// </summary>
        /// <param name="entityId">ID của đối tượng cần xóa</param>
        /// <returns>Số bản ghi đã xóa trong DB</returns>
        ResponseResult Delete(Guid entityId);
    }
}
