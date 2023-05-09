/*Instituto Tecnologico Superior de Cintalapa
Programación Orientada a Objetos
Alumno: Vladimir Durante Aguilar
Profesor: Jorge Ivan Bermudez Rodriguez
Unidad: 03
Examen
*/

using Examen;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al programa de nóminas");
        Console.WriteLine("¿Qué tipo de empleado es usted?");
        Console.WriteLine("1. Contratado");
        Console.WriteLine("2. A destajo");

        int opcion = int.Parse(Console.ReadLine());

        Empleado empleado;

        Console.WriteLine("Ingrese el ID del empleado:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nombre del empleado:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el apellido paterno del empleado:");
        string apellidoPaterno = Console.ReadLine();

        Console.WriteLine("Ingrese el apellido materno del empleado:");
        string apellidoMaterno = Console.ReadLine();

        Console.WriteLine("Ingrese la fecha de ingreso del empleado (DD/MM/AAAA):");
        DateTime fechaIngreso = DateTime.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.WriteLine("Ingrese los años de experiencia del empleado:");
            int aniosExperiencia = int.Parse(Console.ReadLine());

            empleado = new Empleado_Contratado
            {
                ID = id,
                Nombre = nombre,
                ApellidoPaterno = apellidoPaterno,
                ApellidoMaterno = apellidoMaterno,
                FechaIngreso = fechaIngreso,
                esContratado = true,
                AniosExperiencia = aniosExperiencia
            };

            double salario = ((Empleado_Contratado)empleado).CalcularSalario();
            Console.WriteLine($"ID: {empleado.ID}");
            Console.WriteLine($"Nombre: {empleado.Nombre} {empleado.ApellidoPaterno} {empleado.ApellidoMaterno}");
            Console.WriteLine($"Fecha de ingreso: {empleado.FechaIngreso.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Salario: {salario:C}");
        }
        else
        {
            Console.WriteLine("Ingrese el número de clientes del empleado:");
            int numClientes = int.Parse(Console.ReadLine());

            empleado = new Empleado_Destajo
            {
                ID = id,
                Nombre = nombre,
                ApellidoPaterno = apellidoPaterno,
                ApellidoMaterno = apellidoMaterno,
                FechaIngreso = fechaIngreso,
                esContratado = false,
                NumClientes = numClientes
            };

            double pago = ((Empleado_Destajo)empleado).CalcularPago();
            Console.WriteLine($"ID: {empleado.ID}");
            Console.WriteLine($"Nombre: {empleado.Nombre} {empleado.ApellidoPaterno} {empleado.ApellidoMaterno}");
            Console.WriteLine($"Fecha de ingreso: {empleado.FechaIngreso.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Pago: {pago:C}");
        }
    }
}
