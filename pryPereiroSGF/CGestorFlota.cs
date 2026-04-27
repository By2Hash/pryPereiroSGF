using System;
using System.Data.OleDb;

namespace pryPereiroSGF
{
    internal class CGestorFlota
    {
        private readonly string _rutaBD;
        private string _error = "";

        public CGestorFlota(string rutaBD)
        {
            _rutaBD = rutaBD;
        }

        // ── Vehículo (tabla: Vehiculos) ──────────────────────────────────────
        // Columnas reales: Id_Vehiculos, Patente, Marca, Modelo, Mantenimiento, Seguro, Estado
        public string IdVehiculo { get; set; }
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Mantenimiento { get; set; }   // fecha último mantenimiento
        public string Seguro { get; set; }   // vencimiento del seguro
        public string Estado { get; set; }

        // ── Chofer (tabla: Choferes) ─────────────────────────────────────────
        // Columnas reales: Id_Chofer, Nombre_Completo, DNI, Pasaporte, Telefono, Licencia_Conducir
        public string IDChofer { get; set; }
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Pasaporte { get; set; }   // sin campo en el form → se deja vacío
        public string Telefono { get; set; }
        public string Licencia { get; set; }

        // ── Contrato (tabla: Contratos) ──────────────────────────────────────
        // Columnas reales: Id_Contrato, Tipo, Monto_Base, Descripción
        public string IdContrato { get; set; }
        public string TipoContrato { get; set; }
        public string MontoBase { get; set; }
        public string Descripcion { get; set; }

        // ── Alquiler (tabla: Alquileres/Registros) ───────────────────────────
        // Columnas reales: Id_Alquiler, Id_Vehiculo, Id_Chofer, Id_Contratos,
        //                  Fecha_Inicio, Fecha_Fin, Costo_Total, Estado_Cobro
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }   // opcional al dar de alta
        public string CostoTotal { get; set; }   // opcional al dar de alta
        public string EstadoCobro { get; set; }   // opcional al dar de alta

        // ─────────────────────────────────────────────────────────────────────
        // Método principal: guarda los cuatro registros en orden
        // ─────────────────────────────────────────────────────────────────────
        public bool GuardarRegistro()
        {
            if (!ValidarCampos()) return false;

            string cadena = ObtenerCadenaConexion();
            if (string.IsNullOrEmpty(cadena))
            {
                _error = "No se pudo conectar a la base de datos.";
                return false;
            }

            try
            {
                using (var conn = new OleDbConnection(cadena))
                {
                    conn.Open();
                    InsertarVehiculo(conn);
                    InsertarChofer(conn);
                    InsertarContrato(conn);
                    InsertarAlquiler(conn);
                }
                return true;
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
        }

        // ─────────────────────────────────────────────────────────────────────
        // Inserciones individuales
        // ─────────────────────────────────────────────────────────────────────

        private void InsertarVehiculo(OleDbConnection conn)
        {
            const string sql =
                "INSERT INTO Vehiculos " +
                "  (Id_Vehiculos, Patente, Marca, Modelo, Mantenimiento, Seguro, Estado) " +
                "VALUES " +
                "  (@idVeh, @patente, @marca, @modelo, @mant, @seguro, @estado)";

            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idVeh", IdVehiculo ?? "");
                cmd.Parameters.AddWithValue("@patente", Patente ?? "");
                cmd.Parameters.AddWithValue("@marca", Marca ?? "");
                cmd.Parameters.AddWithValue("@modelo", Modelo ?? "");
                cmd.Parameters.AddWithValue("@mant", ParseFecha(Mantenimiento));
                cmd.Parameters.AddWithValue("@seguro", ParseFecha(Seguro));
                cmd.Parameters.AddWithValue("@estado", Estado ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertarChofer(OleDbConnection conn)
        {
            const string sql =
                "INSERT INTO Choferes " +
                "  (Id_Chofer, Nombre_Completo, DNI, Pasaporte, Telefono, Licencia_Conducir) " +
                "VALUES " +
                "  (@id, @nombre, @dni, @pasaporte, @tel, @licencia)";

            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", IDChofer ?? "");
                cmd.Parameters.AddWithValue("@nombre", NombreCompleto ?? "");
                cmd.Parameters.AddWithValue("@dni", DNI ?? "");
                cmd.Parameters.AddWithValue("@pasaporte", Pasaporte ?? "");
                cmd.Parameters.AddWithValue("@tel", Telefono ?? "");
                cmd.Parameters.AddWithValue("@licencia", Licencia ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertarContrato(OleDbConnection conn)
        {
            // Columna "Descripción" tiene tilde — OleDb la acepta entre corchetes
            const string sql =
                "INSERT INTO Contratos " +
                "  (Id_Contrato, Tipo, Monto_Base, [Descripción]) " +
                "VALUES " +
                "  (@idCont, @tipo, @monto, @desc)";

            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idCont", IdContrato ?? "");
                cmd.Parameters.AddWithValue("@tipo", TipoContrato ?? "");
                cmd.Parameters.AddWithValue("@monto", ParseDecimal(MontoBase));
                cmd.Parameters.AddWithValue("@desc", Descripcion ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertarAlquiler(OleDbConnection conn)
        {
            // Tabla con barra oblicua → siempre entre corchetes
            const string sql =
                "INSERT INTO [Alquileres/Registros] " +
                "  (Id_Vehiculo, Id_Chofer, Id_Contratos, Fecha_Inicio, " +
                "   Fecha_Fin, Costo_Total, Estado_Cobro) " +
                "VALUES " +
                "  (@idVeh, @idChofer, @idCont, @fInicio, " +
                "   @fFin, @costo, @estado)";

            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idVeh", IdVehiculo ?? "");
                cmd.Parameters.AddWithValue("@idChofer", IDChofer ?? "");
                cmd.Parameters.AddWithValue("@idCont", IdContrato ?? "");
                cmd.Parameters.AddWithValue("@fInicio", ParseFecha(FechaInicio));
                cmd.Parameters.AddWithValue("@fFin", ParseFecha(FechaFin));   // DBNull si vacío
                cmd.Parameters.AddWithValue("@costo", ParseDecimal(CostoTotal)); // DBNull si vacío
                cmd.Parameters.AddWithValue("@estado", EstadoCobro ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        // ─────────────────────────────────────────────────────────────────────
        // Validaciones
        // ─────────────────────────────────────────────────────────────────────
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(IdVehiculo))
            {
                _error = "El ID del vehículo es obligatorio.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Patente))
            {
                _error = "La patente del vehículo es obligatoria.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(IDChofer))
            {
                _error = "El ID del chofer es obligatorio.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(NombreCompleto))
            {
                _error = "El nombre completo del chofer es obligatorio.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(IdContrato))
            {
                _error = "El ID del contrato es obligatorio.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(TipoContrato))
            {
                _error = "Debe seleccionar el tipo de contrato (Mensual/Semanal).";
                return false;
            }
            if (string.IsNullOrWhiteSpace(FechaInicio))
            {
                _error = "La fecha de inicio del alquiler es obligatoria.";
                return false;
            }
            return true;
        }

        // ─────────────────────────────────────────────────────────────────────
        // Helpers de conversión
        // ─────────────────────────────────────────────────────────────────────
        private static object ParseFecha(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return DBNull.Value;
            if (DateTime.TryParse(texto, out DateTime fecha)) return fecha;
            return DBNull.Value;
        }

        private static object ParseDecimal(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return DBNull.Value;
            if (decimal.TryParse(
                    texto.Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out decimal valor))
                return valor;
            return DBNull.Value;
        }

        // ─────────────────────────────────────────────────────────────────────
        // Conexión (prueba los tres proveedores posibles)
        // ─────────────────────────────────────────────────────────────────────
        private string ObtenerCadenaConexion()
        {
            var providers = new[]
            {
                "Microsoft.ACE.OLEDB.16.0",
                "Microsoft.ACE.OLEDB.12.0",
                "Microsoft.Jet.OLEDB.4.0"
            };

            foreach (var prov in providers)
            {
                string cs = $"Provider={prov};Data Source={_rutaBD};";
                try
                {
                    using (var test = new OleDbConnection(cs))
                    {
                        test.Open();
                        return cs;
                    }
                }
                catch { /* probar el siguiente */ }
            }
            return null;
        }

        public string ObtenerError() => _error;
    }
}