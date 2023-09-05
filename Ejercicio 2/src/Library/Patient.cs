using System;

namespace CoordinacionConsultas
{
    public class Patient
    {
        public string Id { get; }
        public string Name { get; }
        public int Age { get; }

        public Patient(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Id) &&
                   !string.IsNullOrEmpty(Name) &&
                   Age > 0;
        }
    }
}
