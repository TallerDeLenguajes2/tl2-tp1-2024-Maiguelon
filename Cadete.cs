namespace Cadeteria;

public class Cadete
{
    private int id;
    private string nombre;
    private int direccion;
    private int telefono;
    private List<Pedido> listaPedidos;

    public Cadete()
    {
        listaPedidos = new List<Pedido>();
    }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }

    public void JornalACobrar()
    {
        int jornal = listaPedidos.Count * 500;
        Console.WriteLine($"Jornal: {jornal}");
    }

    // El método solo escribe hasta la observación
    public void listarPedidos()
    {
        if (listaPedidos.Count == 0)
        {
            Console.WriteLine("No hay pedidos asignados.");
        }
        else
        {
            foreach (Pedido pedido in listaPedidos)
            {
                Console.WriteLine($"Pedido N° {pedido.Numero}, Observación: {pedido.Observacion}");
            }
        }
    }

}