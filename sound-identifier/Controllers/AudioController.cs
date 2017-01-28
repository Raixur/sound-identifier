using System;
using System.IO;
using System.Text;
using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Mvc;

namespace SoundIdentifier.Controllers
{
    
    public class AudioController : Controller
    {
        public IActionResult Help()
        {
            // TODO: Describe usage
            return new JsonResult("Help for report");
        }

        public IActionResult IdentifyAudio(string audio)
        {
            // TODO: Add to audio db
            // TODO: Identify audio
            // TODO: Store identification to report list
            return new JsonResult("Audio identified");
        }

        public IActionResult StoreAudio()
        {
            return new JsonResult("Audio stored"); 
        }


        public IActionResult PushAudio(string id)
        {
            // TODO: push specified audio to cloud
            return new JsonResult("Audio pushed");
        }
    }

    
}