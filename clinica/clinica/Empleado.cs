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
    public partial class Empleado : MaterialSkin.Controls.MaterialForm
    {
        public Empleado()
        {
            InitializeComponent();
            genero();
            clinican();
            tipoemplea();
            CargarDatosempleados();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }

        private void genero()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;
                // Llenar el ComboBox para tipoUsuario
                string tipoUsuarioQuery = "SELECT generoID FROM genero";
                MySqlCommand tipoUsuarioCommand = new MySqlCommand(tipoUsuarioQuery, connection);
                try
                {
                    MySqlDataReader tipoUsuarioReader = tipoUsuarioCommand.ExecuteReader();
                    sexo.Items.Clear();
                    while (tipoUsuarioReader.Read())
                    {
                        int tipoUsuarioID = tipoUsuarioReader.GetInt32("generoID");
                        sexo.Items.Add(tipoUsuarioID);
                    }
                    if (sexo.Items.Count > 0)
                    {
                        sexo.SelectedIndex = 0;
                    }
                    tipoUsuarioReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar los ComboBox: " + ex.Message);
                }
            }
        }
        private void clinican()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;
                // Llenar el ComboBox para tipoUsuario
                string tipoUsuarioQuery = "SELECT clinicaID FROM clinica";
                MySqlCommand tipoUsuarioCommand = new MySqlCommand(tipoUsuarioQuery, connection);
                try
                {
                    MySqlDataReader tipoUsuarioReader = tipoUsuarioCommand.ExecuteReader();
                    clinica.Items.Clear();
                    while (tipoUsuarioReader.Read())
                    {
                        int tipoUsuarioID = tipoUsuarioReader.GetInt32("clinicaID");
                        clinica.Items.Add(tipoUsuarioID);
                    }
                    if (clinica.Items.Count > 0)
                    {
                        clinica.SelectedIndex = 0;
                    }
                    tipoUsuarioReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar los ComboBox: " + ex.Message);
                }
            }
        }
        private void tipoemplea()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;
                // Llenar el ComboBox para tipoUsuario
                string tipoUsuarioQuery = "SELECT tipoEmpleadoID FROM tipoEmpleado";
                MySqlCommand tipoUsuarioCommand = new MySqlCommand(tipoUsuarioQuery, connection);
                try
                {
                    MySqlDataReader tipoUsuarioReader = tipoUsuarioCommand.ExecuteReader();
                    tipoempleado.Items.Clear();
                    while (tipoUsuarioReader.Read())
                    {
                        int tipoUsuarioID = tipoUsuarioReader.GetInt32("tipoEmpleadoID");
                        tipoempleado.Items.Add(tipoUsuarioID);
                    }
                    if (tipoempleado.Items.Count > 0)
                    {
                        tipoempleado.SelectedIndex = 0;
                    }
                    tipoUsuarioReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar los ComboBox: " + ex.Message);
                }
            }
        }
        private void CargarDatosempleados()
        {
            string query = "SELECT * FROM empleado";
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
                    dataempleado.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de pacientes: {ex.Message}");
                }
            }
        }

        private void ingresarempleado_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {

                if (connection == null) return; // Verifica si la conexión fue exitosa

                //string cod = codigo.Text.Trim();
                string Cui = cui.Text.Trim();
                string nom = nombre.Text.Trim();
                string ap = apellido.Text.Trim();
                string n_clinica = clinica.Text.Trim();
                string correo = email.Text.Trim();
                string tele = telefono.Text.Trim();
                string hora = h_trabajo.Text.Trim();
                string dia = d_trabajo.Text.Trim();
                string tipoem = tipoempleado.Text.Trim();
                string Sexo = sexo.Text.Trim();
                DateTime fechan = dateTimePicker1.Value; // Obteniendo el valor de DateTimePicker1
                DateTime fechag = dateTimePicker2.Value;
                string estado = estatusActivo.Checked ? "1" : "0";

                if (string.IsNullOrEmpty(Cui) || string.IsNullOrEmpty(estado) ||
                            string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(ap) || string.IsNullOrEmpty(n_clinica) ||
                            string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(tele) || string.IsNullOrEmpty(hora) ||
                            string.IsNullOrEmpty(dia) || string.IsNullOrEmpty(tipoem) || string.IsNullOrEmpty(Sexo) ||
                            fechan == default(DateTime) || fechag == default(DateTime))
                //string.IsNullOrEmpty(fechan) || string.IsNullOrEmpty(fechag))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }
                string query = "INSERT INTO empleado ( tipoEmpleadoID, clinicaID, nombreEmpleado, apellidoEmpleado, numeroIdentificacion, diasTrabajoEmpleado, horasTrabajoEmpleado, telefonoEmpleado, emailEmpleado, generoID, fechaNacimientoEmpleado, fechaContratacionEmpleado, estadoEmpleado)" +
                                                          "VALUES (@tipoem, @n_clinica, @nom, @ap, @Cui, @dia, @hora, @tele, @correo, @Sexo, @fechan, @fechag, @estado)";


                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Usa Add con tipos explícitos si es necesario
                        //command.Parameters.AddWithValue("@cod", cod);
                        command.Parameters.AddWithValue("@tipoem", tipoem);
                        command.Parameters.AddWithValue("@n_clinica", n_clinica);
                        command.Parameters.AddWithValue("@nom", nom);
                        command.Parameters.AddWithValue("@ap", ap);
                        command.Parameters.AddWithValue("@Cui", Cui);
                        command.Parameters.AddWithValue("@dia", dia);
                        command.Parameters.AddWithValue("@hora", hora);
                        command.Parameters.AddWithValue("@tele", tele);
                        command.Parameters.AddWithValue("@correo", correo);
                        command.Parameters.AddWithValue("@Sexo", Sexo);
                        command.Parameters.AddWithValue("@fechan", fechan);
                        command.Parameters.AddWithValue("@fechag", fechag);
                        command.Parameters.AddWithValue("@estado", estado);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron datos.");
                        }
                        CargarDatosempleados();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la base de datos: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }



            }
        }

        private void eliminarempleado_Click(object sender, EventArgs e)
        {
            string idIngresado = codigo.Text.Trim();

            if (string.IsNullOrEmpty(idIngresado))
            {
                MessageBox.Show("Por favor, ingrese codigo.");
                return;
            }
            if (!int.TryParse(idIngresado, out int id))
            {
                MessageBox.Show("codigo inválido.");
                return;
            }

            string query = "UPDATE empleado SET estadoEmpleado = 0 WHERE empleadoID = @id";
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
                            MessageBox.Show("El estado del empleado se ha actualizado a inactivo.");
                            CargarDatosempleados();
                            //Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el codigo  proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado del paciente: {ex.Message}");
                }
            }
        }

        private void buscarempleado_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return; // Verifica si la conexión fue exitosa

                //string query = "SELECT citaID, horaCita, estadoCita, motivoCita FROM cita WHERE citaID = @citaID";
                string query = "SELECT * FROM empleado WHERE empleadoID = @cod";
                string cod = codigo.Text.Trim(); // txtSearch es el campo de búsqueda

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cod", cod);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataempleado.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar los datos: {ex.Message}");
                }

            }
        }

        private void modificarempleado_Click(object sender, EventArgs e)
        {
            var dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("Error al conectar con la base de datos.");
                    return; // Verifica si la conexión fue exitosa
                }

                string query = "UPDATE empleado SET " +
                               "tipoEmpleadoID = @tipoem, " +
                               "clinicaID = @n_clinica, " +
                               "nombreEmpleado = @nom, " +
                               "apellidoEmpleado = @ap, " +
                               "numeroIdentificacion = @Cui, " +
                               "diasTrabajoEmpleado = @dia, " +
                               "horasTrabajoEmpleado = @hora, " +
                               "telefonoEmpleado = @tele, " +
                               "emailEmpleado = @correo, " +
                               "generoID = @Sexo, " +
                               "fechaNacimientoEmpleado = @fechan, " +
                               "fechaContratacionEmpleado = @fechag, " +
                               "estadoEmpleado = @estado " + // Eliminé la coma extra aquí
                               "WHERE empleadoID = @cod";

                string cod = codigo.Text.Trim();
                string Cui = cui.Text.Trim();
                string nom = nombre.Text.Trim();
                string ap = apellido.Text.Trim();
                string n_clinica = clinica.Text.Trim();
                string correo = email.Text.Trim();
                string tele = telefono.Text.Trim();
                string hora = h_trabajo.Text.Trim();
                string dia = d_trabajo.Text.Trim();
                string tipoem = tipoempleado.Text.Trim();
                string Sexo = sexo.Text.Trim();
                DateTime fechan = dateTimePicker1.Value; // Obteniendo el valor de DateTimePicker1
                DateTime fechag = dateTimePicker2.Value;
                string estado = estatusActivo.Checked ? "1" : "0";

                if (string.IsNullOrEmpty(Cui) || string.IsNullOrEmpty(estado) ||
                            string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(ap) || string.IsNullOrEmpty(n_clinica) ||
                            string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(tele) || string.IsNullOrEmpty(hora) ||
                            string.IsNullOrEmpty(dia) || string.IsNullOrEmpty(tipoem) || string.IsNullOrEmpty(Sexo) ||
                            fechan == default(DateTime) || fechag == default(DateTime))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                try
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open(); // Asegúrate de abrir la conexión antes de ejecutar el comando
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cod", cod);
                        command.Parameters.AddWithValue("@tipoem", tipoem);
                        command.Parameters.AddWithValue("@n_clinica", n_clinica);
                        command.Parameters.AddWithValue("@nom", nom);
                        command.Parameters.AddWithValue("@ap", ap);
                        command.Parameters.AddWithValue("@Cui", Cui);
                        command.Parameters.AddWithValue("@dia", dia);
                        command.Parameters.AddWithValue("@hora", hora);
                        command.Parameters.AddWithValue("@tele", tele);
                        command.Parameters.AddWithValue("@correo", correo);
                        command.Parameters.AddWithValue("@Sexo", Sexo);
                        command.Parameters.AddWithValue("@fechan", fechan);
                        command.Parameters.AddWithValue("@fechag", fechag);
                        command.Parameters.AddWithValue("@estado", estado);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Empleado modificado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún empleado con el ID especificado.");
                        }
                        CargarDatosempleados(); // INSTRUCCIÓN PARA REFRESCAR LOS DATOS DEL DataGridView
                                                //Limpiar(); // Descomentar si es necesario limpiar los campos después de la actualización
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar los datos: {ex.Message}");
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close(); // Asegúrate de cerrar la conexión después de ejecutar el comando
                    }
                }
            }
        }
    }
}
