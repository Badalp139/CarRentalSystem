using CarRentalSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRentalSystem.Controllers
{

    public class ReturnCarController : Controller
    {
        CarRentalSystemEntities db = new CarRentalSystemEntities();

        
        public ActionResult Save(ReturnCar recar)
        {
            if(ModelState.IsValid)
            {
                db.ReturnCars.Add(recar);

                var car = db.CarRegs.SingleOrDefault(e => e.Carno == recar.Carno);

                if (car == null)
                    return HttpNotFound("CarNo Not Found");
                car.Available = "yes";
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recar);
        }
        // GET: ReturnCar
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Getid(String Carno)
        {
            var carn = (from s in db.Rentails
                        where s.Carid == Carno
                        select new
                        {
                            Startdate = s.Sdate,
                            EndDate = s.Edate,
                            Custid = s.Custid,
                            CarNo = s.Carid,
                            Fee = s.Fee,
                            ElapseDays = SqlFunctions.DateDiff("day", s.Edate, DateTime.Now)



                        }).ToArray();

            return Json(carn, JsonRequestBehavior.AllowGet);
            

        }
    }
}