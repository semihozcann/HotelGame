using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGame.Entities.Concrete
{
    public class User : IdentityUser<int>
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string County { get; set; }
        public DateTime DateofBirth { get; set; }
        public string ImagePath { get; set; }


        [NotMapped]
        //Role:User,Admin 
        public string[] Roles { get; set; }
    }
}
