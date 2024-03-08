using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrercosAPÍ.MODELS
{
    public class Pedido
    {
        //Clave Primaria
        [Key]
        public int  ID { get; set; }
        public DateTime Fecha { get; set; }
        //Clave Foránea
        [ForeignKey(nameof(Cliente))]
        public int ClienteID { get; set; }
    }
}
