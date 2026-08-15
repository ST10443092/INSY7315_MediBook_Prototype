namespace DrBoyzin.Models;

public class RegisterViewModel
{
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
}

public class LoginViewModel
{
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
}

public class AccountPageViewModel
{
    public RegisterViewModel Register { get; set; } = new();
    public LoginViewModel Login { get; set; } = new();
    public bool ShowLogin { get; set; }
}

public class BookingViewModel
{
    public int DoctorId { get; set; } = 1;
    public DateTime Date { get; set; } = DateTime.Today.AddDays(1);
    public string Time { get; set; } = "09:00";
    public string Reason { get; set; } = "";
}

public class BookingPageViewModel
{
    public BookingViewModel Booking { get; set; } = new();
    public List<DoctorRecord> Doctors { get; set; } = [];
    public List<AppointmentRecord> Appointments { get; set; } = [];
}

public class DoctorViewModel
{
    public string Name { get; set; } = "";
    public string Specialty { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
}
