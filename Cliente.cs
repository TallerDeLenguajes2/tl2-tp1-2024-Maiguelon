namespace Cadeteria
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }

        public Cliente(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}
