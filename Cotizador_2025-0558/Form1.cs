namespace Cotizador_2025_0558
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHuesped.Text))
            {
                MessageBox.Show("Escribe el nombre del huésped.", "Falta un dato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHuesped.Focus();
                return;
            }

            if (!decimal.TryParse(nudTarifa.Text, out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser un número mayor que cero.", "Dato incorrecto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudTarifa.Focus();
                return;
            }

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text.Trim(),
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value,
                EsTemporadaAlta = chkTemporadaAlta.Checked
            };

            lblSubtotal.Text = reserva.Subtotal.ToString("N2");
            lblDescuento.Text = "-" + reserva.Descuento.ToString("N2");
            lblItbis.Text = reserva.Itbis.ToString("N2");
            lblServicio.Text = reserva.Servicio.ToString("N2");
            lblTotal.Text = reserva.Total.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHuesped.Clear();
            nudNoches.Value = 1;
            nudTarifa.Value = 1;
            chkTemporadaAlta.Checked = false;
            nudPersonas.Value = 1;
            nudTasa.Value = 0;
            chkFinSemana.Checked = false;
            chkNocturno.Checked = false;
            nudTarifaexcursion.Value = 1;
            nudCantidad.Value = 1;
            nudPrecioUnitario.Value = 1;
            nudPersonasExcursion.Value = 1;
            lstResultados.Items.Clear();

            lblSubtotal.Text = lblDescuento.Text = lblItbis.Text =
                lblServicio.Text = lblTotal.Text = "0.00";

            txtHuesped.Focus();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "0.00")
            {
                MessageBox.Show("Primero calcula una cotización.", "Nada que copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var texto = $"""
        *Cotización Villa Coral*
        Huésped: {txtHuesped.Text}
        Noches: {nudNoches.Value}
        Subtotal: US$ {lblSubtotal.Text}
        Descuento: US$ {lblDescuento.Text}
        ITBIS 18%: US$ {lblItbis.Text}
        Servicio 10%: US$ {lblServicio.Text}
        *TOTAL: US$ {lblTotal.Text}*
        """;

            Clipboard.SetText(texto);

            MessageBox.Show("Cotización copiada. Ya puedes pegarla en WhatsApp.", "Listo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImperativo_Click(object sender, EventArgs e)
        {
            string huesped = txtHuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(nudTarifa.Text);

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;
            if (noches >= 7)
            {
                descuento = subtotal * 0.10m;
            }
            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;

            lstResultados.Items.Add($"- Imperativo | {huesped} | US$ {total:N2}");
        }

        private void btnNivel1_Click(object sender, EventArgs e)
        {
            // 1.1
            int a = 10;
            int b = 3;
            int r1 = a / b;

            // 1.2
            decimal r2 = 10 / 4m;

            // 1.3
            int x = 5;
            x = x + 2;
            x = x * 3;

            // 1.4
            decimal p = 200m;
            decimal r = p * 0.18m;

            // 1.5
            int n = 7;
            decimal d = 0m;
            if (n > 7)
            {
                d = 50m;
            }

            // 1.6
            int n1 = 7;
            bool larga = n1 >= 7;

            // 1.7
            string s = "Villa" + "Coral";

            // 1.8
            int n2 = 4;
            decimal t = 100m;
            decimal total = n2 * t * 1.28m;

            //1.9
            decimal t1 = 120m;
            t1 = t1 + t1 * 0.25m;

            // 1.10
            int noches = (int)8.9m;

            var texto = $"""
        Nivel 1

        1.1: {r1}
        1.2: {r2:N2}
        1.3: {x}
        1.4: {r:N2}
        1.5: {d:N2}
        1.6: {larga}
        1.7: {s}
        1.8: {total:N2}
        1.9: {t1:N2}
        1.10: {noches}
        """;

            MessageBox.Show(texto, "Nivel 1",
        MessageBoxButtons.OK, MessageBoxIcon.Information); ;

        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text.Trim(),
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            decimal tasa = nudTasa.Value;
            decimal pesos = reserva.Total * tasa;
            lstResultados.Items.Add($"Total en Pesos: RD$ {pesos:N2}");

        }

        private void btnPorPersona_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text.Trim(),
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            decimal porPersona = reserva.Total / nudPersonas.Value;
            lstResultados.Items.Add($"Cada persona paga: US$ {porPersona:N2}");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text.Trim(),
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value

            };

            decimal deposito = reserva.Total * 0.30m;
            decimal saldo = reserva.Total - deposito;
            lstResultados.Items.Add($"Depósito 30%: US$ {deposito:N2}");
            lstResultados.Items.Add($"Saldo pendiente: US$ {saldo:N2}");
        }

        private void btnFinSemana_Click(object sender, EventArgs e)
        {
            decimal tarifa = nudTarifa.Value;

            if (chkFinSemana.Checked)
            {
                tarifa *= 1.15m;
            }

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text.Trim(),
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = tarifa

            };

            lstResultados.Items.Add($"Total con fin de semana: US$ {reserva.Total:N2}");

        }

        private void btnDesglose_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text.Trim(),
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value

            };

            lstResultados.Items.Add($"Subtota: US$ {reserva.Subtotal:N2}");
            lstResultados.Items.Add($"Descuento: US$ {reserva.Descuento:N2}");
            lstResultados.Items.Add($"Base imponible: US$ {reserva.BaseImponible:N2}");
            lstResultados.Items.Add($"Itbis 18%: US$ {reserva.Itbis:N2}");
            lstResultados.Items.Add($"Servicio 10%: US$ {reserva.Servicio:N2}");
            lstResultados.Items.Add($"Total: US$ {reserva.Total:N2}");

        }

        private void btnTraslado_Click(object sender, EventArgs e)
        {
            var traslado = new TrasladoAeropuerto
            {
                Pasajeros = (int)nudPersonas.Value,
                Nocturno = chkNocturno.Checked
            };

            lstResultados.Items.Add($"total de traslado incluido: US$ {traslado.Total:N2}");
        }

        private void bntExcursion_Click(object sender, EventArgs e)
        {
            var excursion = new Excursion
            {
                Personas = (int)nudPersonasExcursion.Value,
                PrecioPorPersona = nudTarifaexcursion.Value
            };

            if (excursion.Personas >= 4)
            {
                lstResultados.Items.Add($"Excursion Isla Saona: US$ {excursion.Subtotal:N2}");
                lstResultados.Items.Add($"Descuento 10%: -US$ {excursion.Descuento:N2}");
            }
            lstResultados.Items.Add($"Excursion Isla Saona: US$ {excursion.Total:N2}");
        }

        private void btnMiniBar_Click(object sender, EventArgs e)
        {
            var minibar = new ConsumoMinibar
            {
                Cantidad = (int)nudCantidad.Value,
                PrecioUnitario = nudPrecioUnitario.Value
            };

            lstResultados.Items.Add($"MiniBar: US$ {minibar.Total:N2}");
        }

        private void btnCuentaTotal_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text.Trim(),
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value,
                EsTemporadaAlta = chkTemporadaAlta.Checked
            };
            var traslado = new TrasladoAeropuerto
            {
                Pasajeros = (int)nudPersonas.Value,
                Nocturno = chkNocturno.Checked
            };
            var excursion = new Excursion
            {
                Personas = (int)nudPersonasExcursion.Value,
                PrecioPorPersona = nudTarifaexcursion.Value
            };
            var minibar = new ConsumoMinibar
            {
                Cantidad = (int)nudCantidad.Value,
                PrecioUnitario = nudPrecioUnitario.Value
            };

            decimal cuenta = reserva.Total + traslado.Total
                + excursion.Total + minibar.Total;
            lstResultados.Items.Add($"Reserva: US$ {reserva.Total:N2}");
            lstResultados.Items.Add($"Traslado al Aeropuerto: US$ {traslado.Total:N2}");
            lstResultados.Items.Add($"Excursion Isla Saona: US$ {excursion.Total:N2}");
            lstResultados.Items.Add($"Consumo en el MiniBar: US$ {minibar.Total:N2}");
            lstResultados.Items.Add($"Cuenta Total: US$ {cuenta:N2}");

        }

        private void btnViejo_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Add($"Deposito de 1000: {SistemaViejo.CalcularDeposito(1000m):N2} (debe dar 300.00)");
            lstResultados.Items.Add($"100 USD a tasa 60: {SistemaViejo.APesos(100m, 60m):N2} (debe dar 6,000.00)");
            lstResultados.Items.Add($"Tarifa 200 fin de semana: {SistemaViejo.TarifaFinDeSemana(200m, true):N2} (debe dar 230.00)");
            lstResultados.Items.Add($"Excursion 4 × 50: {SistemaViejo.TotalExcursion(4, 50m):N2} (debe dar 180.00)");
            lstResultados.Items.Add($"Minibar 3 × 4: {SistemaViejo.TotalMinibar(3, 4m):N2} (debe dar 14.16)");
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            decimal tasa = nudTasa.Value;
            decimal tarifa = SistemaViejo.TarifaFinDeSemana(nudTarifa.Value, chkFinSemana.Checked);

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text.Trim(),
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = tarifa,
                EsTemporadaAlta = chkTemporadaAlta.Checked
            };

            var traslado = new TrasladoAeropuerto
            {
                Pasajeros = (int)nudPersonas.Value,
                Nocturno = chkNocturno.Checked
            };

            var excursion = new Excursion
            {
                Personas = (int)nudPersonasExcursion.Value,
                PrecioPorPersona = nudTarifaexcursion.Value
            };

            var minibar = new ConsumoMinibar
            {
                Cantidad = (int)nudCantidad.Value,
                PrecioUnitario = nudPrecioUnitario.Value
            };

            decimal totalGeneral = reserva.Total + traslado.Total
                + excursion.Total + minibar.Total;

            decimal totalPesos = SistemaViejo.APesos(totalGeneral, tasa);
            decimal deposito = SistemaViejo.CalcularDeposito(totalGeneral);

            lstResultados.Items.Add("--- FACTURA DE LA ESTADIA ---");
            lstResultados.Items.Add($"Huésped: {reserva.Huesped}");
            lstResultados.Items.Add($"Reserva: US$ {reserva.Total:N2}");
            lstResultados.Items.Add($"Traslado: US$ {traslado.Total:N2}");
            lstResultados.Items.Add($"Excursion: US$ {excursion.Total:N2}");
            lstResultados.Items.Add($"Minibar: US$ {minibar.Total:N2}");
            lstResultados.Items.Add($"Total general: US$ {totalGeneral:N2}");
            lstResultados.Items.Add($"total general: RD$ {totalPesos:N2}");
            lstResultados.Items.Add($"Deposito 30%: US$ {deposito:N2}");
        }
    }
}
