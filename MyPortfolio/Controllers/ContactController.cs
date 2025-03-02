using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public IActionResult Submit(string Name, string Email, string Message)
        {
            // Here, you could add logic to send the message (e.g., via email or save to a database)

            // Show success message
            TempData["Message"] = "Your message has been sent successfully!";

            // Redirect to the same page to show the message
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
