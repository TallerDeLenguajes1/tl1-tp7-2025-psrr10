namespace EspacioCalculadora;
public class Calculadora
{
    private double dato = 0;
    private bool primeraOperacion = true;  // Nuevo flag para saber si es la primer op

    public void Sumar(double termino)
    {
        dato += termino;
        primeraOperacion = false;
    }

    public void Restar(double termino)
    {
        dato -= termino;
        primeraOperacion = false;
    }

    public void Multiplicar(double termino)
    {
        if (primeraOperacion)
        {
            dato = termino;  // Asignar el valor si es la primera operación
            primeraOperacion = false;
        }
        else
        {
            dato *= termino;
        }
    }

    public void Dividir(double termino)
    {
        if (termino == 0)
        {
            Console.WriteLine("No se puede dividir por cero.");
            return;
        }
        if (primeraOperacion)
        {
            dato = termino;
            primeraOperacion = false;
        }
        else
        {
            dato /= termino;
        }
    }

    public void Limpiar()
    {
        dato = 0;
        primeraOperacion = true;  // Resetear el flag al limpiar
    }

    public double Resultado
    {
        get { return dato; }
    }
}
