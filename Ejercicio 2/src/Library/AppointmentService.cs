// using System;
// using System.Text;

// namespace Library
// {
//     public class AppointmentService
//     {
//         public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
//         {
//             // Crear un StringBuilder para construir un mensaje
//             StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
//             Boolean isValid = true;

//             // Valida si el campo esta vacio
//             if (string.IsNullOrEmpty(name))
//             {
//                 // Agrega un mensaje de error al StringBuilder
//                 stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
//                 isValid = false;
//             }

//             // Valida si el campo esta vacio
//             if (string.IsNullOrEmpty(id))
//             {
//                 // Agrega un mensaje de error al StringBuilder
//                 stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
//                 isValid = false;
//             }

//             // Valida si el campo esta vacio
//             if (string.IsNullOrEmpty(phoneNumber))
//             {
//                 // Agrega un mensaje de error al StringBuilder
//                 stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
//                 isValid = false;
//             }

//             // Valida si el campo esta vacio
//             if (string.IsNullOrEmpty(appoinmentPlace))
//             {
//                 // Agregar un mensaje de error al StringBuilder
//                 stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
//                 isValid = false;
//             }

//             // Valida si el campo esta vacio
//             if (string.IsNullOrEmpty(doctorName))
//             {
//                 // Agregar un mensaje de error al StringBuilder
//                 stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
//                 isValid = false;
//             }

//             // Si todos los campos son validos se agrega un mensaje de exito
//             if (isValid)
//             {
//                 stringBuilder.Append("Appoinment scheduled");
//             }

//             // Retorna el mensaje construido como una cadena de texto
//             return stringBuilder.ToString();
//         }

//     }
// }


//Codigo reescrito con SRP

using System;

namespace CoordinacionConsultas
{
    public class AppointmentService
    {
        public static string CreateAppointment(Appointment appointment)
        {
            if (IsValidAppointment(appointment))
            {
                return "Cita médica programada correctamente.";
            }
            else
            {
                return "No se pudo programar la cita médica, algunos campos son inválidos.";
            }
        }

        private static bool IsValidAppointment(Appointment appointment)
        {
            return !string.IsNullOrEmpty(appointment.Id) &&
                   appointment.Patient.IsValid() &&
                   appointment.Doctor.IsValid() &&
                   appointment.Date != default(DateTime) &&
                   !string.IsNullOrEmpty(appointment.Place);
        }
    }
}
