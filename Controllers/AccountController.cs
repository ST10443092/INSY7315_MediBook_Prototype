using DrBoyzin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrBoyzin.Controllers;

public class AccountController : Controller
{
    [HttpGet("account")]
    public IActionResult Index(string? mode) => View(new AccountPageViewModel { ShowLogin = mode == "login" });

    [HttpPost("account/register")]
    public IActionResult Register() => RedirectToAction("Index", "Booking");

    [HttpPost("account/login")]
    public IActionResult Login() => RedirectToAction("Index", "Booking");
}
