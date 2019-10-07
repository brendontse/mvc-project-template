using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
    public class HomeController : Controller

    {

        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/output")]
        public ActionResult ClassObject(string recipient, string sender)
        {
            ClassVariable myClassVariable = new ClassVariable();
            myClassVariable.Recipient = recipient;
            myClassVariable.Sender = sender;
            return View(myClassVariable);
        }
    }
}