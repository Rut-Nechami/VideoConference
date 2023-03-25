using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VideoConference.Models;

namespace VideoConference.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CameraAndMicrophoneController : Controller
    {
        [HttpPatch]
        public void changeCameraMode([FromBody] int userId, bool onOrOff)
        {
            //Bring the userID to the API of the camera
            //the camera mode will be changed
            //IsCameraOn property will be changed
        }

        [HttpPatch]
        
        public void changeMicrophoneMode([FromBody] int userId, bool mute)
        {
            //Bring the userID to the API of the microphone
            //the microphone mode will be changed
        }

        [HttpPatch]

        public void muteAllParticipants([FromBody]int userId, int conferenceId)
        {
            //check is userId has permissions
            //if so, mute all - update the API of the microphone to mute all the participants in that conference.
            //if not throw exception
        }
    }
}
