namespace Cotizador_2025_0558
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbCotizador = new GroupBox();
            btnDesglose = new Button();
            btnLimpiar = new Button();
            btnCopiar = new Button();
            lblTasa = new Label();
            lblElija = new Label();
            btnPorPersonas = new Button();
            nudPersonas = new NumericUpDown();
            nudTasa = new NumericUpDown();
            nudTarifa = new NumericUpDown();
            chkTemporadaAlta = new CheckBox();
            nudNoches = new NumericUpDown();
            lblTarifa = new Label();
            lblNoches = new Label();
            txtHuesped = new TextBox();
            lblHuesped = new Label();
            gbTotales = new GroupBox();
            btnPesos = new Button();
            btnCalcular = new Button();
            btnFactura = new Button();
            btnCuentaTotal = new Button();
            lblTotal = new Label();
            lblServicio = new Label();
            lblItbis = new Label();
            lblDescuento = new Label();
            lblSubtotal = new Label();
            lblTot = new Label();
            lblServi = new Label();
            lblItb = new Label();
            lblDes = new Label();
            lblSub = new Label();
            lstResultados = new ListBox();
            gbOtrosServicios = new GroupBox();
            btnViejo = new Button();
            chkNocturno = new CheckBox();
            btnTraslado = new Button();
            chkFinSemana = new CheckBox();
            btnFinSemana = new Button();
            lblPrecioUnitario = new Label();
            nudCantidad = new NumericUpDown();
            lblCantidadMini = new Label();
            nudPrecioUnitario = new NumericUpDown();
            btnMiniBar = new Button();
            bntExcursion = new Button();
            nudTarifaexcursion = new NumericUpDown();
            lblTarifaExcursion = new Label();
            btnImperativo = new Button();
            btnNivel1 = new Button();
            gbCotizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbTotales.SuspendLayout();
            gbOtrosServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifaexcursion).BeginInit();
            SuspendLayout();
            // 
            // gbCotizador
            // 
            gbCotizador.BackColor = Color.AliceBlue;
            gbCotizador.Controls.Add(btnDesglose);
            gbCotizador.Controls.Add(btnLimpiar);
            gbCotizador.Controls.Add(btnCopiar);
            gbCotizador.Controls.Add(lblTasa);
            gbCotizador.Controls.Add(lblElija);
            gbCotizador.Controls.Add(btnPorPersonas);
            gbCotizador.Controls.Add(nudPersonas);
            gbCotizador.Controls.Add(nudTasa);
            gbCotizador.Controls.Add(nudTarifa);
            gbCotizador.Controls.Add(chkTemporadaAlta);
            gbCotizador.Controls.Add(nudNoches);
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(txtHuesped);
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Location = new Point(34, 12);
            gbCotizador.Margin = new Padding(4, 3, 4, 3);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Padding = new Padding(4, 3, 4, 3);
            gbCotizador.Size = new Size(495, 396);
            gbCotizador.TabIndex = 1;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // btnDesglose
            // 
            btnDesglose.Location = new Point(270, 286);
            btnDesglose.Name = "btnDesglose";
            btnDesglose.Size = new Size(206, 36);
            btnDesglose.TabIndex = 50;
            btnDesglose.Text = "Desglose";
            btnDesglose.UseVisualStyleBackColor = true;
            btnDesglose.UseWaitCursor = true;
            btnDesglose.Click += btnDesglose_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(270, 328);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(206, 36);
            btnLimpiar.TabIndex = 49;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(26, 328);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(223, 36);
            btnCopiar.TabIndex = 48;
            btnCopiar.Text = "Copiar a WhatsApp";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.Location = new Point(270, 170);
            lblTasa.Margin = new Padding(4, 0, 4, 0);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(127, 23);
            lblTasa.TabIndex = 24;
            lblTasa.Text = "Tasa del dólar:";
            // 
            // lblElija
            // 
            lblElija.AutoSize = true;
            lblElija.Location = new Point(270, 101);
            lblElija.Margin = new Padding(4, 0, 4, 0);
            lblElija.Name = "lblElija";
            lblElija.Size = new Size(188, 23);
            lblElija.TabIndex = 23;
            lblElija.Text = "Cantidad de personas:";
            // 
            // btnPorPersonas
            // 
            btnPorPersonas.Location = new Point(26, 286);
            btnPorPersonas.Name = "btnPorPersonas";
            btnPorPersonas.Size = new Size(223, 36);
            btnPorPersonas.TabIndex = 18;
            btnPorPersonas.Text = "Pago de c/perosona";
            btnPorPersonas.UseVisualStyleBackColor = true;
            btnPorPersonas.UseWaitCursor = true;
            btnPorPersonas.Click += btnPorPersona_Click;
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(278, 127);
            nudPersonas.Margin = new Padding(4, 3, 4, 3);
            nudPersonas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(198, 30);
            nudPersonas.TabIndex = 13;
            nudPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudTasa
            // 
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(278, 196);
            nudTasa.Margin = new Padding(4, 3, 4, 3);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(198, 30);
            nudTasa.TabIndex = 9;
            nudTasa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudTarifa
            // 
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Location = new Point(26, 196);
            nudTarifa.Margin = new Padding(4, 3, 4, 3);
            nudTarifa.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            nudTarifa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(223, 30);
            nudTarifa.TabIndex = 8;
            nudTarifa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkTemporadaAlta
            // 
            chkTemporadaAlta.AutoSize = true;
            chkTemporadaAlta.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkTemporadaAlta.ForeColor = Color.Red;
            chkTemporadaAlta.Location = new Point(26, 242);
            chkTemporadaAlta.Margin = new Padding(4, 3, 4, 3);
            chkTemporadaAlta.Name = "chkTemporadaAlta";
            chkTemporadaAlta.Size = new Size(234, 29);
            chkTemporadaAlta.TabIndex = 7;
            chkTemporadaAlta.Text = "Temporada alta (+25%)";
            chkTemporadaAlta.UseVisualStyleBackColor = true;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(26, 127);
            nudNoches.Margin = new Padding(4, 3, 4, 3);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(223, 30);
            nudNoches.TabIndex = 6;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(26, 170);
            lblTarifa.Margin = new Padding(4, 0, 4, 0);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(186, 23);
            lblTarifa.TabIndex = 4;
            lblTarifa.Text = "Tarifa por noche USD:";
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(26, 101);
            lblNoches.Margin = new Padding(4, 0, 4, 0);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(72, 23);
            lblNoches.TabIndex = 2;
            lblNoches.Text = "Noches:";
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(26, 62);
            txtHuesped.Margin = new Padding(4, 3, 4, 3);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(450, 30);
            txtHuesped.TabIndex = 1;
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(26, 36);
            lblHuesped.Margin = new Padding(4, 0, 4, 0);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(85, 23);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped:";
            // 
            // gbTotales
            // 
            gbTotales.BackColor = Color.AliceBlue;
            gbTotales.Controls.Add(btnPesos);
            gbTotales.Controls.Add(btnCalcular);
            gbTotales.Controls.Add(btnFactura);
            gbTotales.Controls.Add(btnCuentaTotal);
            gbTotales.Controls.Add(lblTotal);
            gbTotales.Controls.Add(lblServicio);
            gbTotales.Controls.Add(lblItbis);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lblSubtotal);
            gbTotales.Controls.Add(lblTot);
            gbTotales.Controls.Add(lblServi);
            gbTotales.Controls.Add(lblItb);
            gbTotales.Controls.Add(lblDes);
            gbTotales.Controls.Add(lblSub);
            gbTotales.Location = new Point(537, 12);
            gbTotales.Margin = new Padding(4, 3, 4, 3);
            gbTotales.Name = "gbTotales";
            gbTotales.Padding = new Padding(4, 3, 4, 3);
            gbTotales.Size = new Size(377, 396);
            gbTotales.TabIndex = 8;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(17, 258);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(323, 36);
            btnPesos.TabIndex = 64;
            btnPesos.Text = "Total en RD$";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(17, 216);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(323, 36);
            btnCalcular.TabIndex = 63;
            btnCalcular.Text = "Calcular USD$";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(17, 342);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(323, 36);
            btnFactura.TabIndex = 62;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnCuentaTotal
            // 
            btnCuentaTotal.Location = new Point(17, 300);
            btnCuentaTotal.Name = "btnCuentaTotal";
            btnCuentaTotal.Size = new Size(323, 36);
            btnCuentaTotal.TabIndex = 61;
            btnCuentaTotal.Text = "Cuenta Total";
            btnCuentaTotal.UseVisualStyleBackColor = true;
            btnCuentaTotal.Click += btnCuentaTotal_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(228, 155);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 28);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(236, 123);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(45, 23);
            lblServicio.TabIndex = 9;
            lblServicio.Text = "0.00";
            lblServicio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(236, 95);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(45, 23);
            lblItbis.TabIndex = 8;
            lblItbis.Text = "0.00";
            lblItbis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(236, 65);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(45, 23);
            lblDescuento.TabIndex = 7;
            lblDescuento.Text = "0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(236, 36);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(45, 23);
            lblSubtotal.TabIndex = 6;
            lblSubtotal.Text = "0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTot
            // 
            lblTot.AutoSize = true;
            lblTot.Location = new Point(26, 160);
            lblTot.Margin = new Padding(4, 0, 4, 0);
            lblTot.Name = "lblTot";
            lblTot.Size = new Size(94, 23);
            lblTot.TabIndex = 5;
            lblTot.Text = "Total USD:";
            // 
            // lblServi
            // 
            lblServi.AutoSize = true;
            lblServi.Location = new Point(26, 123);
            lblServi.Margin = new Padding(4, 0, 4, 0);
            lblServi.Name = "lblServi";
            lblServi.Size = new Size(119, 23);
            lblServi.TabIndex = 4;
            lblServi.Text = "Servicio 10%:";
            // 
            // lblItb
            // 
            lblItb.AutoSize = true;
            lblItb.Location = new Point(26, 95);
            lblItb.Margin = new Padding(4, 0, 4, 0);
            lblItb.Name = "lblItb";
            lblItb.Size = new Size(90, 23);
            lblItb.TabIndex = 3;
            lblItb.Text = "Itbis 18%:";
            // 
            // lblDes
            // 
            lblDes.AutoSize = true;
            lblDes.Location = new Point(26, 65);
            lblDes.Margin = new Padding(4, 0, 4, 0);
            lblDes.Name = "lblDes";
            lblDes.Size = new Size(98, 23);
            lblDes.TabIndex = 2;
            lblDes.Text = "Descuento:";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Location = new Point(26, 36);
            lblSub.Margin = new Padding(4, 0, 4, 0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(84, 23);
            lblSub.TabIndex = 1;
            lblSub.Text = "Subtotal:";
            // 
            // lstResultados
            // 
            lstResultados.BackColor = Color.AliceBlue;
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(931, 12);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(475, 533);
            lstResultados.TabIndex = 13;
            lstResultados.SelectedIndexChanged += lstResultados_SelectedIndexChanged;
            // 
            // gbOtrosServicios
            // 
            gbOtrosServicios.BackColor = Color.AliceBlue;
            gbOtrosServicios.Controls.Add(btnViejo);
            gbOtrosServicios.Controls.Add(chkNocturno);
            gbOtrosServicios.Controls.Add(btnTraslado);
            gbOtrosServicios.Controls.Add(chkFinSemana);
            gbOtrosServicios.Controls.Add(btnFinSemana);
            gbOtrosServicios.Controls.Add(lblPrecioUnitario);
            gbOtrosServicios.Controls.Add(nudCantidad);
            gbOtrosServicios.Controls.Add(lblCantidadMini);
            gbOtrosServicios.Controls.Add(nudPrecioUnitario);
            gbOtrosServicios.Controls.Add(btnMiniBar);
            gbOtrosServicios.Controls.Add(bntExcursion);
            gbOtrosServicios.Controls.Add(nudTarifaexcursion);
            gbOtrosServicios.Controls.Add(lblTarifaExcursion);
            gbOtrosServicios.Location = new Point(34, 423);
            gbOtrosServicios.Name = "gbOtrosServicios";
            gbOtrosServicios.Size = new Size(880, 235);
            gbOtrosServicios.TabIndex = 40;
            gbOtrosServicios.TabStop = false;
            gbOtrosServicios.Text = "Otros servicios";
            // 
            // btnViejo
            // 
            btnViejo.Location = new Point(289, 170);
            btnViejo.Name = "btnViejo";
            btnViejo.Size = new Size(235, 36);
            btnViejo.TabIndex = 60;
            btnViejo.Text = "Sistema Viejo";
            btnViejo.UseVisualStyleBackColor = true;
            btnViejo.Click += btnViejo_Click;
            // 
            // chkNocturno
            // 
            chkNocturno.AutoSize = true;
            chkNocturno.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkNocturno.ForeColor = Color.Red;
            chkNocturno.Location = new Point(586, 125);
            chkNocturno.Margin = new Padding(4, 3, 4, 3);
            chkNocturno.Name = "chkNocturno";
            chkNocturno.Size = new Size(257, 29);
            chkNocturno.TabIndex = 58;
            chkNocturno.Text = "Traslado nocturno (+20%)";
            chkNocturno.UseVisualStyleBackColor = true;
            // 
            // btnTraslado
            // 
            btnTraslado.Location = new Point(586, 170);
            btnTraslado.Name = "btnTraslado";
            btnTraslado.Size = new Size(257, 36);
            btnTraslado.TabIndex = 57;
            btnTraslado.Text = "Total traslado al aeropuerto";
            btnTraslado.UseVisualStyleBackColor = true;
            btnTraslado.Click += btnTraslado_Click;
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkFinSemana.ForeColor = Color.Red;
            chkFinSemana.Location = new Point(586, 39);
            chkFinSemana.Margin = new Padding(4, 3, 4, 3);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(223, 29);
            chkFinSemana.TabIndex = 55;
            chkFinSemana.Text = "Fin de semana (+15%)";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(586, 78);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(248, 36);
            btnFinSemana.TabIndex = 56;
            btnFinSemana.Text = "Total fin de semana";
            btnFinSemana.UseVisualStyleBackColor = true;
            btnFinSemana.UseWaitCursor = true;
            btnFinSemana.Click += btnFinSemana_Click;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(26, 95);
            lblPrecioUnitario.Margin = new Padding(4, 0, 4, 0);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(179, 23);
            lblPrecioUnitario.TabIndex = 50;
            lblPrecioUnitario.Text = "Precio Unitario USD :";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(26, 62);
            nudCantidad.Margin = new Padding(4, 3, 4, 3);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(193, 30);
            nudCantidad.TabIndex = 49;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCantidadMini
            // 
            lblCantidadMini.AutoSize = true;
            lblCantidadMini.Location = new Point(23, 36);
            lblCantidadMini.Margin = new Padding(4, 0, 4, 0);
            lblCantidadMini.Name = "lblCantidadMini";
            lblCantidadMini.Size = new Size(157, 23);
            lblCantidadMini.TabIndex = 48;
            lblCantidadMini.Text = "Cantidad minibar:";
            lblCantidadMini.Click += label2_Click;
            // 
            // nudPrecioUnitario
            // 
            nudPrecioUnitario.DecimalPlaces = 2;
            nudPrecioUnitario.Location = new Point(26, 121);
            nudPrecioUnitario.Margin = new Padding(4, 3, 4, 3);
            nudPrecioUnitario.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            nudPrecioUnitario.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrecioUnitario.Name = "nudPrecioUnitario";
            nudPrecioUnitario.Size = new Size(193, 30);
            nudPrecioUnitario.TabIndex = 47;
            nudPrecioUnitario.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnMiniBar
            // 
            btnMiniBar.Location = new Point(23, 170);
            btnMiniBar.Name = "btnMiniBar";
            btnMiniBar.Size = new Size(196, 36);
            btnMiniBar.TabIndex = 45;
            btnMiniBar.Text = "Total miniBar";
            btnMiniBar.UseVisualStyleBackColor = true;
            btnMiniBar.Click += btnMiniBar_Click;
            // 
            // bntExcursion
            // 
            bntExcursion.Location = new Point(289, 121);
            bntExcursion.Name = "bntExcursion";
            bntExcursion.Size = new Size(235, 36);
            bntExcursion.TabIndex = 42;
            bntExcursion.Text = "Excursión Isla Saona";
            bntExcursion.UseVisualStyleBackColor = true;
            bntExcursion.Click += bntExcursion_Click;
            // 
            // nudTarifaexcursion
            // 
            nudTarifaexcursion.DecimalPlaces = 2;
            nudTarifaexcursion.Location = new Point(289, 80);
            nudTarifaexcursion.Margin = new Padding(4, 3, 4, 3);
            nudTarifaexcursion.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            nudTarifaexcursion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTarifaexcursion.Name = "nudTarifaexcursion";
            nudTarifaexcursion.Size = new Size(235, 30);
            nudTarifaexcursion.TabIndex = 41;
            nudTarifaexcursion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTarifaExcursion
            // 
            lblTarifaExcursion.AutoSize = true;
            lblTarifaExcursion.Location = new Point(289, 42);
            lblTarifaExcursion.Margin = new Padding(4, 0, 4, 0);
            lblTarifaExcursion.Name = "lblTarifaExcursion";
            lblTarifaExcursion.Size = new Size(206, 23);
            lblTarifaExcursion.TabIndex = 40;
            lblTarifaExcursion.Text = "Tarifa de Excursión USD:";
            // 
            // btnImperativo
            // 
            btnImperativo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImperativo.Location = new Point(931, 574);
            btnImperativo.Name = "btnImperativo";
            btnImperativo.Size = new Size(475, 39);
            btnImperativo.TabIndex = 62;
            btnImperativo.Text = "Imperativo";
            btnImperativo.UseVisualStyleBackColor = true;
            btnImperativo.Click += btnImperativo_Click;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(931, 619);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(475, 39);
            btnNivel1.TabIndex = 66;
            btnNivel1.Text = "Nivel 1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1423, 670);
            Controls.Add(btnNivel1);
            Controls.Add(btnImperativo);
            Controls.Add(gbOtrosServicios);
            Controls.Add(lstResultados);
            Controls.Add(gbTotales);
            Controls.Add(gbCotizador);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador Villa Coral - Luzmairy Espiritusanto R. 2025-0558";
            Load += frmInicio_Load;
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            gbOtrosServicios.ResumeLayout(false);
            gbOtrosServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifaexcursion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCotizador;
        private Label lblHuesped;
        private Label lblTarifa;
        private Label lblNoches;
        private TextBox txtHuesped;
        private NumericUpDown nudNoches;
        private CheckBox chkTemporadaAlta;
        private GroupBox gbTotales;
        private Label lblTot;
        private Label lblServi;
        private Label lblItb;
        private Label lblDes;
        private Label lblSub;
        private Label lblSubtotal;
        private Label lblItbis;
        private Label lblDescuento;
        private Label lblTotal;
        private Label lblServicio;
        private ListBox lstResultados;
        private NumericUpDown nudTarifa;
        private NumericUpDown nudTasa;
        private NumericUpDown nudPersonas;
        private Button btnPorPersonas;
        private Label lblTasa;
        private Label lblElija;
        private GroupBox gbOtrosServicios;
        private Label lblPrecioUnitario;
        private NumericUpDown nudCantidad;
        private Label lblCantidadMini;
        private NumericUpDown nudPrecioUnitario;
        private Button btnMiniBar;
        private Button bntExcursion;
        private NumericUpDown nudTarifaexcursion;
        private Label lblTarifaExcursion;
        private Button btnLimpiar;
        private Button btnCopiar;
        private Button btnDesglose;
        private Button btnViejo;
        private CheckBox chkNocturno;
        private Button btnTraslado;
        private CheckBox chkFinSemana;
        private Button btnFinSemana;
        private Button btnPesos;
        private Button btnCalcular;
        private Button btnFactura;
        private Button btnCuentaTotal;
        private Button btnImperativo;
        private Button btnNivel1;
    }
}
