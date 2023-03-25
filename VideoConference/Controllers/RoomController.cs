using Microsoft.AspNetCore.Mvc;
using VideoConference.Models;

namespace VideoConference.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : Controller
    {
        //create new conference room

        //function- User login conference
        //add participant

        //function- User get out conference

        //get all participants

        [HttpPost]
        public Participants addPermissionsToJudgeUser(int userId)
        {
            //When a first - time user wants to enter a conference video,
            //His ID is sent to the users database and there he checks whether he judges or not,
            //If so add Permission with the judge's ID.
        }
    }
}
