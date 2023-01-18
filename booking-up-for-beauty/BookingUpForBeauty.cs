using System;
using System.Runtime.InteropServices.JavaScript;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        var parsedDate = DateTime.Parse(appointmentDateDescription);
        return parsedDate;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        bool truth = false;
        var currentTime = DateTime.Now;
        if (currentTime > appointmentDate)
        {
            truth = true;
        };
        return truth;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        bool truth = false;
        var hour = appointmentDate.Hour;
        if (hour >= 12 && hour < 18)
        {
            truth = true;
        }

        return truth;
    }

    public static string Description(DateTime appointmentDate)
    {
        var stringTime = appointmentDate.ToString("G");
        return $"You have an appointment on {stringTime}.";
    }

    public static DateTime AnniversaryDate()
    {
        var date = new DateTime(2023, 9, 15);
        return date;
    }
}
