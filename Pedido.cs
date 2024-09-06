namespace Cadeteria;

public class Pedido
{
    private int numero;
    private string observacion;
    private Cliente cliente;
    private EstadoPedido estado;

    public Pedido()
    {
        cliente = new Cliente();
    }

    public int Numero { get => numero; set => numero = value; }
    public string Observacion { get => observacion; set => observacion = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }
    public EstadoPedido Estado { get => estado; set => estado = value; }

    public void VerDireccionCliente()
    {
        Console.WriteLine(Cliente.Direccion);
    }

    public void VerDatosCliente()
    {
        Console.WriteLine(Cliente.Nombre);
        Console.WriteLine(Cliente.Direccion);
        Console.WriteLine(Cliente.Telefono);
        Console.WriteLine(Cliente.DatosReferencia);
    }
}