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
	public class TouristicPlaceManager : ITouristicPlaceService
	{
		ITouristicPlaceDal _touristicPlaceDal;

		public TouristicPlaceManager(ITouristicPlaceDal touristicPlaceDal)
		{
			_touristicPlaceDal = touristicPlaceDal;
		}

		public void AddTouristicPlace(TouristicPlace touristicPlace)
		{
			_touristicPlaceDal.Add(touristicPlace);
		}

		public void DeleteTouristicPlace(TouristicPlace touristicPlace)
		{
			_touristicPlaceDal.Delete(touristicPlace);
		}

		public List<TouristicPlace> GetAll()
		{
			return _touristicPlaceDal.GetAll();
		}

        public List<TouristicPlace> GetAllByCityId(int id)
        {
            return _touristicPlaceDal.GetAll(t=>t.CityId == id);
        }

        public TouristicPlace GetById(int touristicPlaceId)
		{
			return _touristicPlaceDal.Get(n => n.Id == touristicPlaceId);
		}

		public void UpdateTouristicPlace(TouristicPlace touristicPlace)
		{
			_touristicPlaceDal.Update(touristicPlace);
		}
	}
}