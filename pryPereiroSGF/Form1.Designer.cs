namespace pryPereiroSGF
{
    partial class frmPricipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPricipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmbBaseDatos = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblCargar = new System.Windows.Forms.Label();
            this.tabCargar = new System.Windows.Forms.TabPage();
            this.lblContrato = new System.Windows.Forms.Label();
            this.gpbContrato = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.mskFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtMontoAlquilado = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMontoAlquilado = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDatosChofer = new System.Windows.Forms.Label();
            this.gpbDatosChofer = new System.Windows.Forms.GroupBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtIDChofer = new System.Windows.Forms.TextBox();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblIdChofer = new System.Windows.Forms.Label();
            this.lblDatosVehículo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.mskVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtUltMant = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblUltimoMantenimiento = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tabCargar.SuspendLayout();
            this.gpbContrato.SuspendLayout();
            this.gpbDatosChofer.SuspendLayout();
            this.gpbDatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConsultar);
            this.tabControl1.Controls.Add(this.tabCargar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.dgvDatos);
            this.tabConsultar.Controls.Add(this.cmbBaseDatos);
            this.tabConsultar.Controls.Add(this.btnCargar);
            this.tabConsultar.Controls.Add(this.lblCargar);
            this.tabConsultar.Location = new System.Drawing.Point(4, 29);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(1250, 502);
            this.tabConsultar.TabIndex = 0;
            this.tabConsultar.Text = "Consultar BD";
            this.tabConsultar.UseVisualStyleBackColor = true;
            this.tabConsultar.Click += new System.EventHandler(this.tabConsultar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(10, 111);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(1230, 378);
            this.dgvDatos.TabIndex = 3;
            // 
            // cmbBaseDatos
            // 
            this.cmbBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaseDatos.FormattingEnabled = true;
            this.cmbBaseDatos.Location = new System.Drawing.Point(608, 46);
            this.cmbBaseDatos.Name = "cmbBaseDatos";
            this.cmbBaseDatos.Size = new System.Drawing.Size(312, 33);
            this.cmbBaseDatos.TabIndex = 2;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(968, 46);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(132, 38);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblCargar
            // 
            this.lblCargar.AutoSize = true;
            this.lblCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargar.Location = new System.Drawing.Point(141, 51);
            this.lblCargar.Name = "lblCargar";
            this.lblCargar.Size = new System.Drawing.Size(385, 25);
            this.lblCargar.TabIndex = 0;
            this.lblCargar.Text = "Selecciona una base de datos para cargar:";
            // 
            // tabCargar
            // 
            this.tabCargar.Controls.Add(this.lblContrato);
            this.tabCargar.Controls.Add(this.gpbContrato);
            this.tabCargar.Controls.Add(this.lblDatosChofer);
            this.tabCargar.Controls.Add(this.gpbDatosChofer);
            this.tabCargar.Controls.Add(this.lblDatosVehículo);
            this.tabCargar.Controls.Add(this.btnLimpiar);
            this.tabCargar.Controls.Add(this.btnGuardar);
            this.tabCargar.Controls.Add(this.gpbDatosVehiculo);
            this.tabCargar.Location = new System.Drawing.Point(4, 29);
            this.tabCargar.Name = "tabCargar";
            this.tabCargar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCargar.Size = new System.Drawing.Size(1250, 502);
            this.tabCargar.TabIndex = 1;
            this.tabCargar.Text = "Cargar Flota";
            this.tabCargar.UseVisualStyleBackColor = true;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(858, 43);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(231, 20);
            this.lblContrato.TabIndex = 9;
            this.lblContrato.Text = "Configuración Contrato (Renta)";
            // 
            // gpbContrato
            // 
            this.gpbContrato.Controls.Add(this.cmbTipo);
            this.gpbContrato.Controls.Add(this.mskFechaInicio);
            this.gpbContrato.Controls.Add(this.txtMontoAlquilado);
            this.gpbContrato.Controls.Add(this.lblFecha);
            this.gpbContrato.Controls.Add(this.lblMontoAlquilado);
            this.gpbContrato.Controls.Add(this.label12);
            this.gpbContrato.Location = new System.Drawing.Point(852, 66);
            this.gpbContrato.Name = "gpbContrato";
            this.gpbContrato.Size = new System.Drawing.Size(369, 322);
            this.gpbContrato.TabIndex = 8;
            this.gpbContrato.TabStop = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(10, 85);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(340, 28);
            this.cmbTipo.TabIndex = 10;
            // 
            // mskFechaInicio
            // 
            this.mskFechaInicio.Location = new System.Drawing.Point(195, 208);
            this.mskFechaInicio.Name = "mskFechaInicio";
            this.mskFechaInicio.Size = new System.Drawing.Size(156, 26);
            this.mskFechaInicio.TabIndex = 9;
            // 
            // txtMontoAlquilado
            // 
            this.txtMontoAlquilado.Location = new System.Drawing.Point(195, 138);
            this.txtMontoAlquilado.Name = "txtMontoAlquilado";
            this.txtMontoAlquilado.Size = new System.Drawing.Size(156, 26);
            this.txtMontoAlquilado.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(9, 218);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(95, 20);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha Inicio";
            // 
            // lblMontoAlquilado
            // 
            this.lblMontoAlquilado.AutoSize = true;
            this.lblMontoAlquilado.Location = new System.Drawing.Point(9, 149);
            this.lblMontoAlquilado.Name = "lblMontoAlquilado";
            this.lblMontoAlquilado.Size = new System.Drawing.Size(123, 20);
            this.lblMontoAlquilado.TabIndex = 2;
            this.lblMontoAlquilado.Text = "Monto Alquilado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tipo (Mensual/Semanal)";
            // 
            // lblDatosChofer
            // 
            this.lblDatosChofer.AutoSize = true;
            this.lblDatosChofer.Location = new System.Drawing.Point(444, 43);
            this.lblDatosChofer.Name = "lblDatosChofer";
            this.lblDatosChofer.Size = new System.Drawing.Size(129, 20);
            this.lblDatosChofer.TabIndex = 7;
            this.lblDatosChofer.Text = "Datos del Chofer";
            // 
            // gpbDatosChofer
            // 
            this.gpbDatosChofer.Controls.Add(this.mskTelefono);
            this.gpbDatosChofer.Controls.Add(this.txtLicencia);
            this.gpbDatosChofer.Controls.Add(this.txtDNI);
            this.gpbDatosChofer.Controls.Add(this.txtNombreCompleto);
            this.gpbDatosChofer.Controls.Add(this.txtIDChofer);
            this.gpbDatosChofer.Controls.Add(this.lblLicencia);
            this.gpbDatosChofer.Controls.Add(this.lblTelefono);
            this.gpbDatosChofer.Controls.Add(this.lblDNI);
            this.gpbDatosChofer.Controls.Add(this.lblNombreCompleto);
            this.gpbDatosChofer.Controls.Add(this.lblIdChofer);
            this.gpbDatosChofer.Location = new System.Drawing.Point(438, 66);
            this.gpbDatosChofer.Name = "gpbDatosChofer";
            this.gpbDatosChofer.Size = new System.Drawing.Size(369, 322);
            this.gpbDatosChofer.TabIndex = 6;
            this.gpbDatosChofer.TabStop = false;
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(195, 194);
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(156, 26);
            this.mskTelefono.TabIndex = 9;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(195, 252);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(156, 26);
            this.txtLicencia.TabIndex = 8;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(195, 138);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(156, 26);
            this.txtDNI.TabIndex = 7;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(195, 85);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(156, 26);
            this.txtNombreCompleto.TabIndex = 6;
            // 
            // txtIDChofer
            // 
            this.txtIDChofer.Location = new System.Drawing.Point(195, 35);
            this.txtIDChofer.Name = "txtIDChofer";
            this.txtIDChofer.Size = new System.Drawing.Size(156, 26);
            this.txtIDChofer.TabIndex = 5;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(9, 257);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(156, 20);
            this.lblLicencia.TabIndex = 4;
            this.lblLicencia.Text = "Licencia de Conducir";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 198);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(6, 143);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(37, 20);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(6, 89);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(137, 20);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Nombre Completo";
            // 
            // lblIdChofer
            // 
            this.lblIdChofer.AutoSize = true;
            this.lblIdChofer.Location = new System.Drawing.Point(6, 40);
            this.lblIdChofer.Name = "lblIdChofer";
            this.lblIdChofer.Size = new System.Drawing.Size(78, 20);
            this.lblIdChofer.TabIndex = 0;
            this.lblIdChofer.Text = "ID Chofer";
            // 
            // lblDatosVehículo
            // 
            this.lblDatosVehículo.AutoSize = true;
            this.lblDatosVehículo.Location = new System.Drawing.Point(38, 43);
            this.lblDatosVehículo.Name = "lblDatosVehículo";
            this.lblDatosVehículo.Size = new System.Drawing.Size(142, 20);
            this.lblDatosVehículo.TabIndex = 5;
            this.lblDatosVehículo.Text = "Datos del Vehículo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1062, 423);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(159, 58);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(852, 423);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 58);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Registro";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gpbDatosVehiculo
            // 
            this.gpbDatosVehiculo.Controls.Add(this.mskVencimiento);
            this.gpbDatosVehiculo.Controls.Add(this.txtUltMant);
            this.gpbDatosVehiculo.Controls.Add(this.txtModelo);
            this.gpbDatosVehiculo.Controls.Add(this.txtMarca);
            this.gpbDatosVehiculo.Controls.Add(this.txtPatente);
            this.gpbDatosVehiculo.Controls.Add(this.lblUltimoMantenimiento);
            this.gpbDatosVehiculo.Controls.Add(this.lblVencimiento);
            this.gpbDatosVehiculo.Controls.Add(this.lblModelo);
            this.gpbDatosVehiculo.Controls.Add(this.lblMarca);
            this.gpbDatosVehiculo.Controls.Add(this.lblPatente);
            this.gpbDatosVehiculo.Location = new System.Drawing.Point(32, 66);
            this.gpbDatosVehiculo.Name = "gpbDatosVehiculo";
            this.gpbDatosVehiculo.Size = new System.Drawing.Size(369, 322);
            this.gpbDatosVehiculo.TabIndex = 0;
            this.gpbDatosVehiculo.TabStop = false;
            this.gpbDatosVehiculo.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // mskVencimiento
            // 
            this.mskVencimiento.Location = new System.Drawing.Point(195, 194);
            this.mskVencimiento.Name = "mskVencimiento";
            this.mskVencimiento.Size = new System.Drawing.Size(156, 26);
            this.mskVencimiento.TabIndex = 9;
            // 
            // txtUltMant
            // 
            this.txtUltMant.Location = new System.Drawing.Point(195, 252);
            this.txtUltMant.Name = "txtUltMant";
            this.txtUltMant.Size = new System.Drawing.Size(156, 26);
            this.txtUltMant.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(195, 138);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(156, 26);
            this.txtModelo.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(195, 85);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(156, 26);
            this.txtMarca.TabIndex = 6;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(195, 35);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(156, 26);
            this.txtPatente.TabIndex = 5;
            // 
            // lblUltimoMantenimiento
            // 
            this.lblUltimoMantenimiento.AutoSize = true;
            this.lblUltimoMantenimiento.Location = new System.Drawing.Point(9, 257);
            this.lblUltimoMantenimiento.Name = "lblUltimoMantenimiento";
            this.lblUltimoMantenimiento.Size = new System.Drawing.Size(77, 20);
            this.lblUltimoMantenimiento.TabIndex = 4;
            this.lblUltimoMantenimiento.Text = "Últ. Mant.";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(6, 198);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(153, 20);
            this.lblVencimiento.TabIndex = 3;
            this.lblVencimiento.Text = "Vencimiento Seguro";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(6, 143);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 89);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(6, 40);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(65, 20);
            this.lblPatente.TabIndex = 0;
            this.lblPatente.Text = "Patente";
            // 
            // frmPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1284, 569);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPricipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestion de Flotas";
            this.tabControl1.ResumeLayout(false);
            this.tabConsultar.ResumeLayout(false);
            this.tabConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tabCargar.ResumeLayout(false);
            this.tabCargar.PerformLayout();
            this.gpbContrato.ResumeLayout(false);
            this.gpbContrato.PerformLayout();
            this.gpbDatosChofer.ResumeLayout(false);
            this.gpbDatosChofer.PerformLayout();
            this.gpbDatosVehiculo.ResumeLayout(false);
            this.gpbDatosVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.TabPage tabCargar;
        private System.Windows.Forms.ComboBox cmbBaseDatos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblCargar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox gpbDatosVehiculo;
        private System.Windows.Forms.TextBox txtUltMant;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblUltimoMantenimiento;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MaskedTextBox mskVencimiento;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblDatosVehículo;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.GroupBox gpbContrato;
        private System.Windows.Forms.MaskedTextBox mskFechaInicio;
        private System.Windows.Forms.TextBox txtMontoAlquilado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMontoAlquilado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDatosChofer;
        private System.Windows.Forms.GroupBox gpbDatosChofer;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtIDChofer;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblIdChofer;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}

