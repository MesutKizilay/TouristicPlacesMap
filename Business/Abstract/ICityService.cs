﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        City GetById(int cityId);
        void AddCity(City city);
        void UpdateCity(City city);
        void DeleteCity(City city);
    }
}