using Microsoft.AspNetCore.Mvc;
using RailwayTicketSystem.Models;

public class AccountController : Controller
{
    private readonly RailwayDbContext _context;

    public AccountController(RailwayDbContext context)
    {
        _context = context;
    }

    public IActionResult Signup()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Signup(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return RedirectToAction("Login");
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        if (user != null)
        {
            HttpContext.Session.SetInt32("UserId", user.Id);
            return RedirectToAction("Booking", "Booking");
        }
        else
        {
            ViewBag.Error = "Invalid credentials";
            return View();
        }
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }
}
