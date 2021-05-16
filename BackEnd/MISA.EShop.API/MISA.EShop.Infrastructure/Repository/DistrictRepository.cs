using Dapper;
using MISA.EShop.Core.Entities;
using MISA.EShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Infrastructure.Repository
{
    public class DistrictRepository:BaseRepository<District>, IDistrictRepository
    {
        public IEnumerable<District> GetDistrictWithProvince(Guid? provinceId)
        {
     

            string queryString = $"SELECT d.ProvinceId,d.DistrictId,d.DistrictName FROM District d  WHERE d.ProvinceId ='{provinceId}'";

            var districtList = _dbConnection
                .Query<District>(queryString);
            return districtList;
        }
    }
}
