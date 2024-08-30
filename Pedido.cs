namespace Cadeteria;

public class Pedido
{
    private int numero;
    private string observacion;
    private Cliente cliente;

    public Pedido()
    {
        cliente = new Cliente();
    }

    public int Numero { get => numero; set => numero = value; }
    public string Observacion { get => observacion; set => observacion = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }

    public void VerDireccionCliente()
    {
        Console.WriteLine(Cliente.Direcion);
    }

    public void VerDatosCliente()
    {
        Console.WriteLine(Cliente.Nombre);
        Console.WriteLine(Cliente.Direcion);
        Console.WriteLine(Cliente.Telefono);
        Console.WriteLine(Cliente.DatosReferencia);
    }
}