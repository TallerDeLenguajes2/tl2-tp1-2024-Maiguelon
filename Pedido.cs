namespace Cadeteria;

public class Pedido {
    private int numero;
    private string observacion;
    private Cliente cliente;
    public Pedido()
    {
    }

    public int Numero { get => numero; set => numero = value; }
    public string Observacion { get => observacion; set => observacion = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }
}