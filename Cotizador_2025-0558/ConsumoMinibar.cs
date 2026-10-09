using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizador_2025_0558
{
    public class ConsumoMinibar
    {
        private const decimal TasaItbis = 0.18m;
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario;
        public decimal Itbis => Subtotal * TasaItbis;
        public decimal Total => Subtotal + Itbis;

    }
}
