using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void AddCity(City city)
        {
            _cityDal.Add(city);
        }

        public void DeleteCity(City city)
        {
            _cityDal.Delete(city);
        }

        public List<City> GetAll()
        {
            return _cityDal.GetAll();
        }

        public City GetById(int cityId)
        {
            return _cityDal.Get(c=>c.Id==cityId);
        }

        public void UpdateCity(City city)
        {
           _cityDal.Update(city);
        }
    }
}