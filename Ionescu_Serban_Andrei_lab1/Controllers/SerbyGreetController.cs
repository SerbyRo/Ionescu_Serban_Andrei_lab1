using Microsoft.AspNetCore.Mvc;

namespace Ionescu_Serban_Andrei_lab1.Controllers
{
    public class SerbyGreetController : Controller
    {
        public String Index()
        {
            return "Welcome to my app!";
           // return Greet();
          //  return displayIntegerAndStringValues(22,"Heey it's Serban");
        }

        public String Greet()
        {
            return "Hello user!";
        }

        public String displayIntegerAndStringValues(int displayedInt, String displayedString)
        {
            return "These are the parameters: " + displayedInt + " and string" + displayedString;
        }
    }
}
