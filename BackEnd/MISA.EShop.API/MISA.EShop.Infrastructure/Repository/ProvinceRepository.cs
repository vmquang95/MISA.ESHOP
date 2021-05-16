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
    public class ProvinceRepository:BaseRepository<Province>, IProvinceRepository
    {
        public IEnumerable<Province> GetProvinceWithCountry(Guid? countryId)
        {
            string queryString = $"SELECT p.CountryId,p.ProvinceId,p.ProvinceName FROM Province p WHERE p.CountryId = '{countryId}'";

            var provinceList = _dbConnection
                .Query<Province>(queryString);
            return provinceList;

        }
    }
}
