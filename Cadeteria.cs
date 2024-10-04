namespace EspacioCadeteria
{
    public class Cadeteria
    {
        private string nombre;
        private string numero;
        private List<Cadete> listaCadetes; // lista de cadetes

        // Constructor
        public Cadeteria()
        {
            listaCadetes = new List<Cadete>();
        }

        // Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Numero { get => numero; set => numero = value; }

        // Método para buscar cadetes por su ID
        public Cadete cadetePorId(int idCadete)
        {
            return listaCadetes.FirstOrDefault(cadete => cadete.Id == idCadete);
        }

        // Método para mover un pedido de un cadete a otro
        public void MoverPedido(int idNuevoCadete, int numeroPedido)
        {
            Cadete nuevoCadete = cadetePorId(idNuevoCadete);

            if (nuevoCadete == null)
            {
                Console.WriteLine("El nuevo cadete no existe.");
                return;
            }

            Pedido pedidoAMover = null;

            // Recorrer todos los cadetes para encontrar el pedido
            foreach (Cadete cadete in listaCadetes)
            {
                pedidoAMover = cadete.BuscarYEliminarPedido(numeroPedido);
                if (pedidoAMover != null)
                {
                    Console.WriteLine($"Pedido N°{numeroPedido} encontrado en {cadete.Nombre}. Se está moviendo a {nuevoCadete.Nombre}.");
                    break;  // Salimos del bucle cuando encontramos el pedido
                }
            }

            if (pedidoAMover != null)
            {
                // Agregar el pedido al nuevo cadete
                nuevoCadete.AgregarPedido(pedidoAMover);
                Console.WriteLine($"Pedido N°{numeroPedido} movido a {nuevoCadete.Nombre}.");
            }
            else
            {
                Console.WriteLine("El pedido no fue encontrado en ningún cadete.");
            }
        }
    }
}
