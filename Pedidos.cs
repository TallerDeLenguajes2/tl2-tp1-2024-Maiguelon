namespace Cadeteria
{
    public class Pedido
    {
        public Cliente Cliente { get; private set; }
        public Cadete CadeteAsignado { get; private set; }
        public EstadoPedido Estado { get; private set; }

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Estado = EstadoPedido.Asignado;
        }

        public void AsignarACadete(Cadete cadete)
        {
            CadeteAsignado = cadete;
        }

        public void CambiarEstado(EstadoPedido nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        // Estado pedido

        public enum EstadoPedido
        {
            Asignado,
            EnCamino,
            Entregado
        }
    }
}
