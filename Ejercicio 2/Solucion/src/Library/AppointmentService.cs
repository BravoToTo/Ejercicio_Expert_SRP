using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(Patient patient, DateTime date, string appointmentPlace, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
            
            if (patient.verifyData())
            {
                stringBuilder.Append("Unable to schedule appointment, incomplete patient data\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment place' is required\n");
                isValid = false;
            }

            if (doctor.verifyData())
            {
                stringBuilder.Append("Unable to schedule appointment, incomplete doctor data\n");
                isValid = false;
            }
            
            if (isValid)
            {
                stringBuilder.Append("appointment scheduled");
            }

            return stringBuilder.ToString();
        }
    }
}
