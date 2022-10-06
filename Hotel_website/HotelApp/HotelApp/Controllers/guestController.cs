using HotelApp.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
namespace HotelApp.Controllers
{
    public class guestController : Controller
    {
        HotelEntities7 context = new HotelEntities7();
        // GET: guest
        [HttpGet]
        public ActionResult Register()
        {
            return View(new Gusets());
        }
        [HttpPost]
        public ActionResult Register(Gusets gst)
        {

            if (context.Gusets.Any(u => u.gusName == gst.gusName))
            {
                ModelState.AddModelError("", "name already found");
                return View(gst);
            }
            if (context.Gusets.Any(u => u.phone == gst.phone))
            {
                ModelState.AddModelError("", "phone number already found");
                return View(gst);
            }
            if (context.Gusets.Any(u => u.SSN == gst.SSN))
            {
                ModelState.AddModelError("", "SSN already found");
                return View(gst);
            }
            if (context.Gusets.Any(u => u.email == gst.email))
            {
                ModelState.AddModelError("", "email already found");
                return View(gst);
            }

            if (ModelState.IsValid==false)
            {
                return View(gst);
            }
            
            context.Gusets.Add(gst);
            context.SaveChanges();

            ModelState.Clear();

            ViewBag.message = "successfully registered";
            return View();
        }

        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult login(Gusets gst)
        {
            var user= context.Gusets.Single(u => u.gusName == gst.gusName &&u.password== gst.password);
            if (user!=null)
            {
                Session["userID"] = user.gusID.ToString();
                Session["userName"] = user.gusName.ToString();
               
                return RedirectToAction("loggedIn");
            }

            ModelState.AddModelError("", "username or password is wrong");

            return View();
        }
        public ActionResult loggedIn()
        {
            if (Session["userID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login");
            }
        }
        
        [HttpGet]
        public ActionResult _book()
        {
            //var book = context.Bookings.Include(s=>s.Gusets);
            ViewBag.gusID = new SelectList(context.Gusets, "gusID", "gusName");
            return View(new Bookings());
        }
        [HttpPost]
        public ActionResult _book(Bookings _Book)
        {
            
            if (ModelState.IsValid)
            {

                _Book.reserve = true;
                context.Bookings.Add(_Book);
                context.SaveChanges();
                ViewBag.message = "successfully reversation";

            }
            ViewBag.gusID = new SelectList(context.Gusets, "gusID", "gusName");

            return View(_Book);
        }
        [HttpGet]
        public ActionResult feedback()
        {
            ViewBag.gusID = new SelectList(context.Gusets, "gusID", "gusName");
            return View(new Fedbacks());
        }
        [HttpPost]
        public ActionResult feedback(Fedbacks _fedback)
        {
            
            if (ModelState.IsValid)
            {
                context.Fedbacks.Add(_fedback);
                context.SaveChanges();
                ModelState.Clear();
                ViewBag.message = "successfully added your fedback";
            }
            ViewBag.gusID = new SelectList(context.Gusets, "gusID", "gusName");
            return View(_fedback);
        }

        [HttpGet]
        public ActionResult cancel()
        {
            ViewBag.gusID = new SelectList(context.Gusets,"gusID","gusName");
            return View(new Bookings());
        }
        [HttpPost]
        public ActionResult cancel(Bookings b)
        {
            ViewBag.gusID = new SelectList(context.Gusets, "gusID", "gusName");
            Bookings old = context.Bookings.FirstOrDefault(u => u.gusID ==b.gusID);
            //if (old!=null)
            //{
               old.reserve = false;
               old.confirmPay = false;
               context.SaveChanges();
                ViewBag.message = "successfully cancel your booking";
            //}
            
            
            return View(b);
        }



    }
}

