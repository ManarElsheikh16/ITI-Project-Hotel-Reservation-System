using HotelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HotelApp.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
        HotelEntities7 context = new HotelEntities7();
        [HttpGet]
        public ActionResult loginAdmin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult loginAdmin(Admins admin)
        {
            var user = context.Admins.Single(u => u.userName == admin.userName && u.passward == admin.passward);
            if (user != null)
            {
                Session["adminID"] = user.adminID.ToString();
                Session["userName"] = user.userName.ToString();
                return RedirectToAction("loggedIn");
            }
            else
            {
                ModelState.AddModelError("", "username or password is wrong");
            }
            return View();
        }
        public ActionResult loggedIn()
        {
            if (Session["adminID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login");
            }
        }
        [HttpGet]
        public ActionResult showDept()
        {
            HotelEntities7 context = new HotelEntities7();
            List<Departments> department = context.Departments.ToList();
            return View(department);
        }
        [HttpGet]
        public ActionResult addDept()
        {
            ViewBag.adminID = new SelectList(context.Admins, "adminID", "userName");
            return View(new Departments());
        }
        [HttpPost]
        public ActionResult addDept(Departments depts)
        {
            ViewBag.adminID = new SelectList(context.Admins, "adminID", "userName");
            if (context.Departments.Any(u => u.deptName == depts.deptName))
            {
                ModelState.AddModelError("", "name already found");
                return View(depts);
            }
            if (!ModelState.IsValid)
            {
                return View(depts);
            }
            context.Departments.Add(depts);
            context.SaveChanges();
            return RedirectToAction("showDept");
        }
        [HttpGet]
        public ActionResult deleteDept()
        {
            return View();
        }
        [HttpPost]
        public ActionResult deleteDept(Departments department)
        {
            if (!ModelState.IsValid)
            {
                return View(department);
            }

            var delete=  context.Departments.Where(u=>u.deptName==department.deptName).FirstOrDefault();
            context.Departments.Remove(delete);
            context.SaveChanges();
            return RedirectToAction("showDept");
        }
        [HttpGet]
        public ActionResult editDept(int? id)
        {
            Departments old = context.Departments.FirstOrDefault(u => u.deptID==id);
            return View(old);
        }
        [HttpPost]
        public ActionResult editDept(int id,Departments department)
        {

            Departments old = context.Departments.FirstOrDefault(u => u.deptID == id);
            if (!ModelState.IsValid)
            {
                return View(department);
            }
            old.deptName= department.deptName;
            context.SaveChanges();
            return RedirectToAction("showDept");
        }
        [HttpGet]
        public ActionResult showStaff()
        {
            HotelEntities7 context = new HotelEntities7();
            List<Staffs> staff = context.Staffs.ToList();
            return View(staff);
        }
        [HttpGet]
        public ActionResult addStaff()
        {
            ViewBag.deptID = new SelectList(context.Departments, "deptID", "deptName");
            return View(new Staffs());
        }
        [HttpPost]
        public ActionResult addStaff(Staffs staff)
        {
            ViewBag.deptID = new SelectList(context.Departments, "deptID", "deptName");
            if (context.Staffs.Any(u => u.staffName == staff.staffName))
            {
                ModelState.AddModelError("", "name already found");
                return View(staff);
            }
            if (!ModelState.IsValid)
            {
                return View(staff);
            }
            context.Staffs.Add(staff);
            context.SaveChanges();
            return RedirectToAction("showStaff");
        }
        [HttpGet]
        public ActionResult deleteStaff()
        {
            return View();
        }
        [HttpPost]
        public ActionResult deleteStaff(Staffs staff)
        {
            Staffs s=  context.Staffs.SingleOrDefault(u => u.staffName == staff.staffName);
            /*if (!ModelState.IsValid)
            {
                return View(staff);
            }*/
                context.Staffs.Remove(s);
                context.SaveChanges();
                return RedirectToAction("showStaff");
            
        }
        [HttpGet]
        public ActionResult editStaff(int? id)
        {
            Staffs staffold = context.Staffs.FirstOrDefault(u => u.staffID == id);
            ViewBag.depts = new SelectList(context.Departments,"deptID","deptName");
       

            return View(staffold);
        }
        [HttpPost]
        public ActionResult editStaff(int id,Staffs staff)
        {
           Staffs staffOld = context.Staffs.FirstOrDefault(u => u.staffID == id);
            if (!ModelState.IsValid)
            {
                return View(staff);
            }
            staffOld.staffName = staff.staffName;
            staffOld.salary = staff.salary;
            staffOld.email = staff.email;
            staffOld.phone = staff.phone;
            staffOld.gender = staff.gender;
            staffOld.address = staff.address;
            staffOld.deptID = staff.deptID;
            context.SaveChanges();
            return RedirectToAction("showStaff");
        }

        [HttpGet]
        public ActionResult showRoom()
        {
            HotelEntities7 context = new HotelEntities7();
            List<Rooms>room  = context.Rooms.ToList();
            ViewBag.gusID = new SelectList(context.Gusets,"gusID","gusName");
            return View(room);
        }
        [HttpGet]
        public ActionResult addRoom()
        {
            return View(new Rooms());
        }
        [HttpPost]
        public ActionResult addRoom(Rooms room)
        {
            if (context.Rooms.Any(u => u.roomType == room.roomType))
            {
                ModelState.AddModelError("", "this room type is already found");
                return View(room);
            }
            if (!ModelState.IsValid)
            {
                return View(room);
            }
            context.Rooms.Add(room);
            context.SaveChanges();
            return RedirectToAction("showRoom");
        }
        [HttpGet]
        public ActionResult deleteRoom()
        {
            return View();
        }
        [HttpPost]
        public ActionResult deleteRoom(Rooms room)
        {
           /* if (!ModelState.IsValid)
            {
                return View(room);
            }*/

            Rooms r = context.Rooms.Where(u => u.roomNum == room.roomNum).FirstOrDefault();
            context.Rooms.Remove(r);
            context.SaveChanges();
            return RedirectToAction("showRoom");
        }
        [HttpGet]
        public ActionResult editRoom(int? id)
        {
            ViewBag.gusID = new SelectList(context.Gusets, "gusID", "gusName");
            Rooms old = context.Rooms.FirstOrDefault(u => u.roomNum == id);
            return View(old);
        }
        [HttpPost]
        public ActionResult editRoom(int id, Rooms room)
        {

            Rooms old = context.Rooms.FirstOrDefault(u => u.roomNum == id);
            if (!ModelState.IsValid)
            {
                return View(room);
            }
            old.floorNum = room.floorNum;
            old.numberOfBed= room.numberOfBed;
            old.petFriendly = room.petFriendly;
            old.price = room.price;
            old.roomType = room.roomType;
            old.smoking= room.smoking;
            old.gusID = room.gusID;
            context.SaveChanges();
            return RedirectToAction("showRoom");
        }

    }
}