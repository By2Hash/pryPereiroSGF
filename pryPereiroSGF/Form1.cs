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

        // ──────────────────────────────────────────────────────────────────────
        // Carga inicial del formulario
        // ──────────────────────────────────────────────────────────────────────
        private void frmPricipal_Load(object sender, EventArgs e)
        {
            // Opciones del combo de tipo de contrato
            cmbTipo.Items.AddRange(new object[] { "Mensual", "Semanal" });

            // Cargar tablas de la BD local en el ComboBox
            CargarTablas();
        }

        // ──────────────────────────────────────────────────────────────────────
        // Tab "Consultar BD"
        // ──────────────────────────────────────────────────────────────────────
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
            cmbBaseDatos.SelectedIndex = 0;
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

        // ──────────────────────────────────────────────────────────────────────
        // Tab "Cargar Flota" — Guardar registro
        // ──────────────────────────────────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var gestor = new CGestorFlota(_rutaBD)
            {
                // ── Datos del Vehículo ─────────────────────────────────────
                // Columnas BD: Id_Vehiculos, Patente, Marca, Modelo,
                //              Mantenimiento, Seguro, Estado
                IdVehiculo = txtIdVehiculo.Text.Trim(),
                Patente = txtPatente.Text.Trim(),
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Mantenimiento = txtMantenimiento.Text.Trim(),
                Seguro = mskVencimiento.Text.Trim(),   // vencimiento del seguro
                Estado = txtEstado.Text.Trim(),

                // ── Datos del Chofer ───────────────────────────────────────
                // Columnas BD: Id_Chofer, Nombre_Completo, DNI,
                //              Pasaporte, Telefono, Licencia_Conducir
                IDChofer = txtIDChofer.Text.Trim(),
                NombreCompleto = txtNombreCompleto.Text.Trim(),
                DNI = txtDNI.Text.Trim(),
                Pasaporte = "",                           // sin campo en el form
                Telefono = mskTelefono.Text.Trim(),
                Licencia = txtLicencia.Text.Trim(),

                // ── Datos del Contrato ─────────────────────────────────────
                // Columnas BD: Id_Contrato, Tipo, Monto_Base, Descripción
                IdContrato = txtIdContrato.Text.Trim(),
                TipoContrato = cmbTipo.SelectedItem?.ToString(),
                MontoBase = txtMontoAlquilado.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),

                // ── Datos del Alquiler ─────────────────────────────────────
                // Columnas BD: Id_Vehiculo, Id_Chofer, Id_Contratos,
                //              Fecha_Inicio, Fecha_Fin, Costo_Total, Estado_Cobro
                // FechaInicio viene del campo "Fecha Inicio" (txtDescripcion
                // fue reutilizado en el diseñador — ver nota abajo)
                FechaInicio = txtDescripcion.Text.Trim(),
                // Los siguientes campos son opcionales al dar de alta:
                FechaFin = "",
                CostoTotal = "",
                EstadoCobro = ""
            };

            // NOTA: en el diseñador, lblDescripcion.Text = "Fecha Inicio" y
            // txtDescripcion es el campo multilinea bajo "Fecha Inicio".
            // Si preferís separar Descripción del contrato y Fecha Inicio del
            // alquiler, agregá un TextBox extra en el GroupBox de Contrato para
            // la descripción, y usá txtDescripcion sólo para la fecha.

            bool ok = gestor.GuardarRegistro();

            if (ok)
            {
                MessageBox.Show(
                    "Registro guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();
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

        // ──────────────────────────────────────────────────────────────────────
        // Limpiar todos los campos del formulario
        // ──────────────────────────────────────────────────────────────────────
        private void LimpiarCampos()
        {
            // Vehículo
            txtIdVehiculo.Clear();
            txtPatente.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtMantenimiento.Clear();
            mskVencimiento.Clear();
            txtEstado.Clear();

            // Chofer
            txtIDChofer.Clear();
            txtNombreCompleto.Clear();
            txtDNI.Clear();
            mskTelefono.Clear();
            txtLicencia.Clear();

            // Contrato / Alquiler
            txtIdContrato.Clear();
            cmbTipo.SelectedIndex = -1;
            txtMontoAlquilado.Clear();
            txtDescripcion.Clear();

            // Foco al primer campo
            txtIdVehiculo.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) { }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ──────────────────────────────────────────────────────────────────────
        // Pintura de GroupBoxes (sin implementación activa)
        // ──────────────────────────────────────────────────────────────────────
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

        private static void PintarGroupBox(object sender, System.Windows.Forms.PaintEventArgs e) { }

        private void gpbDatosVehiculo_Enter(object sender, EventArgs e) { }
    }
}