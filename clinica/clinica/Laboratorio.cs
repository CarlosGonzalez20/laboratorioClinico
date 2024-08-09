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
                    if (connection == null)
                    {
                        MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                        return; // Verifica si la conexión fue exitosa
                    }

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
                                    // Asignar valores a los controles del formulario
                                    Fechaasignacion.Value = reader.GetDateTime("fechaAsignacionLaboratorio");
                                    Dir.Text = reader["direccionLaboratorio"].ToString(); // Cambiado a direccionLaboratorio
                                    Horario.Text = reader["horarioLaboratorio"].ToString();

                                    string estadoLaboratorio = reader["estadoLaboratorio"].ToString();
                                    Console.WriteLine($"Estado laboratorio: {estadoLaboratorio}"); // Para depuración

                                    // Cambiar la lógica para TINYINT
                                    if (estadoLaboratorio == "1")
                                    {
                                        estatusActivo.Checked = true;
                                    }
                                    else
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
            // Obtener el ID ingresado por el usuario
            string idIngresado = IDlab.Text.Trim();

            // Verificar si el ID ingresado no está vacío
            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese un ID.");
                return;
            }

            // Intentar convertir el ID a un número entero
            if (!int.TryParse(idIngresado, out int id))
            {
                MessageBox.Show("ID inválido. Asegúrese de ingresar un número entero.");
                return;
            }

            // Definir la consulta SQL para actualizar el estado del laboratorio
            string query = "UPDATE laboratorio SET estadoLaboratorio = 0 WHERE laboratorioID = @id";

            // Establecer la conexión a la base de datos
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                // Verificar si la conexión fue exitosa
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                try
                {
                    // Crear el comando SQL y asignar el parámetro del ID
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        // Ejecutar la consulta y obtener el número de filas afectadas
                        int filasAfectadas = command.ExecuteNonQuery();

                        // Comprobar si se actualizó algún registro
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("El estado del laboratorio se ha actualizado a inactivo.");

                            // Actualizar el DataGridView con los datos más recientes
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
                    // Mostrar un mensaje de error si ocurre alguna excepción
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
        { "Estado", () => estatusActivo.Checked ? "1" : "0" },
        { "Personal Lab ID", () => personalLabIDTextBox.Text.Trim() }, 
        { "Clinica ID", () => clinicaIDTextBox.Text.Trim() }, 
        { "Examen Medico ID", () => examenMedicoIDTextBox.Text.Trim() } 
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
                int personalLabID, clinicaID, examenMedicoID;
                if (!int.TryParse(campos["Documento de Identificación"].Invoke(), out documento) ||
                    !int.TryParse(campos["Personal Lab ID"].Invoke(), out personalLabID) ||
                    !int.TryParse(campos["Clinica ID"].Invoke(), out clinicaID) ||
                    !int.TryParse(campos["Examen Medico ID"].Invoke(), out examenMedicoID))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                DateTime fechaNac = DateTime.Parse(campos["Fecha de Asignacion"].Invoke());
                string direccion = campos["Dirección"].Invoke();
                string Hora = campos["Horario"].Invoke();
                string estados = campos["Estado"].Invoke();

                string query = "INSERT INTO laboratorio (laboratorioID, personalLabID, clinicaID, examenMedicoID, horarioLaboratorio, DireccionLab, fechaAsignacionLaboratorio, estadoLaboratorio) " +
                               "VALUES (@laboratorioID, @personalLabID, @clinicaID, @examenMedicoID, @horarioLaboratorio, @DireccionLab, @fechaAsignacionLaboratorio, @estadoLaboratorio)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@laboratorioID", documento);
                        command.Parameters.AddWithValue("@personalLabID", personalLabID);
                        command.Parameters.AddWithValue("@clinicaID", clinicaID);
                        command.Parameters.AddWithValue("@examenMedicoID", examenMedicoID);
                        command.Parameters.AddWithValue("@fechaAsignacionLaboratorio", fechaNac);
                        command.Parameters.AddWithValue("@DireccionLab", direccion);
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

            // Convertir el ID a entero
            if (!int.TryParse(idIngresado, out int laboratorioID))
            {
                MessageBox.Show("ID de Laboratorio inválido.");
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

                // Validar los campos
                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
    {
        { "Documento de Identificación", () => IDlab.Text.Trim() },
        { "Fecha de Asignacion", () => Fechaasignacion.Value.ToString("yyyy-MM-dd") },
        { "Dirección", () => Dir.Text.Trim() },
        { "Horario", () => Horario.Text.Trim() },
        { "Estado", () => estatusActivo.Checked ? "1" : "0" },
        { "Personal Lab ID", () => personalLabIDTextBox.Text.Trim() }, // Assuming a TextBox for personalLabID
        { "Clinica ID", () => clinicaIDTextBox.Text.Trim() }, // Assuming a TextBox for clinicaID
        { "Examen Medico ID", () => examenMedicoIDTextBox.Text.Trim() } // Assuming a TextBox for examenMedicoID
    };

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
                int personalLabID, clinicaID, examenMedicoID;
                if (!int.TryParse(campos["Personal Lab ID"].Invoke(), out personalLabID) ||
                    !int.TryParse(campos["Clinica ID"].Invoke(), out clinicaID) ||
                    !int.TryParse(campos["Examen Medico ID"].Invoke(), out examenMedicoID))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                DateTime fechaAsignacion = DateTime.Parse(campos["Fecha de Asignacion"].Invoke());
                string direccion = campos["Dirección"].Invoke();
                string horario = campos["Horario"].Invoke();
                string estado = campos["Estado"].Invoke();

                // Definir la consulta SQL de actualización
                string query = "UPDATE laboratorio SET " +
                               "horarioLaboratorio = @horarioLaboratorio, " +
                               "direccionLaboratorio = @direccionLaboratorio, " +
                               "fechaAsignacionLaboratorio = @fechaAsignacionLaboratorio, " +
                               "estadoLaboratorio = @estadoLaboratorio, " +
                               "personalLabID = @personalLabID, " +
                               "clinicaID = @clinicaID, " +
                               "examenMedicoID = @examenMedicoID " +
                               "WHERE laboratorioID = @laboratorioID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@laboratorioID", laboratorioID);
                        command.Parameters.AddWithValue("@personalLabID", personalLabID);
                        command.Parameters.AddWithValue("@clinicaID", clinicaID);
                        command.Parameters.AddWithValue("@examenMedicoID", examenMedicoID);
                        command.Parameters.AddWithValue("@horarioLaboratorio", horario);
                        command.Parameters.AddWithValue("@direccionLaboratorio", direccion);
                        command.Parameters.AddWithValue("@fechaAsignacionLaboratorio", fechaAsignacion);
                        command.Parameters.AddWithValue("@estadoLaboratorio", estado);

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
                catch (MySqlException sqlEx)
                {
                    // Capturar errores específicos de MySQL para una mejor depuración
                    MessageBox.Show($"Error de MySQL: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar los datos: {ex.Message}");
                }
            }

        }
    }
}
