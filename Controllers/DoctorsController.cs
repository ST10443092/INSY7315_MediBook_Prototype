using DrBoyzin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrBoyzin.Controllers;

public class DoctorsController : Controller
{
    [HttpGet("doctors/contact/{id:int?}")]
    public IActionResult Contact(int? id) => View(DemoData.Doctors.FirstOrDefault(x => x.Id == (id ?? 1)) ?? DemoData.Doctors[0]);

    [HttpGet("admin/doctors/add")]
    public IActionResult Add() => View(new DoctorViewModel());

    [HttpPost("admin/doctors/add")]
    public IActionResult Add(DoctorViewModel model)
    {
        ViewBag.Saved = true;
        return View(model);
    }
}
