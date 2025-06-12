namespace SisPersonal;

public enum Cargo
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public char EstadoCivil { get; set; } // 'C' para Casado, 'S' para Soltero
    public DateTime FechaIngreso { get; set; }
    public double SueldoBasico { get; set; }
    public Cargo Cargo { get; set; }

    // Constructor
    public Empleado(string nombre, string apellido, DateTime nacimiento, char estadoCivil, DateTime ingreso, double sueldo, Cargo cargo)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = nacimiento;
        EstadoCivil = estadoCivil;
        FechaIngreso = ingreso;
        SueldoBasico = sueldo;
        Cargo = cargo;
    }
}
