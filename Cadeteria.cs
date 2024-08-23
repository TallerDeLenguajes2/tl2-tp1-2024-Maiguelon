using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadeteria
{
    public class Cadeteria
    {
        private List<Cadete> cadetes;
        private List<Pedido> pedidos;

        public Cadeteria()
        {
            cadetes = new List<Cadete>();
            pedidos = new List<Pedido>();
        }

        public void AgregarPedido(Pedido pedido, Cadete cadete)
        {
            pedidos.Add(pedido);
            cadete.AsignarPedido(pedido);
        }

        public void ReasignarPedido(Pedido pedido, Cadete nuevoCadete)
        {
            Cadete cadeteAnterior = pedido.CadeteAsignado;
            cadeteAnterior.EliminarPedido(pedido);
            nuevoCadete.AsignarPedido(pedido);
        }

        public void GenerarInforme()
        {
            foreach (var cadete in cadetes)
            {
                Console.WriteLine($"Cadete: {cadete.Nombre}, Entregas: {cadete.PedidosEntregados}, Monto Ganado: ${cadete.CalcularMontoGanado()}");
            }
            var promedio = cadetes.Average(c => c.PedidosEntregados);
            Console.WriteLine($"Promedio de envíos por cadete: {promedio}");
        }
    }
}
