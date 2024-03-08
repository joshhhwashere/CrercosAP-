using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrercosAPÍ.MODELS
{
    public class Cliente
    {
        //Clave Primaria
        [Key]
        public int ID { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public bool Estado { get; set; }
    }
}
