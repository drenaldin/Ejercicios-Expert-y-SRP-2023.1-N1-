using System;

namespace CoordinacionConsultas
{
    public class Appointment
    {
        public string Id { get; }
        public Patient Patient { get; }
        public Doctor Doctor { get; }
        public DateTime Date { get; }
        public string Place { get; }

        public Appointment(string id, Patient patient, Doctor doctor, DateTime date, string place)
        {
            Id = id;
            Patient = patient;
            Doctor = doctor;
            Date = date;
            Place = place;
        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Id) &&
                   Patient != null &&
                   Doctor != null &&
                   Date != default(DateTime) &&
                   !string.IsNullOrEmpty(Place);
        }
    }
}
