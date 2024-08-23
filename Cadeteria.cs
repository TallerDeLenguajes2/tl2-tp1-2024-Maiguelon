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
    }
}
