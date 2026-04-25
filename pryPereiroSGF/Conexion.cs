using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace pryPereiroSGF
{
    internal class CConexion
    {
        private string ERROR = "";

        public bool MostrarEnGrilla(string rutaArchivo, string nombreTabla, DataGridView grilla)
        {
            bool resultado = false;
            string cadenaConexion = ObtenerCadenaConexion(rutaArchivo);

            if (string.IsNullOrEmpty(cadenaConexion))
            {
                ERROR = "No se encontró un proveedor OLEDB disponible. " +
                        "Instale Microsoft Access Database Engine (ACE).";
                return false;
            }

            try
            {
                string safeTable = nombreTabla.StartsWith("[") ? nombreTabla : "[" + nombreTabla + "]";
                string query = "SELECT * FROM " + safeTable;

                using (var conn = new OleDbConnection(cadenaConexion))
                using (var cmd = new OleDbCommand(query, conn))
                using (var da = new OleDbDataAdapter(cmd))
                {
                    var table = new DataTable();
                    da.Fill(table);
                    grilla.DataSource = table;
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
            }

            return resultado;
        }

        public List<string> ObtenerTablas(string rutaArchivo)
        {
            var tablas = new List<string>();
            string cadenaConexion = ObtenerCadenaConexion(rutaArchivo);

            if (string.IsNullOrEmpty(cadenaConexion))
            {
                ERROR = "No se encontró un proveedor OLEDB disponible.";
                return tablas;
            }

            try
            {
                using (var conn = new OleDbConnection(cadenaConexion))
                {
                    conn.Open();
                    var schema = conn.GetSchema("Tables");

                    foreach (DataRow row in schema.Rows)
                    {
                        string tableType = row["TABLE_TYPE"]?.ToString();
                        if (string.Equals(tableType, "TABLE", StringComparison.OrdinalIgnoreCase) ||
                            string.Equals(tableType, "VIEW", StringComparison.OrdinalIgnoreCase))
                        {
                            string tableName = row["TABLE_NAME"]?.ToString();
                            if (!string.IsNullOrEmpty(tableName) && !tableName.StartsWith("MSys"))
                                tablas.Add(tableName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ERROR = ex.Message;
            }

            return tablas;
        }

        private string ObtenerCadenaConexion(string rutaArchivo)
        {
            string extension = Path.GetExtension(rutaArchivo).ToLower();
            var providers = new List<string>();

            if (extension == ".mdb")
            {
                providers.Add("Microsoft.Jet.OLEDB.4.0");
                providers.Add("Microsoft.ACE.OLEDB.16.0");
                providers.Add("Microsoft.ACE.OLEDB.12.0");
            }
            else if (extension == ".accdb")
            {
                providers.Add("Microsoft.ACE.OLEDB.16.0");
                providers.Add("Microsoft.ACE.OLEDB.12.0");
            }

            foreach (var provider in providers)
            {
                string cs = $"Provider={provider};Data Source={rutaArchivo};";
                try
                {
                    using (var cnn = new OleDbConnection(cs))
                    {
                        cnn.Open();
                        return cs;
                    }
                }
                catch { /* probar siguiente */ }
            }

            return null;
        }

        public string ObtenerError() => ERROR;
    }
}