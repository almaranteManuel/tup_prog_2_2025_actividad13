
namespace Ejercicio1_models.Models;

public class Camion
{
    double pesoControl = 0;
    public int Patente { get; set; }
    public double PesoMax { get; set; }

    public Camion(int patente, double peso)
    {
        Patente = patente;
        PesoMax = peso;
    }
}
