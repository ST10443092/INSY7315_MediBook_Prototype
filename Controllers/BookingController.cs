using DrBoyzin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrBoyzin.Controllers;

public class BookingController : Controller
{
    [HttpGet("booking")]
    public IActionResult Index(int? doctorId) => View(BuildPage(new BookingViewModel { DoctorId = doctorId ?? 1 }));

    [HttpPost("booking")]
    public IActionResult Index(BookingPageViewModel page)
    {
        ViewBag.Confirmed = true;
        return View(BuildPage(page.Booking));
    }

    private static BookingPageViewModel BuildPage(BookingViewModel booking) => new()
    {
        Booking = booking,
        Doctors = DemoData.Doctors.Where(x => x.IsAvailable).ToList(),
        Appointments = DemoData.Appointments().Where(x => x.Date >= DateTime.Today).Take(2).ToList()
    };
}
