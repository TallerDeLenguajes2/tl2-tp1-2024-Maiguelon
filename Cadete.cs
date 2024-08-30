namespace Cadeteria;

public class Cadete {
    private int id;
    private string nombre;
    private int direccion;
    private int telefono;
    private List<Pedido> listaPedidos;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
}