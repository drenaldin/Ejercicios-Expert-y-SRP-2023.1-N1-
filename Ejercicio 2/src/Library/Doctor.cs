using System;

namespace CoordinacionConsultas
{
    public class Doctor
    {
        public string Id { get; }
        public string Name { get; }
        public string Specialization { get; }

        public Doctor(string id, string name, string specialization)
        {
            Id = id;
            Name = name;
            Specialization = specialization;
        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Id) &&
                   !string.IsNullOrEmpty(Name) &&
                   !string.IsNullOrEmpty(Specialization);
        }
    }
}
