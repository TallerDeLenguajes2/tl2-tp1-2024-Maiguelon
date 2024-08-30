namespace Cadeteria;

public class Cliente {
    private string nombre;
    private string direcion;
    private string telefono;
    private string datosReferencia; // referencia de direccion

    public string Nombre { get => nombre; set => nombre = value; }
    public string Direcion { get => direcion; set => direcion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string DatosReferencia { get => datosReferencia; set => datosReferencia = value; }
}