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
            this.tabCargar = new System.Windows.Forms.TabPage();
            this.lblCargar = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmbBaseDatos = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gpbDatosChofer = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            this.tabCargar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbDatosVehiculo.SuspendLayout();
            this.gpbDatosChofer.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(994, 594);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.dataGridView1);
            this.tabConsultar.Controls.Add(this.cmbBaseDatos);
            this.tabConsultar.Controls.Add(this.btnCargar);
            this.tabConsultar.Controls.Add(this.lblCargar);
            this.tabConsultar.Location = new System.Drawing.Point(4, 29);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(986, 561);
            this.tabConsultar.TabIndex = 0;
            this.tabConsultar.Text = "Consultar BD";
            this.tabConsultar.UseVisualStyleBackColor = true;
            this.tabConsultar.Click += new System.EventHandler(this.tabConsultar_Click);
            // 
            // tabCargar
            // 
            this.tabCargar.Controls.Add(this.label18);
            this.tabCargar.Controls.Add(this.label17);
            this.tabCargar.Controls.Add(this.label16);
            this.tabCargar.Controls.Add(this.button2);
            this.tabCargar.Controls.Add(this.button1);
            this.tabCargar.Controls.Add(this.groupBox3);
            this.tabCargar.Controls.Add(this.gpbDatosChofer);
            this.tabCargar.Controls.Add(this.gpbDatosVehiculo);
            this.tabCargar.Location = new System.Drawing.Point(4, 29);
            this.tabCargar.Name = "tabCargar";
            this.tabCargar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCargar.Size = new System.Drawing.Size(986, 561);
            this.tabCargar.TabIndex = 1;
            this.tabCargar.Text = "Cargar Flota";
            this.tabCargar.UseVisualStyleBackColor = true;
            // 
            // lblCargar
            // 
            this.lblCargar.AutoSize = true;
            this.lblCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargar.Location = new System.Drawing.Point(26, 44);
            this.lblCargar.Name = "lblCargar";
            this.lblCargar.Size = new System.Drawing.Size(385, 25);
            this.lblCargar.TabIndex = 0;
            this.lblCargar.Text = "Selecciona una base de datos para cargar:";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(876, 39);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(104, 35);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            // 
            // cmbBaseDatos
            // 
            this.cmbBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaseDatos.FormattingEnabled = true;
            this.cmbBaseDatos.Location = new System.Drawing.Point(532, 41);
            this.cmbBaseDatos.Name = "cmbBaseDatos";
            this.cmbBaseDatos.Size = new System.Drawing.Size(312, 33);
            this.cmbBaseDatos.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(969, 445);
            this.dataGridView1.TabIndex = 3;
            // 
            // gpbDatosVehiculo
            // 
            this.gpbDatosVehiculo.Controls.Add(this.maskedTextBox1);
            this.gpbDatosVehiculo.Controls.Add(this.textBox4);
            this.gpbDatosVehiculo.Controls.Add(this.textBox3);
            this.gpbDatosVehiculo.Controls.Add(this.textBox2);
            this.gpbDatosVehiculo.Controls.Add(this.textBox1);
            this.gpbDatosVehiculo.Controls.Add(this.label5);
            this.gpbDatosVehiculo.Controls.Add(this.label4);
            this.gpbDatosVehiculo.Controls.Add(this.label3);
            this.gpbDatosVehiculo.Controls.Add(this.label2);
            this.gpbDatosVehiculo.Controls.Add(this.label1);
            this.gpbDatosVehiculo.Location = new System.Drawing.Point(32, 66);
            this.gpbDatosVehiculo.Name = "gpbDatosVehiculo";
            this.gpbDatosVehiculo.Size = new System.Drawing.Size(255, 323);
            this.gpbDatosVehiculo.TabIndex = 0;
            this.gpbDatosVehiculo.TabStop = false;
            this.gpbDatosVehiculo.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 26);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 26);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 272);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 26);
            this.textBox4.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(95, 198);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(155, 26);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // gpbDatosChofer
            // 
            this.gpbDatosChofer.Controls.Add(this.maskedTextBox2);
            this.gpbDatosChofer.Controls.Add(this.textBox5);
            this.gpbDatosChofer.Controls.Add(this.textBox6);
            this.gpbDatosChofer.Controls.Add(this.textBox7);
            this.gpbDatosChofer.Controls.Add(this.textBox8);
            this.gpbDatosChofer.Controls.Add(this.label6);
            this.gpbDatosChofer.Controls.Add(this.label7);
            this.gpbDatosChofer.Controls.Add(this.label8);
            this.gpbDatosChofer.Controls.Add(this.label9);
            this.gpbDatosChofer.Controls.Add(this.label10);
            this.gpbDatosChofer.Location = new System.Drawing.Point(363, 66);
            this.gpbDatosChofer.Name = "gpbDatosChofer";
            this.gpbDatosChofer.Size = new System.Drawing.Size(255, 323);
            this.gpbDatosChofer.TabIndex = 1;
            this.gpbDatosChofer.TabStop = false;
            this.gpbDatosChofer.Paint += new System.Windows.Forms.PaintEventHandler(this.gpbDatosChofer_Paint);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(95, 198);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(155, 26);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(95, 272);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 26);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(95, 132);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 26);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(95, 84);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(155, 26);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(95, 40);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(155, 26);
            this.textBox8.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "label10";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBox3);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(675, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 323);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contrato";
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox3_Paint);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(95, 198);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(155, 26);
            this.maskedTextBox3.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(95, 272);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(155, 26);
            this.textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(95, 132);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(155, 26);
            this.textBox10.TabIndex = 7;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(95, 84);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(155, 26);
            this.textBox11.TabIndex = 6;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(95, 40);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(155, 26);
            this.textBox12.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "label15";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(852, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(369, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(681, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "label18";
            // 
            // frmPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1018, 618);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPricipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestion de Flotas";
            this.tabControl1.ResumeLayout(false);
            this.tabConsultar.ResumeLayout(false);
            this.tabConsultar.PerformLayout();
            this.tabCargar.ResumeLayout(false);
            this.tabCargar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbDatosVehiculo.ResumeLayout(false);
            this.gpbDatosVehiculo.PerformLayout();
            this.gpbDatosChofer.ResumeLayout(false);
            this.gpbDatosChofer.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbDatosVehiculo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gpbDatosChofer;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}

