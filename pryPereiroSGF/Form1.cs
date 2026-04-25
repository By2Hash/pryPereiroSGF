using System;
using System.IO;
using System.Windows.Forms;

namespace pryPereiroSGF
{
    public partial class frmPricipal : Form
    {
        // Ruta a la BD local incluida en el proyecto
        private readonly string _rutaBD = Path.Combine(
            Application.StartupPath, "BaseDatos", "pryPereiroSGFaccdb.accdb");

        public frmPricipal()
        {
            InitializeComponent();
            this.Load += frmPricipal_Load;
        }

        // ──────────────────────────────────────────────
        // Carga inicial del formulario
        // ──────────────────────────────────────────────
        private void frmPricipal_Load(object sender, EventArgs e)
        {
            // Opciones del combo de tipo de contrato
            cmbTipo.Items.AddRange(new object[] { "Mensual", "Semanal" });

            // Cargar tablas de la BD local en el ComboBox
            CargarTablas();
        }

        // ──────────────────────────────────────────────
        // Tab "Consultar BD"
        // ──────────────────────────────────────────────
        private void tabConsultar_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Lee las tablas de la BD local y las pone en cmbBaseDatos.
        /// </summary>
        private void CargarTablas()
        {
            cmbBaseDatos.Items.Clear();

            if (!File.Exists(_rutaBD))
            {
                MessageBox.Show(
                    $"No se encontró la base de datos en:\n{_rutaBD}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var conexion = new CConexion();
            var tablas = conexion.ObtenerTablas(_rutaBD);

            if (tablas.Count == 0)
            {
                MessageBox.Show(
                    conexion.ObtenerError().Length > 0
                        ? conexion.ObtenerError()
                        : "No se encontraron tablas en la base de datos.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmbBaseDatos.Items.AddRange(tablas.ToArray());
            cmbBaseDatos.SelectedIndex = 0;   // selecciona la primera tabla
        }

        /// <summary>
        /// Botón Cargar: muestra en el DataGridView la tabla elegida en el combo.
        /// </summary>
        private void btnCargar_Click(object sender, EventArgs e)
        {
            string tabla = cmbBaseDatos.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tabla))
            {
                MessageBox.Show("Seleccione una tabla para cargar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conexion = new CConexion();
            bool ok = conexion.MostrarEnGrilla(_rutaBD, tabla, dgvDatos);

            if (!ok)
                MessageBox.Show(conexion.ObtenerError(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ──────────────────────────────────────────────
        // Tab "Cargar Flota"
        // ──────────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var gestor = new CGestorFlota(_rutaBD)
            {
                // Datos del vehículo
                Patente = txtPatente.Text.Trim(),
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                VencimientoSeguro = mskVencimiento.Text.Trim(),
                UltimoMant = txtUltMant.Text.Trim(),

                // Datos del chofer
                IDChofer = txtIDChofer.Text.Trim(),
                NombreCompleto = txtNombreCompleto.Text.Trim(),
                DNI = txtDNI.Text.Trim(),
                Telefono = mskTelefono.Text.Trim(),
                Licencia = txtLicencia.Text.Trim(),

                // Datos del contrato
                TipoContrato = cmbTipo.SelectedItem?.ToString(),
                MontoAlquilado = txtMontoAlquilado.Text.Trim(),
                FechaInicio = mskFechaInicio.Text.Trim()
            };

            bool ok = gestor.GuardarRegistro();

            if (ok)
            {
                MessageBox.Show(
                    "Registro guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();   // limpia el formulario tras guardar
            }
            else
            {
                MessageBox.Show(
                    gestor.ObtenerError(),
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        // ──────────────────────────────────────────────
        // Pintura de GroupBoxes
        // ──────────────────────────────────────────────
        private void groupBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            PintarGroupBox(sender, e);
        }

        private void gpbDatosChofer_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            PintarGroupBox(sender, e);
        }

        private void groupBox3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            PintarGroupBox(sender, e);
        }

        private static void PintarGroupBox(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var box = (GroupBox)sender;
            using (var pen = new System.Drawing.Pen(System.Drawing.Color.Black, 2))
                e.Graphics.DrawRectangle(pen, 0, 10, box.Width - 1, box.Height - 11);
        }

   


    private void LimpiarCampos()
        {
            // Vehículo
            txtPatente.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            mskVencimiento.Clear();
            txtUltMant.Clear();

            // Chofer
            txtIDChofer.Clear();
            txtNombreCompleto.Clear();
            txtDNI.Clear();
            mskTelefono.Clear();
            txtLicencia.Clear();

            // Contrato
            cmbTipo.SelectedIndex = -1;
            txtMontoAlquilado.Clear();
            mskFechaInicio.Clear();

            // Foco al primer campo
            txtPatente.Focus();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}