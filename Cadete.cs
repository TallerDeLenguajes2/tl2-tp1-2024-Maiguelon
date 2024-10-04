namespace Cadeteria
{
    public class Cadete
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;
        private List<Pedido> listaPedidos;

        public Cadete()
        {
            listaPedidos = new List<Pedido>();
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public void JornalACobrar()
        {
            int jornal = listaPedidos.Count * 500;
            Console.WriteLine($"Jornal: {jornal}");
        }

        // Método para listar los pedidos
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

        // Método para buscar y eliminar un pedido
        public Pedido BuscarYEliminarPedido(int numeroPedido)
        {
            Pedido pedido = listaPedidos.FirstOrDefault(p => p.Numero == numeroPedido);

            if (pedido != null)
            {
                listaPedidos.Remove(pedido);  // Eliminar el pedido de la lista
                return pedido;  // Retornar el pedido eliminado
            }

            return null;  // Si no lo encuentra, retorna null
        }

        // Método para agregar un pedido
        public void AgregarPedido(Pedido pedido)
        {
            listaPedidos.Add(pedido);  // Agregar el pedido a la lista
        }
    }
}
