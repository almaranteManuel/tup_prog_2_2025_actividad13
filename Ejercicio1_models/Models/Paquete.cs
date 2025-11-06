
namespace Ejercicio1_models.Models;

public class Paquete
{

    public int NroRegistro {  get; set; }
    public double Peso { get; set; }
    public string ZonaDestino { get; set; }

    public Paquete(int Id, double peso, string zona)
    {
        NroRegistro = Id;
        Peso = peso;
        ZonaDestino = zona;
    }

    public override string ToString()
    {
        return $"{NroRegistro};{Peso};{ZonaDestino}";
    }
}
