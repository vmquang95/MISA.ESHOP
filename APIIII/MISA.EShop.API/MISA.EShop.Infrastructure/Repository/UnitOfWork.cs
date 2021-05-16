using MISA.EShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EShop.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IStoreRepository store, 
            ICountryRepository country, 
            IProvinceRepository province, 
            IDistrictRepository district, 
            IWardRepository ward)
        {
            Store = store;
            Country = country;
            Province = province;
            District = district;
            Ward = ward;
        }

        public IStoreRepository Store { get; }

        public ICountryRepository Country { get; }

        public IProvinceRepository Province { get; }

        public IDistrictRepository District { get; }

        public IWardRepository Ward { get; }
    }
}
