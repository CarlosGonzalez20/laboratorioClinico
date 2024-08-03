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
    public partial class datosPaciente : MaterialSkin.Controls.MaterialForm
    {

        private void CargarTiposDeSangre()
        {
            string[] tiposDeSangre = new string[]
            {
                "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-"
            };
            tipoSangrePaciente.Items.Clear();
            tipoSangrePaciente.Items.AddRange(tiposDeSangre);
            if (tipoSangrePaciente.Items.Count > 0)
            {
                tipoSangrePaciente.SelectedIndex = 0;
            }
        }

        private void CargarDatosGenero_TipoUsu() {
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
                    sexoPaciente.Items.Clear();
                    while (generoReader.Read())
                    {
                        int generoID = generoReader.GetInt32("generoID");
                        sexoPaciente.Items.Add(generoID);
                    }
                    if (sexoPaciente.Items.Count > 0)
                    {
                        sexoPaciente.SelectedIndex = 0;
                    }
                    generoReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar los ComboBox: " + ex.Message);
                }
            }
        }

        private void CargarDatosPacientes()
        {
            string query = "SELECT * FROM paciente";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos. Pacientes");
                    return;
                }

                try
                {
                    // Crear adaptador y llenar el DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    infoPacientes.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de pacientes: {ex.Message}");
                }
            }
        }

        public datosPaciente()
        {
            InitializeComponent();
            CargarTiposDeSangre();
            CargarDatosGenero_TipoUsu();
            CargarDatosPacientes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarPaciente_Click(object sender, EventArgs e)
        {
CargarDatosPacientes();
    DatabaseConnection dbConnection = new DatabaseConnection();
    using (MySqlConnection connection = dbConnection.GetConnection())
    {
        if (connection == null) return; // Verifica si la conexión fue exitosa

        string expedienteID = expedienteNo.Text.Trim();

        if (string.IsNullOrEmpty(expedienteID))
        {
            MessageBox.Show("Por favor, ingrese un número de expediente.");
            return;
        }

        string query = "SELECT * FROM paciente WHERE pacienteID = @pacienteID";

        try
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@pacienteID", expedienteID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tipoUsuario.SelectedItem = reader["tipoUsuarioID"].ToString();
                        documentoIdentificacion.Text = reader["numeroDocumento"].ToString();
                        nombresPaciente.Text = reader["nombrePaciente"].ToString();
                        apellidosPaciente.Text = reader["apellidoPaciente"].ToString();
                        fechaNacPaciente.Value = reader.GetDateTime("fechaNacimientoPaciente");
                        fechaIngPaciente.Value = reader.GetDateTime("fechaRegistro");
                        telefonoPaciente.Text = reader["telefonoPaciente"].ToString();
                        correoPaciente.Text = reader["emailPaciente"].ToString();
                        tipoSangrePaciente.SelectedItem = reader["tipoSangrePaciente"].ToString();
                        sexoPaciente.SelectedItem = reader["generoID"].ToString();
                        direccionPaciente.Text = reader["direccionPaciente"].ToString();
                        alergiasPaciente.Text = reader["alergiasPaciente"].ToString();
                        medicamentosPaciente.Text = reader["medicamentosActualesPaciente"].ToString();
                        nombreEmergencias.Text = reader["nombreContactoEmergencia"].ToString();
                        telefonoEmergencias.Text = reader["telefonoContactoEmergencia"].ToString();
                        relacionEmergencias.Text = reader["relacionContactoEmergencia"].ToString();
                        seguroPaciente.Text = reader["proveedorSeguro"].ToString();

                        string estadoPaciente = reader["estadoPaciente"].ToString();
                        Console.WriteLine($"Estado Paciente: {estadoPaciente}"); // Para depuración
                        if (estadoPaciente=="true") {
                            estatusActivo.Checked = true; 
                        } else if (estadoPaciente=="false") {
                            estatusInactivo.Checked = true;
                        }

                        // Seleccionar la fila en el DataGridView
                        foreach (DataGridViewRow row in infoPacientes.Rows)
                        {
                            if (row.Cells["pacienteID"].Value.ToString() == expedienteID)
                            {
                                row.Selected = true;
                                infoPacientes.FirstDisplayedScrollingRowIndex = row.Index;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un paciente con ese número de expediente.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al buscar el paciente: {ex.Message}");
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
                    { "Tipo de Usuario", () => tipoUsuario.SelectedItem?.ToString() },
                    { "Documento de Identificación", () => documentoIdentificacion.Text.Trim() },
                    { "Nombre", () => nombresPaciente.Text.Trim() },
                    { "Apellido", () => apellidosPaciente.Text.Trim() },
                    { "Fecha de Nacimiento", () => fechaNacPaciente.Value.ToString("yyyy-MM-dd") },
                    { "Fecha de Ingreso", () => fechaIngPaciente.Value.Date.ToString("yyyy-MM-dd") },
                    { "Teléfono", () => telefonoPaciente.Text.Trim() },
                    { "Correo", () => correoPaciente.Text.Trim() },
                    { "Tipo Sangre", () => tipoSangrePaciente.SelectedItem.ToString() },
                    { "Género", () => sexoPaciente.SelectedItem?.ToString() },
                    { "Dirección", () => direccionPaciente.Text.Trim() },
                    { "Alergia", () => alergiasPaciente.Text.Trim() },
                    { "Medicamento", () => medicamentosPaciente.Text.Trim() },
                    { "Nombre del Contacto", () => nombreEmergencias.Text.Trim() },
                    { "Teléfono de Contacto", () => telefonoEmergencias.Text.Trim() },
                    { "Relación del Contacto", () => relacionEmergencias.Text.Trim() },
                    { "Seguro", () => seguroPaciente.Text.Trim() },
                    //{ "Contraseña", () => contraseñaPaciente.Text.Trim() },
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
                int genero;
                int documento;
                int telefono;
                if (!int.TryParse(campos["Tipo de Usuario"].Invoke(), out tipoUsu) ||
                    !int.TryParse(campos["Documento de Identificación"].Invoke(), out documento) ||
                    !int.TryParse(campos["Teléfono"].Invoke(), out telefono) ||
                    !int.TryParse(campos["Género"].Invoke(), out genero))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                string nombre = campos["Nombre"].Invoke();
                string apellido = campos["Apellido"].Invoke();
                DateTime fechaNac = DateTime.Parse(campos["Fecha de Nacimiento"].Invoke());
                DateTime fechaIng = DateTime.Parse(campos["Fecha de Ingreso"].Invoke());
                string direccion = campos["Dirección"].Invoke();
                string alergia = campos["Alergia"].Invoke();
                string medicamento = campos["Medicamento"].Invoke();
                string nombreContacto = campos["Nombre del Contacto"].Invoke();
                int telefonoContacto;
                if (!int.TryParse(campos["Teléfono de Contacto"].Invoke(), out telefonoContacto))
                {
                    MessageBox.Show("El teléfono de contacto no es válido.");
                    return;
                }

                string relacionContacto = campos["Relación del Contacto"].Invoke();
                string seguro = campos["Seguro"].Invoke();
                string estados = campos["Estado"].Invoke();

                string query = "INSERT INTO paciente (tipoUsuarioID, numeroDocumento, nombrePaciente, apellidoPaciente, fechaNacimientoPaciente, telefonoPaciente, emailPaciente, tipoSangrePaciente, generoID, direccionPaciente, alergiasPaciente, medicamentosActualesPaciente, nombreContactoEmergencia, telefonoContactoEmergencia, relacionContactoEmergencia, proveedorSeguro, estadoPaciente) " +
                               "VALUES (@tipoUsuarioID, @numeroDocumento, @nombrePaciente, @apellidoPaciente, @fechaNacimientoPaciente, @telefonoPaciente, @emailPaciente, @tipoSangrePaciente, @generoID, @direccionPaciente, @alergiasPaciente, @medicamentosActualesPaciente, @nombreContactoEmergencia, @telefonoContactoEmergencia, @relacionContactoEmergencia, @proveedorSeguro, @estadoPaciente)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@tipoUsuarioID", tipoUsu);
                        command.Parameters.AddWithValue("@numeroDocumento", documento);
                        command.Parameters.AddWithValue("@nombrePaciente", nombre);
                        command.Parameters.AddWithValue("@apellidoPaciente", apellido);
                        command.Parameters.AddWithValue("@fechaNacimientoPaciente", fechaNac);
                        command.Parameters.AddWithValue("@telefonoPaciente", telefono);
                        command.Parameters.AddWithValue("@emailPaciente", correoPaciente.Text.Trim());
                        command.Parameters.AddWithValue("@tipoSangrePaciente", tipoSangrePaciente.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@generoID", genero);
                        command.Parameters.AddWithValue("@direccionPaciente", direccion);
                        command.Parameters.AddWithValue("@alergiasPaciente", alergia);
                        command.Parameters.AddWithValue("@medicamentosActualesPaciente", medicamento);
                        command.Parameters.AddWithValue("@nombreContactoEmergencia", nombreContacto);
                        command.Parameters.AddWithValue("@telefonoContactoEmergencia", telefonoContacto);
                        command.Parameters.AddWithValue("@relacionContactoEmergencia", relacionContacto);
                        command.Parameters.AddWithValue("@proveedorSeguro", seguro);
                        command.Parameters.AddWithValue("@estadoPaciente", estados);

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
            CargarDatosPacientes();
        }

        private void eliminarPaciente_Click(object sender, EventArgs e)
        {
            string idIngresado = expedienteNo.Text.Trim();

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

            string query = "UPDATE paciente SET estadoPaciente = 0 WHERE pacienteID = @id";
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
                            MessageBox.Show("El estado del paciente se ha actualizado a inactivo.");
                            CargarDatosPacientes();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado del paciente: {ex.Message}");
                }
            }
        }

        private void modificarPaciente_Click(object sender, EventArgs e)
        {
            string idIngresado = expedienteNo.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese el ID del paciente que desea modificar.");
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
                string query = "UPDATE paciente SET " +
                               "tipoUsuarioID = @tipoUsuarioID, " +
                               "numeroDocumento = @numeroDocumento, " +
                               "nombrePaciente = @nombrePaciente, " +
                               "apellidoPaciente = @apellidoPaciente, " +
                               "fechaNacimientoPaciente = @fechaNacimientoPaciente, " +
                               "telefonoPaciente = @telefonoPaciente, " +
                               "emailPaciente = @emailPaciente, " +
                               "tipoSangrePaciente = @tipoSangrePaciente, " +
                               "generoID = @generoID, " +
                               "direccionPaciente = @direccionPaciente, " +
                               "alergiasPaciente = @alergiasPaciente, " +
                               "medicamentosActualesPaciente = @medicamentosActualesPaciente, " +
                               "nombreContactoEmergencia = @nombreContactoEmergencia, " +
                               "telefonoContactoEmergencia = @telefonoContactoEmergencia, " +
                               "relacionContactoEmergencia = @relacionContactoEmergencia, " +
                               "proveedorSeguro = @proveedorSeguro, " +
                               "estadoPaciente = @estadoPaciente " +
                               "WHERE pacienteID = @id";

                // Validar los campos
                Dictionary<string, Func<string>> campos = new Dictionary<string, Func<string>>
        {
            { "Tipo de Usuario", () => tipoUsuario.SelectedItem?.ToString() },
            { "Documento de Identificación", () => documentoIdentificacion.Text.Trim() },
            { "Nombre", () => nombresPaciente.Text.Trim() },
            { "Apellido", () => apellidosPaciente.Text.Trim() },
            { "Fecha de Nacimiento", () => fechaNacPaciente.Value.ToString("yyyy-MM-dd") },
            { "Fecha de Ingreso", () => fechaIngPaciente.Value.Date.ToString("yyyy-MM-dd") },
            { "Teléfono", () => telefonoPaciente.Text.Trim() },
            { "Correo", () => correoPaciente.Text.Trim() },
            { "Tipo Sangre", () => tipoSangrePaciente.SelectedItem.ToString() },
            { "Género", () => sexoPaciente.SelectedItem?.ToString() },
            { "Dirección", () => direccionPaciente.Text.Trim() },
            { "Alergia", () => alergiasPaciente.Text.Trim() },
            { "Medicamento", () => medicamentosPaciente.Text.Trim() },
            { "Nombre del Contacto", () => nombreEmergencias.Text.Trim() },
            { "Teléfono de Contacto", () => telefonoEmergencias.Text.Trim() },
            { "Relación del Contacto", () => relacionEmergencias.Text.Trim() },
            { "Seguro", () => seguroPaciente.Text.Trim() },
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
                int genero;
                int documento;
                int telefono;
                if (!int.TryParse(campos["Tipo de Usuario"].Invoke(), out tipoUsu) ||
                    !int.TryParse(campos["Documento de Identificación"].Invoke(), out documento) ||
                    !int.TryParse(campos["Teléfono"].Invoke(), out telefono) ||
                    !int.TryParse(campos["Género"].Invoke(), out genero))
                {
                    MessageBox.Show("Uno de los campos numéricos no es válido.");
                    return;
                }

                string nombre = campos["Nombre"].Invoke();
                string apellido = campos["Apellido"].Invoke();
                DateTime fechaNac = DateTime.Parse(campos["Fecha de Nacimiento"].Invoke());
                DateTime fechaIng = DateTime.Parse(campos["Fecha de Ingreso"].Invoke());
                string direccion = campos["Dirección"].Invoke();
                string alergia = campos["Alergia"].Invoke();
                string medicamento = campos["Medicamento"].Invoke();
                string nombreContacto = campos["Nombre del Contacto"].Invoke();
                int telefonoContacto;
                if (!int.TryParse(campos["Teléfono de Contacto"].Invoke(), out telefonoContacto))
                {
                    MessageBox.Show("El teléfono de contacto no es válido.");
                    return;
                }

                string relacionContacto = campos["Relación del Contacto"].Invoke();
                string seguro = campos["Seguro"].Invoke();
                string estados = campos["Estado"].Invoke();

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros de la consulta
                        command.Parameters.AddWithValue("@tipoUsuarioID", tipoUsu);
                        command.Parameters.AddWithValue("@numeroDocumento", documento);
                        command.Parameters.AddWithValue("@nombrePaciente", nombre);
                        command.Parameters.AddWithValue("@apellidoPaciente", apellido);
                        command.Parameters.AddWithValue("@fechaNacimientoPaciente", fechaNac);
                        command.Parameters.AddWithValue("@telefonoPaciente", telefono);
                        command.Parameters.AddWithValue("@emailPaciente", correoPaciente.Text.Trim());
                        command.Parameters.AddWithValue("@tipoSangrePaciente", tipoSangrePaciente.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@generoID", genero);
                        command.Parameters.AddWithValue("@direccionPaciente", direccion);
                        command.Parameters.AddWithValue("@alergiasPaciente", alergia);
                        command.Parameters.AddWithValue("@medicamentosActualesPaciente", medicamento);
                        command.Parameters.AddWithValue("@nombreContactoEmergencia", nombreContacto);
                        command.Parameters.AddWithValue("@telefonoContactoEmergencia", telefonoContacto);
                        command.Parameters.AddWithValue("@relacionContactoEmergencia", relacionContacto);
                        command.Parameters.AddWithValue("@proveedorSeguro", seguro);
                        command.Parameters.AddWithValue("@estadoPaciente", estados);
                        command.Parameters.AddWithValue("@id", id);

                        // Ejecutar la consulta
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Datos modificados correctamente.");

                            // Opcional: Actualizar el DataGridView
                            CargarDatosPacientes();
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
