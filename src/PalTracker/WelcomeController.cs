using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        private readonly WelcomeMessage _message;
        [HttpGet]
        public string SayHello() => "hello";

         public WelcomeController(WelcomeMessage message)
        {
            _message = message;
        }
    }
}