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

    public int Edad
    {
        get
        {
            var hoy = DateTime.Today;
            int edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }
    }


    public int Antiguedad
    {
        get
        {
            var hoy = DateTime.Today;
            int años = hoy.Year - FechaIngreso.Year;
            if (FechaIngreso.Date > hoy.AddYears(-años)) años--;
            return años;
        }
    }

    public int AñosParaJubilarse
    {
        get
        {
            return 65 - Edad;
        }
    }


    public double CalcularSalario()
    {
        double adicional;
        if (Antiguedad <= 20)
        {
            adicional = SueldoBasico * (Antiguedad * 0.01);
        }
        else
        {
            adicional = SueldoBasico * 0.25;
        }

        if (Cargo == Cargo.Ingeniero || Cargo == Cargo.Especialista)
        {
            adicional *= 1.5;
        }

        if (EstadoCivil == 'C')
        {
            adicional += 150000;
        }
        return SueldoBasico + adicional;  
    }


}
