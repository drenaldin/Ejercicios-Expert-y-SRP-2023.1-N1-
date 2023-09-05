# Ejercicio del tema Expert & SRP-Sistema de consultas médicas
## Programación II
### FIT - Universidad Católica del Uruguay

Como desarrolladores de software, se nos pide hacer el mantenimiento de un sistema de gestión médica, especifícamente se nos pide que hagamos mantenimiento de la funcionalidad de coordinación de consultas. Para ello debemos tener en cuenta que:
1. Se podrían agregar otros datos del paciente como por ejemplo su edad.
2. Se podrían agregar otros datos al Doctor como por ejemplo su especialidad.
3. La consulta debe tener un identificador único
4. Cada dato que se ingrese al sistema debe ser válidado.

Para el ejercicio se pide:

Parte 1: Crítica al código

Nomenclatura poco clara: Los nombres de las variables y métodos deberían ser más descriptivos. Por ejemplo, id podría ser patientId, y isValid podría ser isValidAppointment.

Exceso de responsabilidad: La clase AppointmentService realiza tareas de validación y generación de mensajes. Sería mejor separar estas responsabilidades en métodos diferentes.

Duplicación de código: Hay repetición de código para verificar si las cadenas son nulas o vacías.

Falta de manejo de excepciones: El código actual no maneja excepciones en caso de problemas durante la creación de la cita médica.



PParte 2: Realización de las CRC correspondientes

Para la Coordinación de Consultas, necesitamos identificar las Clases, Responsabilidades y Colaboraciones (CRC):

Clase Appointment
Responsabilidades:
Almacenar datos de una cita médica.
Validar los datos de la cita médica.
Colaboraciones:
Puede colaborar con una clase Patient para almacenar información del paciente.
Puede colaborar con una clase Doctor para almacenar información del médico.


Clase Patient
Responsabilidades:
Almacenar datos del paciente.
Validar los datos del paciente.
Colaboraciones:
Puede colaborar con la clase Appointment para asociarse con una cita médica.

Clase Doctor
Responsabilidades:
Almacenar datos del médico.
Validar los datos del médico.
Colaboraciones:
Puede colaborar con la clase Appointment para asociarse con una cita médica.

Clase AppointmentService
Responsabilidades:
Crear una cita médica.
Validar los datos de entrada para la cita.
Colaboraciones:
Puede colaborar con las clases Appointment, Patient, y Doctor para crear y validar citas médicas.



Parte 3: Aplicar patrones/principios según la crítica

