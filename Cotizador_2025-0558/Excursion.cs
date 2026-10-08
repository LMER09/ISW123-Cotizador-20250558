using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizador_2025_0558
{
    public class Excursion
    {
        private const decimal ExcursionDescuento = 0.10m;
        private const int PersonasMinimas = 4;

        public int Personas { get; set; }
        public decimal PrecioPorPersona { get; set; }

        public decimal Subtotal => Personas * PrecioPorPersona;

        public decimal Descuento => Personas >= 
            PersonasMinimas ? Subtotal * ExcursionDescuento : 0m;
        public decimal Total => Subtotal - Descuento;

    }
}
