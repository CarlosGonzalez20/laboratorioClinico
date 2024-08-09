using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MySql.Data.MySqlClient;

namespace clinica
{
    public partial class Laboratorio : MaterialSkin.Controls.MaterialForm
    {
        private void CargarDatosLaboratorio()
        {
            string query = "SELECT * FROM laboratorio";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos. laboratorio");
                    return;
                }

                try
                {
                    // Crear adaptador y llenar el DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    infoLab.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de los laboratorio: {ex.Message}");
                }
            }
        }
        public Laboratorio()
        {
            InitializeComponent();
        }

        private void Laboratorio_Load(object sender, EventArgs e)
        {

        }

        private void buscarPaciente_Click(object sender, EventArgs e)
        {
            CargarDatosLaboratorio();
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string expedienteID = IDlab.Text.Trim();

                if (string.IsNullOrEmpty(expedienteID))
                {
                    MessageBox.Show("Por favor, ingrese un número de expediente.");
                    return;
                }

                string query = "SELECT * FROM laboratorio WHERE laboratorioID = @laboratorioID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@laboratorioID", expedienteID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Fechaasignacion.Value = reader.GetDateTime("fechaAsignacionLaboratorio");
                                Dir.Text = reader["direccionProveedor"].ToString();
                                Horario.Text = reader["horarioLaboratorio"].ToString();

                                string estadoPaciente = reader["estadoLaboratorio"].ToString();
                                Console.WriteLine($"Estado laboratorio: {estadoPaciente}"); // Para depuración
                                if (estadoPaciente == "true")
                                {
                                    estatusActivo.Checked = true;
                                }
                                else if (estadoPaciente == "false")
                                {
                                    estadoInactivo.Checked = true;
                                }

                                // Seleccionar la fila en el DataGridView
                                foreach (DataGridViewRow row in infoLab.Rows)
                                {
                                    if (row.Cells["laboratorioID"].Value.ToString() == expedienteID)
                                    {
                                        row.Selected = true;
                                        infoLab.FirstDisplayedScrollingRowIndex = row.Index;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró un laboratorio con ese número de expediente.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar el laboratorio: {ex.Message}");
                }
            }
        }

        private void eliminarPaciente_Click(object sender, EventArgs e)
        {
            string idIngresado = IDlab.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }
            if (!int.TryParse(idIngresado, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            string query = "UPDATE laboratorio SET estadoLaboratorio = 0 WHERE laboratorioID = @id";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int filasAfectadas = command.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("El estado del laboratorio se ha actualizado a inactivo.");
                            CargarDatosLaboratorio();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado del laboratorio: {ex.Message}");
                }
            }

        }

        private void ingresarPaciente_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
                {
                    { "Documento de Identificación", () => IDlab.Text.Trim() },
                    { "Fecha de Asignacion", () => Fechaasignacion.Value.ToString("yyyy-MM-dd") },
                    { "Dirección", () => Dir.Text.Trim() },
                    { "Horario", () => Horario.Text.Trim() },
                    { "Estado", () => estatusActivo.Checked ? "1" : "0" }
                };

                // Validar los campos
                foreach (var campo in campos)
                {
                    string valor = campo.Value.Invoke();
                    if (string.IsNullOrEmpty(valor))
                    {
                        MessageBox.Show($"El campo '{campo.Key}' es obligatorio.");
                        return;
                    }
                }

                // Convertir los valores necesarios a sus tipos correspondientes
                int documento;
                if (!int.TryParse(campos["Documento de Identificación"].Invoke(), out documento))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                DateTime fechaNac = DateTime.Parse(campos["Fecha de Asignacion"].Invoke());
                string direccion = campos["Dirección"].Invoke();
                string Hora = campos["Horario"].Invoke();
                string estados = campos["Estado"].Invoke();
                string query = "INSERT INTO laboratorio (laboratorioID, horarioLaboratorio, direccionLaboratorio, fechaAsignacionLaboratorio, estadoLaboratorio) " +
                               "VALUES (@laboratorioID, @horarioLaboratorio, @direccionLaboratorio, @fechaAsignacionLaboratorio, @estadoLaboratorio)";


                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@laboratorioID", documento);
                        command.Parameters.AddWithValue("@fechaAsignacionLaboratorio", fechaNac);
                        command.Parameters.AddWithValue("@direccionLaboratorio", direccion);
                        command.Parameters.AddWithValue("@horarioLaboratorio", Hora);
                        command.Parameters.AddWithValue("@estadoLaboratorio", estados);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos ingresados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al ingresar los datos: {ex.Message}");
                }
            }
            CargarDatosLaboratorio();
        }

        private void modificarPaciente_Click(object sender, EventArgs e)
        {
            string idIngresado = IDlab.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese el ID del Laboratorio que desea modificar.");
                return;
            }

            // Convertir el ID a entero (ajusta si tu ID es de otro tipo de dato)
            if (!int.TryParse(idIngresado, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                // Definir la consulta SQL de actualización
                string query = "UPDATE laboratorio SET " +
                               "horarioLaboratorio = @horarioLaboratorio, " +
                               "actividadLaboratorio = @actividadLaboratorio, " +
                               "fechaAsignacionLaboratorio = @fechaAsignacionLaboratorio, " +
                               "estadoLaboratorio = @estadoLaboratorio " +
                               "WHERE laboratorioID = @laboratorioID";



                // Validar los campos
                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
        {
                    { "Documento de Identificación", () => IDlab.Text.Trim() },
                    { "Fecha de Asignacion", () => Fechaasignacion.Value.ToString("yyyy-MM-dd") },
                    { "Dirección", () => Dir.Text.Trim() },
                    { "Horario", () => Horario.Text.Trim() },
                    { "Estado", () => estatusActivo.Checked ? "1" : "0" }
        };

                // Validar los campos
                foreach (var campo in campos)
                {
                    string valor = campo.Value.Invoke();
                    if (string.IsNullOrEmpty(valor))
                    {
                        MessageBox.Show($"El campo '{campo.Key}' es obligatorio.");
                        return;
                    }
                }

                // Convertir los valores necesarios a sus tipos correspondientes
                int documento;
                if (!int.TryParse(campos["Documento de Identificación"].Invoke(), out documento))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                DateTime fechaNac = DateTime.Parse(campos["Fecha de Asignacion"].Invoke());
                string direccion = campos["Dirección"].Invoke();
                string Hora = campos["Horario"].Invoke();
                string estados = campos["Estado"].Invoke();

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@laboratorioID", documento);
                        command.Parameters.AddWithValue("@fechaAsignacionLaboratorio", fechaNac);
                        command.Parameters.AddWithValue("@direccionLaboratorio", direccion);
                        command.Parameters.AddWithValue("@horarioLaboratorio", Hora);
                        command.Parameters.AddWithValue("@estadoLaboratorio", estados);

                        // Ejecutar la consulta
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Datos modificados correctamente.");

                            // Opcional: Actualizar el DataGridView
                            CargarDatosLaboratorio();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar los datos: {ex.Message}");
                }
            }
        }
    }
}
