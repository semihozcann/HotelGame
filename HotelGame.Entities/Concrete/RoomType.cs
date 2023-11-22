using HotelGame.Core.Entities.Abstract;
using HotelGame.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGame.Entities.Concrete
{
    public class RoomType : BaseEntity<int> , IEntity
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int PeopleCount { get; set; }


    }
}
