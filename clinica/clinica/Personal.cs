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
    public partial class Personal : MaterialSkin.Controls.MaterialForm
    {



        public Personal()
        {
            InitializeComponent();
            cargarGenero();
            cargarInformacion();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void cargarInformacion()
        {
            string query = "SELECT * FROM personalLab";
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
                    infoPersonal.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de pacientes: {ex.Message}");
                }
            }



        }
        private void CargarDatosPersonal()
        {
            string query = "SELECT * FROM personalLab";
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
                    infoPersonal.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de médicos: {ex.Message}");
                }
            }
        }

        private void cargarGenero()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null) return;

                // Llenar el ComboBox para genero
                string generoQuery = "SELECT nombreGenero FROM genero";
                MySqlCommand generoCommand = new MySqlCommand(generoQuery, connection);

                MySqlDataReader generoReader = null;
                try
                {
                    generoReader = generoCommand.ExecuteReader();
                    sexoPer.Items.Clear();
                    while (generoReader.Read())
                    {
                        string nombreGenero = generoReader.GetString("nombreGenero");
                        sexoPer.Items.Add(nombreGenero);
                    }
                    if (sexoPer.Items.Count > 0)
                    {
                        sexoPer.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el ComboBox de género: " + ex.Message);
                }
                finally
                {
                    // Asegurarse de cerrar el lector si se ha abierto
                    generoReader?.Close();
                }
            }
        }


        private void ingresarPersonal_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                    return;
                }

                string no_ident = numeroIdentificacion.Text.Trim();
                string nombres = nombre.Text.Trim();
                string apellidos = apellido.Text.Trim();
                string fecha_naci = nacimiento.Value.ToString("yyyy-MM-dd");
                string fecha_cont = fechaContratacion.Value.ToString("yyyy-MM-dd");
                string horarios = horarioPersonal.Text.Trim();
                string puesto = puestoPersonal.Text.Trim();
                string estados = estatusActivo.Checked ? "1" : "0";
                string telefonos = telefono.Text.Trim();
                string email = correoElectronico.Text.Trim();

                // Obtener el género seleccionado del ComboBox
                string generoSeleccionado = sexoPer.SelectedItem as string;

                // Verificar si el género seleccionado es nulo
                if (string.IsNullOrEmpty(generoSeleccionado))
                {
                    MessageBox.Show("Por favor, selecciona un género.");
                    return;
                }

                // Convertir el género seleccionado a 1 (Masculino) o 2 (Femenino)
                int generoID = generoSeleccionado == "Masculino" ? 1 : 2;

                string dias = "";
                if (lunes.Checked) dias += "lunes, ";
                if (martes.Checked) dias += "martes, ";
                if (miercoles.Checked) dias += "miércoles, ";
                if (jueves.Checked) dias += "jueves, ";
                if (viernes.Checked) dias += "viernes, ";
                if (sabado.Checked) dias += "sábado, ";
                if (domingo.Checked) dias += "domingo, ";

                // Elimina la última coma y espacio si hay días seleccionados
                if (dias.EndsWith(", ")) dias = dias.Substring(0, dias.Length - 2);

                // Verificación de campos vacíos
                if (string.IsNullOrEmpty(no_ident) ||
                    string.IsNullOrEmpty(nombres) ||
                    string.IsNullOrEmpty(apellidos) ||
                    string.IsNullOrEmpty(fecha_naci) ||
                    string.IsNullOrEmpty(fecha_cont) ||
                    string.IsNullOrEmpty(horarios) ||
                    string.IsNullOrEmpty(puesto) ||
                    string.IsNullOrEmpty(estados) ||
                    string.IsNullOrEmpty(telefonos) ||
                    string.IsNullOrEmpty(dias))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                // Consulta SQL para insertar en la base de datos
                string query = "INSERT INTO personalLab (numeroIdentificacion, nombrePersonalLab, apellidoPersonalLab, fechaNacimientoPersonalLab, fechaContratacionPersonalLab, horarioPersonalLab, diasTrabajoPersonalLab, posicionPersonalLab, telefonoPersonalLab, emailPersonalLab, estadoPersonalLab, generoID) VALUES (@no_ident, @nombres, @apellidos, @fecha_naci, @fecha_cont, @horarios, @dias, @puesto, @telefonos, @email, @estados, @generoID)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@no_ident", no_ident);
                        command.Parameters.AddWithValue("@nombres", nombres);
                        command.Parameters.AddWithValue("@apellidos", apellidos);
                        command.Parameters.AddWithValue("@fecha_naci", fecha_naci);
                        command.Parameters.AddWithValue("@fecha_cont", fecha_cont);
                        command.Parameters.AddWithValue("@horarios", horarios);
                        command.Parameters.AddWithValue("@dias", dias);
                        command.Parameters.AddWithValue("@puesto", puesto);
                        command.Parameters.AddWithValue("@telefonos", telefonos);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@estados", estados == "1" ? 1 : 0);
                        command.Parameters.AddWithValue("@generoID", generoID); // Enviar 1 o 2 según el género

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente.");
                            cargarInformacion(); // Llama a cargarInformacion() después de insertar los datos
                        }
                        else
                        {
                            MessageBox.Show("No se insertaron datos.");
                        }
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

        private void eliminarPersonal_Click(object sender, EventArgs e)
        {

            string idIngresado = ID.Text.Trim();

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

            string query = "UPDATE personalLab SET estadoPersonalLab = 0 WHERE personalLabID = @id";
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
                            MessageBox.Show("El estado del personal se ha actualizado a inactivo.");
                            CargarDatosPersonal();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estado del personal: {ex.Message}");
                }
            }

        }

        private void buscarPersonal_Click(object sender, EventArgs e)
        {



            {

                {
                    DatabaseConnection dbConnection = new DatabaseConnection();
                    using (MySqlConnection connection = dbConnection.GetConnection())
                    {
                        if (connection == null)
                        {
                            MessageBox.Show("No se pudo establecer la conexión a la base de datos.");
                            return;
                        }

                        string id = ID.Text.Trim(); // Asegúrate de tener un TextBox para el ID

                        if (string.IsNullOrEmpty(id))
                        {
                            MessageBox.Show("Por favor, proporciona un ID.");
                            return;
                        }

                        string query = "SELECT * FROM personalLab WHERE personalLabID = @id";

                        try
                        {
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@id", id);
                                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                                DataTable dataTable = new DataTable();
                                dataAdapter.Fill(dataTable);

                                if (dataTable.Rows.Count > 0)
                                {
                                    infoPersonal.DataSource = dataTable;
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                                    infoPersonal.DataSource = null; // Limpia el DataGridView si no se encuentra nada
                                }
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
            }
        }
    }






}
    










        

