using Microsoft.AspNetCore.Mvc;
// using RailwayTicketSystem.Data;
using RailwayTicketSystem.Models;

namespace RailwayTicketSystem.Controllers
{
    public class BookingController : Controller
    {
        private readonly RailwayDbContext _context;

        public BookingController(RailwayDbContext context)
        {
            _context = context;
        }

        // GET: /Booking/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: /Booking/Booking
        public IActionResult Booking()
        {
            return View();
        }

        // POST: /Booking 
        [HttpPost]
        public IActionResult Booking(Booking booking)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Saving Bookings");
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                Console.WriteLine("Booking Saved");
                TempData["Message"] = "Booking Successful!";
                return RedirectToAction("Booking");
            }
            Console.WriteLine("Model is Invalid");
            return View(booking);
        }


        // POST: /Booking/Create
        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                return RedirectToAction("Success");
            }
            return View(booking);
        }

        // GET: /Booking/Success
        public IActionResult Success()
        {
            return View();
        }
    }
}
