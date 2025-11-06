
namespace Ejercicio1_models.Models;

public class Sistema
{
    public List<Paquete> listaPaquetes = new List<Paquete>();
    private List<Camion> listaCamiones = new List<Camion>();
    
    public Sistema()
    {
        listaCamiones.Add(new Camion(100, 100) );
        listaCamiones.Add(new Camion(101, 200));
        listaCamiones.Add(new Camion(102, 150));
    }

    public string[] CamionesCargados()
    {
        string[] cargaC = new string[listaCamiones.Count];

        int n = 0;
        foreach (Camion c in listaCamiones)
        {
            cargaC[n++] = c.Patente.ToString();
        }

        return cargaC;
    }

    public void Descargar(FileStream archivo)
    {
        StreamReader sr = new StreamReader(archivo);

        while (sr.EndOfStream == false)
        {
            string linea = sr.ReadLine();

            string[] datos = linea.Split(";");
            int nroRegistro = Convert.ToInt32(datos[0]);
            double peso = Convert.ToDouble(datos[1]);
            string zona = Convert.ToString(datos[2]);

            Paquete nuevo = new Paquete(nroRegistro, peso, zona);

            listaPaquetes.Add(nuevo);
        }

        sr.Close();
    }
}
