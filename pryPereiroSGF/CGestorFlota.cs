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

       

        // Vehículo
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string VencimientoSeguro { get; set; }
        public string UltimoMant { get; set; }

        // Chofer
        public string IDChofer { get; set; }
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Licencia { get; set; }

        // Contrato
        public string TipoContrato { get; set; }
        public string MontoAlquilado { get; set; }
        public string FechaInicio { get; set; }
        // Método principal: guarda los tres registros

      
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
                }
                return true;
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
        }

        // Inserciones individuales

        private void InsertarVehiculo(OleDbConnection conn)
        {
            // ⚠ Ajustá el nombre de tabla y columnas a tu BD real
            const string sql =
                "INSERT INTO Vehiculos " +
                "  (Patente, Marca, Modelo, VencimientoSeguro, UltimoMantenimiento) " +
                "VALUES " +
                "  (@patente, @marca, @modelo, @vencimiento, @ultMant)";

            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@patente", Patente ?? "");
                cmd.Parameters.AddWithValue("@marca", Marca ?? "");
                cmd.Parameters.AddWithValue("@modelo", Modelo ?? "");
                cmd.Parameters.AddWithValue("@vencimiento", ParseFecha(VencimientoSeguro));
                cmd.Parameters.AddWithValue("@ultMant", UltimoMant ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertarChofer(OleDbConnection conn)
        {
            // ⚠ Ajustá el nombre de tabla y columnas a tu BD real
            const string sql =
                "INSERT INTO Choferes " +
                "  (IDChofer, NombreCompleto, DNI, Telefono, Licencia) " +
                "VALUES " +
                "  (@id, @nombre, @dni, @tel, @licencia)";

            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", IDChofer ?? "");
                cmd.Parameters.AddWithValue("@nombre", NombreCompleto ?? "");
                cmd.Parameters.AddWithValue("@dni", DNI ?? "");
                cmd.Parameters.AddWithValue("@tel", Telefono ?? "");
                cmd.Parameters.AddWithValue("@licencia", Licencia ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertarContrato(OleDbConnection conn)
        {
            const string sql =
                "INSERT INTO Contratos " +
                "  (IDChofer, PatenteVehiculo, TipoContrato, MontoAlquilado, FechaInicio) " +
                "VALUES " +
                "  (@idChofer, @patente, @tipo, @monto, @fecha)";

            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idChofer", IDChofer ?? "");
                cmd.Parameters.AddWithValue("@patente", Patente ?? "");
                cmd.Parameters.AddWithValue("@tipo", TipoContrato ?? "");
                cmd.Parameters.AddWithValue("@monto", ParseDecimal(MontoAlquilado));
                cmd.Parameters.AddWithValue("@fecha", ParseFecha(FechaInicio));
                cmd.ExecuteNonQuery();
            }
        }
        // Validaciones

        private bool ValidarCampos()
        {
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
            if (string.IsNullOrWhiteSpace(TipoContrato))
            {
                _error = "Debe seleccionar el tipo de contrato.";
                return false;
            }
            return true;
        }

        // Helpers de conversión

        private static object ParseFecha(string texto)
        {
            if (DateTime.TryParse(texto, out DateTime fecha))
                return fecha;
            return DBNull.Value;
        }

        private static object ParseDecimal(string texto)
        {
            if (decimal.TryParse(
                    texto?.Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out decimal valor))
                return valor;
            return DBNull.Value;
        }

        // Conexión (misma lógica que CConexion)

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