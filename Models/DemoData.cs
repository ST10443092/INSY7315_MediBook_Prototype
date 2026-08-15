namespace DrBoyzin.Models;

public static class DemoData
{
    public static readonly List<DoctorRecord> Doctors =
    [
        new() { Id = 1, Name = "Dr. Boyzin", Specialty = "General Practice", Email = "dr.boyzin@medibook.health", Phone = "0800 123 456" },
        new() { Id = 2, Name = "Dr. Naledi Mokoena", Specialty = "Paediatrics", Email = "naledi.mokoena@medibook.health", Phone = "0800 123 457" },
        new() { Id = 3, Name = "Dr. Ethan Naidoo", Specialty = "Dermatology", Email = "ethan.naidoo@medibook.health", Phone = "0800 123 458" },
        new() { Id = 4, Name = "Dr. Amahle Dlamini", Specialty = "Cardiology", Email = "amahle.dlamini@medibook.health", Phone = "0800 123 459" },
        new() { Id = 5, Name = "Dr. Liam Jacobs", Specialty = "Orthopaedics", Email = "liam.jacobs@medibook.health", Phone = "0800 123 460" },
        new() { Id = 6, Name = "Dr. Zinhle Khumalo", Specialty = "Obstetrics & Gynaecology", Email = "zinhle.khumalo@medibook.health", Phone = "0800 123 461", IsAvailable = false }
    ];

    public static List<AppointmentRecord> Appointments()
    {
        var doctor = Doctors[0];
        return
        [
            NewAppointment(1, DateTime.Today, "09:00", "Annual check-up", "Confirmed", "Thando Nkosi", "thando@example.com", doctor),
            NewAppointment(2, DateTime.Today, "10:30", "Follow-up consultation", "Confirmed", "Amina Patel", "amina@example.com", doctor),
            NewAppointment(3, DateTime.Today.AddDays(2), "14:00", "Recurring headaches", "Confirmed", "Lerato Molefe", "lerato@example.com", doctor),
            NewAppointment(4, DateTime.Today.AddDays(5), "15:30", "General consultation", "Confirmed", "Sipho Dube", "sipho@example.com", doctor),
            NewAppointment(5, DateTime.Today.AddDays(-3), "11:00", "Wellness review", "Completed", "Mia Adams", "mia@example.com", doctor)
        ];
    }

    private static AppointmentRecord NewAppointment(int id, DateTime date, string time, string reason, string status, string name, string email, DoctorRecord doctor) =>
        new() { Id = id, Date = date, Time = time, Reason = reason, Status = status, User = new() { FullName = name, Email = email }, Doctor = doctor };
}
