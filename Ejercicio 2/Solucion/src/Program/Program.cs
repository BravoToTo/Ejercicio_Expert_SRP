using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient P1 = new Patient("Steven Jhonson", "24", "5555-555-555", "986782342");
            Patient P2 = new Patient("Ralf Manson", "39", "5555-555-555", "");
            Doctor D1 = new Doctor("Armand", "Neurosurgeon");
            Doctor D2 = new Doctor("", "Cardiologist");

            string appointmentResult = AppointmentService.CreateAppointment(P1, DateTime.Now, "Wall Street", D1);
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment(P2, DateTime.Now, "Queen Street", D2);
            Console.WriteLine(appointmentResult2);
        }
    }
}
