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
    public class WardRepository:BaseRepository<Ward>, IWardRepository
    {
        public IEnumerable<Ward> GetWardWithDistrict(Guid? districtId)
        {
            //string procName = $"Proc_GetWardWithDistrict";

            //var parameters = new DynamicParameters();
            //parameters.Add("@DistrictId", districtId);

            //var wardList = _dbConnection
            //    .Query<Ward>
            //    (procName, parameters, commandType: CommandType.StoredProcedure);
            //return wardList;

            string queryString = $"SELECT w.DistrictId,w.WardId,w.WardName FROM Ward w  WHERE w.DistrictId ='{districtId}'";

            var wardList = _dbConnection
                .Query<Ward>(queryString);
            return wardList;
        }
    }
}
