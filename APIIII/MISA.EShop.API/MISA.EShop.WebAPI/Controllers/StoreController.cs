using Microsoft.AspNetCore.Mvc;
using MISA.EShop.Core.Entities;
using MISA.EShop.Core.Interfaces;
using MISA.EShop.Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.EShop.WebAPI.Controllers
{

    public class StoreController : BaseEntityController<Store>
    {
        private IStoreService _storeService;
        public StoreController(IStoreService storeService) : base(storeService)
        {
            _storeService = storeService;
        }


        /// <summary>
        /// API lấy thông tin đối tượng theo mã 
        /// </summary>
        /// <param name="storeCode">Mã cửa hàng</param>
        /// <returns>ResponseResult với data là Danh sách bản ghi có mã cửa hàng bằng mã cửa hàng truyền vào</returns>
        /// CreatedBy: ntcu 20.04.20201
        [HttpGet("getbycode")]
        public IActionResult Get(string storeCode)
        {
            var responseResult = new ResponseResult();
            try
            {
                responseResult = _storeService.GetStoreByStoreCode(storeCode);
            }
            catch (Exception e)
            {
                responseResult.OnException(responseResult, e);
            }

            return Ok(responseResult);
        }

        /// <summary>
        /// API lấy thông tin cửa hàng theo các tham số lọc: storeCode, storeName, address, phoneNumber, status
        /// </summary>
        /// <param name="filterparams">Đối tượng có các thuộc tính các tham số lọc</param>
        /// <returns>ResponseResult với data là Danh sách cửa hàng lọc được</returns>
        /// CreatedBy: nctu 20.04.2021
        [HttpGet("Filter")]
        public IActionResult Get([FromQuery] FilterStoreParams filterparams)
        {
            var responseResult = new ResponseResult();
            try
            {
                responseResult = _storeService.GetStoreFilter(
                    filterparams.storeCode, 
                    filterparams.storeName, 
                    filterparams.address, 
                    filterparams.phoneNumber, 
                    filterparams.status);
            }
            catch (Exception e)
            {
                responseResult.OnException(responseResult, e);
            }
            return Ok(responseResult);
        }

        

    }
}
