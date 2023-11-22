using HotelGame.Entities.Concrete;
using HotelGame.WebMVC.Helpers.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelGame.WebMVC.Controllers
{
    public class BaseController : Controller
    {
        public User CurrentUser
        {
            get
            {
                if (User != null)
                    return _userAccessor.GetUser();
                else
                    return null;
            }
        }


        IUserAccessor _userAccessor;
        public BaseController(IUserAccessor userAccessor)
        {
            _userAccessor = userAccessor;
        }

    }
}
