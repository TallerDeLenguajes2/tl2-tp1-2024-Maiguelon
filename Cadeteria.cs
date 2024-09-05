namespace Cadeteria;

public class Cadeteria
{
    private string nombre;
    private int numero;
    private List<Cadete> listaCadetes; // creo lista de cadetes que existirá cuando se cree cadetería
    public Cadeteria()
    {
        listaCadetes = new List<Cadete>();
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public int Numero { get => numero; set => numero = value; }
    public List<Cadete> ListaCadetes { get => listaCadetes; set => listaCadetes = value; }

    public Cadete cadetePorId(int idCadete)
    {
        return listaCadetes.FirstOrDefault(cadete => cadete.Id == idCadete);
    }

}
