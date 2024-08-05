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

    public partial class Medico : MaterialSkin.Controls.MaterialForm
    {
        public Medico()
        {
            InitializeComponent();
            CargarDatosEspecialidades();
            CargarDatosMedico();
            CargarDatosGenero_TipoUsu_Especialidad();
        }

        private void CargarDatosEspecialidades()
        {
            string query = "SELECT * FROM especialidad";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos. Medico");
                    return;
                }

                try
                {
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    infoEspecialidad.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de especialidades: {ex.Message}");
                }
            }
        }

        private void CargarDatosMedico()
        {
            string query = "SELECT * FROM medico";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos. Medico");
                    return;
                }

                try
                {
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    infoMedicos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de médicos: {ex.Message}");
                }
            }
        }

        private void CargarDatosGenero_TipoUsu_Especialidad()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;
                // Llenar el ComboBox para tipoUsuario
                string tipoUsuarioQuery = "SELECT tipoUsuarioID FROM tipoUsuario";
                MySqlCommand tipoUsuarioCommand = new MySqlCommand(tipoUsuarioQuery, connection);
                try
                {
                    MySqlDataReader tipoUsuarioReader = tipoUsuarioCommand.ExecuteReader();
                    tipoUsuario.Items.Clear();
                    while (tipoUsuarioReader.Read())
                    {
                        int tipoUsuarioID = tipoUsuarioReader.GetInt32("tipoUsuarioID");
                        tipoUsuario.Items.Add(tipoUsuarioID);
                    }
                    if (tipoUsuario.Items.Count > 0)
                    {
                        tipoUsuario.SelectedIndex = 0;
                    }
                    tipoUsuarioReader.Close();

                    // Llenar el ComboBox para genero
                    string generoQuery = "SELECT generoID FROM genero";
                    MySqlCommand generoCommand = new MySqlCommand(generoQuery, connection);

                    MySqlDataReader generoReader = generoCommand.ExecuteReader();
                    sexoMedico.Items.Clear();
                    while (generoReader.Read())
                    {
                        int generoID = generoReader.GetInt32("generoID");
                        sexoMedico.Items.Add(generoID);
                    }
                    if (sexoMedico.Items.Count > 0)
                    {
                        sexoMedico.SelectedIndex = 0;
                    }
                    generoReader.Close();

                    // Llenar el ComboBox para especialidad
                    string especialidadQuery = "SELECT especialidadID FROM especialidad";
                    MySqlCommand especialidadCommand = new MySqlCommand(especialidadQuery, connection);

                    MySqlDataReader especialidadReader = especialidadCommand.ExecuteReader();
                    especialidadMedico.Items.Clear();
                    while (especialidadReader.Read())
                    {
                        int especialidadID = especialidadReader.GetInt32("especialidadID");
                        especialidadMedico.Items.Add(especialidadID);
                    }
                    if (especialidadMedico.Items.Count > 0)
                    {
                        especialidadMedico.SelectedIndex = 0;
                    }
                    generoReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar los ComboBox: " + ex.Message);
                }
            }
        }

        private void Medico_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buscarEspecialidad_Click(object sender, EventArgs e)
        {
            CargarDatosEspecialidades();
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string especialidadMedID = especialidadID.Text.Trim();

                if (string.IsNullOrEmpty(especialidadMedID))
                {
                    MessageBox.Show("Por favor, ingrese un número de especialidad.");
                    return;
                }

                string query = "SELECT * FROM especialidad WHERE especialidadID = @especialidadID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@especialidadID", especialidadMedID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombreEspecialidad.Text = reader["nombreEspecialidad"].ToString();
                                descripcionEspecialidad.Text = reader["descripcionEspecialidad"].ToString();

                                string estadoPaciente = reader["estadoEspecialidad"].ToString();
                                Console.WriteLine($"Estado Paciente: {estadoPaciente}"); // Para depuración
                                if (estadoPaciente == "true")
                                {
                                    estadoActivo.Checked = true;
                                }
                                else if (estadoPaciente == "false")
                                {
                                    estadoInactivo.Checked = true;
                                }

                                // Seleccionar la fila en el DataGridView
                                foreach (DataGridViewRow row in infoEspecialidad.Rows)
                                {
                                    if (row.Cells["especialidadID"].Value.ToString() == especialidadMedID)
                                    {
                                        row.Selected = true;
                                        infoEspecialidad.FirstDisplayedScrollingRowIndex = row.Index;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró una especialidad con ese número.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar la especialidad: {ex.Message}");
                }
            }

        }

        private void ingresarEspecialidad_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
                {
                    { "Nombre", () => nombreEspecialidad.Text.Trim() },
                    { "Descripcion", () => descripcionEspecialidad.Text.Trim() },
                    { "Estado", () => estadoActivo.Checked ? "1" : "0" }
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

                string nombre = campos["Nombre"].Invoke();
                string descripcion = campos["Descripcion"].Invoke();
                string estados = campos["Estado"].Invoke();

                string query = "INSERT INTO especialidad (nombreEspecialidad, descripcionEspecialidad, estadoEspecialidad) " +
                               "VALUES (@nombreEspecialidad, @descripcionEspecialidad, @estadoEspecialidad)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@nombreEspecialidad", nombre);
                        command.Parameters.AddWithValue("@descripcionEspecialidad", descripcion);
                        command.Parameters.AddWithValue("@estadoEspecialidad", estados);

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
            CargarDatosEspecialidades();
        }

        private void eliminarEspecialidad_Click(object sender, EventArgs e)
        {
            string idIngresado = especialidadID.Text.Trim();

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

            string query = "UPDATE especialidad SET estadoEspecialidad = 0 WHERE especialidadID = @id";
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
                            MessageBox.Show("El estado de la especialidad se ha actualizado a inactivo.");
                            CargarDatosEspecialidades();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado de la especialidad: {ex.Message}");
                }
            }
        }

        private void modificarEspecialidad_Click(object sender, EventArgs e)
        {
            string idIngresado = especialidadID.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese el ID de la especialidad que desea modificar.");
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
                string query = "UPDATE especialidad SET " +
                               "nombreEspecialidad = @nombreEspecialidad, " +
                               "descripcionEspecialidad = @descripcionEspecialidad, " +
                               "estadoEspecialidad = @estadoEspecialidad " +
                               "WHERE especialidadID = @id";

                // Validar los campos
                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
                {
                    { "Nombre", () => nombreEspecialidad.Text.Trim() },
                    { "Descripcion", () => descripcionEspecialidad.Text.Trim() },
                    { "Estado", () => estadoActivo.Checked ? "1" : "0" }
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

                string nombre = campos["Nombre"].Invoke();
                string descripcion = campos["Descripcion"].Invoke();
                string estados = campos["Estado"].Invoke();

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@nombreEspecialidad", nombre);
                        command.Parameters.AddWithValue("@descripcionEspecialidad", descripcion);
                        command.Parameters.AddWithValue("@estadoEspecialidad", estados);
                        command.Parameters.AddWithValue("@id", id);

                        // Ejecutar la consulta
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Datos modificados correctamente.");

                            // Opcional: Actualizar el DataGridView
                            CargarDatosEspecialidades();
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

        private void buscarMedico_Click(object sender, EventArgs e)
        {
            CargarDatosMedico();
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                string matriculaID = matricula.Text.Trim();

                if (string.IsNullOrEmpty(matriculaID))
                {
                    MessageBox.Show("Por favor, ingrese un número de matricula.");
                    return;
                }

                string query = "SELECT * FROM medico WHERE medicoID = @medicoID";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@medicoID", matriculaID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tipoUsuario.SelectedItem = reader["tipoUsuarioID"].ToString();
                                documentoIdentificacion.Text = reader["numeroDocumento"].ToString();
                                nombresMedico.Text = reader["nombreMedico"].ToString();
                                apellidosMedico.Text = reader["apellidoMedico"].ToString();
                                sexoMedico.SelectedItem = reader["generoID"].ToString();
                                sexoMedico.SelectedItem = reader["especialidadID"].ToString();
                                fechaNacMedico.Value = reader.GetDateTime("fechaNacimientoMedico");
                                fechaRegMedico.Value = reader.GetDateTime("fechaRegistro");
                                telefonoMedico.Text = reader["telefonoMedico"].ToString();
                                correoMedico.Text = reader["emailMedico"].ToString();
                                medicoAsociado.Text = reader["medicoAsociado"].ToString();

                                string estadoMedico = reader["estadoMedico"].ToString();
                                Console.WriteLine($"Estado Medico: {estadoMedico}"); // Para depuración
                                if (estadoMedico == "true")
                                {
                                    estatusActivo.Checked = true;
                                }
                                else if (estadoMedico == "false")
                                {
                                    estatusInactivo.Checked = true;
                                }

                                // Seleccionar la fila en el DataGridView
                                foreach (DataGridViewRow row in infoMedicos.Rows)
                                {
                                    if (row.Cells["medicoID"].Value.ToString() == matriculaID)
                                    {
                                        row.Selected = true;
                                        infoMedicos.FirstDisplayedScrollingRowIndex = row.Index;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró un medico con ese número de matrícula.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar el médico: {ex.Message}");
                }
            }

        }

        private void ingresarMedico_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
        {
            { "Tipo de Usuario", () => tipoUsuario.SelectedItem?.ToString() },
            { "Documento de Identificación", () => documentoIdentificacion.Text.Trim() },
            { "Nombre", () => nombresMedico.Text.Trim() },
            { "Apellido", () => apellidosMedico.Text.Trim() },
            { "Género", () => sexoMedico.SelectedItem?.ToString() },
            { "Especialidad", () => especialidadMedico.SelectedItem?.ToString() },
            { "Fecha de Nacimiento", () => fechaNacMedico.Value.ToString("yyyy-MM-dd") },
            { "Fecha de Ingreso", () => fechaRegMedico.Value.Date.ToString("yyyy-MM-dd") },
            { "Teléfono", () => telefonoMedico.Text.Trim() },
            { "Correo", () => correoMedico.Text.Trim() },
            { "Asociado", () => medicoAsociado.Checked ? "1" : "0" },
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
                int tipoUsu;
                long documento;
                long telefono;
                int genero;
                int especialidad;
                if (!int.TryParse(campos["Tipo de Usuario"].Invoke(), out tipoUsu) ||
                    !long.TryParse(campos["Documento de Identificación"].Invoke(), out documento) ||
                    !long.TryParse(campos["Teléfono"].Invoke(), out telefono) ||
                    !int.TryParse(campos["Género"].Invoke(), out genero) ||
                    !int.TryParse(campos["Especialidad"].Invoke(), out especialidad))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                string nombre = campos["Nombre"].Invoke();
                string apellido = campos["Apellido"].Invoke();
                DateTime fechaNac = DateTime.Parse(campos["Fecha de Nacimiento"].Invoke());
                DateTime fechaIng = DateTime.Parse(campos["Fecha de Ingreso"].Invoke());
                string asociado = campos["Asociado"].Invoke();
                string estados = campos["Estado"].Invoke();
                string correo = correoMedico.Text.Trim();

                string query = "INSERT INTO medico (tipoUsuarioID, numeroDocumento, nombreMedico, apellidoMedico, generoID, especialidadID, fechaNacimientoMedico, fechaRegistro, telefonoMedico, emailMedico, medicoAsociado, estadoMedico) " +
                               "VALUES (@tipoUsuarioID, @numeroDocumento, @nombreMedico, @apellidoMedico, @generoID, @especialidadID, @fechaNacimientoMedico, @fechaRegistro, @telefonoMedico, @emailMedico, @medicoAsociado, @estadoMedico)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@tipoUsuarioID", tipoUsu);
                        command.Parameters.AddWithValue("@numeroDocumento", documento);
                        command.Parameters.AddWithValue("@nombreMedico", nombre);
                        command.Parameters.AddWithValue("@apellidoMedico", apellido);
                        command.Parameters.AddWithValue("@generoID", genero);
                        command.Parameters.AddWithValue("@especialidadID", especialidad);
                        command.Parameters.AddWithValue("@fechaNacimientoMedico", fechaNac);
                        command.Parameters.AddWithValue("@fechaRegistro", fechaIng);
                        command.Parameters.AddWithValue("@telefonoMedico", telefono);
                        command.Parameters.AddWithValue("@emailMedico", correo);
                        command.Parameters.AddWithValue("@medicoAsociado", asociado);
                        command.Parameters.AddWithValue("@estadoMedico", estados);

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
            CargarDatosMedico();
        }

        private void modificarMedico_Click(object sender, EventArgs e)
        {
            string idIngresado = matricula.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese el ID del médico que desea modificar.");
                return;
            }

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

                string query = "UPDATE medico SET " +
                               "tipoUsuarioID = @tipoUsuarioID, " +
                               "numeroDocumento = @numeroDocumento, " +
                               "nombreMedico = @nombreMedico, " +
                               "apellidoMedico = @apellidoMedico, " +
                               "generoID = @generoID, " +
                               "especialidadID = @especialidadID, " +
                               "fechaNacimientoMedico = @fechaNacimientoMedico, " +
                               "fechaRegistro = @fechaRegistro, " +
                               "telefonoMedico = @telefonoMedico, " +
                               "emailMedico = @emailMedico, " +
                               "medicoAsociado = @medicoAsociado, " +
                               "estadoMedico = @estadoMedico " +
                               "WHERE medicoID = @id";

                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
        {
            { "Tipo de Usuario", () => tipoUsuario.SelectedItem.ToString() },  // Asegúrate de que SelectedValue esté configurado
            { "Documento de Identificación", () => documentoIdentificacion.Text.Trim() },
            { "Nombre", () => nombresMedico.Text.Trim() },
            { "Apellido", () => apellidosMedico.Text.Trim() },
            { "Género", () => sexoMedico.SelectedItem.ToString() },  // Asegúrate de que SelectedValue esté configurado
            { "Especialidad", () => especialidadMedico.SelectedItem.ToString() },  // Asegúrate de que SelectedValue esté configurado
            { "Fecha de Nacimiento", () => fechaNacMedico.Value.ToString("yyyy-MM-dd") },
            { "Fecha de Ingreso", () => fechaRegMedico.Value.ToString("yyyy-MM-dd") },
            { "Teléfono", () => telefonoMedico.Text.Trim() },
            { "Correo", () => correoMedico.Text.Trim() },
            { "Asociado", () => medicoAsociado.Checked ? "1" : "0" },
            { "Estado", () => estatusActivo.Checked ? "1" : "0" }
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

                int tipoUsu, genero, documento, telefono, especialidad;
                if (!int.TryParse(campos["Tipo de Usuario"].Invoke(), out tipoUsu) ||
                    !int.TryParse(campos["Documento de Identificación"].Invoke(), out documento) ||
                    !int.TryParse(campos["Teléfono"].Invoke(), out telefono) ||
                    !int.TryParse(campos["Especialidad"].Invoke(), out especialidad) ||
                    !int.TryParse(campos["Género"].Invoke(), out genero))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                string nombre = campos["Nombre"].Invoke();
                string apellido = campos["Apellido"].Invoke();
                DateTime fechaNac = DateTime.Parse(campos["Fecha de Nacimiento"].Invoke());
                DateTime fechaIng = DateTime.Parse(campos["Fecha de Ingreso"].Invoke());
                string correo = campos["Correo"].Invoke();
                string asociado = campos["Asociado"].Invoke();
                string estados = campos["Estado"].Invoke();

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tipoUsuarioID", tipoUsu);
                        command.Parameters.AddWithValue("@numeroDocumento", documento);
                        command.Parameters.AddWithValue("@nombreMedico", nombre);
                        command.Parameters.AddWithValue("@apellidoMedico", apellido);
                        command.Parameters.AddWithValue("@generoID", genero);
                        command.Parameters.AddWithValue("@especialidadID", especialidad);
                        command.Parameters.AddWithValue("@fechaNacimientoMedico", fechaNac);
                        command.Parameters.AddWithValue("@fechaRegistro", fechaIng);
                        command.Parameters.AddWithValue("@telefonoMedico", telefono);
                        command.Parameters.AddWithValue("@emailMedico", correo);
                        command.Parameters.AddWithValue("@medicoAsociado", asociado);
                        command.Parameters.AddWithValue("@estadoMedico", estados);
                        command.Parameters.AddWithValue("@id", id);

                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Datos modificados correctamente.");
                            // Opcional: Actualizar el DataGridView
                            CargarDatosMedico();
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

        private void eliminarMedico_Click(object sender, EventArgs e)
        {
            string idIngresado = matricula.Text.Trim();

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

            string query = "UPDATE medico SET estadoMedico = 0 WHERE medicoID = @id";
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
                            MessageBox.Show("El estado del medico se ha actualizado a inactivo.");
                            CargarDatosMedico();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado del medico: {ex.Message}");
                }
            }

        }
    }

}
    }
}
