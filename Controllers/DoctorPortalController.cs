using DrBoyzin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrBoyzin.Controllers;

public class DoctorPortalController : Controller
{
    [HttpGet("doctor/dashboard")]
    public IActionResult Dashboard()
    {
        var appointments = DemoData.Appointments();
        return View(new DoctorDashboardViewModel
        {
            Doctor = DemoData.Doctors[0],
            Today = appointments.Where(x => x.Date.Date == DateTime.Today).ToList(),
            Upcoming = appointments.Where(x => x.Date.Date > DateTime.Today).ToList(),
            TotalPatients = 5
        });
    }

    [HttpGet("doctor/patients")]
    public IActionResult Patients()
    {
        var appointments = DemoData.Appointments();
        var upcoming = appointments.Where(x => x.Date >= DateTime.Today && x.Status == "Confirmed").ToList();
        var completed = appointments.Where(x => x.Status == "Completed").ToList();
        return View(new DoctorPatientsViewModel
        {
            UpcomingClients = upcoming.Count,
            ConsultedClients = completed.Count,
            CompletedConsultations = completed.Count,
            ConsultationsThisMonth = completed.Count,
            CompletionRate = 92,
            Upcoming = upcoming,
            RecentConsultations = completed
        });
    }

    [HttpPost("doctor/appointments/{id:int}/status")]
    public IActionResult UpdateStatus(int id, string status) => RedirectToAction(nameof(Dashboard));

    [HttpGet("doctor/availability")]
    public IActionResult Availability() => View(new DoctorAvailabilityViewModel { IsAvailable = true });

    [HttpPost("doctor/availability")]
    public IActionResult Availability(DoctorAvailabilityViewModel model)
    {
        ViewBag.Saved = true;
        return View(model);
    }

    [HttpPost("doctor/availability/toggle")]
    public IActionResult ToggleAvailability() => RedirectToAction(nameof(Dashboard));

    [HttpGet("doctor/profile")]
    public IActionResult Profile() => View(new DoctorProfileViewModel
    {
        Name = DemoData.Doctors[0].Name,
        Specialty = DemoData.Doctors[0].Specialty,
        Email = DemoData.Doctors[0].Email,
        Phone = DemoData.Doctors[0].Phone
    });

    [HttpPost("doctor/profile")]
    public IActionResult Profile(DoctorProfileViewModel model)
    {
        ViewBag.Saved = true;
        return View(model);
    }
}
