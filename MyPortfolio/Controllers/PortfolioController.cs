using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Models;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            var projects = new List<Project>
            {
                new Project { Id = 1, Title = "Absolute Cinema", Description = "Our cinema ticket booking online system is programmed to provide customers with an easy way to book movie tickets. Instead of rushing to the cinema or standing in a long queue, customers can browse movies, check showtimes, and reserve seats all in one place. The platforms will ensure a convenient and efficient booking process, accessible anytime and anywhere.\r\n", ImageUrl = "https://img.freepik.com/premium-vector/online-ticket-booking-concept-watching-movie_294779-70.jpg" },

                new Project { Id = 2, Title = "Campus Navigation System", Description = "This project is developed as a real-time campus navigation application that helps students, faculty, and visitors easily find their way around large academic campuses. It aims to simplify navigation, reduce confusion, and enhance the overall campus experience through turn-by-turn directions and real-time updates.", ImageUrl = "https://wordpress.mapsted.com/wp-content/uploads/2022/05/Indoor-nav-4-1024x515.jpg" },

                new Project { Id = 3, Title = "Smart Home Automation System", Description = "This project is all about making life at home easier, smarter, and more secure. With a smart home automation system, you can control your lights, temperature, security, and appliances from anywhere, all with a tap on your phone or a simple voice command. It’s designed to save energy, boost convenience, and give you peace of mind—because your home should work for you, not the other way around.\n\n\n\n\n\n\n\n", ImageUrl = "https://cg-new-drupal-site-s3-bucket.s3.ap-south-1.amazonaws.com/staging/s3fs-public/2020-12/cyril-blog-2.jpg" },

                new Project { Id = 4, Title = "Public Transportation Navigation System", Description = "This project aims to develop a real-time public transportation navigation system to help commuters efficiently plan and navigate their routes using buses, trains, and other transit options. It will provide live tracking, optimized route suggestions, and real-time arrival updates to improve travel convenience and reduce waiting times. ", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_87_okkkZxpdVvBZGvxWAsU0m9HA0057V0A&s" }

            };

            return View(projects);
        }
    }
}
