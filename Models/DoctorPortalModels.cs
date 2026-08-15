namespace DrBoyzin.Models;

public class DoctorRecord
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Specialty { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public bool IsAvailable { get; set; } = true;
    public string AvailableFrom { get; set; } = "08:00";
    public string AvailableTo { get; set; } = "17:00";
}

public class DemoPatient
{
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
}

public class AppointmentRecord
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; } = "";
    public string Reason { get; set; } = "";
    public string Status { get; set; } = "Confirmed";
    public DemoPatient User { get; set; } = new();
    public DoctorRecord Doctor { get; set; } = new();
}

public class DoctorDashboardViewModel
{
    public DoctorRecord Doctor { get; set; } = new();
    public List<AppointmentRecord> Today { get; set; } = [];
    public List<AppointmentRecord> Upcoming { get; set; } = [];
    public int TotalPatients { get; set; }
}

public class DoctorPatientsViewModel
{
    public int UpcomingClients { get; set; }
    public int ConsultedClients { get; set; }
    public int CompletedConsultations { get; set; }
    public int CancelledAppointments { get; set; }
    public int ConsultationsThisMonth { get; set; }
    public int CompletionRate { get; set; }
    public List<AppointmentRecord> Upcoming { get; set; } = [];
    public List<AppointmentRecord> RecentConsultations { get; set; } = [];
}

public class DoctorAvailabilityViewModel
{
    public bool IsAvailable { get; set; }
    public string AvailableFrom { get; set; } = "08:00";
    public string AvailableTo { get; set; } = "17:00";
}

public class DoctorProfileViewModel
{
    public string Name { get; set; } = "";
    public string Specialty { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
}
