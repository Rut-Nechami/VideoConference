using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VideoConference.Models;

namespace VideoConference.Controllers
{
    public class CameraAndMicrophoneController : Controller
    {
        [HttpPost]
        public void addNewParticipant([FromBody] int userId, int roomId)
        {
            //add a new participant to a specific room.
        }
        [HttpPatch]
        public void changeCameraMode([FromBody] int userId)
        {
            //Bring the userID to the API of the camera
            //the camera will be opened or closed.
        }

        [HttpPatch]
        
        public void changeMicrophoneMode([FromBody] int userId, int clickerId)
        {
            //Bring the userID to the API of the microphone
            //the microphone will be opened or closed.
        }

        [HttpPatch]

        public void muteAllParticipants([FromBody]int clickerId, int [] userIds)
        {
            //check if the clicker is judge and has admin permissions.
            //if so, mute all - update the API of the microphone to mute all the participants.
            //if not throw exception
        }
    }
}
