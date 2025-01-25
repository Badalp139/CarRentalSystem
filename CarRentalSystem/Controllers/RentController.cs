using CarRentalSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRentalSystem.Controllers
{
    public class RentController : Controller
    {
        CarRentalSystemEntities db = new CarRentalSystemEntities();

        // GET: Rent
        public ActionResult Index()
        {
            var result = (from r in db.Rentails
                          join c in db.CarRegs on r.Carid equals c.Carno
                          select new RentailViewModel
                          {
                              id = r.id,
                              Carid = r.Carid,
                              Custid = r.Custid,
                              Fee = r.Fee,
                              Sdate = r.Sdate,
                              Edate = r.Edate,
                              Available = c.Available


                          }).ToList();

            return View(result);
        }

        [HttpGet]
        public ActionResult GetCar()
        {
            var car = db.CarRegs.ToList();
            return Json(car, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public ActionResult Getid(int id)
        {
            var customer = (from s in db.Customers where s.Id == id select s.CustName).ToList();
            return Json(customer, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult Getavil(String Carno)
        {
            var caravil = (from s in db.CarRegs where s.Carno == Carno select s.Available).FirstOrDefault();
            return Json(caravil, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult Save(Rentail Rent)
        {
           
            if (ModelState.IsValid)
            {
                db.Rentails.Add(Rent);

                var car = db.CarRegs.SingleOrDefault(e => e.Carno == Rent.Carid);
                if(car == null)
                
                   return HttpNotFound("CarNo is not Valid");

                    car.Available = "no";
                    db.Entry(car).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");       
            }
            return View(Rent);
        }

    }
}