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
            btnNivel1 = new Button();
            lblTasa = new Label();
            lblElija = new Label();
            chkFinSemana = new CheckBox();
            btnPorPersonas = new Button();
            btnFinSemana = new Button();
            btnDeposito = new Button();
            btnCopiar = new Button();
            nudPersonas = new NumericUpDown();
            nudTasa = new NumericUpDown();
            nudTarifa = new NumericUpDown();
            chkTemporadaAlta = new CheckBox();
            nudNoches = new NumericUpDown();
            lblTarifa = new Label();
            lblNoches = new Label();
            txtHuesped = new TextBox();
            lblHuesped = new Label();
            btnDesglose = new Button();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            gbTotales = new GroupBox();
            btnPesos = new Button();
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
            btnImperativo = new Button();
            lstResultados = new ListBox();
            btnTraslado = new Button();
            chkNocturno = new CheckBox();
            bntExcursion = new Button();
            lblTarifaExcursion = new Label();
            btnMiniBar = new Button();
            nudPrecioUnitario = new NumericUpDown();
            lblMinibar = new Label();
            label2 = new Label();
            nudCantidad = new NumericUpDown();
            label1 = new Label();
            btnCuentaTotal = new Button();
            lblValorPredeterminado = new Label();
            btnViejo = new Button();
            gbCotizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecioUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // gbCotizador
            // 
            gbCotizador.BackColor = Color.AliceBlue;
            gbCotizador.Controls.Add(btnNivel1);
            gbCotizador.Controls.Add(lblTasa);
            gbCotizador.Controls.Add(lblElija);
            gbCotizador.Controls.Add(chkFinSemana);
            gbCotizador.Controls.Add(btnPorPersonas);
            gbCotizador.Controls.Add(btnFinSemana);
            gbCotizador.Controls.Add(btnDeposito);
            gbCotizador.Controls.Add(btnCopiar);
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
            gbCotizador.Size = new Size(624, 403);
            gbCotizador.TabIndex = 1;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(342, 331);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(239, 36);
            btnNivel1.TabIndex = 14;
            btnNivel1.Text = "Nivel 1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.Location = new Point(342, 160);
            lblTasa.Margin = new Padding(4, 0, 4, 0);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(127, 23);
            lblTasa.TabIndex = 24;
            lblTasa.Text = "Tasa del dólar:";
            // 
            // lblElija
            // 
            lblElija.AutoSize = true;
            lblElija.Location = new Point(339, 36);
            lblElija.Margin = new Padding(4, 0, 4, 0);
            lblElija.Name = "lblElija";
            lblElija.Size = new Size(242, 23);
            lblElija.TabIndex = 23;
            lblElija.Text = "Elija la cantidad de personas:";
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkFinSemana.ForeColor = Color.MediumBlue;
            chkFinSemana.Location = new Point(342, 237);
            chkFinSemana.Margin = new Padding(4, 3, 4, 3);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(223, 29);
            chkFinSemana.TabIndex = 19;
            chkFinSemana.Text = "Fin de semana (+15%)";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // btnPorPersonas
            // 
            btnPorPersonas.Location = new Point(339, 99);
            btnPorPersonas.Name = "btnPorPersonas";
            btnPorPersonas.Size = new Size(242, 36);
            btnPorPersonas.TabIndex = 18;
            btnPorPersonas.Text = "Por Persona";
            btnPorPersonas.UseVisualStyleBackColor = true;
            btnPorPersonas.UseWaitCursor = true;
            btnPorPersonas.Click += btnPorPersona_Click;
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(339, 289);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(242, 36);
            btnFinSemana.TabIndex = 21;
            btnFinSemana.Text = "Total con Fin de Semana";
            btnFinSemana.UseVisualStyleBackColor = true;
            btnFinSemana.UseWaitCursor = true;
            btnFinSemana.Click += btnFinSemana_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(26, 289);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(272, 36);
            btnDeposito.TabIndex = 20;
            btnDeposito.Text = "Depósito / Saldo Pendiente";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.UseWaitCursor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(26, 331);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(272, 36);
            btnCopiar.TabIndex = 11;
            btnCopiar.Text = "Copiar a WhatsApp";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(339, 63);
            nudPersonas.Margin = new Padding(4, 3, 4, 3);
            nudPersonas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(242, 30);
            nudPersonas.TabIndex = 13;
            nudPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudTasa
            // 
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(342, 186);
            nudTasa.Margin = new Padding(4, 3, 4, 3);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(239, 30);
            nudTasa.TabIndex = 9;
            nudTasa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudTarifa
            // 
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Location = new Point(26, 186);
            nudTarifa.Margin = new Padding(4, 3, 4, 3);
            nudTarifa.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            nudTarifa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(272, 30);
            nudTarifa.TabIndex = 8;
            nudTarifa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkTemporadaAlta
            // 
            chkTemporadaAlta.AutoSize = true;
            chkTemporadaAlta.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkTemporadaAlta.ForeColor = Color.MediumBlue;
            chkTemporadaAlta.Location = new Point(26, 237);
            chkTemporadaAlta.Margin = new Padding(4, 3, 4, 3);
            chkTemporadaAlta.Name = "chkTemporadaAlta";
            chkTemporadaAlta.Size = new Size(234, 29);
            chkTemporadaAlta.TabIndex = 7;
            chkTemporadaAlta.Text = "Temporada alta (+25%)";
            chkTemporadaAlta.UseVisualStyleBackColor = true;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(26, 121);
            nudNoches.Margin = new Padding(4, 3, 4, 3);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(272, 30);
            nudNoches.TabIndex = 6;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(26, 160);
            lblTarifa.Margin = new Padding(4, 0, 4, 0);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(186, 23);
            lblTarifa.TabIndex = 4;
            lblTarifa.Text = "Tarifa por noche USD:";
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(26, 95);
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
            txtHuesped.Size = new Size(272, 30);
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
            // btnDesglose
            // 
            btnDesglose.Location = new Point(325, 120);
            btnDesglose.Name = "btnDesglose";
            btnDesglose.Size = new Size(223, 36);
            btnDesglose.TabIndex = 22;
            btnDesglose.Text = "Desglose";
            btnDesglose.UseVisualStyleBackColor = true;
            btnDesglose.UseWaitCursor = true;
            btnDesglose.Click += btnDesglose_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(325, 162);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(223, 36);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(325, 36);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(220, 36);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // gbTotales
            // 
            gbTotales.BackColor = Color.AliceBlue;
            gbTotales.Controls.Add(btnPesos);
            gbTotales.Controls.Add(lblTotal);
            gbTotales.Controls.Add(lblServicio);
            gbTotales.Controls.Add(btnDesglose);
            gbTotales.Controls.Add(lblItbis);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lblSubtotal);
            gbTotales.Controls.Add(btnLimpiar);
            gbTotales.Controls.Add(lblTot);
            gbTotales.Controls.Add(lblServi);
            gbTotales.Controls.Add(lblItb);
            gbTotales.Controls.Add(btnCalcular);
            gbTotales.Controls.Add(lblDes);
            gbTotales.Controls.Add(lblSub);
            gbTotales.Location = new Point(39, 437);
            gbTotales.Margin = new Padding(4, 3, 4, 3);
            gbTotales.Name = "gbTotales";
            gbTotales.Padding = new Padding(4, 3, 4, 3);
            gbTotales.Size = new Size(619, 233);
            gbTotales.TabIndex = 8;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(325, 78);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(220, 36);
            btnPesos.TabIndex = 17;
            btnPesos.Text = "Total en RD$";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(196, 155);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 28);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(204, 123);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(45, 23);
            lblServicio.TabIndex = 9;
            lblServicio.Text = "0.00";
            lblServicio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(204, 95);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(45, 23);
            lblItbis.TabIndex = 8;
            lblItbis.Text = "0.00";
            lblItbis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(204, 65);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(45, 23);
            lblDescuento.TabIndex = 7;
            lblDescuento.Text = "0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(204, 36);
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
            // btnImperativo
            // 
            btnImperativo.Location = new Point(702, 623);
            btnImperativo.Name = "btnImperativo";
            btnImperativo.Size = new Size(469, 36);
            btnImperativo.TabIndex = 12;
            btnImperativo.Text = "Imperativo";
            btnImperativo.UseVisualStyleBackColor = true;
            btnImperativo.Click += btnImperativo_Click;
            // 
            // lstResultados
            // 
            lstResultados.BackColor = Color.AliceBlue;
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(702, 12);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(469, 602);
            lstResultados.TabIndex = 13;
            // 
            // btnTraslado
            // 
            btnTraslado.Location = new Point(361, 748);
            btnTraslado.Name = "btnTraslado";
            btnTraslado.Size = new Size(254, 36);
            btnTraslado.TabIndex = 23;
            btnTraslado.Text = "Traslado Aeropuerto";
            btnTraslado.UseVisualStyleBackColor = true;
            btnTraslado.Click += btnTraslado_Click;
            // 
            // chkNocturno
            // 
            chkNocturno.AutoSize = true;
            chkNocturno.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkNocturno.ForeColor = Color.MediumBlue;
            chkNocturno.Location = new Point(366, 713);
            chkNocturno.Margin = new Padding(4, 3, 4, 3);
            chkNocturno.Name = "chkNocturno";
            chkNocturno.Size = new Size(257, 29);
            chkNocturno.TabIndex = 25;
            chkNocturno.Text = "Traslado nocturno (+20%)";
            chkNocturno.UseVisualStyleBackColor = true;
            // 
            // bntExcursion
            // 
            bntExcursion.Location = new Point(39, 813);
            bntExcursion.Name = "bntExcursion";
            bntExcursion.Size = new Size(269, 36);
            bntExcursion.TabIndex = 26;
            bntExcursion.Text = "Excursión Isla Saona";
            bntExcursion.UseVisualStyleBackColor = true;
            bntExcursion.Click += bntExcursion_Click;
            // 
            // lblTarifaExcursion
            // 
            lblTarifaExcursion.AutoSize = true;
            lblTarifaExcursion.Location = new Point(39, 695);
            lblTarifaExcursion.Margin = new Padding(4, 0, 4, 0);
            lblTarifaExcursion.Name = "lblTarifaExcursion";
            lblTarifaExcursion.Size = new Size(206, 23);
            lblTarifaExcursion.TabIndex = 27;
            lblTarifaExcursion.Text = "Tarifa de Excursión USD:";
            // 
            // btnMiniBar
            // 
            btnMiniBar.Location = new Point(39, 1074);
            btnMiniBar.Name = "btnMiniBar";
            btnMiniBar.Size = new Size(269, 36);
            btnMiniBar.TabIndex = 29;
            btnMiniBar.Text = "MiniBar";
            btnMiniBar.UseVisualStyleBackColor = true;
            btnMiniBar.Click += btnMiniBar_Click;
            // 
            // nudPrecioUnitario
            // 
            nudPrecioUnitario.DecimalPlaces = 2;
            nudPrecioUnitario.Location = new Point(36, 1028);
            nudPrecioUnitario.Margin = new Padding(4, 3, 4, 3);
            nudPrecioUnitario.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            nudPrecioUnitario.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrecioUnitario.Name = "nudPrecioUnitario";
            nudPrecioUnitario.Size = new Size(193, 30);
            nudPrecioUnitario.TabIndex = 31;
            nudPrecioUnitario.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMinibar
            // 
            lblMinibar.AutoSize = true;
            lblMinibar.Location = new Point(34, 883);
            lblMinibar.Margin = new Padding(4, 0, 4, 0);
            lblMinibar.Name = "lblMinibar";
            lblMinibar.Size = new Size(217, 23);
            lblMinibar.TabIndex = 30;
            lblMinibar.Text = "Consumido en el MiniBar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 922);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 23);
            label2.TabIndex = 32;
            label2.Text = "Cantidad de Productos:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(36, 948);
            nudCantidad.Margin = new Padding(4, 3, 4, 3);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(193, 30);
            nudCantidad.TabIndex = 33;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 993);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 23);
            label1.TabIndex = 34;
            label1.Text = "Precio Unitario USD :";
            // 
            // btnCuentaTotal
            // 
            btnCuentaTotal.Location = new Point(702, 665);
            btnCuentaTotal.Name = "btnCuentaTotal";
            btnCuentaTotal.Size = new Size(469, 36);
            btnCuentaTotal.TabIndex = 35;
            btnCuentaTotal.Text = "Cuenta Total";
            btnCuentaTotal.UseVisualStyleBackColor = true;
            btnCuentaTotal.Click += btnCuentaTotal_Click;
            // 
            // lblValorPredeterminado
            // 
            lblValorPredeterminado.Location = new Point(39, 728);
            lblValorPredeterminado.Name = "lblValorPredeterminado";
            lblValorPredeterminado.Size = new Size(221, 82);
            lblValorPredeterminado.TabIndex = 36;
            lblValorPredeterminado.Text = "Valores predeterminados: 6 personas - Tarifa 85 USD";
            // 
            // btnViejo
            // 
            btnViejo.Location = new Point(702, 709);
            btnViejo.Name = "btnViejo";
            btnViejo.Size = new Size(469, 36);
            btnViejo.TabIndex = 37;
            btnViejo.Text = "Sistema Viejo";
            btnViejo.UseVisualStyleBackColor = true;
            btnViejo.Click += btnViejo_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1206, 1132);
            Controls.Add(btnViejo);
            Controls.Add(lblValorPredeterminado);
            Controls.Add(btnCuentaTotal);
            Controls.Add(label1);
            Controls.Add(nudCantidad);
            Controls.Add(label2);
            Controls.Add(nudPrecioUnitario);
            Controls.Add(lblMinibar);
            Controls.Add(btnMiniBar);
            Controls.Add(lblTarifaExcursion);
            Controls.Add(bntExcursion);
            Controls.Add(chkNocturno);
            Controls.Add(btnTraslado);
            Controls.Add(lstResultados);
            Controls.Add(btnImperativo);
            Controls.Add(gbTotales);
            Controls.Add(gbCotizador);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            ((System.ComponentModel.ISupportInitialize)nudPrecioUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnCopiar;
        private Button btnImperativo;
        private ListBox lstResultados;
        private NumericUpDown nudTarifa;
        private Button btnNivel1;
        private NumericUpDown nudTasa;
        private Button btnPesos;
        private NumericUpDown nudPersonas;
        private CheckBox chkFinSemana;
        private Button btnPorPersonas;
        private Button btnDesglose;
        private Button btnFinSemana;
        private Button btnDeposito;
        private Label lblTasa;
        private Label lblElija;
        private Button btnTraslado;
        private CheckBox chkNocturno;
        private Button bntExcursion;
        private Label lblTarifaExcursion;
        private Button btnMiniBar;
        private NumericUpDown nudPrecioUnitario;
        private Label lblMinibar;
        private Label label2;
        private NumericUpDown nudCantidad;
        private Label label1;
        private Button btnCuentaTotal;
        private Label lblValorPredeterminado;
        private Button btnViejo;
    }
}
