using System;
using CoordinacionConsultas;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un paciente
            Patient patient1 = new Patient("986782342", "Steven Jhonson", 45);

            // Crear un médico
            Doctor doctor1 = new Doctor("D12345", "Armand", "Cardiología");

            // Crear una cita médica
            Appointment appointment1 = new Appointment("A123", patient1, doctor1, DateTime.Now, "Wall Street");

            // Crear otra cita médica
            Patient patient2 = new Patient("789456123", "Ralf Manson", 30);
            Doctor doctor2 = new Doctor("D67890", "John Doe", "Pediatría");
            Appointment appointment2 = new Appointment("A456", patient2, doctor2, DateTime.Now, "Queen Street");

            // Programar la primera cita médica
            string appointmentResult1 = AppointmentService.CreateAppointment(appointment1);
            Console.WriteLine(appointmentResult1);

            // Programar la segunda cita médica
            string appointmentResult2 = AppointmentService.CreateAppointment(appointment2);
            Console.WriteLine(appointmentResult2);
        }
    }
}

//La clase Program tiene la responsabilidad de crear citas médicas y mostrar resultados en la consola. Esto viola el principio SRP, 
//ya que debería haber una separación de responsabilidades más clara.
//El código no realiza ninguna validación de los datos de entrada, lo que hace que la creación de citas médicas pueda tener  información incorrecta o faltante.