using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadeteria
{
    public class Cadete
    {
        public string Nombre { get; private set; }
        private List<Pedido> pedidos;

        public Cadete(string nombre)
        {
            Nombre = nombre;
            pedidos = new List<Pedido>();
        }

        public void AsignarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
            pedido.AsignarACadete(this);
        }

        public void EliminarPedido(Pedido pedido)
        {
            pedidos.Remove(pedido);
        }

        public int PedidosEntregados => pedidos.Count(p => p.Estado == EstadoPedido.Entregado);

        public double CalcularMontoGanado()
        {
            return PedidosEntregados * 500;
        }

    }
}
