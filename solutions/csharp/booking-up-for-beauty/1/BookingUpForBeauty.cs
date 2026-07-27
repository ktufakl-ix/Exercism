static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime.TryParse(appointmentDateDescription, out var date);
        return date;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        if(appointmentDate<DateTime.Now)
        {
            return true;
        }
        return false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if (12 <=appointmentDate.Hour && appointmentDate.Hour < 18)
            return true;
        return false;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}
