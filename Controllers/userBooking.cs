using System.Xml.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
namespace FlightBookingAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]   
    public class UserBookingController:ControllerBase
    {
        [HttpGet("{id}")]
        public Models.userBooking get(int id)
        {
            business_logic.getuserData ob= new business_logic.getuserData();
            Dictionary<int,Models.userBooking> user= ob.data();
            return user[id];
        }
    }
}
