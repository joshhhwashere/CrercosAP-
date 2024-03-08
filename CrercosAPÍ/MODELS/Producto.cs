﻿using System.ComponentModel.DataAnnotations;

namespace CrercosAPÍ.MODELS
{
    public class Producto
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public bool Estado { get; set; }
    }
}
