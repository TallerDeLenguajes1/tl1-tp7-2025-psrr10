using System;
using SisPersonal;

class Programa
{
    static void Main()
    {
        Empleado[] empleados = new Empleado[3];

        empleados[0] = new Empleado("Ana", "Gómez", new DateTime(1985, 6, 20), 'C', new DateTime(2010, 4, 1), 650000, Cargo.Ingeniero);

        empleados[1] = new Empleado("Luis", "Pérez", new DateTime(1965, 8, 15), 'S', new DateTime(2015, 3, 10), 500000, Cargo.Auxiliar);

        empleados[2] = new Empleado("María", "López", new DateTime(1972, 12, 5), 'C', new DateTime(2000, 1, 1), 700000, Cargo.Especialista);

        Console.WriteLine("Empleados cargados correctamente");

        double totalSalarios = 0;
        foreach (Empleado e in empleados)
        {
            totalSalarios = totalSalarios + e.CalcularSalario();
        }


        Console.WriteLine($"Monto total pagado en salarios = ${totalSalarios}");

        Empleado proximo = empleados[0];
        foreach (Empleado e in empleados)
        {
            if (e.AñosParaJubilarse < proximo.AñosParaJubilarse)
            {
                proximo = e;
            }
        }

        Console.WriteLine("\n🧓 Empleado más próximo a jubilarse:");
        Console.WriteLine($"Nombre: {proximo.Nombre} {proximo.Apellido}");
        Console.WriteLine($"Edad: {proximo.Edad}");
        Console.WriteLine($"Antigüedad: {proximo.Antiguedad} años");
        Console.WriteLine($"Años para jubilarse: {proximo.AñosParaJubilarse}");
        Console.WriteLine($"Salario: ${proximo.CalcularSalario()}");



    }
}