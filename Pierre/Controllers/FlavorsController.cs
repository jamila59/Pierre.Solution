using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pierre.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierreContext _db;

    public FlavorsController(PierreContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }
    public ActionResult Create()
    {
        ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
        return View();
    }
    [HttpPost]
    public ActionResult Create(Flavor flavor, int TreatId)
    {
        _db.Flavors.Add(flavor);
        if (TreatId != 0)
        {
            _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

     public ActionResult Details(int id)
    {
      var thisFlavor = _db.Flavors
          .Include(flavor => flavor.Treats)
          .ThenInclude(join => join.Treat)
          .FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    } 
    public ActionResult Edit(int id)
    {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
        ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
        return View(thisFlavor);
    }
    [HttpPost]
    public ActionResult Edit(Flavor flavor, int TreatId)
    {
        if (TreatId != 0)
        {
          _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
        }
        _db.Entry(flavor).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    public ActionResult AddCategory(int id)
    {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
        ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
        return View(thisFlavor);
    }
    [HttpPost]
    public ActionResult AddTreat(Flavor flavor, int TreatId)
    {
        if (TreatId != 0)
        {
        _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}