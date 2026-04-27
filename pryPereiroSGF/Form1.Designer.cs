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
            this.txtMontoAlquilado = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
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
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblIdVehiculo = new System.Windows.Forms.Label();
            this.txtIdVehiculo = new System.Windows.Forms.TextBox();
            this.txtMantenimiento = new System.Windows.Forms.TextBox();
            this.lblMantenimiento = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtIdContrato = new System.Windows.Forms.TextBox();
            this.lblIdContrato = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.dgvDatos);
            this.tabConsultar.Controls.Add(this.cmbBaseDatos);
            this.tabConsultar.Controls.Add(this.btnCargar);
            this.tabConsultar.Controls.Add(this.lblCargar);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabConsultar.Size = new System.Drawing.Size(831, 405);
            this.tabConsultar.TabIndex = 0;
            this.tabConsultar.Text = "Consultar BD";
            this.tabConsultar.UseVisualStyleBackColor = true;
            this.tabConsultar.Click += new System.EventHandler(this.tabConsultar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(7, 72);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(820, 329);
            this.dgvDatos.TabIndex = 3;
            // 
            // cmbBaseDatos
            // 
            this.cmbBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaseDatos.FormattingEnabled = true;
            this.cmbBaseDatos.Location = new System.Drawing.Point(405, 30);
            this.cmbBaseDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBaseDatos.Name = "cmbBaseDatos";
            this.cmbBaseDatos.Size = new System.Drawing.Size(209, 24);
            this.cmbBaseDatos.TabIndex = 2;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(645, 30);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(88, 25);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblCargar
            // 
            this.lblCargar.AutoSize = true;
            this.lblCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargar.Location = new System.Drawing.Point(94, 33);
            this.lblCargar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargar.Name = "lblCargar";
            this.lblCargar.Size = new System.Drawing.Size(281, 17);
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
            this.tabCargar.Location = new System.Drawing.Point(4, 22);
            this.tabCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCargar.Name = "tabCargar";
            this.tabCargar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCargar.Size = new System.Drawing.Size(831, 405);
            this.tabCargar.TabIndex = 1;
            this.tabCargar.Text = "Cargar Flota";
            this.tabCargar.UseVisualStyleBackColor = true;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(572, 28);
            this.lblContrato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(153, 13);
            this.lblContrato.TabIndex = 9;
            this.lblContrato.Text = "Configuración Contrato (Renta)";
            // 
            // gpbContrato
            // 
            this.gpbContrato.Controls.Add(this.txtDescripcion);
            this.gpbContrato.Controls.Add(this.txtIdContrato);
            this.gpbContrato.Controls.Add(this.lblIdContrato);
            this.gpbContrato.Controls.Add(this.cmbTipo);
            this.gpbContrato.Controls.Add(this.txtMontoAlquilado);
            this.gpbContrato.Controls.Add(this.lblDescripcion);
            this.gpbContrato.Controls.Add(this.lblMontoAlquilado);
            this.gpbContrato.Controls.Add(this.label12);
            this.gpbContrato.Location = new System.Drawing.Point(568, 43);
            this.gpbContrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbContrato.Name = "gpbContrato";
            this.gpbContrato.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbContrato.Size = new System.Drawing.Size(246, 270);
            this.gpbContrato.TabIndex = 8;
            this.gpbContrato.TabStop = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(7, 102);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(228, 21);
            this.cmbTipo.TabIndex = 10;
            // 
            // txtMontoAlquilado
            // 
            this.txtMontoAlquilado.Location = new System.Drawing.Point(115, 152);
            this.txtMontoAlquilado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMontoAlquilado.Name = "txtMontoAlquilado";
            this.txtMontoAlquilado.Size = new System.Drawing.Size(120, 20);
            this.txtMontoAlquilado.TabIndex = 7;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 207);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(65, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Fecha Inicio";
            // 
            // lblMontoAlquilado
            // 
            this.lblMontoAlquilado.AutoSize = true;
            this.lblMontoAlquilado.Location = new System.Drawing.Point(6, 155);
            this.lblMontoAlquilado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoAlquilado.Name = "lblMontoAlquilado";
            this.lblMontoAlquilado.Size = new System.Drawing.Size(83, 13);
            this.lblMontoAlquilado.TabIndex = 2;
            this.lblMontoAlquilado.Text = "Monto Alquilado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tipo (Mensual/Semanal)";
            // 
            // lblDatosChofer
            // 
            this.lblDatosChofer.AutoSize = true;
            this.lblDatosChofer.Location = new System.Drawing.Point(296, 28);
            this.lblDatosChofer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosChofer.Name = "lblDatosChofer";
            this.lblDatosChofer.Size = new System.Drawing.Size(86, 13);
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
            this.gpbDatosChofer.Location = new System.Drawing.Point(292, 43);
            this.gpbDatosChofer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbDatosChofer.Name = "gpbDatosChofer";
            this.gpbDatosChofer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbDatosChofer.Size = new System.Drawing.Size(246, 270);
            this.gpbDatosChofer.TabIndex = 6;
            this.gpbDatosChofer.TabStop = false;
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(130, 168);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(105, 20);
            this.mskTelefono.TabIndex = 9;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(128, 220);
            this.txtLicencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(105, 20);
            this.txtLicencia.TabIndex = 8;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(130, 123);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(105, 20);
            this.txtDNI.TabIndex = 7;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(130, 73);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(105, 20);
            this.txtNombreCompleto.TabIndex = 6;
            // 
            // txtIDChofer
            // 
            this.txtIDChofer.Location = new System.Drawing.Point(130, 23);
            this.txtIDChofer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDChofer.Name = "txtIDChofer";
            this.txtIDChofer.Size = new System.Drawing.Size(105, 20);
            this.txtIDChofer.TabIndex = 5;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(4, 223);
            this.lblLicencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(107, 13);
            this.lblLicencia.TabIndex = 4;
            this.lblLicencia.Text = "Licencia de Conducir";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(4, 171);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(4, 126);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(4, 76);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(91, 13);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Nombre Completo";
            // 
            // lblIdChofer
            // 
            this.lblIdChofer.AutoSize = true;
            this.lblIdChofer.Location = new System.Drawing.Point(4, 26);
            this.lblIdChofer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdChofer.Name = "lblIdChofer";
            this.lblIdChofer.Size = new System.Drawing.Size(52, 13);
            this.lblIdChofer.TabIndex = 0;
            this.lblIdChofer.Text = "ID Chofer";
            // 
            // lblDatosVehículo
            // 
            this.lblDatosVehículo.AutoSize = true;
            this.lblDatosVehículo.Location = new System.Drawing.Point(25, 28);
            this.lblDatosVehículo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosVehículo.Name = "lblDatosVehículo";
            this.lblDatosVehículo.Size = new System.Drawing.Size(98, 13);
            this.lblDatosVehículo.TabIndex = 5;
            this.lblDatosVehículo.Text = "Datos del Vehículo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(708, 340);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 38);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(568, 340);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 38);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Registro";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gpbDatosVehiculo
            // 
            this.gpbDatosVehiculo.Controls.Add(this.txtEstado);
            this.gpbDatosVehiculo.Controls.Add(this.lblEstado);
            this.gpbDatosVehiculo.Controls.Add(this.txtMantenimiento);
            this.gpbDatosVehiculo.Controls.Add(this.lblMantenimiento);
            this.gpbDatosVehiculo.Controls.Add(this.txtIdVehiculo);
            this.gpbDatosVehiculo.Controls.Add(this.lblIdVehiculo);
            this.gpbDatosVehiculo.Controls.Add(this.mskVencimiento);
            this.gpbDatosVehiculo.Controls.Add(this.txtModelo);
            this.gpbDatosVehiculo.Controls.Add(this.txtMarca);
            this.gpbDatosVehiculo.Controls.Add(this.txtPatente);
            this.gpbDatosVehiculo.Controls.Add(this.lblVencimiento);
            this.gpbDatosVehiculo.Controls.Add(this.lblModelo);
            this.gpbDatosVehiculo.Controls.Add(this.lblMarca);
            this.gpbDatosVehiculo.Controls.Add(this.lblPatente);
            this.gpbDatosVehiculo.Location = new System.Drawing.Point(21, 43);
            this.gpbDatosVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbDatosVehiculo.Name = "gpbDatosVehiculo";
            this.gpbDatosVehiculo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbDatosVehiculo.Size = new System.Drawing.Size(246, 270);
            this.gpbDatosVehiculo.TabIndex = 0;
            this.gpbDatosVehiculo.TabStop = false;
            this.gpbDatosVehiculo.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            this.gpbDatosVehiculo.Enter += new System.EventHandler(this.gpbDatosVehiculo_Enter);
            // 
            // mskVencimiento
            // 
            this.mskVencimiento.Location = new System.Drawing.Point(130, 202);
            this.mskVencimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskVencimiento.Mask = "00/00/0000";
            this.mskVencimiento.Name = "mskVencimiento";
            this.mskVencimiento.Size = new System.Drawing.Size(105, 20);
            this.mskVencimiento.TabIndex = 9;
            this.mskVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(130, 126);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(105, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(130, 91);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(105, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(130, 59);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(105, 20);
            this.txtPatente.TabIndex = 5;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(4, 205);
            this.lblVencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(102, 13);
            this.lblVencimiento.TabIndex = 3;
            this.lblVencimiento.Text = "Vencimiento Seguro";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(4, 129);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(4, 94);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(4, 62);
            this.lblPatente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 0;
            this.lblPatente.Text = "Patente";
            // 
            // lblIdVehiculo
            // 
            this.lblIdVehiculo.AutoSize = true;
            this.lblIdVehiculo.Location = new System.Drawing.Point(4, 26);
            this.lblIdVehiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdVehiculo.Name = "lblIdVehiculo";
            this.lblIdVehiculo.Size = new System.Drawing.Size(63, 13);
            this.lblIdVehiculo.TabIndex = 10;
            this.lblIdVehiculo.Text = "Id_Vehiculo";
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.Location = new System.Drawing.Point(130, 23);
            this.txtIdVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.Size = new System.Drawing.Size(105, 20);
            this.txtIdVehiculo.TabIndex = 11;
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Location = new System.Drawing.Point(130, 164);
            this.txtMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(105, 20);
            this.txtMantenimiento.TabIndex = 14;
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Location = new System.Drawing.Point(4, 167);
            this.lblMantenimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(76, 13);
            this.lblMantenimiento.TabIndex = 13;
            this.lblMantenimiento.Text = "Mantenimiento";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(132, 242);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(105, 20);
            this.txtEstado.TabIndex = 16;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(6, 245);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado";
            // 
            // txtIdContrato
            // 
            this.txtIdContrato.Location = new System.Drawing.Point(115, 23);
            this.txtIdContrato.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdContrato.Name = "txtIdContrato";
            this.txtIdContrato.Size = new System.Drawing.Size(122, 20);
            this.txtIdContrato.TabIndex = 12;
            // 
            // lblIdContrato
            // 
            this.lblIdContrato.AutoSize = true;
            this.lblIdContrato.Location = new System.Drawing.Point(6, 26);
            this.lblIdContrato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdContrato.Name = "lblIdContrato";
            this.lblIdContrato.Size = new System.Drawing.Size(52, 13);
            this.lblIdContrato.TabIndex = 11;
            this.lblIdContrato.Text = "ID Chofer";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(115, 207);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(120, 51);
            this.txtDescripcion.TabIndex = 13;
            // 
            // frmPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPatente;
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
        private System.Windows.Forms.TextBox txtMontoAlquilado;
        private System.Windows.Forms.Label lblDescripcion;
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
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtMantenimiento;
        private System.Windows.Forms.Label lblMantenimiento;
        private System.Windows.Forms.TextBox txtIdVehiculo;
        private System.Windows.Forms.Label lblIdVehiculo;
        private System.Windows.Forms.TextBox txtIdContrato;
        private System.Windows.Forms.Label lblIdContrato;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}

