using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizador_2025_0558
{
    public class TrasladoAeropuerto
    {
        private const decimal PrecioPorPasajero = 25m;
        private const decimal RecargoNocturno = 0.20m;
        public int Pasajeros { get; set; }
        public bool Nocturno { get; set; }
        public decimal Subtotal => Pasajeros * PrecioPorPasajero;
        public decimal Recargo => Nocturno ? Subtotal * RecargoNocturno : 0m;
        public decimal Total => Subtotal + Recargo;

    }
}
