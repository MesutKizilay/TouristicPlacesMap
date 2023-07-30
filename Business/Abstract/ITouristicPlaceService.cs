using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITouristicPlaceService
    {
        List<TouristicPlace> GetAll();
        TouristicPlace GetById(int touristicPlaceId);
        void AddTouristicPlace(TouristicPlace touristicPlace);
        void UpdateTouristicPlace(TouristicPlace touristicPlace);
        void DeleteTouristicPlace(TouristicPlace touristicPlace);
        List<TouristicPlace> GetAllByCityId(int id);
    }
}