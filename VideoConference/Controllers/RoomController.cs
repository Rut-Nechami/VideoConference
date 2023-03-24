using Microsoft.AspNetCore.Mvc;
using VideoConference.Models;

namespace VideoConference.Controllers
{
    public class RoomController : Controller
    {
        //function- User login conference

        //function- User get out conference

        [HttpGet]
        public Participants getJudgeUser(int userId)
        {
            //When a first - time user wants to enter a conference video,
            //His ID is sent to the general database and there he checks whether he judges or not,
            //If so returns it with permissions as admin.
        }
    }
}
