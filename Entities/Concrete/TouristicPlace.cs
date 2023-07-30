using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TouristicPlace:IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string PlaceName { get; set; }
        public string Location { get; set; }
        public string Features { get; set; }
        public int VisitorNumber { get; set; }
    }
}