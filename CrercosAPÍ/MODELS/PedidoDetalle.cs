using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrercosAPÍ.MODELS
{
    public class PedidoDetalle
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey(nameof(Pedido))]
        public int PedidoID { get; set; }
        [ForeignKey(nameof(Producto))]
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        //este es el valor variable, es el valor que va a cambiar
        //y podemos consultar si hubo cambios en el precio
        public decimal Costo { get; set; }
    }
}
