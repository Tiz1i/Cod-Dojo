using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WeddingPlaner.Models;
using System.Collections;
using System.Collections.Generic;

namespace WeddingPlaner.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }



    [HttpPost("Register")]
    public IActionResult Register(User user)
    {
        if (ModelState.IsValid)
        {
            // If a User exists with provided email
            if (_context.Users.Any(u => u.Email == user.Email))
            {
                // Manually add a ModelState error to the Email field, with provided
                // error message
                ModelState.AddModelError("Email", "Email already in use!");

                // You may consider returning to the View at this point
                return View("Index");
            }
            // Initializing a PasswordHasher object, providing our User class as its type
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            user.Password = Hasher.HashPassword(user, user.Password);
            //Save your user object to the database

            _context.Users.Add(user);
            _context.SaveChanges();
            User Userdb = _context.Users.FirstOrDefault(u => u.Email == user.Email);

            HttpContext.Session.SetInt32("UserId", Userdb.UserId);
            int? IntVariable = HttpContext.Session.GetInt32("UserId");

            return RedirectToAction("Dashboard");

        }
        else
        {
            return View("Index");
        }

    }

    [HttpPost]
    public IActionResult LogIn(LoginUser user)
    {
        if (ModelState.IsValid)
        {
            // If initial ModelState is valid, query for a user with provided email
            var userInDb = _context.Users.FirstOrDefault(u => u.Email == user.Email);
            // If no user exists with provided email
            if (userInDb == null)
            {
                // Add an error to ModelState and return to View!
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return View("Index");
            }

            // Initialize hasher object
            var hasher = new PasswordHasher<LoginUser>();

            // verify provided password against hash stored in db
            var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.Password);


            // result can be compared to 0 for failure
            if (result == 0)
            {
                ModelState.AddModelError("Password", "Invalid Password");
                // handle failure (this should be similar to how "existing email" is handled)
                return View("Index");
            }

            HttpContext.Session.SetInt32("UserId", userInDb.UserId);

            int IntVariable = (int)HttpContext.Session.GetInt32("UserId");

            return RedirectToAction("Dashboard");
        }
        return View("Index");
    }

    public IActionResult LogOut()
    {
        HttpContext.Session.Clear();

        return RedirectToAction("Index");
    }

    public IActionResult LogIn()
    {

        return View();
    }

    public IActionResult Dashboard()
    {
        ViewBag.allwed = _context.Weddings.Include(e => e.Invitations).ThenInclude(e => e.Person).ToList();
        ViewBag.allinvite = _context.Invites.ToList();
        int Variable1 = (int)HttpContext.Session.GetInt32("UserId");
        ViewBag.dbinvite = _context.Invites.FirstOrDefault(p=> p.UserId == Variable1);

        return View();
    }

    public IActionResult AddWedding()
    {
        
        return View();
    }


    [HttpGet("Deletewedding/{id}")]

    public IActionResult Deletewedding(int id)
    {
        Wedding removingWedding = _context.Weddings.FirstOrDefault(p => p.WeddingId == id);

        _context.Weddings.Remove(removingWedding);
        _context.SaveChanges();
        // return View("Index");
        return RedirectToAction("Dashboard"); // pasi bejm return view  ben id=0 dhe nxjerr prb

    }


    [HttpPost]
    public IActionResult CreateWedding(Wedding marrngaadd)
    {
        if (ModelState.IsValid)
        {


            if (marrngaadd.Date < DateTime.Now)
            {

                ModelState.AddModelError("Date", "Date must be in the future");

                return View("AddWedding");
            }

            else
            {

                int IntVariable = (int)HttpContext.Session.GetInt32("UserId");
                marrngaadd.UserId = IntVariable;
                _context.Add(marrngaadd);
                _context.SaveChanges();
                Wedding mywed = _context.Weddings.OrderByDescending(e => e.UpdatedAt).FirstOrDefault();



                return RedirectToAction("SHowWedding", new { id = mywed.WeddingId });
            }


        }
        return View("AddWedding");
    }
    [HttpGet("SHowWedding/{id}")]
    public IActionResult SHowWedding(int id)
    {
        ViewBag.wedid = id;
        ViewBag.mywed = _context.Weddings.FirstOrDefault(e => e.WeddingId == id);
        ViewBag.guests=_context.Invites.Include(e=>e.Person).Where(e=> e.WeddingId ==id).ToList();
        return View();
    }



    public IActionResult Attend(int id)
    {
        int Variable1 = (int)HttpContext.Session.GetInt32("UserId");
        List<Invite> allinvite = _context.Invites.ToList();
        Invite dbinvite = _context.Invites.FirstOrDefault(p => p.WeddingId == id && p.UserId == Variable1);
        if (allinvite.Contains(dbinvite))
        {
            return RedirectToAction("Dashboard");

        }
        else
        {
            Invite MYinvite = new Invite()
            {
                WeddingId = id,
                UserId = Variable1
            };
            _context.Add(MYinvite);
            _context.SaveChanges();
            
            return RedirectToAction("Dashboard");
        }

    }

    public IActionResult NotAttend(int id)
    {


        int Variable1 = (int)HttpContext.Session.GetInt32("UserId");
        List<Invite> allinvite = _context.Invites.ToList();
        Invite dbinvite = _context.Invites.FirstOrDefault(p => p.WeddingId == id && p.UserId == Variable1);
        if (allinvite.Contains(dbinvite))
        {
            int IntVariable = (int)HttpContext.Session.GetInt32("UserId");
            Invite removingInvite = _context.Invites.FirstOrDefault(p => p.WeddingId == id && p.UserId == IntVariable);
            _context.Invites.Remove(removingInvite);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        else
        {

            return RedirectToAction("Dashboard");
        }
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
